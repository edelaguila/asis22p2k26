using CapaControlador_Seguridad;
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

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteProducto : Form
    {
        private ClsModeloProducto _Producto = new ClsModeloProducto();
        public FrmReporteProducto()
        {
            InitializeComponent();
        }

        private void FrmReporteProducto_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSourceProducto = new ReportDataSource(
        "DataSet1",
        _Producto.SeguridadMetObtenerProductosReporte());

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "CapaVista_Seguridad.Reportes.RpReporteMantenimientoUsuario.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceProducto);
            this.reportViewer1.RefreshReport();

        }
    }
}
