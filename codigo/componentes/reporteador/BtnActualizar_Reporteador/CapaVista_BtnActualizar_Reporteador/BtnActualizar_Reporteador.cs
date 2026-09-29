/*
    Jose Xavier Bolaños Tenas 
 */

using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CapaControlador_BtnActualizar;

namespace CapaVista_BtnActualizar
{
    [ToolboxItem(true)]
    [Description(
        "Boton reutilizable para actualizar el listado de reportes.")]
    public partial class ReporteadorUcActualizar : UserControl
    {
        private readonly ClsControladorBtnActualizar _Controlador;

        public DataGridView DgvReportes { get; set; }

        public ReporteadorUcActualizar()
        {
            InitializeComponent();

            _Controlador =
                new ClsControladorBtnActualizar();
        }

        private void ReporteadorBtnActualizar_Click(
            object Sender,
            EventArgs E)
        {
            if (DgvReportes == null)
            {
                MessageBox.Show(
                    "No se ha asignado el DataGridView de reportes.",
                    "Ocurrió un error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            ReporteadorMetRefrescarGrid();
        }

        private void ReporteadorMetRefrescarGrid()
        {
            try
            {
                DataTable TablaReportes =
                    _Controlador.ReporteadorMetObtenerReportes();

                DgvReportes.DataSource = null;
                DgvReportes.Columns.Clear();
                DgvReportes.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn ColumnaNumero =
                    new DataGridViewTextBoxColumn();

                ColumnaNumero.Name =
                    "NumeroReporte";

                ColumnaNumero.HeaderText =
                    "NumeroReporte";

                ColumnaNumero.DataPropertyName =
                    "NumeroReporte";

                ColumnaNumero.Width = 100;

                DgvReportes.Columns.Add(
                    ColumnaNumero);

                DataGridViewTextBoxColumn ColumnaNombre =
                    new DataGridViewTextBoxColumn();

                ColumnaNombre.Name =
                    "NombreReporte";

                ColumnaNombre.HeaderText =
                    "NombreReporte";

                ColumnaNombre.DataPropertyName =
                    "NombreReporte";

                ColumnaNombre.Width = 180;

                DgvReportes.Columns.Add(
                    ColumnaNombre);

                DataGridViewTextBoxColumn ColumnaRuta =
                    new DataGridViewTextBoxColumn();

                ColumnaRuta.Name =
                    "RutaReporte";

                ColumnaRuta.HeaderText =
                    "RutaReporte";

                ColumnaRuta.DataPropertyName =
                    "RutaReporte";

                ColumnaRuta.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

                DgvReportes.Columns.Add(
                    ColumnaRuta);

                DataGridViewTextBoxColumn ColumnaFecha =
                    new DataGridViewTextBoxColumn();

                ColumnaFecha.Name =
                    "FechaReporte";

                ColumnaFecha.HeaderText =
                    "FechaReporte";

                ColumnaFecha.DataPropertyName =
                    "FechaReporte";

                ColumnaFecha.Width = 100;

                ColumnaFecha.DefaultCellStyle.Format =
                    "dd/MM/yyyy";

                DgvReportes.Columns.Add(
                    ColumnaFecha);

                DgvReportes.DataSource =
                    TablaReportes;

                DgvReportes.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se pudo actualizar el listado de reportes.",
                    "Ocurrió un error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}