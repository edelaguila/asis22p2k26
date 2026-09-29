using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CapaControlador_Reporteador;

namespace CapaVista_Reporteador
{
    public partial class FrmReportes : Form
    {
        // =========================================================
        // MODELO
        // =========================================================

        private ClsModeloReporteador modeloReporteador;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmReportes()
        {
            InitializeComponent();

            modeloReporteador = new ClsModeloReporteador();

            // =====================================================
            // BTN RUTA
            // =====================================================
            // NO QUITAR.
            // BtnRuta sigue llenando el TextBox de la ruta.

            if (BtnRuta != null)
            {
                BtnRuta.CampoTextoRuta =
                    ReporteadorTxtRutaReporte;
            }


            // =====================================================
            // BTN GUARDAR
            // =====================================================

            if (BtnGuardar != null)
            {
                BtnGuardar.TxtNombreReporte =
                    ReporteadorTxtNombreReporte;

                BtnGuardar.TxtRutaReporte =
                    ReporteadorTxtRutaReporte;

                // El UserControl solamente avisa del Click.
                BtnGuardar.Click += BtnGuardar1_Click;
            }

            // =====================================================
            // BTN Imprimir
            // =====================================================
            if (BtnImprimir != null)
            {
                BtnImprimir.RutaReporte = null;
            }

            ReporteadorDgvReportes.SelectionChanged +=
                ReporteadorDgvReportes_SelectionChanged;


            // Cargar formulario
            Load += FrmReportes_Load;
        }


        // =========================================================
        // LOAD
        // =========================================================

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                // Volver a asegurar la conexión de los controles
                if (BtnRuta != null)
                {
                    BtnRuta.CampoTextoRuta =
                        ReporteadorTxtRutaReporte;
                }

                if (BtnGuardar != null)
                {
                    BtnGuardar.TxtNombreReporte =
                        ReporteadorTxtNombreReporte;

                    BtnGuardar.TxtRutaReporte =
                        ReporteadorTxtRutaReporte;
                }

                // Cargar registros
                CargarTabla();

