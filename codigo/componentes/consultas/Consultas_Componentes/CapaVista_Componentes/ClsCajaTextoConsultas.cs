using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"

    // Cuadro de texto con estilo para Consultas y límite de caracteres configurable.
    public class ClsCajaTextoConsultas : TextBox
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsCajaTextoConsultas()
        {
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            BackColor = Color.White;
            ForeColor = _ColorTexto;
            BorderStyle = BorderStyle.FixedSingle;
            ShortcutsEnabled = true;
            Margin = new Padding(3);
            MaxLength = 50;
        }

        public void EstablecerLimiteCaracteres(int limite)
        {
            if (limite < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(limite), "El límite no puede ser negativo.");

            MaxLength = limite;
        }

        protected override Size DefaultSize => new Size(200, 27);

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            base.OnReadOnlyChanged(e);
            BackColor = ReadOnly ? Color.Gainsboro : Color.White;
        }
    }

    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "26/09/26"
}