using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Components
{
    public class ClsBotonRadioConsultas : RadioButton
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsBotonRadioConsultas()
        {
            Font = new Font(
                "Tahoma",
                9.5F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            ForeColor = _ColorTexto;
            BackColor = Color.Transparent;
            AutoSize = true;
            Cursor = Cursors.Hand;
            UseVisualStyleBackColor = true;
            Margin = new Padding(3);
        }
    }
}