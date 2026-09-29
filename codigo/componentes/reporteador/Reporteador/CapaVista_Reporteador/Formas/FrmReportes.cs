/* 
    VELVETH SARAI CHAVEZ MEJIA 0901 23 6269
 */

using CapaControlador_Reporteador;
using CapaModelo_Reporteador.Entidades;
using System;
using System.IO;
using System.Windows.Forms;

namespace CapaVista_Reporteador
{
    public partial class FrmReportes : Form
    {
        // =========================================================
        // VARIABLES DEL FORMULARIO
        // =========================================================

        private ClsModeloReporteador
            _ModeloReporteador;

        private bool _ModoEdicion =
            false;

        private int _NumeroReporteEdicion =
            0;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmReportes()
        {
            InitializeComponent();

            _ModeloReporteador =
                new ClsModeloReporteador();

            // -----------------------------------------------------
            // Configuración de los campos principales.
            // -----------------------------------------------------

            ReporteadorTxtNombreReporte.Enabled =
                true;

            ReporteadorTxtNombreReporte.ReadOnly =
                false;

            ReporteadorTxtNombreReporte.TabStop =
                true;

            ReporteadorTxtNombreReporte2.Enabled =
                true;

            ReporteadorTxtNombreReporte2.ReadOnly =
                false;

            ReporteadorTxtNombreReporte2.TabStop =
                true;

            ReporteadorTxtRutaReporte.Enabled =
                true;

            ReporteadorTxtRutaReporte.ReadOnly =
                true;

            ReporteadorTxtRutaReporte.TabStop =
                false;

            // -----------------------------------------------------
            // Configurar componente Ruta.
            // -----------------------------------------------------

            if (ReporteadorBtnRuta != null)
            {
                ReporteadorBtnRuta.CampoTextoRuta =
                    ReporteadorTxtRutaReporte;
            }

            // -----------------------------------------------------
            // Configurar DataGridView.
            // -----------------------------------------------------

            if (ReporteadorDgvReportes != null)
            {
                ReporteadorDgvReportes.SelectionChanged +=
                    ReporteadorDgvReportes_SelectionChanged;
            }

            // -----------------------------------------------------
            // Configurar componente de búsqueda.
            // -----------------------------------------------------

            if (ReporteadorBtnBusqueda != null)
            {
                ReporteadorBtnBusqueda.TxtNombreReporte =
                    ReporteadorTxtNombreReporte2;

                ReporteadorBtnBusqueda.DtpFechaReporte =
                    ReporteadorDtpFechaReporte;

                ReporteadorBtnBusqueda.ChkNombreReporte =
                    ReporteadorChkNombreReporte;

                ReporteadorBtnBusqueda.ChkFechaReporte =
                    ReporteadorChkFechaReporte;

                ReporteadorBtnBusqueda.DgvReportes =
                    ReporteadorDgvReportes;
            }

            // -----------------------------------------------------
            // Configurar componente de actualización.
            // -----------------------------------------------------

            if (ReporteadorBtnActualizar != null)
            {
                ReporteadorBtnActualizar.DgvReportes =
                    ReporteadorDgvReportes;
            }

            // -----------------------------------------------------
            // Configurar componente de edición.
            // -----------------------------------------------------

            if (ReporteadorBtnEditar != null)
            {
                ReporteadorBtnEditar
                    .ReporteadorTxtNombreReporte =
                    ReporteadorTxtNombreReporte;

                ReporteadorBtnEditar
                    .ReporteadorTxtRutaReporte =
                    ReporteadorTxtRutaReporte;

                ReporteadorBtnEditar.Click +=
                    BtnEditar_Click;
            }

            // -----------------------------------------------------
            // Configurar componente de limpieza.
            // -----------------------------------------------------

            if (ReporteadorBtnLimpiar != null)
            {
                ReporteadorBtnLimpiar.Click +=
                    BtnLimpiar_Click;
            }

            // -----------------------------------------------------
            // Configurar componente de impresión.
            // -----------------------------------------------------

            if (ReporteadorBtnImprimir != null)
            {
                ReporteadorBtnImprimir.RutaReporte =
                    null;
            }

            // -----------------------------------------------------
            // Evento Load del formulario.
            // -----------------------------------------------------

            Load +=
                FrmReportes_Load;
        }

