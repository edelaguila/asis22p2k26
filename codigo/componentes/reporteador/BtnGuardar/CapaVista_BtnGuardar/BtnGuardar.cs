using System;
using System.Windows.Forms;

namespace CapaVista_BtnGuardar
{
    public partial class BtnGuardar : UserControl
    {
  
        // CONTROLES DEL FORMULARIO PRINCIPAL
 
        public TextBox TxtNombreReporte { get; set; }

        public TextBox TxtRutaReporte { get; set; }

        // CONSTRUCTOR

        public BtnGuardar()
        {
            InitializeComponent();

            // El botón interno solamente dispara el evento Click
            btnAccionGuardar.Click += BtnAccionGuardar_Click;
        }

        // CLICK DEL BOTÓN INTERNO

        private void BtnAccionGuardar_Click(object sender, EventArgs e)
        {
           
            OnClick(EventArgs.Empty);
        }
    }
}