                // Preparar nuevo registro
                PrepararNuevoRegistro();
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo cargar el formulario.\n\n" +
                    ex.Message
                );
            }
        }


        // =========================================================
        // CLICK DEL BTN GUARDAR
        // =========================================================

        private void BtnGuardar1_Click(object sender, EventArgs e)
        {
            GuardarReporte();
        }


        // =========================================================
        // GUARDAR REPORTE
        // =========================================================

        private void GuardarReporte()
        {
            try
            {
                // -------------------------------------------------
                // VALIDAR NOMBRE
                // -------------------------------------------------

                string nombre =
                    ReporteadorTxtNombreReporte.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MostrarError(
                        "Debe ingresar el nombre del reporte."
                    );

                    ReporteadorTxtNombreReporte.Focus();

                    return;
                }


                // -------------------------------------------------
                // VALIDAR RUTA
                // -------------------------------------------------

                string ruta =
                    ReporteadorTxtRutaReporte.Text.Trim();

                if (string.IsNullOrWhiteSpace(ruta))
                {
                    MostrarError(
                        "Debe seleccionar el archivo PDF del reporte."
                    );

                    return;
                }


                // -------------------------------------------------
                // VALIDAR EXTENSIÓN
                // -------------------------------------------------

                if (!ruta.EndsWith(
                    ".pdf",
                    StringComparison.OrdinalIgnoreCase))
                {
                    MostrarError(
                        "El archivo seleccionado debe ser un PDF."
                    );

                    return;
                }


                // -------------------------------------------------
                // VALIDAR QUE EL ARCHIVO EXISTA
                // -------------------------------------------------

                if (!File.Exists(ruta))
                {
                    MostrarError(
                        "El archivo seleccionado no existe.\n\n" +
                        "Seleccione nuevamente el PDF."
                    );

                    return;
                }


                // -------------------------------------------------
                // ASEGURAR MODELO
                // -------------------------------------------------

                if (modeloReporteador == null)
                {
                    modeloReporteador =
                        new ClsModeloReporteador();
                }


                // -------------------------------------------------
                // PREPARAR NUEVO REGISTRO
                // -------------------------------------------------

                PrepararNuevoRegistro();


                // -------------------------------------------------
                // ASIGNAR DATOS
                // -------------------------------------------------

                modeloReporteador.NombreReporte =
                    nombre;

                modeloReporteador.RutaReporte =
                    ruta;

                modeloReporteador.FechaReporte =
                    DateTime.Now.Date;


                // -------------------------------------------------
                // GUARDAR
                // -------------------------------------------------

                string resultado =
                    modeloReporteador.GrabarCambios();


                // -------------------------------------------------
                // RESULTADO
                // -------------------------------------------------

                if (resultado == "Grabación exitosa")
                {
                    MostrarExito(
                        "El reporte se guardó correctamente."
                    );

                    LimpiarFormulario();

                    modeloReporteador =
                        new ClsModeloReporteador();

                    PrepararNuevoRegistro();

                    CargarTabla();

                    return;
                }


                // -------------------------------------------------
                // ERROR DEVUELTO POR EL MODELO
                // -------------------------------------------------

                MostrarError(
                    "No se pudo guardar el reporte.\n\n" +
                    resultado
                );
            }
            catch (Exception ex)
            {
                MostrarError(
                    "Ocurrió un error al guardar el reporte.\n\n" +
                    ex.Message
                );
            }
        }


        // =========================================================
        // PREPARAR NUEVO REGISTRO
        // =========================================================

        private void PrepararNuevoRegistro()
        {
            try
            {
                if (modeloReporteador == null)
                {
                    modeloReporteador =
                        new ClsModeloReporteador();
                }

                modeloReporteador.Estado =
                    ClsEstadoEntidad.Added;

                // El modelo genera el siguiente número.
                modeloReporteador.NumeroReporte =
                    modeloReporteador
                    .GenerarSiguienteNumeroReporte(30);

                modeloReporteador.FechaReporte =
                    DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo generar el número del reporte.\n\n" +
                    ex.Message
                );
            }
        }


        // =========================================================
        // CARGAR DATAGRIDVIEW
        // =========================================================

        public void CargarTabla()
        {
            try
            {
                if (modeloReporteador == null)
                {
                    modeloReporteador =
                        new ClsModeloReporteador();
                }

                var lista =
                    modeloReporteador.GetAll();


                // =================================================
                // LIMPIAR COLUMNAS
                // =================================================

                ReporteadorDgvReportes.DataSource = null;

                ReporteadorDgvReportes.Columns.Clear();

                ReporteadorDgvReportes.AutoGenerateColumns =
                    false;


                // =================================================
                // NUMERO REPORTE
                // =================================================

                DataGridViewTextBoxColumn colNumero =
                    new DataGridViewTextBoxColumn();

                colNumero.Name =
                    "NumeroReporte";

                colNumero.HeaderText =
                    "NumeroReporte";

                colNumero.DataPropertyName =
                    "NumeroReporte";

                colNumero.Width = 100;

                ReporteadorDgvReportes.Columns.Add(
                    colNumero
                );


                // =================================================
                // NOMBRE REPORTE
                // =================================================

                DataGridViewTextBoxColumn colNombre =
                    new DataGridViewTextBoxColumn();

                colNombre.Name =
                    "NombreReporte";

                colNombre.HeaderText =
                    "NombreReporte";

                colNombre.DataPropertyName =
                    "NombreReporte";

                colNombre.Width = 180;

                ReporteadorDgvReportes.Columns.Add(
                    colNombre
                );


                // =================================================
                // RUTA REPORTE
                // =================================================

                DataGridViewTextBoxColumn colRuta =
                    new DataGridViewTextBoxColumn();

                colRuta.Name =
                    "RutaReporte";

                colRuta.HeaderText =
                    "RutaReporte";

                colRuta.DataPropertyName =
                    "RutaReporte";

                colRuta.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;

                ReporteadorDgvReportes.Columns.Add(
                    colRuta
                );


                // =================================================
                // FECHA REPORTE
                // =================================================

                DataGridViewTextBoxColumn colFecha =
                    new DataGridViewTextBoxColumn();

                colFecha.Name =
                    "FechaReporte";

                colFecha.HeaderText =
                    "FechaReporte";

                colFecha.DataPropertyName =
                    "FechaReporte";

                colFecha.Width = 100;

                colFecha.DefaultCellStyle.Format =
                    "dd/MM/yyyy";

                ReporteadorDgvReportes.Columns.Add(
                    colFecha
                );


                // =================================================
                // CARGAR DATOS
                // =================================================

                ReporteadorDgvReportes.DataSource =
                    lista;

                ReporteadorDgvReportes.Refresh();
            }
            catch (Exception ex)
            {
                MostrarError(
                    "No se pudo cargar la lista de reportes.\n\n" +
                    ex.Message
                );
            }
        }

        // =========================================================
        // SELECCIONAR REPORTE PARA IMPRIMIR
        // =========================================================

        private void ReporteadorDgvReportes_SelectionChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (BtnImprimir == null)
                {
                    return;
                }

                if (ReporteadorDgvReportes.CurrentRow == null)
                {
                    BtnImprimir.RutaReporte = null;
                    return;
                }

                object valorRuta =
                    ReporteadorDgvReportes
                    .CurrentRow
                    .Cells["RutaReporte"]
                    .Value;

                if (valorRuta == null ||
                    valorRuta == DBNull.Value)
                {
                    BtnImprimir.RutaReporte = null;
                    return;
                }

                BtnImprimir.RutaReporte =
                    valorRuta.ToString();
            }
            catch
            {
                BtnImprimir.RutaReporte = null;
            }
        }


        // =========================================================
        // LIMPIAR FORMULARIO
        // =========================================================

        private void LimpiarFormulario()
        {
            ReporteadorTxtNombreReporte.Clear();

            ReporteadorTxtRutaReporte.Clear();

            ReporteadorTxtNombreReporte.Focus();
        }


        // =========================================================
        // DIÁLOGO DE ÉXITO
        // =========================================================

        private void MostrarExito(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Operación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // =========================================================
        // DIÁLOGO DE ERROR
        // =========================================================

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }


        // =========================================================
        // DIÁLOGO DE CONFIRMACIÓN
        // =========================================================
        // Este método lo utilizaremos para ELIMINAR.
        // NO se utiliza para Guardar.

        private bool MostrarConfirmacion(string mensaje)
        {
            DialogResult resultado =
                MessageBox.Show(
                    mensaje,
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            return resultado == DialogResult.Yes;
        }
    }
}