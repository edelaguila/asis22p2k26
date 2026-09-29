using System;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasComplejas : Components.ClsBaseTerminus
    {
        public FrmConsultasComplejas()
        {
            InitializeComponent();
        }

        private void ConsultasMetBtnSalir(object sender, EventArgs e)
        {
            FrmConsultasSimples FormularioConsultasSimples = new FrmConsultasSimples();
            FormularioConsultasSimples.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            FormularioConsultasSimples.Show();
        }
    }
}