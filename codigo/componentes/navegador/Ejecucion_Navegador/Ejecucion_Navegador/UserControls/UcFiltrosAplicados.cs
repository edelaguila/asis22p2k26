using CapaVista_Consultas.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Consultas.UserControls
{
    public partial class UcFiltrosAplicados : ClsControlUsuarioConsultas
    {
        public UcFiltrosAplicados()
        {
            InitializeComponent();
        }

        private void ConsultasBtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
