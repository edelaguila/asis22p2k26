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

/*
 * ============================================================
 * Área         : Seguridad
 * Autor        : Evelyn Sofía Andrade Luna
 * Carné        : 9959-23-1224
 * Fecha        : 24/09/2026
 * ============================================================
 * Propósito    :
 *   Formulario de reporte del módulo de Asignación de
 *   Aplicación a Usuario. Carga y muestra el reporte RDLC
 *   con el listado completo de asignaciones de aplicaciones
 *   a usuarios por módulo, incluyendo los permisos otorgados
 *   a cada uno.
 * ============================================================
 */

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteAsignacionAplicacionUsuario : Form
    {
        private ClsModeloAsigAppUsuario AsigAppUsu = new ClsModeloAsigAppUsuario();
        public FrmReporteAsignacionAplicacionUsuario()
        {
            InitializeComponent();
        }

        private void FrmReporteAsignacionAplicacionUsuario_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("ReporteAsignacionAppUsu", AsigAppUsu.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteAsignacionAplicacionUsuario.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
