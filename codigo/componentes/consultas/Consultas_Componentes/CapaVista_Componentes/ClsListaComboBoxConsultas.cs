using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes
{

    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
    public class ClsListaComboBoxConsultas : ComboBox
    {
        private static readonly Color _ColorTexto =
            ColorTranslator.FromHtml("#2E4A63");

        public ClsListaComboBoxConsultas()
        {
            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            ForeColor = _ColorTexto;
            BackColor = Color.White;

            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;

            IntegralHeight = true;
            MaxDropDownItems = 8;

            Margin = new Padding(3);
        }

        protected override Size DefaultSize =>
            new Size(200, 27);
    }

    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
}