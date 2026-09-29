/*
    CARLOS EDUARDO CHIN CAAL
 */

using System;
using System.ComponentModel;
using System.Windows.Forms;
using CapaControlador_BtnImprimir_Reporteador;

namespace CapaVista_BtnImprimir_Reporteador
{
    [ToolboxItem(true)]
    [Description(
        "Botón reutilizable para imprimir reportes PDF.")]
    public partial class ReporteadorUcImprimir
        : UserControl
    {
        private readonly ClsModeloBtnImprimir
            _Controlador;

        public string RutaReporte
        {
            get;
            set;
        }

        public ReporteadorUcImprimir()
        {
            InitializeComponent();

            _Controlador =
                new ClsModeloBtnImprimir();

            ReporteadorBtnImprimir.Click +=
                BtnAccionImprimir_Click;
        }

        private void BtnAccionImprimir_Click(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetEjecutarImpresion();
        }

        private void ReporteadorMetEjecutarImpresion()
        {
            try
            {
                bool Resultado =
                    _Controlador
                    .ReporteadorMetEjecutarImpresion(
                        RutaReporte,
                        out string Mensaje);

                if (Resultado)
                {
                    MessageBox.Show(
                        Mensaje,
                        "Imprimir reporte",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show(
                    Mensaje,
                    "Imprimir reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar " +
                    "imprimir el reporte.",
                    "Imprimir reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}