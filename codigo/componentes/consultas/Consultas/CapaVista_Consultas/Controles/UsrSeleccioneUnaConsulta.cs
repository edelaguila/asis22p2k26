using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas.Controles
{
    // Inicio del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026
    public partial class UsrSeleccioneUnaConsulta : CapaVista_Componentes.ClsControlUsuarioConsultas
    {
        public event Action<string, string> ConsultaSeleccionada;
        public string Tabla { get; set; }
        public string Query { get; set; }

        private readonly ClsConsultaSeleccionada _Consultas = new ClsConsultaSeleccionada();

        public UsrSeleccioneUnaConsulta()
        {
            InitializeComponent();
            ConsultasProcActualizarConsultas();
        }

        private void ConsultasProcActualizarConsultas()
        {
            try
            {
                ConsultasDgvConsultasReutilizables.Columns.Clear();

                DataTable Consultas = _Consultas.ConsultasFuncCargarConsultas();

                ConsultasDgvConsultasReutilizables.DataSource = Consultas;

                if (ConsultasDgvConsultasReutilizables.Columns["Query"] != null)
                {
                    ConsultasDgvConsultasReutilizables.Columns["Query"].Visible = false;
                }

                if (ConsultasDgvConsultasReutilizables.Columns["Tabla"] != null)
                {
                    ConsultasDgvConsultasReutilizables.Columns["Tabla"].Visible = false;
                }
            }
            catch (InvalidOperationException Excepcion)
            {
                ConsultasDgvConsultasReutilizables.DataSource = null;

                MessageBox.Show(
                    Excepcion.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception Excepcion)
            {
                ConsultasDgvConsultasReutilizables.DataSource = null;

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
            if (string.IsNullOrWhiteSpace(Tabla))
            {
                ConsultasProcActualizarConsultas();
                return;
            }

            ConsultasProcActualizarConsultasPorTabla(Tabla);
        }

        private void ConsultasMetBtnIngresarClick(object Sender, EventArgs Evento)
        {
            FrmMantenimientoConsultas FormularioMantenimientoConsultas = new FrmMantenimientoConsultas(Tabla);
            FormularioMantenimientoConsultas.ShowDialog();
            ConsultasProcRefrescarConsultas();
        }



        private void ConsultasMetBtnConsultarClick(object Sender, EventArgs Evento)
        {
            DataGridView Grilla = ConsultasDgvConsultasReutilizables;

            DataGridViewRow FilaSeleccionada = null;

            if (Grilla.SelectedRows.Count > 0)
            {
                FilaSeleccionada = Grilla.SelectedRows[0];
            }
            else
            {
                foreach (DataGridViewRow Fila in Grilla.Rows)
                {
                    if (Fila.Visible && !Fila.IsNewRow)
                    {
                        FilaSeleccionada = Fila;
                        break;
                    }
                }

                if (FilaSeleccionada == null)
                {
                    MessageBox.Show(
                        "No hay consultas disponibles para ejecutar.",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DataGridViewCell CeldaVisible = null;

                foreach (DataGridViewCell Celda in FilaSeleccionada.Cells)
                {
                    if (Celda.Visible)
                    {
                        CeldaVisible = Celda;
                        break;
                    }
                }

                if (CeldaVisible == null)
                {
                    MessageBox.Show(
                        "No hay columnas visibles para seleccionar.",
                        "Consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Grilla.ClearSelection();

                Grilla.CurrentCell = CeldaVisible;

                FilaSeleccionada.Selected = true;
            }

            Query = FilaSeleccionada.Cells["Query"].Value?.ToString();

            Tabla = FilaSeleccionada.Cells["Tabla"].Value?.ToString();

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

            ConsultaSeleccionada?.Invoke(Query, Tabla);
        }

        public void ConsultasProcActualizarConsultasPorTabla(string NombreTabla)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NombreTabla))
                {
                    throw new ArgumentException("El nombre de la tabla no puede estar vacío.");
                }

                Tabla = NombreTabla;

                ConsultasDgvConsultasReutilizables.Columns.Clear();

                DataTable Consultas = _Consultas.ConsultasFuncCargarConsultasPorTabla(NombreTabla);

                ConsultasDgvConsultasReutilizables.DataSource = Consultas;

                if (ConsultasDgvConsultasReutilizables.Columns["Id"] != null)
                {
                    ConsultasDgvConsultasReutilizables.Columns["Id"].Visible = false;
                }

                if (ConsultasDgvConsultasReutilizables.Columns["Query"] != null)
                {
                    ConsultasDgvConsultasReutilizables.Columns["Query"].Visible = false;
                }

                if (ConsultasDgvConsultasReutilizables.Columns["Tabla"] != null)
                {
                    ConsultasDgvConsultasReutilizables.Columns["Tabla"].Visible = false;
                }

            }
            catch (ArgumentException Excepcion)
            {
                ConsultasDgvConsultasReutilizables.DataSource = null;

                MessageBox.Show(
                    Excepcion.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        // Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026

        // Inicio del código de Diego Fernando Santizo Samayoa 0901-22-15950 el 22/09/2026
        private void ConsultasMetBtnEliminarClick(object Sender, EventArgs Evento)
        {
            try
            {
                if (ConsultasDgvConsultasReutilizables.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una consulta para eliminar.",
                        "Eliminar consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (ConsultasDgvConsultasReutilizables.Columns["Id"] == null)
                {
                    MessageBox.Show(
                        "No se encontró el identificador de la consulta.",
                        "Eliminar consulta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                int IdConsulta = Convert.ToInt32(
                    ConsultasDgvConsultasReutilizables.CurrentRow.Cells["Id"].Value);

                DialogResult Resultado = MessageBox.Show(
                    "¿Está seguro de eliminar la consulta seleccionada?",
                    "Eliminar consulta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (Resultado != DialogResult.Yes)
                {
                    return;
                }

                _Consultas.ConsultasProcEliminarConsulta(IdConsulta);

                MessageBox.Show(
                    "Consulta eliminada correctamente.",
                    "Eliminar consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ConsultasProcRefrescarConsultas();
            }
            catch (InvalidOperationException Excepcion)
            {
                MessageBox.Show(
                    Excepcion.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "Ocurrió un error inesperado al eliminar la consulta.\n\n" +
                    Excepcion.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Fin del código de Diego Fernando Santizo Samayoa 0901-22-15950 el 22/09/2026
    }
}