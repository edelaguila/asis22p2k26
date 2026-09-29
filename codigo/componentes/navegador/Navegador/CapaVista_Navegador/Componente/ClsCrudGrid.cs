//Aca comienza mi codigo
//Donald Estuardo Osorio Pérez 
//Carnet: 0901-23-17982
//18/09/2026
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CapaModelo_Navegador;

namespace CapaVista_Navegador
{
    // Se encarga del DataGridView: crearlo, mostrarlo, moverse entre filas y sincronizar los controles
    public class ClsCrudGrid
    {
        // Guardamos el formulario donde se va a dibujar la tabla
        private Navegador _Formulario;

        // Lista de controles del formulario mapeados con sus nombres de campo/columna
        private Dictionary<string, Control> _MapaControles;

        // Evento opcional para notificar la selección de fila hacia afuera si se requiere
        public event EventHandler<DataGridViewRow> AlSeleccionarFila;

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // La tabla vive en el área desplegable del propio Navegador (abajo de la barra de botones): el
        // Navegador se expande al consultar o ingresar y se contrae al ocultarla. Ver Navegador.NavegadorMetMostrarDetalle.
        private const int _AltoTabla = 320;
        private int _AltoSuperior;
        private string _Titulo = "Registros";
        private Label _LblTitulo;
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // Propiedad para acceder a la tabla desde fuera si hace falta
        public DataGridView NavegadorDgvDatos { get; private set; }

        public ClsCrudGrid(Navegador Formulario)
        {
            this._Formulario = Formulario;
            this._MapaControles = new Dictionary<string, Control>(StringComparer.OrdinalIgnoreCase);
        }

        // Permite vincular un control (TextBox, Label, ComboBox, etc.) con el nombre del campo en la BD
        public void NavegadorMetRegistrarControl(string NombreCampo, Control ControlFormulario)
        {
            if (!string.IsNullOrEmpty(NombreCampo) && ControlFormulario != null)
            {
                _MapaControles[NombreCampo] = ControlFormulario;
            }
        }

        // Llena la tabla con los datos que vienen del DataTable y la hace visible
        public void NavegadorMetMostrar(DataTable Datos)
        {
            // Si la tabla no existe en el form, la creamos
            if (NavegadorDgvDatos == null)
                NavegadorMetCrearGrid();

            NavegadorDgvDatos.DataSource = Datos;
            NavegadorMetMostrarDetalle();
            NavegadorDgvDatos.ReadOnly = true;

            // Bloqueamos las columnas para que el usuario no edite nada directo
            foreach (DataGridViewColumn Columna in NavegadorDgvDatos.Columns)
                Columna.ReadOnly = true;

            // Si hay datos, seleccionamos la primera fila y poblamos los controles
            if (NavegadorDgvDatos.Rows.Count > 0)
            {
                NavegadorMetSeleccionar(0);
            }
        }

        // Oculta la tabla si está creada
        public void NavegadorMetOcultar()
        {
            _Formulario.NavegadorMetOcultarDetalle();
        }

        // Instancia el DataGridView y le da las propiedades iniciales del diseño
        private void NavegadorMetCrearGrid()
        {
            NavegadorDgvDatos = new DataGridView();
            NavegadorDgvDatos.Name = "NavegadorDgvDatos";
            NavegadorDgvDatos.AllowUserToAddRows = false;
            NavegadorDgvDatos.AllowUserToDeleteRows = false;
            NavegadorDgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            NavegadorDgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NavegadorDgvDatos.MultiSelect = false;
            NavegadorDgvDatos.ReadOnly = true;
            NavegadorDgvDatos.BackgroundColor = Color.White;
            NavegadorDgvDatos.Dock = DockStyle.Fill;

            // Suscripción al evento CellClick para actualizar datos al hacer clic en una fila
            NavegadorDgvDatos.CellClick += NavegadorDgvDatos_CellClick;

            // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
            // La tabla se coloca en el área desplegable del Navegador.
            NavegadorMetCrearPanel();
        }

        // Coloca un panel arriba de la tabla, dentro del área desplegable del Navegador (lo usa el
        // formulario de Ingresar/Modificar). El Navegador se expande lo que mide el panel.
        public void NavegadorMetAgregarSuperior(Control Panel)
        {
            Panel.Dock = DockStyle.Top;
            _AltoSuperior = Panel.Height;
            _Formulario.NavegadorPnlDetalle.Controls.Add(Panel);
            NavegadorMetMostrarDetalle();
        }

        // Quita el panel de arriba y el Navegador vuelve a medir solo lo que ocupa la tabla.
        public void NavegadorMetQuitarSuperior(Control Panel)
        {
            _Formulario.NavegadorPnlDetalle.Controls.Remove(Panel);
            _AltoSuperior = 0;

            if (_Formulario.NavegadorPnlDetalle.Visible)
                NavegadorMetMostrarDetalle();
        }

