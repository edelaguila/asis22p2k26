using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Components
{
    public class ClsTablaDatosConsultas : DataGridView
    {
        private static readonly Color _Primario =
            ColorTranslator.FromHtml("#2E4A63");

        private static readonly Color _Secundario =
            ColorTranslator.FromHtml("#4E8078");

        private static readonly Color _Fondo =
            ColorTranslator.FromHtml("#EDE7DA");

        private static readonly Color _FondoAlterno =
            Color.FromArgb(245, 242, 235);

        public ClsTablaDatosConsultas()
        {
            DoubleBuffered = true;

            ConsultasMetAplicarEstandarizacion();
        }

        protected override void OnHandleCreated(System.EventArgs e)
        {
            base.OnHandleCreated(e);

            ConsultasMetAplicarEstandarizacion();
        }

        private void ConsultasMetAplicarEstandarizacion()
        {
            AutoGenerateColumns = true;

            Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            BackgroundColor = Color.White;

            BorderStyle = BorderStyle.None;

            CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            GridColor = _Fondo;

            EnableHeadersVisualStyles = false;

            ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = _Primario,
                    ForeColor = Color.White,
                    SelectionBackColor = _Primario,
                    SelectionForeColor = Color.White,
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft,
                    Font = new Font(
                        "Tahoma",
                        9.5F,
                        FontStyle.Bold,
                        GraphicsUnit.Point)
                };

            DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = _Primario,
                    SelectionBackColor = _Secundario,
                    SelectionForeColor = Color.White,
                    Alignment =
                        DataGridViewContentAlignment.MiddleLeft,
                    Padding = new Padding(3, 0, 3, 0),
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Regular,
                        GraphicsUnit.Point)
                };

            RowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.White,
                    ForeColor = _Primario,
                    SelectionBackColor = _Secundario,
                    SelectionForeColor = Color.White
                };

            AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = _FondoAlterno,
                    ForeColor = _Primario,
                    SelectionBackColor = _Secundario,
                    SelectionForeColor = Color.White
                };

            RowHeadersVisible = false;

            ReadOnly = true;

            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;

            SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            MultiSelect = false;

            EditMode =
                DataGridViewEditMode.EditProgrammatically;

            AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            ColumnHeadersHeight = 32;

            ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            RowTemplate.Height = 28;

            Margin = new Padding(3);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ClientSize.Width <= 0 ||
                ClientSize.Height <= 0)
            {
                return;
            }

            using (Pen Borde = new Pen(_Primario, 1F))
            {
                e.Graphics.DrawRectangle(
                    Borde,
                    0,
                    0,
                    ClientSize.Width - 1,
                    ClientSize.Height - 1);
            }
        }
    }
}