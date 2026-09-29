/*
 * ===================================================================
 * Área : Seguridad
 * Autor : Victor Josue Samayoa Ortiz
 * Carné : 0901-23-1494
 * Fecha : 23/09/2026
 * ===================================================================
 * Propósito :
 *  El formulario de Reporte de la bitácora del módulo de Seguridad
 *  obtiene el listado de las acciones registradas mediante el 
 *  modelo de controlador y las vincula al ReportViewer como fuente de
 *  datos del reporte RDLC embebido RpReporteBitacora.
 * ===================================================================
*/

using CapaControlador_Seguridad;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReporteBitacora : Form
    {
        private ClsModeloBitacora controladorBitacora = new ClsModeloBitacora();
        private List<ClsModeloBitacora> _datosReporte;

        public FrmReporteBitacora()
        {
            InitializeComponent();
        }

        public FrmReporteBitacora(List<ClsModeloBitacora> datos) : this()
        {
            _datosReporte = datos;
        }

        private void FrmReporteBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                var lista = _datosReporte ?? controladorBitacora.SeguridadMetObtenerTodas();
                if (lista == null)
                {
                    lista = new List<ClsModeloBitacora>();
                }

                reportViewer1.LocalReport.DataSources.Clear();

                Assembly ensamblado = typeof(FrmReporteBitacora).Assembly;
                string nombreRecurso = ensamblado.GetManifestResourceNames()
                    .FirstOrDefault(r => r.EndsWith("RpReporteBitacora.rdlc", StringComparison.OrdinalIgnoreCase));

                Stream streamReporte = null;
                if (!string.IsNullOrEmpty(nombreRecurso))
                {
                    streamReporte = ensamblado.GetManifestResourceStream(nombreRecurso);
                }

                if (streamReporte != null)
                {
                    using (streamReporte)
                    {
                        reportViewer1.LocalReport.LoadReportDefinition(streamReporte);
                    }
                }
                else
                {
                    string rutaArchivo = BuscarRutaReporte("RpReporteBitacora.rdlc");
                    if (!string.IsNullOrEmpty(rutaArchivo) && File.Exists(rutaArchivo))
                    {
                        using (var fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            reportViewer1.LocalReport.LoadReportDefinition(fs);
                        }
                    }
                    else
                    {
                        reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Seguridad.Reportes.RpReporteBitacora.rdlc";
                    }
                }

                ReportDataSource reportDataSource = new ReportDataSource("RpReporteBitacora", lista);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuscarRutaReporte(string nombreArchivo)
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            for (int i = 0; i < 8 && !string.IsNullOrEmpty(dir); i++)
            {
                string ruta = Path.Combine(dir, "Reportes", nombreArchivo);
                if (File.Exists(ruta)) return ruta;

                ruta = Path.Combine(dir, "Seguridad", "CapaVista_Seguridad", "Reportes", nombreArchivo);
                if (File.Exists(ruta)) return ruta;

                ruta = Path.Combine(dir, "codigo", "componentes", "seguridad", "Seguridad", "CapaVista_Seguridad", "Reportes", nombreArchivo);
                if (File.Exists(ruta)) return ruta;

                DirectoryInfo parent = Directory.GetParent(dir);
                dir = parent != null ? parent.FullName : null;
            }
            return null;
        }
    }
}
