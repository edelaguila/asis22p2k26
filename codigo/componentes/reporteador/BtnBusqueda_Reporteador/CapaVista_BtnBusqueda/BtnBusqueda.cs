/*
     GABRIELA PINTO GARCIA
 */

using System;
using System.Data;
using System.Windows.Forms;

using CapaControlador_BtnBusqueda;

namespace CapaVista_BtnBusqueda
{
    public partial class ReporteadorUcBusqueda
        : UserControl
    {
        private readonly ClsModeloBtnBusqueda
            _Controlador;

        public TextBox TxtNombreReporte
        {
            get;
            set;
        }

        public DateTimePicker DtpFechaReporte
        {
            get;
            set;
        }

        public CheckBox ChkNombreReporte
        {
            get;
            set;
        }

        public CheckBox ChkFechaReporte
        {
            get;
            set;
        }

        public DataGridView DgvReportes
        {
            get;
            set;
        }

        public ReporteadorUcBusqueda()
        {
            InitializeComponent();

            _Controlador =
                new ClsModeloBtnBusqueda();

            ReporteadorBtnBusqueda.Click +=
                ReporteadorMetBtnBusquedaClick;
        }

        private void ReporteadorMetBtnBusquedaClick(
            object Sender,
            EventArgs Evento)
        {
            ReporteadorMetEjecutarBusqueda();
        }

        public void ReporteadorMetEjecutarBusqueda()
        {
            try
            {
                string NombreReporte =
                    string.Empty;

                DateTime? FechaReporte =
                    null;

                bool BuscarPorNombre =
                    ChkNombreReporte != null &&
                    ChkNombreReporte.Checked;

                bool BuscarPorFecha =
                    ChkFechaReporte != null &&
                    ChkFechaReporte.Checked;

                if (BuscarPorNombre &&
                    TxtNombreReporte != null)
                {
                    NombreReporte =
                        TxtNombreReporte.Text.Trim();
                }

                if (BuscarPorFecha &&
                    DtpFechaReporte != null)
                {
                    FechaReporte =
                        DtpFechaReporte.Value.Date;
                }

                DataTable Resultados =
                    _Controlador
                    .ReporteadorMetBuscarReportes(
                        NombreReporte,
                        FechaReporte,
                        BuscarPorNombre,
                        BuscarPorFecha);

                if (DgvReportes != null)
                {
                    DgvReportes.DataSource =
                        Resultados;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudieron buscar los reportes.",
                    "Ocurrió un error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}