        // =========================================================
        // CARGA DEL FORMULARIO
        // =========================================================

        private void FrmReportes_Load(
            object Sender,
            EventArgs E)
        {
            try
            {
                ReporteadorMetCargarTabla();

                _ModoEdicion =
                    false;

                _NumeroReporteEdicion =
                    0;

                ReporteadorMetPrepararNuevoRegistro();

                ReporteadorTxtNombreReporte.Focus();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo cargar el formulario.");
            }
        }

        // =========================================================
        // GUARDAR REPORTE
        // =========================================================

        /// <summary>
        /// Guarda un nuevo reporte o actualiza
        /// el reporte seleccionado.
        /// </summary>
        public void GuardarReporte()
        {
            try
            {
                string NombreReporte =
                    ReporteadorTxtNombreReporte
                    .Text
                    .Trim();

                // Validar nombre.
                if (string.IsNullOrWhiteSpace(
                    NombreReporte))
                {
                    ReporteadorMetMostrarError(
                        "Debe ingresar el nombre del reporte.");

                    ReporteadorTxtNombreReporte.Focus();

                    return;
                }

                string RutaReporte =
                    ReporteadorTxtRutaReporte
                    .Text
                    .Trim();

                // Validar ruta.
                if (string.IsNullOrWhiteSpace(
                    RutaReporte))
                {
                    ReporteadorMetMostrarError(
                        "Debe seleccionar el archivo PDF " +
                        "del reporte.");

                    return;
                }

                // Validar extensión.
                if (!RutaReporte.EndsWith(
                    ".pdf",
                    StringComparison.OrdinalIgnoreCase))
                {
                    ReporteadorMetMostrarError(
                        "El archivo seleccionado debe ser un PDF.");

                    return;
                }

                // Validar existencia.
                if (!File.Exists(
                    RutaReporte))
                {
                    ReporteadorMetMostrarError(
                        "El archivo seleccionado no existe.");

                    return;
                }

                // Crear modelo si fuera necesario.
                if (_ModeloReporteador == null)
                {
                    _ModeloReporteador =
                        new ClsModeloReporteador();
                }

                // -------------------------------------------------
                // Determinar número de reporte.
                // -------------------------------------------------

                if (_ModoEdicion)
                {
                    _ModeloReporteador.NumeroReporte =
                        _NumeroReporteEdicion;
                }
                else
                {
                    _ModeloReporteador.NumeroReporte =
                        ReporteadorMetObtenerSiguienteNumeroReporte();
                }

                _ModeloReporteador.NombreReporte =
                    NombreReporte;

                _ModeloReporteador.RutaReporte =
                    RutaReporte;

                _ModeloReporteador.FechaReporte =
                    ReporteadorDtpFechaReporte
                    .Value
                    .Date;

                // -------------------------------------------------
                // Determinar operación.
                // -------------------------------------------------

                _ModeloReporteador.Estado =
                    _ModoEdicion
                    ? ClsEstadoEntidad.Modified
                    : ClsEstadoEntidad.Added;

                // -------------------------------------------------
                // Ejecutar operación.
                // -------------------------------------------------

                string Resultado =
                    _ModeloReporteador
                    .ReporteadorMetGuardarReporte();

                if (Resultado ==
                    "Grabación exitosa")
                {
                    ReporteadorMetMostrarExito(
                        "El reporte se guardó correctamente.");

                    _ModoEdicion =
                        false;

                    _NumeroReporteEdicion =
                        0;

                    ReporteadorMetLimpiarFormulario();
                    ReporteadorMetCargarTabla();
                    ReporteadorMetPrepararNuevoRegistro();

                    return;
                }

                if (Resultado ==
                    "Actualización exitosa")
                {
                    ReporteadorMetMostrarExito(
                        "El reporte se actualizó correctamente.");

                    _ModoEdicion =
                        false;

                    _NumeroReporteEdicion =
                        0;

                    ReporteadorMetLimpiarFormulario();
                    ReporteadorMetCargarTabla();
                    ReporteadorMetPrepararNuevoRegistro();

                    return;
                }

                ReporteadorMetMostrarError(
                    Resultado);
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "Ocurrió un error al guardar el reporte.");
            }
        }

