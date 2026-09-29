using CapaVista_Consultas.Components;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcCondicionesOrdenamientoAgrupacion : ClsControlUsuarioConsultas
    {
        public UcCondicionesOrdenamientoAgrupacion()
        {
            InitializeComponent();
            ConsultasMetCargarDatosIniciales();
        }

        private void ConsultasMetCargarDatosIniciales()
        {
            ConsultasCboOperador.Items.Clear();

            ConsultasCboOperador.Items.AddRange(new object[]
            {
                "=",
                ">",
                "<",
                ">=",
                "<=",
                "Contiene",
                "Comienza con",
                "Termina con"
            });
            ConsultasRdoAscendente.Checked = true;
        }
    }
}
