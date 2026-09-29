using System;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasComplejas :
        Componentes.ClsBaseTerminus
    {
        public string TablaActual { get; private set; }

        public string IdSeleccionado { get; private set; }

        public bool SeleccionRealizada { get; private set; }

        public FrmConsultasComplejas()
        {
            InitializeComponent();

            ConsultasMetConfigurarFormulario();
        }

        public FrmConsultasComplejas(
            string Tabla,
            string CampoId)
            : this()
        {
            TablaActual = Tabla;

            ConsultasUcTabla
                .ConsultasMetConfigurarSeleccion(
                    CampoId);

            ConsultasUcTabla
                .ConsultasProcCambiarRegistrosPorPagina(
                    30,
                    TablaActual);
        }

        private void ConsultasMetConfigurarFormulario()
        {
            ConsultasUcTabla
                .ConsultasMetAjustarAlturaFilas(30);

            ConsultasUcConsultasReutilizables
                .ConsultaSeleccionada +=
                    ConsultasMetEjecutarConsultaSeleccionada;

            ConsultasUcTabla
                .ConsultasEvtFilaSeleccionada +=
                    ConsultasMetUcTablaFilaSeleccionada;
        }

        private void ConsultasMetUcTablaFilaSeleccionada(
            object Sender,
            EventArgs Evento)
        {
            IdSeleccionado =
                ConsultasUcTabla.IdSeleccionado;

            SeleccionRealizada =
                ConsultasUcTabla.SeleccionRealizada;

            if (!SeleccionRealizada)
            {
                return;
            }

            DialogResult =
                DialogResult.OK;

            Close();
        }

        // Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"

        private void ConsultasMetEjecutarConsultaSeleccionada(
            string Query,
            string Tabla)
        {
            TablaActual = Tabla;

            ConsultasUcTabla
                .ConsultasProcCargarConsultaDesdeQuery(
                    Query,
                    Tabla);
        }

        private void ConsultasMetBtnSeleccionarClick(
            object Sender,
            EventArgs Evento)
        {
            bool ResultadoSeleccion =
                ConsultasUcTabla
                    .ConsultasFuncSeleccionarRegistro();

            if (!ResultadoSeleccion)
            {
                MessageBox.Show(
                    "Seleccione un registro.",
                    "Consultas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            IdSeleccionado =
                ConsultasUcTabla.IdSeleccionado;

            SeleccionRealizada =
                ConsultasUcTabla.SeleccionRealizada;

            DialogResult =
                DialogResult.OK;

            Close();
        }

        private void ConsultasMetBtnSalirClick(
            object Sender,
            EventArgs Evento)
        {
            DialogResult Respuesta =
                MessageBox.Show(
                    "¿Desea salir del componente de Consultas?",
                    "Consultas",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (Respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ConsultasMetBtnInicioClick(
            object Sender,
            EventArgs Evento)
        {
            Close();
        }

        private void ConsultasMetBtnRefrescarClick(object Sender, EventArgs Evento)
        {
            ConsultasUcTabla.ConsultasProcActualizarTabla(TablaActual);
        }

        // Fin de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "16/09/26"
    }
}