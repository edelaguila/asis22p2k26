using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Consultas.Componentes
{
    public class ClsBotonConsultas : Button
    {
        private static readonly Color _FondoConsultas =
            ColorTranslator.FromHtml("#EDE7DA");

        public ClsBotonConsultas()
        {
            AutoSize = false;

            Size = new Size(80, 80);
            MinimumSize = new Size(80, 80);
            MaximumSize = new Size(80, 80);

            BackColor = _FondoConsultas;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            UseVisualStyleBackColor = false;

            BackgroundImageLayout = ImageLayout.Stretch;

            Cursor = Cursors.Hand;

            Margin = new Padding(0);
            Anchor = AnchorStyles.None;
        }

        protected override Size DefaultSize =>
            new Size(80, 80);

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            Cursor = Enabled
                ? Cursors.Hand
                : Cursors.Default;
        }
    }
}