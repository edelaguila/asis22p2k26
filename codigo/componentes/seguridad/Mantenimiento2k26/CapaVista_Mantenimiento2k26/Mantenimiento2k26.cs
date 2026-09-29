using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26
{
    public partial class Mantenimiento2k26 : Form
    {
        public Mantenimiento2k26()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tbltipopuesto", 4, 5);
        }
    }
}
