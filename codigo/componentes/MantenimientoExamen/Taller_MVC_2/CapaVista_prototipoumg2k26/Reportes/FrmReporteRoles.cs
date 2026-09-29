using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_prototipoumg2k26;

namespace CapaVista_prototipoumg2k26.Reportes
{ 
    public partial class FrmReporteRoles : Form
    {
        private readonly ModeloEmpleado rol = new ModeloEmpleado();

        public FrmReporteRoles()
        {
            InitializeComponent();
        }

        private void FrmReporteRoles_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDataSource reportDataSource = new ReportDataSource("DatosRoles", rol.GetAll());

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_prototipoumg2k26.Reportes.ReporteRoles.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible generar el reporte de roles.\n\n" + ex.Message,
                    "Reporte de roles",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
