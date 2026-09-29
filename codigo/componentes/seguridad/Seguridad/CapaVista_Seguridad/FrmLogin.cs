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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }
        private GraphicsPath SeguridadMetObtenerRectanguloRedondeado(Rectangle Limites, int Radio)
        {
            GraphicsPath RutaGrafica = new GraphicsPath();
            int Diametro = Radio * 2;
            RutaGrafica.AddArc(Limites.X, Limites.Y, Diametro, Diametro, 180, 90);
            RutaGrafica.AddArc(Limites.Right - Diametro, Limites.Y, Diametro, Diametro, 270, 90);
            RutaGrafica.AddArc(Limites.Right - Diametro, Limites.Bottom - Diametro, Diametro, Diametro, 0, 90);
            RutaGrafica.AddArc(Limites.X, Limites.Bottom - Diametro, Diametro, Diametro, 90, 90);
            RutaGrafica.CloseFigure();
            return RutaGrafica;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SeguridadPnlInterfazLogin.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(SeguridadPnlInterfazLogin.ClientRectangle, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var modelo = new ClsModeloUsuario();
                bool acceso = modelo.SeguridadMetIniciarSesion(SeguridadTxtUsuario.Text, SeguridadTxtContraseña.Text);

                if (acceso)
                {
                    ClsSesionSeguridad.SeguridadMetIniciarSesion(
                        idUsuario: modelo.IdUsuario,
                        nombreUsuario: modelo.NombreUsuario,
                        nombreEmpleado: modelo.NombreEmpleado,
                        roles: modelo.Roles
                    );

                    this.Hide();
                    var frmPrincipal = new FrmSplash();
                    frmPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SeguridadTxtContraseña.Clear();
                    SeguridadTxtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperacion Recuperacion = new FrmRecuperacion();

            this.Hide();

            Recuperacion.ShowDialog();

            this.Show();
        }
    }
}