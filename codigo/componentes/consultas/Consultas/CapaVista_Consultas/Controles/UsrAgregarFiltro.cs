using CapaControlador_Consultas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CapaVista_Consultas.Controles
{
    // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "26/09/26"
            // Control que permite elegir un campo, un operador y un valor para solicitar una búsqueda.
    public partial class UsrAgregarFiltro : CapaVista_Componentes.ClsControlUsuarioConsultas
    {
        private readonly ClsControladorFiltroSimple _Controlador = new ClsControladorFiltroSimple();

        private string _TablaActual;

        public event EventHandler<ClsArgumentosFiltro> ConsultasEvtBuscarSolicitado;
        public event EventHandler ConsultasEvtRefrescarSolicitado;

        public UsrAgregarFiltro()
        {
            InitializeComponent();

            ConsultasBtnBuscar.Click += ConsultasMetBtnBuscarClick;
            ConsultasBtnRefrescar.Click += ConsultasMetBtnRefrescarClick;

            // TextoKeyDown transmite las teclas del TextBox interno de UsrTextbox.
            ConsultasUsrValor.TextoKeyDown += ConsultasMetTxtValorKeyDown;
            ConsultasCboCampo.SelectedIndexChanged +=
                ConsultasMetCboCampoSelectedIndexChanged;

            ConsultasUsrValor.MaxLength = 50;
        }

        public void ConsultasProcActualizarTabla(string Tabla)
        {
            if (string.IsNullOrWhiteSpace(Tabla))
            {
                _TablaActual = null;
                ConsultasCboCampo.Items.Clear();
                ConsultasCboOperador.Items.Clear();
                ConsultasUsrValor.Text = string.Empty;
                ConsultasUsrValor.ConsultasMetLimpiarError();
                return;
            }

            _TablaActual = Tabla;
            ConsultasMetCargarCampos();
        }

        // Inicio del código de Miguel David Contreras Jacinto - carné: "0901-21-3878" - Fecha: "26/09/26"
             // Actualiza los operadores y el límite del valor cuando cambia el campo seleccionado.
        private void ConsultasMetCboCampoSelectedIndexChanged(
            object Sender, EventArgs Evento)
        {
            ConsultasMetCargarOperadoresPorTipo();
        }
        // Fin del código de Miguel David Contreras Jacinto - carné: "0901-21-3878" - Fecha: "26/09/26"

        public void ConsultasProcLimpiar()
        {
            ConsultasCboCampo.SelectedIndex = -1;
            ConsultasCboOperador.SelectedIndex = -1;
            ConsultasUsrValor.Text = string.Empty;
            ConsultasUsrValor.ConsultasMetLimpiarError();
        }

        private void ConsultasMetCargarCampos()
        {
            ConsultasCboCampo.Items.Clear();

            try
            {
                List<string> Campos =
                    _Controlador.ConsultasFuncObtenerCampos(_TablaActual);

                foreach (string Campo in Campos)
                {
                    ConsultasCboCampo.Items.Add(Campo);
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "No se pudieron cargar los campos de la tabla '" +
                    _TablaActual + "'.\n\nDetalle: " + Excepcion.Message,
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ConsultasMetBtnBuscarClick(object Sender, EventArgs Evento)
        {
            string Campo = ConsultasCboCampo.SelectedItem == null
                ? string.Empty
                : ConsultasCboCampo.SelectedItem.ToString();

            string Operador = ConsultasCboOperador.SelectedItem == null
                ? string.Empty
                : ConsultasCboOperador.SelectedItem.ToString();

            string Valor = ConsultasUsrValor.Text;

            string Mensaje = _Controlador.ConsultasFuncValidarFiltro(Campo, Operador, Valor);

            if (Mensaje != null)
            {
                MessageBox.Show(
                    Mensaje,
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            ConsultasUsrValor.ConsultasMetLimpiarError();

            ConsultasEvtBuscarSolicitado?.Invoke(this, new ClsArgumentosFiltro(Campo, Operador, Valor));
        }
        // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"

        // Inicio del código de Miguel David Contreras Jacinto - carné: "0901-21-3878" - Fecha: "26/09/26"
             // Carga los operadores compatibles con el tipo del campo y ajusta el límite del valor.
        private void ConsultasMetCargarOperadoresPorTipo()
        {
            string OperadorSeleccionado =
                ConsultasCboOperador.SelectedItem == null
                    ? string.Empty
                    : ConsultasCboOperador.SelectedItem.ToString();

            ConsultasUsrValor.MaxLength = 50;
            ConsultasUsrValor.Text = string.Empty;
            ConsultasUsrValor.ConsultasMetLimpiarError();
            ConsultasCboOperador.Items.Clear();

            if (ConsultasCboCampo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(_TablaActual))
            {
                return;
            }

            string Campo = ConsultasCboCampo.SelectedItem.ToString();

            Type TipoCampo =
                _Controlador.ConsultasFuncObtenerTipoCampo(_TablaActual, Campo);

            if (TipoCampo == null)
                return;

            // Campos de fecha y hora.
            if (TipoCampo == typeof(DateTime))
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add(">");
                ConsultasCboOperador.Items.Add("<");
                ConsultasCboOperador.Items.Add(">=");
                ConsultasCboOperador.Items.Add("<=");

                ConsultasUsrValor.MaxLength = 19; // aaaa-MM-dd HH:mm:ss
            }
            // Campos numéricos.
            else if (TipoCampo == typeof(decimal) ||
                     TipoCampo == typeof(int) ||
                     TipoCampo == typeof(long) ||
                     TipoCampo == typeof(double) ||
                     TipoCampo == typeof(float))
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add(">");
                ConsultasCboOperador.Items.Add("<");
                ConsultasCboOperador.Items.Add(">=");
                ConsultasCboOperador.Items.Add("<=");

                ConsultasUsrValor.MaxLength = 10;
            }
            // Campos booleanos.
            else if (TipoCampo == typeof(bool))
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
            }
            // Campos de texto.
            else
            {
                ConsultasCboOperador.Items.Add("=");
                ConsultasCboOperador.Items.Add("<>");
                ConsultasCboOperador.Items.Add("Contiene");
                ConsultasCboOperador.Items.Add("Comienza con");
                ConsultasCboOperador.Items.Add("Termina con");
            }

            if (!string.IsNullOrWhiteSpace(OperadorSeleccionado) &&
                ConsultasCboOperador.Items.Contains(OperadorSeleccionado))
            {
                ConsultasCboOperador.SelectedItem = OperadorSeleccionado;
            }
            else
            {
                ConsultasCboOperador.SelectedIndex = -1;
            }
        }
        // Fin del código de Miguel David Contreras Jacinto - carné: "0901-21-3878" - Fecha: "26/09/26"

        private void ConsultasMetBtnRefrescarClick(
            object Sender, EventArgs Evento)
        {
            ConsultasProcLimpiar();
            ConsultasEvtRefrescarSolicitado?.Invoke(this, EventArgs.Empty);
        }

        private void ConsultasMetTxtValorKeyDown(
            object Sender, KeyEventArgs Evento)
        {
            if (Evento.KeyCode == Keys.Enter)
            {
                Evento.SuppressKeyPress = true;
                ConsultasMetBtnBuscarClick(Sender, EventArgs.Empty);
            }
        }

        
        // Guarda los datos del filtro que se envían al solicitar una búsqueda.
        public class ClsArgumentosFiltro : EventArgs
        {
            public string Campo { get; private set; }
            public string Operador { get; private set; }
            public string Valor { get; private set; }

            public ClsArgumentosFiltro(
                string Campo, string Operador, string Valor)
            {
                this.Campo = Campo;
                this.Operador = Operador;
                this.Valor = Valor;
            }
        }
        // Fin del código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "26/09/26"

        // Inicio de código de Diego Fernando Santizo Samayoa - carné: "0901-22-15950" - Fecha: "26/09/26"
        
        // Busca el archivo CHM desde la carpeta de ejecución y abre la ayuda de consulta simple.
        private void ConsultasMetBtnAyudaClick(object Sender, EventArgs Evento)
        {
            DirectoryInfo Directorio =
                new DirectoryInfo(Application.StartupPath);

            while (Directorio != null)
            {
                string Ruta = Path.Combine(
                    Directorio.FullName,
                    "ayuda",
                    "componentes",
                    "consultas",
                    "Ayuda_Consultas.chm");

                if (File.Exists(Ruta))
                {
                    Help.ShowHelp(this, Ruta, "ConsultaSimple.html");
                    return;
                }

                Directorio = Directorio.Parent;
            }

            MessageBox.Show("No se encontró el archivo de ayuda.");
        }

        // Procedimientos para actualizar textbox

        public void ConsultasProcMostrarErrorValor(string Mensaje)
        {
            ConsultasUsrValor.ConsultasMetMostrarError(Mensaje);
        }

        public void ConsultasProcLimpiarErrorValor()
        {
            ConsultasUsrValor.ConsultasMetLimpiarError();
        }

        public void ConsultasProcAvisarSinResultados()
        {
            if (ConsultasCboCampo.SelectedItem == null ||
                string.IsNullOrWhiteSpace(_TablaActual))
                return;

            string Campo = ConsultasCboCampo.SelectedItem.ToString();
            Type TipoCampo =
                _Controlador.ConsultasFuncObtenerTipoCampo(_TablaActual, Campo);

            if (TipoCampo == typeof(DateTime))
            {
                ConsultasUsrValor.ConsultasMetMostrarError(
                    "No se encontraron resultados. Verifique el formato: " +
                    "aaaa-MM-dd HH:mm:ss (ejemplo: 2026-09-27 14:30:00).");
            }
        }

        // Fin de código de Diego Fernando Santizo Samayoa - carné: "0901-22-15950" - Fecha: "26/09/26"

    }
}