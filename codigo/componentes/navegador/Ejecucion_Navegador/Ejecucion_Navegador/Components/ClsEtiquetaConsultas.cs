using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Components
{
    public class ClsEtiquetaConsultas : Label
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

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
    }
}