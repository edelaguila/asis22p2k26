/*
 * ==================================================================
 * Área   : Mantenimiento2k26u
 * Autor  : José Pablo Cano Cóbar
 * Carné  : 0901-23-1727
 * Fecha  : 13/10/2026
 * ==================================================================
 * Propósito :
 *   Formulario de mantenimiento del catálogo de Películas. Presenta el
 *   listado, permite Ingresar, Modificar y Eliminar registros, buscar
 *   por nombre, navegar entre resultados, abrir la ayuda y generar el
 *   reporte, delegando TODA la lógica al controlador ClsModeloPelicula.
 *
 * Reglas específicas :
 *   - Esta clase no contiene una sola línea de SQL ni abre conexiones.
 *   - Las cinco acciones que exige el enunciado quedan en la bitácora
 *     del sistema de Seguridad: el alta, la consulta, la modificación
 *     y la eliminación las registra el controlador al ejecutarlas; el
 *     reporte lo registra al armar su origen de datos.
 *   - Los botones se habilitan según los permisos del rol en sesión
 *     sobre el par (20, 21): módulo Catálogos, aplicación Películas.
 *   - F1 abre la ayuda desde cualquier punto del formulario.
 * ===================================================================
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using CapaControlador_Mantenimiento2k26u;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Mantenimiento2k26u.frmReportes;

namespace CapaVista_Mantenimiento2k26u
{
    public partial class FrmMantenimientoPeliculas : Form
    {
        // Mismos valores que inserta el script dbPeliculas_Mantenimiento2k26u.sql.
        private const int ID_MODULO = 20;       // Catálogos
        private const int ID_APLICACION = 21;   // Películas

        private readonly ClsModeloPelicula _ControladorPelicula = new ClsModeloPelicula();
        private readonly BindingSource _Origen = new BindingSource();
        private ClsPermisoAplicacion _MisPermisos;
        private bool _Cargando;

        public FrmMantenimientoPeliculas()
        {
            InitializeComponent();

            MantenimientoProcLlenarCatalogos();
            _Origen.CurrentChanged += MantenimientoMetOrigenCambio;

            MantenimientoProcMostrarUsuario();
            MantenimientoProcCargarDatos(true);   // true = registra la consulta en bitácora
            MantenimientoProcEstadoInicial();

            Dictionary<Control, TipoPermiso> MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { MantenimientoBtnIngresar, TipoPermiso.Insertar },
                { MantenimientoBtnModificar, TipoPermiso.Editar },
                { MantenimientoBtnEliminar, TipoPermiso.Eliminar },
                { MantenimientoBtnImprimir, TipoPermiso.Imprimir }
            };

            _MisPermisos = ClsPermisosMantenimiento.MantenimientoFuncAplicarPermisos(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            this.KeyDown += MantenimientoMetTeclaPresionada;
        }

        #region Catálogos y usuario

        private void MantenimientoProcLlenarCatalogos()
        {
            // DropDown (no DropDownList) a propósito: la columna admite
            // cualquier texto de 45 caracteres, así que las listas sugieren
            // valores sin impedir que se escriba uno nuevo.
            MantenimientoCboClasificacion.Items.AddRange(new object[]
                { "A", "B", "B-15", "C", "D" });

            MantenimientoCboGenero.Items.AddRange(new object[]
                { "Acción", "Animación", "Ciencia ficción", "Comedia", "Documental",
                  "Drama", "Romance", "Suspenso", "Terror" });

            MantenimientoCboSubtitulado.Items.AddRange(new object[]
                { "Sí", "No" });

            MantenimientoCboIdioma.Items.AddRange(new object[]
                { "Español", "Inglés", "Francés", "Japonés", "Coreano", "Portugués" });
        }

        private void MantenimientoProcMostrarUsuario()
        {
            if (ClsSesionSeguridad.HaySesionActiva)
            {
                MantenimientoLblUsuario.Text =
                    "Usuario: " + ClsSesionSeguridad.NombreUsuario +
                    "   |   " + ClsSesionSeguridad.NombreEmpleado +
                    "   |   Rol: " + ClsSesionSeguridad.SeguridadMetRolesComoTexto();
            }
            else
            {
                MantenimientoLblUsuario.Text = "Sin sesión activa";
            }
        }

        #endregion

        #region Gestión de datos

        /// <param name="RegistrarBitacora">
        /// true cuando la carga es una consulta real del usuario; false cuando
        /// solo se está refrescando la rejilla después de grabar, para no
        /// ensuciar la bitácora con una consulta por cada alta.
        /// </param>
        private void MantenimientoProcCargarDatos(bool RegistrarBitacora)
        {
            try
            {
                _Cargando = true;
                _Origen.RemoveFilter();

                DataTable Peliculas = RegistrarBitacora
                    ? _ControladorPelicula.MantenimientoFuncObtenerTabla()
                    : _ControladorPelicula.MantenimientoFuncObtenerTablaSilenciosa();

                _Origen.DataSource = Peliculas;
                MantenimientoDgvPeliculas.DataSource = _Origen;

                MantenimientoProcFormatearRejilla();
                _Cargando = false;

                MantenimientoProcCargarRegistroActual();
                MantenimientoProcActualizarContador();
                MantenimientoProcAvisarSiFalloBitacora();
            }
            catch (Exception Error)
            {
                _Cargando = false;
                MessageBox.Show(
                    "Error al consultar la base de datos." + Environment.NewLine +
                    Environment.NewLine + Error.Message,
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MantenimientoProcFormatearRejilla()
        {
            if (MantenimientoDgvPeliculas.Columns.Count == 0) { return; }

            if (MantenimientoDgvPeliculas.Columns.Contains("is_active"))
            {
                int Indice = MantenimientoDgvPeliculas.Columns["is_active"].Index;
                MantenimientoDgvPeliculas.Columns.Remove("is_active");

                DataGridViewCheckBoxColumn Casilla = new DataGridViewCheckBoxColumn
                {
                    Name = "is_active",
                    DataPropertyName = "is_active",
                    HeaderText = "Activa",
                    TrueValue = 1,
                    FalseValue = 0
                };
                MantenimientoDgvPeliculas.Columns.Insert(Indice, Casilla);
            }

            MantenimientoProcTitular("idPelicula", "Id", 60);
            MantenimientoProcTitular("nombrePelicula", "Nombre", 260);
            MantenimientoProcTitular("clasificacionPelicula", "Clasificación", 120);
            MantenimientoProcTitular("generoPelicula", "Género", 150);
            MantenimientoProcTitular("subtituladoPelicula", "Subtitulado", 110);
            MantenimientoProcTitular("idiomaPelicula", "Idioma", 130);
            MantenimientoProcTitular("precioPelicula", "Precio", 110);

            if (MantenimientoDgvPeliculas.Columns.Contains("precioPelicula"))
            {
                MantenimientoDgvPeliculas.Columns["precioPelicula"].DefaultCellStyle.Format = "N2";
                MantenimientoDgvPeliculas.Columns["precioPelicula"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void MantenimientoProcTitular(string Columna, string Titulo, int Ancho)
        {
            if (!MantenimientoDgvPeliculas.Columns.Contains(Columna)) { return; }
            MantenimientoDgvPeliculas.Columns[Columna].HeaderText = Titulo;
            MantenimientoDgvPeliculas.Columns[Columna].Width = Ancho;
        }

        private void MantenimientoProcCargarRegistroActual()
        {
            if (_Cargando) { return; }

            DataRowView Fila = _Origen.Current as DataRowView;
            if (Fila == null)
            {
                MantenimientoProcLimpiarCampos();
                return;
            }

            MantenimientoTxtId.Text = Fila["idPelicula"].ToString();
            MantenimientoTxtNombre.Text = Fila["nombrePelicula"].ToString();
            MantenimientoCboClasificacion.Text = Fila["clasificacionPelicula"].ToString();
            MantenimientoCboGenero.Text = Fila["generoPelicula"].ToString();
            MantenimientoCboSubtitulado.Text = Fila["subtituladoPelicula"].ToString();
            MantenimientoCboIdioma.Text = Fila["idiomaPelicula"].ToString();

            object Precio = Fila["precioPelicula"];
            MantenimientoTxtPrecio.Text = Precio == DBNull.Value
                ? "0.00"
                : Convert.ToDouble(Precio).ToString("N2", CultureInfo.CurrentCulture);

            object Activa = Fila["is_active"];
            MantenimientoChkEstado.Checked = Activa != DBNull.Value && Convert.ToInt32(Activa) == 1;
        }

        private void MantenimientoProcActualizarContador()
        {
            int Total = _Origen.Count;
            MantenimientoLblContador.Text = Total == 0
                ? "Mostrando 0 de 0 registros"
                : "Mostrando " + (_Origen.Position + 1) + " de " + Total + " registros";
        }

        private void MantenimientoProcAvisarSiFalloBitacora()
        {
            if (!_ControladorPelicula.MantenimientoFuncBitacoraFallo()) { return; }

            MessageBox.Show(
                "La operación se realizó, pero NO se pudo registrar en la bitácora." +
                Environment.NewLine + Environment.NewLine +
                _ControladorPelicula.UltimoMensajeBitacora,
                "Bitácora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Estados del formulario

        private void MantenimientoProcEstadoInicial()
        {
            MantenimientoTxtNombre.Enabled = false;
            MantenimientoCboClasificacion.Enabled = false;
            MantenimientoCboGenero.Enabled = false;
            MantenimientoCboSubtitulado.Enabled = false;
            MantenimientoCboIdioma.Enabled = false;
            MantenimientoTxtPrecio.Enabled = false;
            MantenimientoChkEstado.Enabled = false;

            MantenimientoBtnGuardar.Enabled = false;
            MantenimientoBtnRefrescar.Enabled = true;
            MantenimientoBtnConsultar.Enabled = true;
            MantenimientoDgvPeliculas.Enabled = true;

            // Ingresar, Modificar, Eliminar e Imprimir los gobierna el permiso:
            // solo se vuelven a habilitar si el rol lo permite.
            if (_MisPermisos != null)
            {
                MantenimientoBtnIngresar.Enabled = _MisPermisos.PuedeInsertar;
                MantenimientoBtnModificar.Enabled = _MisPermisos.PuedeEditar;
                MantenimientoBtnEliminar.Enabled = _MisPermisos.PuedeEliminar;
                MantenimientoBtnImprimir.Enabled = _MisPermisos.PuedeImprimir;
            }
        }

        private void MantenimientoProcEstadoEdicion()
        {
            MantenimientoTxtNombre.Enabled = true;
            MantenimientoCboClasificacion.Enabled = true;
            MantenimientoCboGenero.Enabled = true;
            MantenimientoCboSubtitulado.Enabled = true;
            MantenimientoCboIdioma.Enabled = true;
            MantenimientoTxtPrecio.Enabled = true;
            MantenimientoChkEstado.Enabled = true;

            MantenimientoBtnIngresar.Enabled = false;
            MantenimientoBtnModificar.Enabled = false;
            MantenimientoBtnEliminar.Enabled = false;
            MantenimientoBtnRefrescar.Enabled = false;
            MantenimientoBtnGuardar.Enabled = true;
            MantenimientoDgvPeliculas.Enabled = false;
        }

        private void MantenimientoProcLimpiarCampos()
        {
            MantenimientoTxtId.Text = string.Empty;
            MantenimientoTxtNombre.Text = string.Empty;
            MantenimientoCboClasificacion.Text = string.Empty;
            MantenimientoCboGenero.Text = string.Empty;
            MantenimientoCboSubtitulado.Text = string.Empty;
            MantenimientoCboIdioma.Text = string.Empty;
            MantenimientoTxtPrecio.Text = "0.00";
            MantenimientoChkEstado.Checked = true;
        }

        /// <summary>Copia lo capturado en pantalla hacia el controlador.</summary>
        private bool MantenimientoFuncCargarControlador()
        {
            double Precio;
            if (!ClsModeloPelicula.MantenimientoFuncInterpretarPrecio(MantenimientoTxtPrecio.Text, out Precio))
            {
                MessageBox.Show(
                    "El precio no es un número válido. Escriba un valor como 45.50",
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MantenimientoTxtPrecio.Focus();
                return false;
            }

            _ControladorPelicula.NombrePelicula = MantenimientoTxtNombre.Text;
            _ControladorPelicula.ClasificacionPelicula = MantenimientoCboClasificacion.Text;
            _ControladorPelicula.GeneroPelicula = MantenimientoCboGenero.Text;
            _ControladorPelicula.SubtituladoPelicula = MantenimientoCboSubtitulado.Text;
            _ControladorPelicula.IdiomaPelicula = MantenimientoCboIdioma.Text;
            _ControladorPelicula.PrecioPelicula = Precio;
            _ControladorPelicula.IsActive = MantenimientoChkEstado.Checked;
            return true;
        }

        #endregion

        #region Eventos CRUD

        private void MantenimientoBtnIngresar_Click(object sender, EventArgs e)
        {
            MantenimientoProcEstadoEdicion();
            MantenimientoProcLimpiarCampos();
            MantenimientoTxtNombre.Focus();
        }

        private void MantenimientoBtnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MantenimientoTxtId.Text))
            {
                MessageBox.Show(
                    "Seleccione una película de la tabla para modificarla.",
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MantenimientoProcEstadoEdicion();
            MantenimientoTxtNombre.Focus();
        }

        private void MantenimientoBtnGuardar_Click(object sender, EventArgs e)
        {
            if (!MantenimientoFuncCargarControlador()) { return; }

            if (string.IsNullOrEmpty(MantenimientoTxtId.Text))
            {
                _ControladorPelicula.IdPelicula = 0;
                _ControladorPelicula.Estado = EstadoPelicula.Agregado;
            }
            else
            {
                _ControladorPelicula.IdPelicula = Convert.ToInt32(MantenimientoTxtId.Text);
                _ControladorPelicula.Estado = EstadoPelicula.Modificado;
            }

            string Resultado = _ControladorPelicula.MantenimientoFuncGrabarCambios();
            MessageBox.Show(Resultado, "Mantenimiento de Películas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            MantenimientoProcAvisarSiFalloBitacora();
            MantenimientoProcCargarDatos(false);
            MantenimientoProcEstadoInicial();
        }

        private void MantenimientoBtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MantenimientoTxtId.Text))
            {
                MessageBox.Show(
                    "Seleccione una película de la tabla para eliminarla.",
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult Respuesta = MessageBox.Show(
                "¿Está seguro de eliminar definitivamente la película \"" +
                MantenimientoTxtNombre.Text + "\"?",
                "Confirmación de eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (Respuesta != DialogResult.Yes) { return; }

            _ControladorPelicula.IdPelicula = Convert.ToInt32(MantenimientoTxtId.Text);
            _ControladorPelicula.Estado = EstadoPelicula.Eliminado;

            string Resultado = _ControladorPelicula.MantenimientoFuncGrabarCambios();
            MessageBox.Show(Resultado, "Mantenimiento de Películas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            MantenimientoProcAvisarSiFalloBitacora();
            MantenimientoProcCargarDatos(false);
            MantenimientoProcEstadoInicial();
        }

        private void MantenimientoBtnCancelar_Click(object sender, EventArgs e)
        {
            MantenimientoProcCargarDatos(false);
            MantenimientoProcEstadoInicial();
        }

        #endregion

        #region Consulta, reporte, navegación y ayuda

        private void MantenimientoBtnConsultar_Click(object sender, EventArgs e)
        {
            string Criterio = Microsoft.VisualBasic.Interaction.InputBox(
                "Escriba el nombre o parte del nombre de la película a buscar.\n" +
                "Deje el cuadro vacío para ver el catálogo completo.",
                "Consultar películas", string.Empty);

            try
            {
                _Cargando = true;
                _Origen.RemoveFilter();

                DataTable Resultado = string.IsNullOrWhiteSpace(Criterio)
                    ? _ControladorPelicula.MantenimientoFuncObtenerTabla()
                    : _ControladorPelicula.MantenimientoFuncBuscarPorNombre(Criterio);

                _Origen.DataSource = Resultado;
                MantenimientoDgvPeliculas.DataSource = _Origen;
                MantenimientoProcFormatearRejilla();
                _Cargando = false;

                if (Resultado.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron películas que coincidan con \"" + Criterio.Trim() + "\".",
                        "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MantenimientoProcCargarRegistroActual();
                MantenimientoProcActualizarContador();
                MantenimientoProcAvisarSiFalloBitacora();
            }
            catch (Exception Error)
            {
                _Cargando = false;
                MessageBox.Show(
                    "Error al ejecutar la consulta." + Environment.NewLine +
                    Environment.NewLine + Error.Message,
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MantenimientoProcEstadoInicial();
        }

        private void MantenimientoBtnRefrescar_Click(object sender, EventArgs e)
        {
            MantenimientoProcCargarDatos(true);
            MantenimientoProcEstadoInicial();
        }

        private void MantenimientoBtnImprimir_Click(object sender, EventArgs e)
        {
            // El controlador registra la acción REPORTE al armar el origen de datos.
            FrmReportePeliculas Reporte = new FrmReportePeliculas();
            Reporte.ShowDialog();
        }

        private void MantenimientoBtnInicio_Click(object sender, EventArgs e) => _Origen.MoveFirst();
        private void MantenimientoBtnAnterior_Click(object sender, EventArgs e) => _Origen.MovePrevious();
        private void MantenimientoBtnSiguiente_Click(object sender, EventArgs e) => _Origen.MoveNext();
        private void MantenimientoBtnFin_Click(object sender, EventArgs e) => _Origen.MoveLast();

        private void MantenimientoBtnSalir_Click(object sender, EventArgs e) => this.Close();

        private void MantenimientoMetTeclaPresionada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MantenimientoBtnAyuda_Click(sender, EventArgs.Empty);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Busca el archivo de ayuda subiendo desde la carpeta del ejecutable.
        /// Se evita la ruta absoluta "C:/..." que usa el MDI de Seguridad:
        /// esa ruta falla en cuanto el proyecto se clona en otra máquina.
        /// </summary>
        private void MantenimientoBtnAyuda_Click(object sender, EventArgs e)
        {
            DirectoryInfo Directorio = new DirectoryInfo(Application.StartupPath);

            while (Directorio != null)
            {
                string RutaChm = Path.Combine(Directorio.FullName,
                    "ayuda", "componentes", "mantenimiento2k26u", "Ayuda_Peliculas.chm");
                if (File.Exists(RutaChm))
                {
                    Help.ShowHelp(this, RutaChm, "Peliculas.html");
                    return;
                }

                string RutaHtml = Path.Combine(Directorio.FullName,
                    "ayuda", "componentes", "mantenimiento2k26u", "Ayuda_Peliculas.html");
                if (File.Exists(RutaHtml))
                {
                    System.Diagnostics.Process.Start(RutaHtml);
                    return;
                }

                Directorio = Directorio.Parent;
            }

            MessageBox.Show(
                "No se encontró el archivo de ayuda. Debe estar en " +
                "ayuda\\componentes\\mantenimiento2k26u\\ dentro del repositorio.",
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MantenimientoMetOrigenCambio(object sender, EventArgs e)
        {
            if (_Cargando) { return; }
            MantenimientoProcCargarRegistroActual();
            MantenimientoProcActualizarContador();
        }

        private void MantenimientoDgvPeliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { MantenimientoProcCargarRegistroActual(); }
        }

        #endregion
    }
}
