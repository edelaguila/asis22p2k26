using System;
using System.Windows.Forms;
using CapaControlador_BtnImprimir;

namespace CapaVista_BtnImprimir
{
    public partial class BtnImprimir : UserControl
    {
        private readonly ClsModeloBtnImprimir controlador;

        public string RutaReporte { get; set; }

        public BtnImprimir()
        {
            InitializeComponent();

            controlador = new ClsModeloBtnImprimir();

            btnAccionImprimir.Click += BtnAccionImprimir_Click;
        }

        private void BtnAccionImprimir_Click(object sender, EventArgs e)
        {
            bool resultado = controlador.EjecutarImpresion(
                RutaReporte,
                out string mensaje
            );

            if (resultado)
            {
                MessageBox.Show(
                    mensaje,
                    "Imprimir reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    mensaje,
                    "Imprimir reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}