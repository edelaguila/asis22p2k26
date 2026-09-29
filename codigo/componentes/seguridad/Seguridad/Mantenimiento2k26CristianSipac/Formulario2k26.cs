using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento2k26CristianSipac
{
    public partial class Formulario2k26 : Form
    {
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 14;
        public Formulario2k26()
        {
            InitializeComponent();
            NavegadorExamen.NavegadorMetConfigurar("tbl_paciente", ID_MODULO, ID_APLICACION);
        }
    }
}
