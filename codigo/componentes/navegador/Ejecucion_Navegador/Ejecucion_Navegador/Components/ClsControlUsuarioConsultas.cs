using System.Drawing;
using System.Windows.Forms;
namespace CapaVista_Consultas.Components
{
    public class ClsControlUsuarioConsultas : UserControl
    {
        private static readonly Font _FuentePredeterminada =
            new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point);

        protected ClsControlUsuarioConsultas()
        {
            DoubleBuffered = true;

            Font = _FuentePredeterminada;

            BackColor = ColorTranslator.FromHtml("#EDE7DA");

            AutoScaleMode = AutoScaleMode.Font;
        }
    }
}