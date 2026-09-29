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
    public partial class FrmSplash : Form
    {
        [System.Runtime.InteropServices.DllImport("uxtheme.dll", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        private int _Progreso;

        public FrmSplash()
        {
            InitializeComponent();
            SeguridadMetAplicarColorBarra();
            SeguridadMetIniciarCarga();
        }

        private void SeguridadMetAplicarColorBarra()
        {
            SetWindowTheme(SeguridadPgbCarga.Handle, "", "");
            SeguridadPgbCarga.ForeColor = ColorTranslator.FromHtml("#006D77");
        }

        private void SeguridadMetIniciarCarga()
        {
            _Progreso = 0;
            _TimerCarga.Start();
        }

        private void _TimerCarga_Tick(object sender, EventArgs e)
        {
            _Progreso += 1;
            if (_Progreso < 100) SeguridadPgbCarga.Value = _Progreso + 1;
            SeguridadPgbCarga.Value = _Progreso;
            SeguridadLblPorcentaje.Text = _Progreso + "%";

            if (_Progreso >= 100)
            {
                _TimerCarga.Stop();
                this.Hide();
                FrmMDISeguridad Principal = new FrmMDISeguridad();
                Principal.ShowDialog();
                this.Close();
            }
        }
    }
}