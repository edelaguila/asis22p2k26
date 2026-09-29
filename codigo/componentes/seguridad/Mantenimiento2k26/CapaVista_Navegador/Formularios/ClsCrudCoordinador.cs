using CapaControlador_Navegador;
using CapaModelo_Navegador;
using CapaVista_Consultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace CapaVista_Navegador
{
    public class ClsCrudCoordinador
    {
        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Antes el tipo era FrmCrud. Ahora es Form para que el formulario pueda vivir fuera de este
        // proyecto (en la solución que consume el navegador), y el nombre de la tabla lo da quien lo usa.
        private readonly Navegador _Vista;

        private string _NombreTabla;

        public string NombreTabla
        {
            get { return _NombreTabla; }
            set { _NombreTabla = value; }
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        private readonly ClsCtrlTabla _CtrlTabla;
        private readonly ClsCrudGrid _Grid;
        private readonly ClsCrudFormulario _Formulario;
        private readonly ClsCrudAcciones _Acciones;
        private readonly ClsSelectorLlave _SelectorLlave;


        private List<ClsColumnaInfo> _EsquemaActual;
        private Dictionary<string, string> _PkModificar;

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Se quitaron UsuarioActual y CodigoModulo: no se usaban.
        public ClsCrudCoordinador(Navegador Vista, string Tabla)
        {
            _Vista = Vista;

            _NombreTabla = Tabla;

            _CtrlTabla = new ClsCtrlTabla();

            _Grid = new ClsCrudGrid(_Vista);

            _Formulario = new ClsCrudFormulario(_Vista);

            _SelectorLlave = new ClsSelectorLlave(_Vista);

            _Acciones = new ClsCrudAcciones();
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // CONSULTAR TABLA
        private bool NavegadorFuncConsultarTabla()
        {
            try
            {
                DataTable Datos =
                    _CtrlTabla.NavegadorFuncLlenarDgv(
                        NombreTabla);

                _EsquemaActual =
                    _SelectorLlave.NavegadorFuncObtenerEsquemaConLlaves(
                        NombreTabla);

                // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
                // El título es el de la ventana emergente de la tabla; no se le cambia el título al
                // formulario o MDI que contiene al Navegador.
                _Grid.Titulo = "1001 – Crud " + NombreTabla;
                _Grid.NavegadorMetMostrar(Datos);
                // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

                return true;
            }
            catch (Exception Excepcion)
            {
                _EsquemaActual = null;

                _Formulario.NavegadorMetCerrar();

                _Grid.NavegadorMetOcultar();

                MessageBox.Show(
                    _Acciones.NavegadorFuncMensajeAmigable(
                        Excepcion),
                    "Error al consultar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        // INGRESAR
        public void NavegadorMetIngresar()
        {
            if (!NavegadorFuncConsultarTabla())
                return;

            _PkModificar = null;

            if (_EsquemaActual == null ||
                _EsquemaActual.Count == 0)
            {
                MessageBox.Show(
                    "No se pudo obtener la estructura de la tabla indicada.",
                    "Ingresar registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
            // El registro se captura en un panel dentro del área desplegable del Navegador y se guarda o
            // cancela con los botones Guardar y Cancelar del propio Navegador.
            _Formulario.NavegadorMetAbrir(
                NombreTabla,
                _EsquemaActual,
                false,
                null,
                _Grid);
            // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
        }

        // CONSULTAR
        //Cambios Por Mario Alberto Taracena Pérez 0901-23-9355 y Dylan Rene Hernandez Recinos 0901-23-519
        // Antes este método solo recargaba la tabla completa. Ahora abre el formulario
        // de Consultas Simples del componente Consultas, recibe la llave primaria del
        // registro que el usuario seleccione y filtra el grid del Navegador para mostrar
        // únicamente ese registro. Desde ahí se puede Modificar o Eliminar.
        public void NavegadorMetConsultar()
        {
            _Formulario.NavegadorMetCerrar();

            // 1. Cargar la tabla completa primero: necesitamos el esquema para saber cuál
            //    es el campo PK, y de paso el grid queda con datos si el usuario cancela.
            if (!NavegadorFuncConsultarTabla())
                return;

            // 2. Detectar el campo PK del esquema actual
            ClsColumnaInfo ColumnaPK = null;

            if (_EsquemaActual != null)
            {
                ColumnaPK = _EsquemaActual.Find(Columna => Columna.EsPK);
            }

            if (ColumnaPK == null)
            {
                MessageBox.Show(
                    "La tabla '" + NombreTabla + "' no tiene una llave primaria detectable. " +
                    "No se puede abrir el selector de Consultas.",
                    "Consultar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 3. Abrir el formulario de Consultas Simples del componente Consultas
            try
            {
                using (FrmConsultasSimples FormularioConsultas =
                    new FrmConsultasSimples(NombreTabla, ColumnaPK.Nombre))
                {
                    // Se pasa el formulario padre como owner para que el diálogo
                    // aparezca al frente y no detrás de la ventana principal.
                    Form Padre = _Vista.FindForm();

                    if (FormularioConsultas.ShowDialog(Padre) == DialogResult.OK &&
                        FormularioConsultas.SeleccionRealizada)
                    {
                        _Grid.NavegadorMetFiltrarPorLlave(
                            ColumnaPK.Nombre,
                            FormularioConsultas.IdSeleccionado);
                    }
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "No se pudo abrir el selector de Consultas.\n\n" + Excepcion.Message,
                    "Consultar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // REFRESCAR
        public void NavegadorMetRefrescar()
        {
            _Formulario.NavegadorMetCerrar();

            NavegadorFuncConsultarTabla();
        }

        // MODIFICAR
        public void NavegadorMetModificar()
        {
            DataGridViewRow Fila =
                _Grid.NavegadorDgvDatos != null
                ? _Grid.NavegadorDgvDatos.CurrentRow
                : null;

            if (Fila == null || Fila.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro en la tabla para Modificar.",
                    "Modificar registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            _EsquemaActual =
                _SelectorLlave.NavegadorFuncObtenerEsquemaConLlaves(
                    NombreTabla);

            _PkModificar =
                _Grid.NavegadorFuncObtenerClavesPrimarias(
                    _EsquemaActual,
                    Fila);

            if (_PkModificar.Count == 0)
            {
                MessageBox.Show(
                    "No se pudo obtener la llave primaria del registro seleccionado.",
                    "Modificar registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
            _Formulario.NavegadorMetAbrir(
                NombreTabla,
                _EsquemaActual,
                true,
                Fila,
                _Grid);
            // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
        }

        // ELIMINAR
        public void NavegadorMetEliminar()
        {
            DataGridViewRow Fila =
                _Grid.NavegadorDgvDatos != null
                ? _Grid.NavegadorDgvDatos.CurrentRow
                : null;

            if (Fila == null || Fila.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione un registro en la tabla para eliminar.",
                    "Eliminar registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            Dictionary<string, string> ClavesPrimarias =
                _Grid.NavegadorFuncObtenerClavesPrimarias(
                    _EsquemaActual,
                    Fila);

            string Mensaje;

            try
            {
                if (_Acciones.NavegadorFuncEliminar(
                    NombreTabla,
                    ClavesPrimarias,
                    out Mensaje))
                {
                    MessageBox.Show(
                        "Registro eliminado correctamente.",
                        "Eliminación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    NavegadorFuncConsultarTabla();
                }
                else if (!string.IsNullOrEmpty(Mensaje))
                {
                    MessageBox.Show(
                        Mensaje,
                        "Eliminar registro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    _Acciones.NavegadorFuncMensajeAmigable(
                        Excepcion),
                    "Error al eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // GUARDAR
        public void NavegadorMetGuardar()
        {
            if (!_Formulario.Visible)
            {
                MessageBox.Show(
                    "Abra un registro con Ingresar o Modificar antes de guardar.",
                    "Guardar registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (NavegadorFuncGuardar())
            {
                _Formulario.NavegadorMetCerrar();
            }
        }

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Guarda el registro del panel. Devuelve true si se guardó (el panel se cierra) y false si hubo
        // una validación o un error (el panel queda abierto para corregir).
        private bool NavegadorFuncGuardar()
        {
            Dictionary<string, string> Datos =
                _Formulario.NavegadorFuncObtenerDatos();

            string Mensaje;

            try
            {
                if (_Acciones.NavegadorFuncGuardar(
                    NombreTabla,
                    _EsquemaActual,
                    Datos,
                    _Formulario.ModoModificar,
                    _PkModificar,
                    out Mensaje))
                {
                    MessageBox.Show(
                        "Registro guardado correctamente.",
                        "Guardado exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    _PkModificar = null;

                    NavegadorFuncConsultarTabla();

                    return true;
                }
                else if (!string.IsNullOrEmpty(Mensaje))
                {
                    MessageBox.Show(
                        Mensaje,
                        "Guardar registro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    _Acciones.NavegadorFuncMensajeAmigable(
                        Excepcion),
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return false;
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // CANCELAR
        public void NavegadorMetCancelar()
        {
            _Formulario.NavegadorMetCerrar();

            _PkModificar = null;
        }

        // OCULTAR GRID
        public void NavegadorMetOcultarGrid()
        {
            _Grid.NavegadorMetOcultar();
        }

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // SALIR: minimiza el CRUD. Cierra el panel del registro (si estaba abierto) y contrae el Navegador
        // a solo la barra de botones; el formulario que lo contiene sigue abierto.
        public void NavegadorMetMinimizar()
        {
            _Formulario.NavegadorMetCerrar();

            _PkModificar = null;

            _Grid.NavegadorMetOcultar();
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // INICIO
        public void NavegadorMetInicio()
        {
            _Grid.NavegadorMetInicio();
        }

        // ANTERIOR
        public void NavegadorMetAnterior()
        {
            _Grid.NavegadorMetAnterior();
        }

        // SIGUIENTE
        public void NavegadorMetSiguiente()
        {
            _Grid.NavegadorMetSiguiente();
        }

        // FIN
        public void NavegadorMetFin()
        {
            _Grid.NavegadorMetFin();
        }

        // IMPRIMIR
        // Pendiente de integración con el componente Reporteador (ver reunión del 21/09/2026: falta
        // acordar con ellos qué parámetro exacto reciben además del código de aplicación). Por ahora
        // solo se avisa que la función no está disponible en vez de no hacer nada al oprimir el botón.
        public void NavegadorMetImprimir()
        {
            MessageBox.Show(
                "La impresión de reportes está pendiente de integración con el componente Reporteador.",
                "Imprimir",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}