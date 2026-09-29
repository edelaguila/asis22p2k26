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

        // Abre el explorador de archivos y permite
        // seleccionar únicamente archivos PDF.
        private void ReporteadorMetSeleccionarArchivo(
            object Sender,
            EventArgs E)
        {
            using (
                OpenFileDialog
                ReporteadorOfdSeleccionarArchivo =
                    new OpenFileDialog())
            {
                // Título mostrado en el explorador.
                ReporteadorOfdSeleccionarArchivo.Title =
                    "Seleccionar reporte en PDF";

                // Filtro para mostrar únicamente archivos PDF.
                ReporteadorOfdSeleccionarArchivo.Filter =
                    "Archivos PDF (*.pdf)|*.pdf";

                // Obliga a seleccionar un archivo existente.
                ReporteadorOfdSeleccionarArchivo
                    .CheckFileExists = true;

                // Solo permite seleccionar un archivo.
                ReporteadorOfdSeleccionarArchivo
                    .Multiselect = false;

                // Abre el explorador de archivos.
                if (
                    ReporteadorOfdSeleccionarArchivo
                    .ShowDialog()
                    == DialogResult.OK)
                {
                    string RutaReporte =
                        ReporteadorOfdSeleccionarArchivo
                        .FileName;

                    // Valida la ruta mediante el controlador.
                    bool Resultado =
                        _Controlador
                        .ReporteadorMetValidarRuta(
                            RutaReporte,
                            out string Mensaje);

                    if (Resultado)
                    {
                        // Coloca la ruta seleccionada
                        // en el TextBox del formulario.
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

                    // Muestra el mensaje de validación
                    // cuando la ruta no es válida.
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