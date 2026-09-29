using System;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    public partial class FrmConsultasSimples : Components.ClsBaseTerminus
    {

        public FrmConsultasSimples()
        {
            InitializeComponent();

        }

        public FrmConsultasSimples(string tabla)
        {
            InitializeComponent();
            ConsultasUcTablaSimple.ConsultasProcActualizarTablaClick(tabla);
        }

        private void ConsultasMetBtnComplejas(object sender, EventArgs e)
        {
            FrmConsultasComplejas FormularioConsultasComplejas = new FrmConsultasComplejas();

            FormularioConsultasComplejas.FormClosed += (s, args) =>
            {
                Application.Exit();
            };

            this.Hide();
            FormularioConsultasComplejas.Show();
        }
    }
}