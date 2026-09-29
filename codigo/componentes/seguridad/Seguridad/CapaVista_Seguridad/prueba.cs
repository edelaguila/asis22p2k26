using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblreporte", 4, 5);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmReportes.pruebantesparcial reporte = new frmReportes.pruebantesparcial();
            reporte.Show();
        }
    }
}
