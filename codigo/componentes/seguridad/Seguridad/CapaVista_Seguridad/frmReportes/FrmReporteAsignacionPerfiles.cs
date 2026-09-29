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


 /* ============================================================
 * Área : Seguridad
 * Autor : Daniella Jurado
 * Carné : 0901-23-3679
 * Fecha : 23/09/2026
 * ============================================================
 * Propósito :
 * Esta ventana se encarga de generar y mostrar el reporte de las
 * asignaciones de perfiles a los usuarios del sistema. Obtiene la
 * información de las asignaciones mediante el controlador y la
 * carga en el reporte utilizando el origen de datos
 * correspondiente. También establece el archivo RDLC que define
 * el diseño del reporte y actualiza el visor para mostrar la
 * información al usuario.
 * ============================================================
 */

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteAsignacionPerfiles : Form
    {

        private ClsModeloAsignacionPerfiles AsignacionPerfiles = new ClsModeloAsignacionPerfiles();
        public FrmReporteAsignacionPerfiles()
        {
            InitializeComponent();
        }

        private void FrmReporteAsignacionPerfiles_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DsAsignacionPerfiles", AsignacionPerfiles.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteAsignacionPerfiles.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
