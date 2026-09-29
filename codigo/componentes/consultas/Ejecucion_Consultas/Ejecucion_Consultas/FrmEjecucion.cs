using CapaVista_Consultas;
using CapaVista_Consultas.Componentes;
using System;

namespace Ejecucion_Consultas
{
    public partial class FrmEjecucion :
        ClsBaseTerminus
    {
        public FrmEjecucion()
        {
            InitializeComponent();
        }

        private void ConsultasMetBtnConsultarClick(
            object sender,
            EventArgs e)
        {
            using (FrmConsultasSimples FormularioConsultasSimples =
                new FrmConsultasSimples(
                    "tblConsulta",
                    "Pk_Consulta"))
            {
                FormularioConsultasSimples.ShowDialog();

                if (FormularioConsultasSimples.SeleccionRealizada)
                {
                    ConsultasTxtId.Text =
                        FormularioConsultasSimples.IdSeleccionado;
                }
            }
        }
    }
}