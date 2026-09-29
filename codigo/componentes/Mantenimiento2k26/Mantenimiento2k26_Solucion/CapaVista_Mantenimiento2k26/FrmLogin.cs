using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mantenimiento2k26
{
    public partial class FrmLogin : Form
    {
        private readonly TextBox TxtUsuario = new TextBox();
        private readonly TextBox TxtContrasena = new TextBox();
        private readonly Button BtnIngresar = new Button();

        public FrmLogin()
        {
            InitializeComponent();

            this.Text = "Iniciar sesión";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(320, 170);

            this.Controls.Add(new Label { Text = "Usuario", Location = new Point(20, 20), AutoSize = true });
            TxtUsuario.SetBounds(120, 17, 180, 23);
            this.Controls.Add(TxtUsuario);

            this.Controls.Add(new Label { Text = "Contraseña", Location = new Point(20, 60), AutoSize = true });
            TxtContrasena.SetBounds(120, 57, 180, 23);
            TxtContrasena.UseSystemPasswordChar = true;
            this.Controls.Add(TxtContrasena);

            BtnIngresar.Text = "Ingresar";
            BtnIngresar.SetBounds(120, 105, 180, 35);
            BtnIngresar.Click += BtnIngresar_Click;
            this.Controls.Add(BtnIngresar);
            this.AcceptButton = BtnIngresar;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtUsuario.Text) || string.IsNullOrWhiteSpace(TxtContrasena.Text))
                {
                    MessageBox.Show("Por favor ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool credencialesValidas = true;

                if (credencialesValidas)
                {
                    this.Hide();
                    FrmMenu menu = new FrmMenu();
                    menu.FormClosed += (s, args) => this.Close();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtContrasena.Clear();
                    TxtContrasena.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}