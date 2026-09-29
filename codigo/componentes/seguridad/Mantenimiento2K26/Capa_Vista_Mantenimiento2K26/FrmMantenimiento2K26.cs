using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mantenimiento2K26
{
    public partial class FrmMantenimiento2K26 : Form
    {
        public FrmMantenimiento2K26()
        {
            InitializeComponent();

            navegador1.NavegadorMetConfigurar("tblPeliculas", 4, 5);
        }
    }
}
