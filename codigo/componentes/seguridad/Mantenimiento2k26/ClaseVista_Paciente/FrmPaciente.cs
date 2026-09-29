using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseVista_Paciente
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tbl_paciente", 4, 5);


        }
    }
}
