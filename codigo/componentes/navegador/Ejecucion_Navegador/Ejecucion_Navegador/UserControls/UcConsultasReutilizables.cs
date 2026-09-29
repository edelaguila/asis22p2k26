using CapaVista_Consultas.Components;
using System;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcConsultasReutilizables : ClsControlUsuarioConsultas
    {
        public UcConsultasReutilizables()
        {
            InitializeComponent();
        }
        private void ConsultasMetBtnIngresar(object sender, EventArgs e)
        {
            FrmMantenimientoConsultas FormularioMantenimientoConsultas = new FrmMantenimientoConsultas();
            FormularioMantenimientoConsultas.Show();
        }
    }
}
