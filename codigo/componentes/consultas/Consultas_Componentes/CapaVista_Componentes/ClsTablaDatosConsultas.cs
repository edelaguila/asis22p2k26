using System.Drawing;
using System.Windows.Forms;

namespace CapaVista_Consultas.Componentes
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

        private const int _AlturaMinimaFila = 28;
        private const int _AlturaMaximaFila = 40;

        public ClsTablaDatosConsultas()
        {
            DoubleBuffered = true;

            ConsultasMetAplicarEstandarizacion();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            ConsultasMetAjustarAlturaFilas();
        }

        protected override void OnRowsAdded(
            DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);

            ConsultasMetAjustarAlturaFilas();
        }

        protected override void OnRowsRemoved(
            DataGridViewRowsRemovedEventArgs e)
        {
            base.OnRowsRemoved(e);

            ConsultasMetAjustarAlturaFilas();
        }

        protected override void OnDataBindingComplete(
            DataGridViewBindingCompleteEventArgs e)
        {
            base.OnDataBindingComplete(e);

            ConsultasMetAjustarAlturaFilas();
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

        private void ConsultasMetAjustarAlturaFilas()
        {
            if (Rows.Count == 0 || ClientSize.Height <= 0)
                return;

            int CantidadFilas = Rows.Count;

            int EspacioDisponible =
                ClientSize.Height
                - ColumnHeadersHeight
                - 2;

            if (EspacioDisponible <= 0)
                return;

            int AlturaCalculada =
                EspacioDisponible / CantidadFilas;

            if (AlturaCalculada <= _AlturaMinimaFila)
            {
                foreach (DataGridViewRow Fila in Rows)
                {
                    Fila.Height = _AlturaMinimaFila;
                }

                return;
            }

            if (AlturaCalculada >= _AlturaMaximaFila)
            {
                foreach (DataGridViewRow Fila in Rows)
                {
                    Fila.Height = _AlturaMaximaFila;
                }

                return;
            }

            int Sobrante =
                EspacioDisponible
                - (AlturaCalculada * CantidadFilas);

            for (int i = 0; i < CantidadFilas; i++)
            {
                int AlturaFila =
                    AlturaCalculada +
                    (i < Sobrante ? 1 : 0);

                if (AlturaFila > _AlturaMaximaFila)
                    AlturaFila = _AlturaMaximaFila;

                Rows[i].Height = AlturaFila;
            }
        }

        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ClientSize.Width <= 0 ||
                ClientSize.Height <= 0)
            {
                return;
            }

            using (Pen Borde = new Pen(_Primario, 1))
            {
                int Ancho = ClientSize.Width - 1;
                int Alto = ClientSize.Height - 1;

                e.Graphics.DrawLine(
                    Borde,
                    0,
                    0,
                    Ancho,
                    0);

                e.Graphics.DrawLine(
                    Borde,
                    0,
                    0,
                    0,
                    Alto);

                e.Graphics.DrawLine(
                    Borde,
                    Ancho,
                    0,
                    Ancho,
                    Alto);

                e.Graphics.DrawLine(
                    Borde,
                    0,
                    Alto,
                    Ancho,
                    Alto);
            }
        }
    }
}