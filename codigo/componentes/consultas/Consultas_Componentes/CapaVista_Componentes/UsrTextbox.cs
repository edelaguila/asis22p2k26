using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"
    // Control de texto que muestra un borde y un mensaje cuando existe un error.
    public partial class UsrTextbox : ClsControlUsuarioConsultas
    {
        private static readonly Color _ColorError = Color.Red;

        public UsrTextbox()
        {
            InitializeComponent();
            ConsultasTxtCampo.Clear();
            ConsultasTxtCampo.TextChanged += ConsultasMetTxtCampoTextChanged;

            ConsultasMetLimpiarError();
        }

        public event KeyEventHandler TextoKeyDown
        {
            add { ConsultasTxtCampo.KeyDown += value; }
            remove { ConsultasTxtCampo.KeyDown -= value; }
        }

        private void ConsultasMetTxtCampoTextChanged(object Sender, EventArgs Evento)
        {
            base.Text = ConsultasTxtCampo.Text;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get => ConsultasTxtCampo == null
                ? base.Text
                : ConsultasTxtCampo.Text;

            set
            {
                if (ConsultasTxtCampo == null)
                {
                    base.Text = value;
                    return;
                }

                ConsultasTxtCampo.Text =
                    string.Equals(value, Name, StringComparison.Ordinal)
                        ? string.Empty
                        : value ?? string.Empty;
            }
        }

        [Browsable(true)]
        [DefaultValue(50)]
        public int MaxLength
        {
            get => ConsultasTxtCampo.MaxLength;
            set => ConsultasMetEstablecerLimiteCaracteres(value);
        }

        [Browsable(true)]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => ConsultasTxtCampo.ReadOnly;
            set => ConsultasTxtCampo.ReadOnly = value;
        }

        public void ConsultasMetEstablecerLimiteCaracteres(int Limite)
        {
            ConsultasTxtCampo.EstablecerLimiteCaracteres(Limite);
        }

        public void ConsultasMetMostrarError(string Mensaje)
        {
            if (string.IsNullOrWhiteSpace(Mensaje))
            {
                ConsultasMetLimpiarError();
                return;
            }

            ConsultasTlpCampo.BackColor = _ColorError;

            ConsultasLblError.Text = Mensaje;
            ConsultasLblError.Visible = true;
            Height = 60;
        }

        public void ConsultasMetLimpiarError()
        {
            ConsultasLblError.Text = string.Empty;
            ConsultasLblError.Visible = false;

            ConsultasTlpCampo.BackColor = Color.Transparent;
            Height = 35;
        }

        public void ConsultasMetEnfocarTexto()
        {
            ConsultasTxtCampo.Focus();
        }
    }
    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"
}