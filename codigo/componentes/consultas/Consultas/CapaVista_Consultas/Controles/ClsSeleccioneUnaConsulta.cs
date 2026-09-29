using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    public partial class ClsSeleccioneUnaConsulta : Componentes.ClsControlUsuarioConsultas
    {
        public event Action<string, string> ConsultaSeleccionada;
        public string Tabla { get; set; }
        public string Query { get; set; }

        private readonly ClsConsultaSeleccionada _Consultas =
            new ClsConsultaSeleccionada();

        public ClsSeleccioneUnaConsulta()
        {
            InitializeComponent();

            ConsultasProcActualizarConsultas();
        }

        private void ConsultasProcActualizarConsultas()
        {
            try
            {
                ConsultasDgvConsultasReutilizables
                    .Columns.Clear();

                DataTable Consultas =
                    _Consultas
                        .ConsultasFuncCargarConsultas();

                ConsultasDgvConsultasReutilizables
                    .DataSource = Consultas;

                if (ConsultasDgvConsultasReutilizables
                    .Columns["Query"] != null)
                {
                    ConsultasDgvConsultasReutilizables
                        .Columns["Query"]
                        .Visible = false;
                }

                if (ConsultasDgvConsultasReutilizables
                    .Columns["Tabla"] != null)
                {
                    ConsultasDgvConsultasReutilizables
                        .Columns["Tabla"]
                        .Visible = false;
                }
            }
            catch (InvalidOperationException Excepcion)
            {
                ConsultasDgvConsultasReutilizables
                    .DataSource = null;

                MessageBox.Show(
                    Excepcion.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception Excepcion)
            {
                ConsultasDgvConsultasReutilizables
                    .DataSource = null;

                MessageBox.Show(
                    "Ocurrió un error inesperado al cargar " +
                    "las consultas.\n\n" +
                    Excepcion.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void ConsultasProcRefrescarConsultas()
        {
            ConsultasProcActualizarConsultas();
        }

        private void ConsultasMetBtnIngresarClick(
            object Sender,
            EventArgs Evento)
        {
            FrmMantenimientoConsultas
                FormularioMantenimientoConsultas =
                    new FrmMantenimientoConsultas();

            FormularioMantenimientoConsultas.Show();
        }

        private void ConsultasMetBtnEliminarClick(
            object Sender,
            EventArgs Evento)
        {

        }

        private void ConsultasMetBtnConsultarClick(
            object Sender,
            EventArgs Evento)
        {
            if (ConsultasDgvConsultasReutilizables
                .CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione una fila para ejecutar la consulta.",
                    "Consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Query =
                ConsultasDgvConsultasReutilizables
                    .CurrentRow
                    .Cells["Query"]
                    .Value?
                    .ToString();

            Tabla =
                ConsultasDgvConsultasReutilizables
                    .CurrentRow
                    .Cells["Tabla"]
                    .Value?
                    .ToString();

            if (string.IsNullOrWhiteSpace(Query))
            {
                MessageBox.Show(
                    "La consulta seleccionada no contiene " +
                    "una sentencia válida.",
                    "Consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ConsultaSeleccionada?.Invoke(
                Query,
                Tabla);
        }
    }
}