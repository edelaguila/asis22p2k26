using CapaControlador_Seguridad;
using Microsoft.Reporting.WinForms;
using CapaControlador_Seguridad.Modelos_de_controladores;
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
 * ==================================================================
 * Área : Seguridad
 * Autor : Carlos David Calderón Ramirez
 * Carné : 9959-23-848
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 * Aqui se realiza la vista del reporte para ser llamado en el form
 * y se pueda visualizar 
 * ===================================================================
*/


namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteMantenimientoEmpleado : Form
    {
        private ClsModeloEmpleado _Empleado = new ClsModeloEmpleado();
        public FrmReporteMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmReporteMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DsMantenimientoEmpleado", _Empleado.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteMantenimientoEmpleado.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
