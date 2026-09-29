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
    public partial class Antes : Form
    {
        public Antes()
        {            
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblreporte", 4, 5);
        }

        private void Antes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
