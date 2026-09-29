using CapaVista_Consultas.Components;
using System.ComponentModel;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcAgruparOrdenar : ClsControlUsuarioConsultas
    {
        public UcAgruparOrdenar()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                ConsultasMetCargarDatosIniciales();
            }
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
        }
    }
}