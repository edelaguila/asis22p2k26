using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
    public class ClsEtiquetaConsultas : Label
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        private bool _CampoObligatorio;

        [Category("Consultas")]
        [Description("Muestra un asterisco rojo a la derecha del texto.")]
        [DefaultValue(false)]
        public bool CampoObligatorio
        {
            get { return _CampoObligatorio; }
            set
            {
                if (_CampoObligatorio == value) return;

                _CampoObligatorio = value;
                PerformLayout();
                Invalidate();
            }
        }

        public ClsEtiquetaConsultas()
        {
            Font = new Font(
                "Tahoma",
                9.5F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            ForeColor = _ColorTexto;
            BackColor = Color.Transparent;
            AutoSize = true;
            TextAlign = ContentAlignment.MiddleLeft;
            Margin = new Padding(3);
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            Size size = base.GetPreferredSize(proposedSize);

            if (_CampoObligatorio)
            {
                size.Width += TextRenderer.MeasureText(
                    "*", Font, Size.Empty,
                    TextFormatFlags.NoPadding).Width;
            }

            return size;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!_CampoObligatorio || string.IsNullOrEmpty(Text))
                return;

            int anchoTexto = TextRenderer.MeasureText(
                Text, Font, Size.Empty,
                TextFormatFlags.NoPadding).Width;

            Rectangle posicionAsterisco = new Rectangle(
                Padding.Left + anchoTexto,
                0,
                Width - Padding.Left - anchoTexto,
                Height);

            TextRenderer.DrawText(
                e.Graphics,
                "*",
                Font,
                posicionAsterisco,
                Color.Red,
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPadding);
        }
    }
    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
}