        // =========================================================
        // CARGAR TABLA
        // =========================================================

        /// <summary>
        /// Carga todos los reportes en el DataGridView.
        /// </summary>
        public void CargarTabla()
        {
            ReporteadorMetCargarTabla();
        }

        private void ReporteadorMetCargarTabla()
        {
            try
            {
                if (_ModeloReporteador == null)
                {
                    _ModeloReporteador =
                        new ClsModeloReporteador();
                }

                ReporteadorDgvReportes.DataSource =
                    _ModeloReporteador
                    .ReporteadorMetObtenerTodos();

                ReporteadorDgvReportes.Refresh();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo cargar la lista de reportes.");
            }
        }

        // =========================================================
        // EDITAR
        // =========================================================

        private void BtnEditar_Click(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetPrepararEdicion();
        }

        /// <summary>
        /// Carga los datos del reporte seleccionado
        /// en los campos del formulario.
        /// </summary>
        private void ReporteadorMetPrepararEdicion()
        {
            try
            {
                if (ReporteadorDgvReportes.CurrentRow == null)
                {
                    ReporteadorMetMostrarError(
                        "Debe seleccionar un reporte para editar.");

                    return;
                }

                object Numero =
                    ReporteadorDgvReportes
                    .CurrentRow
                    .Cells["NumeroReporte"]
                    .Value;

                object Nombre =
                    ReporteadorDgvReportes
                    .CurrentRow
                    .Cells["NombreReporte"]
                    .Value;

                object Ruta =
                    ReporteadorDgvReportes
                    .CurrentRow
                    .Cells["RutaReporte"]
                    .Value;

                object Fecha =
                    ReporteadorDgvReportes
                    .CurrentRow
                    .Cells["FechaReporte"]
                    .Value;

                if (Numero == null ||
                    Numero == DBNull.Value)
                {
                    ReporteadorMetMostrarError(
                        "El reporte seleccionado " +
                        "no tiene número.");

                    return;
                }

                _NumeroReporteEdicion =
                    Convert.ToInt32(Numero);

                ReporteadorTxtNombreReporte.Text =
                    Nombre == null ||
                    Nombre == DBNull.Value
                    ? string.Empty
                    : Nombre.ToString();

                ReporteadorTxtRutaReporte.Text =
                    Ruta == null ||
                    Ruta == DBNull.Value
                    ? string.Empty
                    : Ruta.ToString();

                if (Fecha != null &&
                    Fecha != DBNull.Value)
                {
                    ReporteadorDtpFechaReporte.Value =
                        Convert.ToDateTime(Fecha);
                }

                _ModoEdicion =
                    true;

                ReporteadorTxtNombreReporte.Focus();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo preparar el reporte " +
                    "para editar.");
            }
        }

        // =========================================================
        // LIMPIAR FORMULARIO
        // =========================================================

        /// <summary>
        /// Limpia todos los campos utilizados
        /// por el formulario.
        /// </summary>
        public void LimpiarFormulario()
        {
            ReporteadorMetLimpiarFormulario();
        }

        private void ReporteadorMetLimpiarFormulario()
        {
            ReporteadorTxtNombreReporte.Clear();

            ReporteadorTxtRutaReporte.Clear();

            ReporteadorTxtNombreReporte2.Clear();

            ReporteadorDtpFechaReporte.Value =
                DateTime.Now;

            if (ReporteadorChkNombreReporte != null)
            {
                ReporteadorChkNombreReporte.Checked =
                    false;
            }

            if (ReporteadorChkFechaReporte != null)
            {
                ReporteadorChkFechaReporte.Checked =
                    false;
            }

            if (ReporteadorBtnImprimir != null)
            {
                ReporteadorBtnImprimir.RutaReporte =
                    null;
            }

            ReporteadorTxtNombreReporte.Focus();
        }

        // =========================================================
        // EVENTO DEL BOTÓN LIMPIAR
        // =========================================================

        private void BtnLimpiar_Click(
            object Sender,
            EventArgs E)
        {
            try
            {
                ReporteadorMetLimpiarFormulario();

                _ModoEdicion =
                    false;

                _NumeroReporteEdicion =
                    0;

                ReporteadorMetPrepararNuevoRegistro();

                ReporteadorMetCargarTabla();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo limpiar el formulario.");
            }
        }

        // =========================================================
        // SELECCIÓN DEL DATAGRIDVIEW
        // =========================================================

        /// <summary>
        /// Actualiza la ruta del componente de impresión
        /// cuando el usuario selecciona un reporte.
        /// </summary>
        private void ReporteadorDgvReportes_SelectionChanged(
            object Sender,
            EventArgs E)
        {
            try
            {
                if (ReporteadorBtnImprimir == null)
                {
                    return;
                }

                if (ReporteadorDgvReportes.CurrentRow == null)
                {
                    ReporteadorBtnImprimir.RutaReporte =
                        null;

                    return;
                }

                if (!ReporteadorDgvReportes.Columns.Contains(
                    "RutaReporte"))
                {
                    ReporteadorBtnImprimir.RutaReporte =
                        null;

                    return;
                }

                object Ruta =
                    ReporteadorDgvReportes
                    .CurrentRow
                    .Cells["RutaReporte"]
                    .Value;

                ReporteadorBtnImprimir.RutaReporte =
                    Ruta == null ||
                    Ruta == DBNull.Value
                    ? null
                    : Ruta.ToString();
            }
            catch (Exception)
            {
                if (ReporteadorBtnImprimir != null)
                {
                    ReporteadorBtnImprimir.RutaReporte =
                        null;
                }
            }
        }

        // =========================================================
        // OBTENER SIGUIENTE NÚMERO
        // =========================================================

        private int
            ReporteadorMetObtenerSiguienteNumeroReporte()
        {
            try
            {
                if (_ModeloReporteador == null)
                {
                    _ModeloReporteador =
                        new ClsModeloReporteador();
                }

                // Código de módulo 30:
                // rango 3000 - 3099.
                return _ModeloReporteador
                    .ReporteadorMetObtenerSiguienteNumeroReporte(
                        30);
            }
            catch (Exception)
            {
                // Valor inicial utilizado si no se puede
                // consultar temporalmente la numeración.
                return 3001;
            }
        }

        // =========================================================
        // PREPARAR NUEVO REGISTRO
        // =========================================================

        private void
            ReporteadorMetPrepararNuevoRegistro()
        {
            if (_ModeloReporteador == null)
            {
                _ModeloReporteador =
                    new ClsModeloReporteador();
            }

            _ModeloReporteador.NumeroReporte =
                ReporteadorMetObtenerSiguienteNumeroReporte();

            _ModeloReporteador.FechaReporte =
                DateTime.Now.Date;

            ReporteadorDtpFechaReporte.Value =
                DateTime.Now;
        }

        // =========================================================
        // MOSTRAR MENSAJE DE ÉXITO
        // =========================================================

        private void ReporteadorMetMostrarExito(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // MOSTRAR MENSAJE DE ERROR
        // =========================================================

        private void ReporteadorMetMostrarError(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}