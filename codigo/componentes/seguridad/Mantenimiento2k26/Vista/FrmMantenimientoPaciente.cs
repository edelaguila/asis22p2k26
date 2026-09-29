using System;
using System.Windows.Forms;

namespace Mantenimiento2k26.Vista
{
    public partial class FrmMantenimientoPaciente : Form
    {
        public FrmMantenimientoPaciente()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tbl_paciente", 4, 16);
        }
    }
}
