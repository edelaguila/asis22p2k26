/*
 * ==================================================================
 * Área : Seguridad - Mantenimiento2k26
 * Autor : Byron Alexander
 * Carné : 0901-23-3747
 * Fecha : 29/09/2026
 * ==================================================================
 * Propósito :
 *  Formulario del mantenimiento de departamentos. Usa el control
 *  Navegador (CRUD y bitácora) configurado con los datos del
 *  Controlador. El botón Reporte muestra/oculta el reporte
 *  (ReportViewer + RpReporteDepartamento.rdlc) dentro de este mismo
 *  formulario y Ayuda abre Mantenimiento2k26Ayudas.chm de la carpeta
 *  ayuda.
 * ===================================================================
*/

using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaControlador_Mantenimiento2k26;

namespace CapaVista_Mantenimiento2k26
{
    public partial class FrmDepartamento : Form
    {
        private readonly ClsControladorDepartamento _Controlador = new ClsControladorDepartamento();

        // Ruta del .chm dentro del repositorio (carpeta ayuda).
        private const string _RutaAyuda =
            @"ayuda\componentes\mantenimiento2k26\Mantenimiento2k26Ayudas\Mantenimiento2k26Ayudas.chm";

        public FrmDepartamento()
        {
            InitializeComponent();

            Mantenimiento2k26Navegador.NavegadorMetConfigurar(
                _Controlador.Mantenimiento2k26FuncTabla(),
                _Controlador.Mantenimiento2k26FuncIdModulo(),
                _Controlador.Mantenimiento2k26FuncIdAplicacion());

            Mantenimiento2k26Navegador.NavegadorAccionSolicitada += Mantenimiento2k26MetAccion;
        }

        // La Ayuda la resuelve este formulario (el Navegador ya no abre la suya).
        private void Mantenimiento2k26MetAccion(string Accion)
        {
            if (Accion == "AYUDA")
            {
                Mantenimiento2k26MetMostrarAyuda();
            }
        }

        // Botón Reporte: muestra el reporte dentro del formulario; si ya está visible, lo oculta.
        private void Mantenimiento2k26BtnReporte_Click(object sender, System.EventArgs e)
        {
            if (Mantenimiento2k26RvReporte.Visible)
            {
                Mantenimiento2k26RvReporte.Visible = false;
                Mantenimiento2k26BtnReporte.Text = "Reporte";
                return;
            }

            ReportDataSource Fuente = new ReportDataSource(
                "RpReporteDepartamento", _Controlador.Mantenimiento2k26FuncObtenerReporte());

            Mantenimiento2k26RvReporte.LocalReport.ReportEmbeddedResource =
                "CapaVista_Mantenimiento2k26.Reportes.RpReporteDepartamento.rdlc";
            Mantenimiento2k26RvReporte.LocalReport.DataSources.Clear();
            Mantenimiento2k26RvReporte.LocalReport.DataSources.Add(Fuente);
            Mantenimiento2k26RvReporte.RefreshReport();

            Mantenimiento2k26RvReporte.Visible = true;
            Mantenimiento2k26RvReporte.BringToFront();
            Mantenimiento2k26BtnReporte.Text = "Ocultar reporte";
        }

        // Busca la carpeta ayuda subiendo desde donde corre el .exe (bin\Debug) hasta la raíz del repositorio.
        private void Mantenimiento2k26MetMostrarAyuda()
        {
            DirectoryInfo Carpeta = new DirectoryInfo(Application.StartupPath);

            while (Carpeta != null)
            {
                string Ruta = Path.Combine(Carpeta.FullName, _RutaAyuda);

                if (File.Exists(Ruta))
                {
                    Help.ShowHelp(this, Ruta, "Departamentos_Mantenimiento2k26.html");
                    return;
                }

                Carpeta = Carpeta.Parent;
            }

            MessageBox.Show("No se encontró el archivo de ayuda:\n" + _RutaAyuda,
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
