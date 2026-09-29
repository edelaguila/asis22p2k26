using CapaVista_Consultas;
using CapaVista_Componentes;

using System;

namespace Ejecucion_Consultas
{
    // Inicio del código de Diego Fernando Santizo Samayoa 0901-22-15950 el 21/09/2026
    public partial class FrmEjecucion : ClsBaseTerminus
    {
        public FrmEjecucion()
        {
            InitializeComponent();
        }

        private void ConsultasMetBtnConsultarClick(object Sender, EventArgs Evento)
        {
            using (FrmConsultasSimples Formulario = new FrmConsultasSimples("tblConsulta", "Pk_Consulta"))
            {
                Formulario.ShowDialog();

                if (Formulario.SeleccionRealizada)
                {
                    ConsultasTxtId.Text = Formulario.CampoSeleccionado;
                }
            }
        }
        // Fin del código de Diego Fernando Santizo Samayoa 0901-22-15950 el 21/09/2026

    }
}