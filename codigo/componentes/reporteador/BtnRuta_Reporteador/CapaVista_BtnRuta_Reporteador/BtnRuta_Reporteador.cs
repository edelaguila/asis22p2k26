/* 
            VELVETH SARAÌ CHAVEZ MEJÌA
 */

using System;
using System.Windows.Forms;
using CapaControlador_BtnRuta_Reporteador;

namespace CapaVista_BtnRuta_Reporteador
{
    public partial class ReporteadorUcRutaReporte
        : UserControl
    {
        // Controlador encargado de validar la ruta seleccionada.
        private readonly ClsControladorBtnRutaReporteador
            _Controlador;

        // Campo de texto del formulario donde se colocará
        // la ruta seleccionada.
        public TextBox CampoTextoRuta
        {
            get;
            set;
        }

        public ReporteadorUcRutaReporte()
        {
            InitializeComponent();

            _Controlador =
                new ClsControladorBtnRutaReporteador();

            // Conecta el botón del UserControl
            // con el método de selección de archivos.
            ReporteadorBtnRutaReporte.Click +=
                ReporteadorMetSeleccionarArchivo;
        }

        // =========================================================
        // SELECCIONAR ARCHIVO RDLC
        // =========================================================

        private void ReporteadorMetSeleccionarArchivo(
            object Sender,
            EventArgs E)
        {
            using (
                OpenFileDialog
                ReporteadorOfdSeleccionarArchivo =
                    new OpenFileDialog())
            {
                // -------------------------------------------------
                // Título del explorador.
                // -------------------------------------------------

                ReporteadorOfdSeleccionarArchivo.Title =
                    "Seleccionar reporte RDLC";

                // -------------------------------------------------
                // SOLO permite archivos RDLC.
                // -------------------------------------------------

                ReporteadorOfdSeleccionarArchivo.Filter =
                    "Archivo RDLC (*.rdlc)|*.rdlc";

                // -------------------------------------------------
                // Mostrar únicamente archivos existentes.
                // -------------------------------------------------

                ReporteadorOfdSeleccionarArchivo
                    .CheckFileExists = true;

                ReporteadorOfdSeleccionarArchivo
                    .CheckPathExists = true;

                // -------------------------------------------------
                // Solo permite seleccionar un archivo.
                // -------------------------------------------------

                ReporteadorOfdSeleccionarArchivo
                    .Multiselect = false;

                // -------------------------------------------------
                // Mostrar el filtro RDLC como primera opción.
                // -------------------------------------------------

                ReporteadorOfdSeleccionarArchivo
                    .FilterIndex = 1;

                // -------------------------------------------------
                // Abrir explorador.
                // -------------------------------------------------

                if (
                    ReporteadorOfdSeleccionarArchivo
                    .ShowDialog()
                    == DialogResult.OK)
                {
                    string RutaReporte =
                        ReporteadorOfdSeleccionarArchivo
                        .FileName;

                    // -------------------------------------------------
                    // Validación adicional de extensión.
                    // -------------------------------------------------

                    if (!RutaReporte.EndsWith(
                        ".rdlc",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show(
                            "Solo se permiten archivos de tipo .rdlc.",
                            "Archivo no válido",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // -------------------------------------------------
                    // Validar la ruta mediante el controlador.
                    // -------------------------------------------------

                    bool Resultado =
                        _Controlador
                        .ReporteadorMetValidarRuta(
                            RutaReporte,
                            out string Mensaje);

                    if (Resultado)
                    {
                        // -------------------------------------------------
                        // Colocar ruta en el TextBox.
                        // -------------------------------------------------

                        if (CampoTextoRuta != null)
                        {
                            CampoTextoRuta.Text =
                                RutaReporte;

                            return;
                        }

                        MessageBox.Show(
                            "No se ha asignado el control " +
                            "de texto para la ruta.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // -------------------------------------------------
                    // Mostrar error de validación.
                    // -------------------------------------------------

                    MessageBox.Show(
                        Mensaje,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}