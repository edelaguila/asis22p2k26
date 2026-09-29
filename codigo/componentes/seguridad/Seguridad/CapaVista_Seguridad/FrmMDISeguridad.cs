using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVista_Seguridad
{
    public partial class FrmMDISeguridad : Form
    {
        public FrmMDISeguridad()
        {
            InitializeComponent();
            this.Load += FrmMDISeguridad_Load;
        }

        private void FrmMDISeguridad_Load(object sender, EventArgs e)
        {
            SeguridadMetActualizarInfoUsuario();
            SeguridadMetCargarKPIs();
        }

        private void SeguridadMetActualizarInfoUsuario()
        {
            SeguridadLblUsuario.Text = $"Usuario: {ClsSesionSeguridad.NombreEmpleado}";
            SeguridadLblUsuarioRol.Text = $"Rol: {ClsSesionSeguridad.SeguridadMetRolesComoTexto()}";
        }

        private void SeguridadMetCargarKPIs()
        {
            try
            {
                var Dashboard = new ClsModeloDashboard();
                SeguridadLblKPIResp1.Text = Dashboard.SeguridadMetUsuarios().ToString();
                SeguridadLblKPIResp2.Text = Dashboard.SeguridadMetAplicaciones().ToString();
                SeguridadLblKPIResp3.Text = Dashboard.SeguridadMetPerfiles().ToString();
                SeguridadLblKPIResp4.Text = Dashboard.SeguridadMetModulos().ToString();
                SeguridadLblKPIResp5.Text = Dashboard.SeguridadMetBitacora().ToString();
                SeguridadLblKPIResp6.Text = Dashboard.SeguridadMetAsignaciones().ToString();
            }
            catch { }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int Radio = 20;
            SeguridadPnlDashboard.Region = new Region(SeguridadMetRedondearEsquinas(SeguridadPnlDashboard.ClientRectangle, Radio));
        }

        private GraphicsPath SeguridadMetRedondearEsquinas(Rectangle Rectangulo, int Radio)
        {
            GraphicsPath RutaGrafica = new GraphicsPath();
            int Diametro = Radio * 2;

            RutaGrafica.AddArc(Rectangulo.X, Rectangulo.Y, Diametro, Diametro, 180, 90);
            RutaGrafica.AddArc(Rectangulo.Right - Diametro, Rectangulo.Y, Diametro, Diametro, 270, 90);
            RutaGrafica.AddArc(Rectangulo.Right - Diametro, Rectangulo.Bottom - Diametro, Diametro, Diametro, 0, 90);
            RutaGrafica.AddArc(Rectangulo.X, Rectangulo.Bottom - Diametro, Diametro, Diametro, 90, 90);
            RutaGrafica.CloseFigure();

            return RutaGrafica;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmAsignacionAppPerf Perfil = new FrmAsignacionAppPerf();
            Perfil.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBitacora Bitacora = new FrmBitacora();
            Bitacora.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmAsignacionAplicacionUsuario AsigAplicacionUsuario = new FrmAsignacionAplicacionUsuario();
            AsigAplicacionUsuario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAsignacionPerfiles AsignacionPerfiles = new FrmAsignacionPerfiles();
            AsignacionPerfiles.ShowDialog();
        }

        private void SeguridadBtnPerfiles_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPerfiles MantenimientoPerfiles = new FrmMantenimientoPerfiles();
            MantenimientoPerfiles.ShowDialog();
        }

        private void SeguridadBtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Usuarios = new FrmUsuarios();
            Usuarios.ShowDialog();
        }

        private void SeguridadBtnBurger_Click(object sender, EventArgs e)
        {
            if (SeguridadPnlNavegador.Width == 270)
            {
                SeguridadPnlNavegador.Width = 64;
                SeguridadPnlDashboard.Location = new Point(200, 52);
                SeguridadBtnBurger.Location = new Point(220, 13);
                SeguridadLblUsuario.Location = new Point(285, 19);
                SeguridadLblUsuarioRol.Location = new Point(285, 39);
            }
            else
            {
                SeguridadPnlNavegador.Width = 270;
                SeguridadPnlDashboard.Location = new Point(307, 52);
                SeguridadBtnBurger.Location = new Point(323, 13);
                SeguridadLblUsuario.Location = new Point(390, 19);
                SeguridadLblUsuarioRol.Location = new Point(390, 39);
            }
        }

        private void SeguridadBtnModulos_Click(object sender, EventArgs e)
        {
            FrmModulo Modulo = new FrmModulo();
            Modulo.ShowDialog();
        }

        private void SeguridadBtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmMantenimientoEmpleado Empleados = new FrmMantenimientoEmpleado();
            Empleados.ShowDialog();
        }

        private void SeguridadBtnAplicaciones_Click(object sender, EventArgs e)
        {
            FrmMantenimientoAplicacion Aplicaciones = new FrmMantenimientoAplicacion();
            Aplicaciones.ShowDialog();
        }
    }
}
