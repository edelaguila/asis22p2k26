/*
 * ===================================================================
 * Área : Seguridad
 * Autor : Cristian David Sipac Ispache
 * Carné : 0901-23-1494
 * Fecha : 23/09/2026
 * ===================================================================
 * Propósito :
 *  El formulario de Reporte del módulo de Mantenimiento de Perfiles
 *  obtiene el listado de las acciones registradas mediante el 
 *  modelo de controlador y las vincula al ReportViewer como fuente de
 *  datos del reporte RDLC embebido RpReporteMantenimientoPerfil.
 * ===================================================================
*/

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
    public partial class FrmReporteMantenimientoPerfiles : Form
    {
        private ClsModeloRoles roles = new ClsModeloRoles();
        public FrmReporteMantenimientoPerfiles()
        {
            InitializeComponent();
        }

        private void FrmReporteMantenimientoPerfiles_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DsMantenimientoPerfiles", roles.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteMantenimientoPerfil.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
