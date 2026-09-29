using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Componentes
{
    // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
    public class ClsBaseTerminus : Form
    {
        protected ClsBaseTerminus()
        {
            DoubleBuffered = true;

            Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            BackColor = ColorTranslator.FromHtml("#EDE7DA");

            AutoScaleMode = AutoScaleMode.Font;

            KeyPreview = true;

            StartPosition = FormStartPosition.CenterParent;

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            AutoScaleMode = AutoScaleMode.None;
        }
    }
    // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "15/09/26"
}