using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_BtnBusqueda;

namespace CapaVista_BtnBusqueda
{
    public partial class BtnBusqueda : UserControl
    {
        private ClsModeloBtnBusqueda modeloBusqueda;

        public TextBox TxtNombreReporte { get; set; }
        public DateTimePicker DtpFechaReporte { get; set; }
        public CheckBox ChkNombreReporte { get; set; }
        public CheckBox ChkFechaReporte { get; set; }
        public DataGridView DgvReportes { get; set; }

        public BtnBusqueda()
        {
            InitializeComponent();

            modeloBusqueda = new ClsModeloBtnBusqueda();
            btnAccionBusqueda.Click += BtnAccionBusqueda_Click;
        }

        private void BtnAccionBusqueda_Click(object sender, EventArgs e)
        {
            EjecutarBusqueda();
        }

        public void EjecutarBusqueda()
        {
            try
            {
                string nombreReporte = "";
                DateTime? fechaReporte = null;

                bool buscarPorNombre =
                    ChkNombreReporte != null &&
                    ChkNombreReporte.Checked;

                bool buscarPorFecha =
                    ChkFechaReporte != null &&
                    ChkFechaReporte.Checked;

                if (buscarPorNombre && TxtNombreReporte != null)
                {
                    nombreReporte = TxtNombreReporte.Text.Trim();
                }

                if (buscarPorFecha && DtpFechaReporte != null)
                {
                    fechaReporte = DtpFechaReporte.Value.Date;
                }

                DataTable resultados = modeloBusqueda.BuscarReportes(
                    nombreReporte,
                    fechaReporte,
                    buscarPorNombre,
                    buscarPorFecha
                );

                if (DgvReportes != null)
                {
                    DgvReportes.DataSource = resultados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron buscar los reportes.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}