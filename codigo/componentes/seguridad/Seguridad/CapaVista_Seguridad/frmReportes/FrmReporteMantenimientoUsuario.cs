/*
 * ===================================================================
 * Área : Seguridad
 * Autor : Victor Omar Gomez Carrascosa
 * Carné : 0901-23-1494
 * Fecha : 23/09/2026
 * ===================================================================
 * Propósito :
 *  El formulario de Reporte del módulo de Mantenimiento de Usuario
 *  obtiene el listado de las acciones registradas mediante el 
 *  modelo de controlador y las vincula al ReportViewer como fuente de
 *  datos del reporte RDLC embebido RpReporteMantenimientoUsuario.
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
    public partial class FrmReporteMantenimientoUsuario : Form
    {
        private ClsModeloUsuario Usuario = new ClsModeloUsuario();
        public FrmReporteMantenimientoUsuario()
        {
            InitializeComponent();
        }

        private void FrmReporteUsuario_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSourceUsuario = new ReportDataSource("DsMantenimientoUsuario", Usuario.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteMantenimientoUsuario.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSourceUsuario);
            this.reportViewer1.RefreshReport();
          
        }
    }
}
