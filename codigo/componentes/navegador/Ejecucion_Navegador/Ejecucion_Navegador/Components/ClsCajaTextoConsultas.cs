using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Components
{
    public class ClsCajaTextoConsultas : TextBox
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsCajaTextoConsultas()
        {
            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            BackColor = Color.White;
            ForeColor = _ColorTexto;
            BorderStyle = BorderStyle.FixedSingle;
            ShortcutsEnabled = true;
            Margin = new Padding(3);
        }

        protected override Size DefaultSize =>
            new Size(200, 27);

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            base.OnReadOnlyChanged(e);

            BackColor = ReadOnly
                ? Color.Gainsboro
                : Color.White;
        }
    }
}