        // Título que se muestra debajo de la tabla (tabla que se está trabajando).
        public string Titulo
        {
            set
            {
                _Titulo = value;

                if (_LblTitulo != null)
                    _LblTitulo.Text = value;
            }
        }

        // Agrega la tabla y su título al área desplegable. La tabla se agrega primero (Fill) para que
        // ocupe lo que dejan el título (abajo) y el panel del registro (arriba).
        private void NavegadorMetCrearPanel()
        {
            _LblTitulo = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 24,
                Text = _Titulo,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font(_Formulario.Font, FontStyle.Bold)
            };

            _Formulario.NavegadorPnlDetalle.Controls.Add(NavegadorDgvDatos);
            _Formulario.NavegadorPnlDetalle.Controls.Add(_LblTitulo);
        }

        // Despliega el Navegador con espacio para la tabla y, si está abierto, el panel del registro.
        private void NavegadorMetMostrarDetalle()
        {
            _Formulario.NavegadorMetMostrarDetalle(_AltoTabla + _AltoSuperior);
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // Manejador del evento CellClick al hacer clic directamente en la tabla
        private void NavegadorDgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < NavegadorDgvDatos.Rows.Count)
            {
                NavegadorMetProcesarSeleccionFila(NavegadorDgvDatos.Rows[e.RowIndex]);
            }
        }

        // Procesa la fila activa: llena controles (TextBox, Label, ComboBox, CheckBox) y dispara eventos
        private void NavegadorMetProcesarSeleccionFila(DataGridViewRow Fila)
        {
            if (Fila == null) return;

            // Actualizamos dinámicamente cada control registrado en el diccionario
            foreach (KeyValuePair<string, Control> Par in _MapaControles)
            {
                string NombreCampo = Par.Key;
                Control ControlForm = Par.Value;
                string Valor = NavegadorFuncObtenerValor(Fila, NombreCampo);

                NavegadorMetAsignarValorAControl(ControlForm, Valor);
            }

            // Notificamos si existe algún suscriptor externo
            AlSeleccionarFila?.Invoke(this, Fila);
        }

        // Asigna el valor leído de la celda al tipo de control correspondiente
        private void NavegadorMetAsignarValorAControl(Control ControlForm, string Valor)
        {
            if (ControlForm == null) return;

            if (ControlForm is TextBox txt)
            {
                txt.Text = Valor;
            }
            else if (ControlForm is Label lbl)
            {
                lbl.Text = Valor;
            }
            else if (ControlForm is ComboBox cbo)
            {
                cbo.Text = Valor;
                if (cbo.SelectedIndex == -1 && cbo.Items.Count > 0)
                {
                    cbo.SelectedValue = Valor;
                }
            }
            else if (ControlForm is CheckBox chk)
            {
                chk.Checked = Valor == "1" || Valor.Equals("true", StringComparison.OrdinalIgnoreCase);
            }
            else if (ControlForm is DateTimePicker dtp)
            {
                if (DateTime.TryParse(Valor, out DateTime Fecha))
                    dtp.Value = Fecha;
            }
        }

        // Busca en qué posición de la tabla está una columna por su nombre
        public int NavegadorFuncObtenerIndiceColumna(string NombreCampo)
        {
            if (NavegadorDgvDatos == null)
                return -1;

            foreach (DataGridViewColumn Columna in NavegadorDgvDatos.Columns)
            {
                // Revisamos si coincide con el nombre del mapeo
                if (string.Equals(Columna.DataPropertyName, NombreCampo, StringComparison.OrdinalIgnoreCase))
                    return Columna.Index;

                // O si coincide con el nombre directo del control
                if (string.Equals(Columna.Name, NombreCampo, StringComparison.OrdinalIgnoreCase))
                    return Columna.Index;
            }

            return -1; // Si no la encuentra devuelve -1
        }

        // Saca el texto de una celda en específico recibiendo la fila y el nombre de la columna
        public string NavegadorFuncObtenerValor(DataGridViewRow Fila, string Campo)
        {
            int Indice = NavegadorFuncObtenerIndiceColumna(Campo);

            if (Indice < 0 || Fila == null)
                return "";

            object Valor = Fila.Cells[Indice].Value;
            // Validamos que no venga nulo ni con vacíos de BD
            return Valor == null || Valor == DBNull.Value ? "" : Convert.ToString(Valor);
        }

        // Lee de la fila seleccionada solo las columnas marcadas como PK en el esquema
        public Dictionary<string, string> NavegadorFuncObtenerClavesPrimarias(List<ClsColumnaInfo> Esquema, DataGridViewRow Fila)
        {
            Dictionary<string, string> Resultado = new Dictionary<string, string>();

            if (Esquema == null || Fila == null)
                return Resultado;

            // Recorremos las columnas del esquema y armamos un mapa con las que son Llave Primaria
            foreach (ClsColumnaInfo Columna in Esquema)
            {
                if (Columna.EsPK)
                    Resultado[Columna.Nombre] = NavegadorFuncObtenerValor(Fila, Columna.Nombre);
            }

            return Resultado;
        }

        // Selecciona la primera fila de la tabla
        public void NavegadorMetInicio()
        {
            NavegadorMetSeleccionar(0);
        }

        // Sube una fila en la selección si no estamos al principio
        public void NavegadorMetAnterior()
        {
            if (NavegadorDgvDatos == null || NavegadorDgvDatos.Rows.Count == 0)
                return;

            NavegadorMetSeleccionar(Math.Max(0, NavegadorFuncIndiceActual() - 1));
        }

        // Baja una fila en la selección si no llegamos al final
        public void NavegadorMetSiguiente()
        {
            if (NavegadorDgvDatos == null || NavegadorDgvDatos.Rows.Count == 0)
                return;

            NavegadorMetSeleccionar(
                Math.Min(NavegadorDgvDatos.Rows.Count - 1, NavegadorFuncIndiceActual() + 1));
        }

        // Selecciona la última fila disponible
        public void NavegadorMetFin()
        {
            if (NavegadorDgvDatos == null || NavegadorDgvDatos.Rows.Count == 0)
                return;

            NavegadorMetSeleccionar(NavegadorDgvDatos.Rows.Count - 1);
        }

        // Devuelve el número de fila donde está parado el usuario actualmente
        private int NavegadorFuncIndiceActual()
        {
            return NavegadorDgvDatos != null && NavegadorDgvDatos.CurrentRow != null
                ? NavegadorDgvDatos.CurrentRow.Index
                : 0;
        }

        // Marca la fila seleccionada en pantalla y mueve el scroll para que se vea si está muy abajo
        private void NavegadorMetSeleccionar(int Indice)
        {
            if (NavegadorDgvDatos == null ||
                !NavegadorDgvDatos.Visible ||
                NavegadorDgvDatos.Rows.Count == 0 ||
                Indice < 0 ||
                Indice >= NavegadorDgvDatos.Rows.Count)
                return;

            // Limpiamos selección anterior y marcamos la nueva
            NavegadorDgvDatos.ClearSelection();
            NavegadorDgvDatos.Rows[Indice].Selected = true;
            NavegadorDgvDatos.CurrentCell = NavegadorDgvDatos.Rows[Indice].Cells[0];

            // Si la fila quedó fuera de la vista actual, movemos el scroll automático
            if (NavegadorDgvDatos.FirstDisplayedScrollingRowIndex > Indice ||
                NavegadorDgvDatos.FirstDisplayedScrollingRowIndex +
                NavegadorDgvDatos.DisplayedRowCount(false) <= Indice)
            {
                NavegadorDgvDatos.FirstDisplayedScrollingRowIndex = Indice;
            }

            // Carga de datos inmediata a los controles registrados al moverse por los botones
            NavegadorMetProcesarSeleccionFila(NavegadorDgvDatos.Rows[Indice]);
        }

        //Cambios Por Mario Alberto Taracena Pérez 0901-23-9355 y Dylan Rene Hernandez Recinos 0901-23-519
        // Filtra el DataGridView para mostrar únicamente la fila cuya llave primaria coincide
        // con el valor seleccionado en el componente de Consultas. Si ValorPK viene vacío o nulo,
        // quita el filtro y vuelve a mostrar todos los registros cargados.
        public void NavegadorMetFiltrarPorLlave(string NombreCampoPK, string ValorPK)
        {
            if (NavegadorDgvDatos == null || NavegadorDgvDatos.DataSource == null)
                return;

            DataTable Tabla = NavegadorDgvDatos.DataSource as DataTable;
            if (Tabla == null)
                return;

            if (string.IsNullOrEmpty(ValorPK))
            {
                Tabla.DefaultView.RowFilter = "";
            }
            else
            {
                DataColumn Columna = null;

                foreach (DataColumn C in Tabla.Columns)
                {
                    if (string.Equals(C.ColumnName, NombreCampoPK, StringComparison.OrdinalIgnoreCase))
                    {
                        Columna = C;
                        break;
                    }
                }

                if (Columna == null)
                    return;

                Type Tipo = Columna.DataType;

                bool EsNumerico = Tipo == typeof(int) || Tipo == typeof(long) ||
                                  Tipo == typeof(short) || Tipo == typeof(byte) ||
                                  Tipo == typeof(decimal) || Tipo == typeof(double) ||
                                  Tipo == typeof(float);

                if (EsNumerico)
                {
                    Tabla.DefaultView.RowFilter = Columna.ColumnName + " = " + ValorPK;
                }
                else
                {
                    string ValorEscapado = ValorPK.Replace("'", "''");
                    Tabla.DefaultView.RowFilter = Columna.ColumnName + " = '" + ValorEscapado + "'";
                }
            }

            if (NavegadorDgvDatos.Rows.Count > 0)
            {
                NavegadorMetSeleccionar(0);
            }
        }
    }
}

//aca termina mi codigo
//Donald Estuardo Osorio Pérez 
//Carnet: 0901-23-17982
//18/09/2026
