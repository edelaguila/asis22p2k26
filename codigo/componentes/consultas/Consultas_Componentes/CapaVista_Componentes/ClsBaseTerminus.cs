using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Componentes
{
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
}