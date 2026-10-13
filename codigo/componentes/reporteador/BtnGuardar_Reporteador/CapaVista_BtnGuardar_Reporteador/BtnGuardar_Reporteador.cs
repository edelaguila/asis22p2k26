
/* 
    VELVETH SARAI CHAVEZ MEJIA
 */
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace CapaVista_BtnGuardar_Reporteador
{
    [ToolboxItem(true)]
    [Description(
        "Botón reutilizable para guardar registros del Reporteador.")]
    public partial class ReporteadorUcGuardar :
        UserControl
    {
        [Category("Reporteador")]
        [DefaultValue("GuardarReporte")]
        public string MetodoGuardarReporte
        {
            get;
            set;
        } = "GuardarReporte";

        [Category("Reporteador")]
        [DefaultValue(false)]
        public bool NumeroReporteGestionadoPorFormulario
        {
            get;
            set;
        } = false;

        public ReporteadorUcGuardar()
        {
            InitializeComponent();

            ReporteadorMetConectarEvento();
        }

        // ============================================================
        // CONECTAR EVENTO
        // ============================================================

        private void ReporteadorMetConectarEvento()
        {
            ReporteadorBtnGuardar.Click +=
                ReporteadorMetGuardarClick;
        }

        // ============================================================
        // CLICK
        // ============================================================

        private void ReporteadorMetGuardarClick(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetEjecutarGuardar();
        }

        // ============================================================
        // EJECUTAR GUARDADO
        // ============================================================

        private void ReporteadorMetEjecutarGuardar()
        {
            try
            {
                Form Contenedor =
                    FindForm();

                if (Contenedor == null)
                {
                    MessageBox.Show(
                        "No se encontró el formulario principal del Reporteador.",
                        "Guardar reporte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    MetodoGuardarReporte))
                {
                    MessageBox.Show(
                        "No se configuró el método de guardado.",
                        "Guardar reporte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MethodInfo Metodo =
                    Contenedor.GetType().GetMethod(
                        MetodoGuardarReporte,
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.Instance,
                        null,
                        Type.EmptyTypes,
                        null);

                if (Metodo == null)
                {
                    MessageBox.Show(
                        "No se encontró el método de guardado del Reporteador.",
                        "Guardar reporte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Metodo.Invoke(
                    Contenedor,
                    null);
            }
            catch (TargetInvocationException)
            {
                // El FrmReportes ya controla y muestra
                // el mensaje correspondiente.
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar guardar el reporte.",
                    "Guardar reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}