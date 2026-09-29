using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
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

            AutoScaleMode = AutoScaleMode.None;
        }
    }
    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
}