/*
 * ==============================
 * Área : Seguridad
 * Autor : Byron Alexander Chiquito Paredes
 * Carné : 0901-23-3747
 * Fecha : 24/09/2026
 * ==============================
 * Propósito :
 * Formulario que permite al usuario recuperar el acceso
 * a su cuenta cuando olvida su contraseña, solicitando un
 * código de verificación por correo electrónico y
 * permitiendo definir una nueva contraseña en dos pasos
 * dentro de la misma ventana
 * ==============================
 */

using CapaControlador_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmRecuperacion : Form
    {
        public FrmRecuperacion()
        {
            InitializeComponent();
            SeguridadMetIrAPasoUno();

            SeguridadBtnEnviarCodigo.Click += SeguridadBtnEnviarCodigo_Click;
            SeguridadBtnCambiarContrasena.Click += SeguridadBtnCambiarContrasena_Click;
            SeguridadChkVerContrasena.CheckedChanged += SeguridadChkVerContrasena_CheckedChanged;  
        }

        private void SeguridadMetIrAPasoUno()
        {
            SeguridadPnlEnviarCodigo.Enabled = true;
            SeguridadPnlVerificarCambiar.Enabled = false;
        }

        private void SeguridadMetIrAPasoDos()
        {
            SeguridadPnlEnviarCodigo.Enabled = false;
            SeguridadPnlVerificarCambiar.Enabled = true;
        }

        private void SeguridadBtnEnviarCodigo_Click(object sender, EventArgs e)
        {
            var Modelo = new ClsModeloSolicitarCodigo
            {
                NombreUsuario = SeguridadTxtUsuario.Text,
                CorreoUsuario = SeguridadTxtCorreo.Text
            };

            bool Valido = new ClsValidacionDatos(Modelo).SeguridadMetValidar();
            if (!Valido) return;

            try
            {
                string Resultado = Modelo.SeguridadMetSolicitarCodigo();
                MessageBox.Show(Resultado);
                if (Resultado == "Codigo enviado")
                {
                    SeguridadMetIrAPasoDos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnCambiarContrasena_Click(object sender, EventArgs e)
        {
            var Modelo = new ClsModeloCambiarContrasena
            {
                CodigoRecuperacion = SeguridadTxtCodigoVerificacion.Text,
                NuevaContrasena = SeguridadTxtNuevaContrasena.Text,
                ConfirmarContrasena = SeguridadTxtConfirmarContrasena.Text
            };

            bool Valido = new ClsValidacionDatos(Modelo).SeguridadMetValidar();
            if (!Valido) return;

            try
            {
                string Resultado = Modelo.SeguridadMetCambiarContrasena();
                MessageBox.Show(Resultado);
                if (Resultado == "Contrasena actualizada")
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void SeguridadChkVerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            char Caracter = SeguridadChkVerContrasena.Checked ? '\0' : '●';
            SeguridadTxtNuevaContrasena.PasswordChar = Caracter;
            SeguridadTxtConfirmarContrasena.PasswordChar = Caracter;

        }

        private void SeguridadLnkAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "Recuperacion_Seguridad.html");
        }
    }
}
