using System;
using System.Windows.Forms;

namespace CapaVista_BtnRuta
{
    public partial class BtnRuta : UserControl
    {
        public TextBox CampoTextoRuta { get; set; }

        public BtnRuta()
        {
            InitializeComponent();
        }

        private void BtnRutaReporte_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtro para mostrar ÚNICAMENTE archivos PDF
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFileDialog.Title = "Seleccionar reporte en PDF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (CampoTextoRuta != null)
                    {
                        CampoTextoRuta.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("No se ha asignado el control de texto para la ruta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}