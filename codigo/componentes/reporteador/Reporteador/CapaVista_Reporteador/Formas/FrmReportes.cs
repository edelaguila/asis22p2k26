/*
    VELVETH SARAI CHAVEZ MEJIA 0901 23 6269
*/

using CapaControlador_Reporteador;
using CapaModelo_Reporteador.Entidades;
using CapaVista_BtnVerReporte_Reporteador;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CapaVista_Reporteador
{
    public partial class FrmReportes : Form
    {
        private ClsModeloReporteador _ModeloReporteador;

        private bool _ModoEdicion = false;

        private int _NumeroReporteEdicion = 0;

        private int _IdAplicacionSeleccionada = 0;

        private Dictionary<string, object> _FuentesDeDatosReporteador;

        public FrmReportes()
        {
            InitializeComponent();

            _ModeloReporteador = new ClsModeloReporteador();

            // ============================================================
            // CONFIGURACIÓN DE LOS CAMPOS
            // ============================================================

            ReporteadorTxtNombreReporte.Enabled = true;
            ReporteadorTxtNombreReporte.ReadOnly = false;
            ReporteadorTxtNombreReporte.TabStop = true;

            ReporteadorTxtNombreReporte2.Enabled = true;
            ReporteadorTxtNombreReporte2.ReadOnly = false;
            ReporteadorTxtNombreReporte2.TabStop = true;

            ReporteadorTxtRutaReporte.Enabled = true;
            ReporteadorTxtRutaReporte.ReadOnly = true;
            ReporteadorTxtRutaReporte.TabStop = false;

            // ============================================================
            // BOTÓN RUTA
            // ============================================================

            if (ReporteadorBtnRuta != null)
            {
                ReporteadorBtnRuta.CampoTextoRuta =
                    ReporteadorTxtRutaReporte;
            }

            // ============================================================
            // BOTÓN BÚSQUEDA
            // ============================================================

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

            // ============================================================
            // BOTÓN ACTUALIZAR
            // ============================================================

            if (ReporteadorBtnActualizar != null)
            {
                ReporteadorBtnActualizar.DgvReportes =
                    ReporteadorDgvReportes;
            }

            // ============================================================
            // BOTÓN EDITAR
            // ============================================================

            if (ReporteadorBtnEditar != null)
            {
                ReporteadorBtnEditar.ReporteadorTxtNombreReporte =
                    ReporteadorTxtNombreReporte;

                ReporteadorBtnEditar.ReporteadorTxtRutaReporte =
                    ReporteadorTxtRutaReporte;

                ReporteadorBtnEditar.Click += BtnEditar_Click;
            }

            // ============================================================
            // BOTÓN LIMPIAR
            // ============================================================

            if (ReporteadorBtnLimpiar != null)
            {
                ReporteadorBtnLimpiar.Click += BtnLimpiar_Click;
            }

            // ============================================================
            // LOAD
            // ============================================================

            Load += FrmReportes_Load;
        }

        // ================================================================
        // LOAD DEL FORMULARIO
        // ================================================================

        private void FrmReportes_Load(
            object Sender,
            EventArgs E)
        {
            try
            {
                ReporteadorMetCargarTabla();

                _ModoEdicion = false;

                _NumeroReporteEdicion = 0;

                ReporteadorMetPrepararNuevoRegistro();

                ReporteadorTxtNombreReporte.Focus();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo cargar el formulario.");
            }
        }

        // ================================================================
        // GUARDAR REPORTE
        // ================================================================

        public void GuardarReporte()
        {
            try
            {
                if (_IdAplicacionSeleccionada <= 0)
                {
                    ReporteadorMetMostrarError(
                        "Debe seleccionar una aplicación antes de guardar el reporte.");

                    return;
                }

                string NombreReporte =
                    ReporteadorTxtNombreReporte.Text.Trim();

                string RutaReporte =
                    ReporteadorTxtRutaReporte.Text.Trim();

                // --------------------------------------------------------
                // VALIDAR NOMBRE
                // --------------------------------------------------------

                if (string.IsNullOrWhiteSpace(NombreReporte))
                {
                    ReporteadorMetMostrarError(
                        "Debe ingresar el nombre del reporte.");

                    ReporteadorTxtNombreReporte.Focus();

                    return;
                }

                // --------------------------------------------------------
                // VALIDAR RUTA
                // --------------------------------------------------------

                if (string.IsNullOrWhiteSpace(RutaReporte))
                {
                    ReporteadorMetMostrarError(
                        "Debe seleccionar el archivo .rdlc del reporte.");

                    return;
                }

                // --------------------------------------------------------
                // VALIDAR EXTENSIÓN
                // --------------------------------------------------------

                string ExtensionArchivo =
                    Path.GetExtension(RutaReporte);

                if (!ExtensionArchivo.Equals(
                    ".rdlc",
                    StringComparison.OrdinalIgnoreCase))
                {
                    ReporteadorMetMostrarError(
                        "Solo se permiten archivos de tipo .rdlc.");

                    return;
                }

                // --------------------------------------------------------
                // VALIDAR EXISTENCIA
                // --------------------------------------------------------

                if (!File.Exists(RutaReporte))
                {
                    ReporteadorMetMostrarError(
                        "El archivo seleccionado no existe.");

                    return;
                }

                if (_ModeloReporteador == null)
                {
                    _ModeloReporteador =
                        new ClsModeloReporteador();
                }

                // --------------------------------------------------------
                // OBTENER REPORTES EXISTENTES
                // --------------------------------------------------------

                var ReportesExistentes =
                    _ModeloReporteador.ReporteadorMetObtenerTodos(_IdAplicacionSeleccionada);

                // --------------------------------------------------------
                // VALIDAR NOMBRE DUPLICADO
                // --------------------------------------------------------

                bool NombreRepetido =
                    ReportesExistentes.Any(Reporte =>
                        !string.IsNullOrWhiteSpace(
                            Reporte.NombreReporte)

                        &&

                        Reporte.NombreReporte
                            .Trim()
                            .Equals(
                                NombreReporte,
                                StringComparison.OrdinalIgnoreCase)

                        &&

                        (
                            !_ModoEdicion

                            ||

                            Reporte.NumeroReporte !=
                            _NumeroReporteEdicion
                        )
                    );

                if (NombreRepetido)
                {
                    ReporteadorMetMostrarError(
                        "No se puede guardar el reporte porque el nombre ya existe.");

                    ReporteadorTxtNombreReporte.Focus();

                    return;
                }

                // --------------------------------------------------------
                // VALIDAR RUTA DUPLICADA
                // --------------------------------------------------------

                bool RutaRepetida =
                    ReportesExistentes.Any(Reporte =>
                        !string.IsNullOrWhiteSpace(
                            Reporte.RutaReporte)

                        &&

                        Reporte.RutaReporte
                            .Trim()
                            .Equals(
                                RutaReporte,
                                StringComparison.OrdinalIgnoreCase)

                        &&

                        (
                            !_ModoEdicion

                            ||

                            Reporte.NumeroReporte !=
                            _NumeroReporteEdicion
                        )
                    );

                if (RutaRepetida)
                {
                    ReporteadorMetMostrarError(
                        "No se puede guardar el reporte porque la ruta del archivo .rdlc ya está registrada.");

                    return;
                }

                // --------------------------------------------------------
                // NÚMERO DEL REPORTE
                // --------------------------------------------------------

                if (_ModoEdicion)
                {
                    // Mantener el número del registro editado.
                    _ModeloReporteador.NumeroReporte =
                        _NumeroReporteEdicion;
                }
                else
                {
                    int MayorNumeroReporte = 3000;

                    foreach (var Reporte in ReportesExistentes)
                    {
                        if (Reporte.NumeroReporte >
                            MayorNumeroReporte)
                        {
                            MayorNumeroReporte =
                                Reporte.NumeroReporte;
                        }
                    }

                    _ModeloReporteador.NumeroReporte =
                        MayorNumeroReporte + 1;
                }

                // --------------------------------------------------------
                // ASIGNAR DATOS
                // --------------------------------------------------------

                _ModeloReporteador.NombreReporte =
                    NombreReporte;

                _ModeloReporteador.RutaReporte =
                    RutaReporte;

                _ModeloReporteador.FechaReporte =
                    ReporteadorDtpFechaReporte.Value.Date;

                _ModeloReporteador.IdAplicacion =
                    _IdAplicacionSeleccionada;

                _ModeloReporteador.Estado =
                    _ModoEdicion
                        ? ClsEstadoEntidad.Modified
                        : ClsEstadoEntidad.Added;

                // --------------------------------------------------------
                // GUARDAR
                // --------------------------------------------------------

                string Resultado =
                    _ModeloReporteador
                        .ReporteadorMetGuardarReporte();

                // --------------------------------------------------------
                // NUEVO REGISTRO
                // --------------------------------------------------------

                if (Resultado == "Grabación exitosa")
                {
                    ReporteadorMetMostrarExito(
                        "El reporte se guardó correctamente.");

                    _ModoEdicion = false;

                    _NumeroReporteEdicion = 0;

                    ReporteadorMetLimpiarFormulario();

                    ReporteadorMetCargarTabla();

                    ReporteadorMetPrepararNuevoRegistro();

                    return;
                }

                // --------------------------------------------------------
                // EDICIÓN
                // --------------------------------------------------------

                if (Resultado == "Actualización exitosa")
                {
                    ReporteadorMetMostrarExito(
                        "El reporte se actualizó correctamente.");

                    _ModoEdicion = false;

                    _NumeroReporteEdicion = 0;

                    ReporteadorMetLimpiarFormulario();

                    ReporteadorMetCargarTabla();

                    ReporteadorMetPrepararNuevoRegistro();

                    return;
                }

                ReporteadorMetMostrarError(Resultado);
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "Ocurrió un error al guardar el reporte.");
            }
        }

        // ================================================================
        // VER REPORTE
        // ================================================================
        private void ReporteadorBtnVerReporte_Click(object sender, EventArgs ArgumentosEvento)
        {
            try
            {
                if (ReporteadorDgvReportes.CurrentRow == null)
                {
                    ReporteadorMetMostrarError("Debe seleccionar un reporte para verlo.");
                    return;
                }

                object NumeroReporte = ReporteadorDgvReportes.CurrentRow.Cells["NumeroReporte"].Value;

                if (NumeroReporte == null || NumeroReporte == DBNull.Value)
                {
                    ReporteadorMetMostrarError("No se pudo obtener el número del reporte.");
                    return;
                }

                ReporteadorBtnVerReporte.ReporteadorMetMostrarReporte(Convert.ToInt32(NumeroReporte), _FuentesDeDatosReporteador);
            }
            catch (Exception ex)
            {
                ReporteadorMetMostrarError("No se pudo abrir el reporte.\n\n" + ex.Message);
            }
        }



        // ================================================================
        // CARGAR TABLA
        // ================================================================

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
                        .ReporteadorMetObtenerTodos(_IdAplicacionSeleccionada);

                ReporteadorDgvReportes.Refresh();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo cargar la lista de reportes.");
            }
        }

        // ================================================================
        // BOTÓN EDITAR
        // ================================================================

        private void BtnEditar_Click(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetPrepararEdicion();
        }

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
                        "El reporte seleccionado no tiene número.");

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

                _ModoEdicion = true;

                ReporteadorTxtNombreReporte.Focus();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo preparar el reporte para editar.");
            }
        }

        // ================================================================
        // LIMPIAR
        // ================================================================

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

            ReporteadorTxtNombreReporte.Focus();
        }

        private void BtnLimpiar_Click(
            object Sender,
            EventArgs E)
        {
            try
            {
                ReporteadorMetLimpiarFormulario();

                _ModoEdicion = false;

                _NumeroReporteEdicion = 0;

                ReporteadorMetPrepararNuevoRegistro();

                ReporteadorMetCargarTabla();
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "No se pudo limpiar el formulario.");
            }
        }

        // ================================================================
        // OBTENER SIGUIENTE NÚMERO
        // ================================================================

        private int ReporteadorMetObtenerSiguienteNumeroReporte()
        {
            try
            {
                if (_ModeloReporteador == null)
                {
                    _ModeloReporteador =
                        new ClsModeloReporteador();
                }

                var ReportesExistentes =
                    _ModeloReporteador
                        .ReporteadorMetObtenerTodos(_IdAplicacionSeleccionada);

                int MayorNumeroReporte = 3000;

                foreach (var Reporte in ReportesExistentes)
                {
                    if (Reporte.NumeroReporte >
                        MayorNumeroReporte)
                    {
                        MayorNumeroReporte =
                            Reporte.NumeroReporte;
                    }
                }

                return MayorNumeroReporte + 1;
            }
            catch (Exception)
            {
                return 3001;
            }
        }

        // ================================================================
        // PREPARAR NUEVO REGISTRO
        // ================================================================

        private void ReporteadorMetPrepararNuevoRegistro()
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

        // ================================================================
        // DIÁLOGO DE CONFIRMACIÓN
        // ================================================================

        private bool ReporteadorMetMostrarConfirmacion(
            string Mensaje)
        {
            return MessageBox.Show(
                Mensaje,
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)
                == DialogResult.Yes;
        }

        // ================================================================
        // DIÁLOGO DE ADVERTENCIA
        // ================================================================

        private void ReporteadorMetConfirmacion(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // ================================================================
        // DIÁLOGO DE ÉXITO
        // ================================================================

        private void ReporteadorMetMostrarExito(
            string Mensaje)
        {
            Form Ventana =
                new Form();

            Ventana.Text =
                "Operación exitosa";

            Ventana.StartPosition =
                FormStartPosition.CenterParent;

            Ventana.FormBorderStyle =
                FormBorderStyle.FixedDialog;

            Ventana.MaximizeBox =
                false;

            Ventana.MinimizeBox =
                false;

            Ventana.ShowInTaskbar =
                false;

            Ventana.ClientSize =
                new Size(
                    360,
                    125);

            Label Icono =
                new Label();

            Icono.Text =
                "✓";

            Icono.ForeColor =
                Color.White;

            Icono.BackColor =
                Color.FromArgb(
                    40,
                    167,
                    69);

            Icono.Font =
                new Font(
                    "Segoe UI",
                    20,
                    FontStyle.Bold);

            Icono.TextAlign =
                ContentAlignment.MiddleCenter;

            Icono.Size =
                new Size(
                    45,
                    45);

            Icono.Location =
                new Point(
                    20,
                    25);

            System.Drawing.Drawing2D.GraphicsPath Circulo =
                new System.Drawing.Drawing2D.GraphicsPath();

            Circulo.AddEllipse(
                0,
                0,
                Icono.Width,
                Icono.Height);

            Icono.Region =
                new Region(
                    Circulo);

            Label Texto =
                new Label();

            Texto.Text =
                Mensaje;

            Texto.AutoSize =
                false;

            Texto.TextAlign =
                ContentAlignment.MiddleLeft;

            Texto.Font =
                new Font(
                    "Segoe UI",
                    9);

            Texto.Location =
                new Point(
                    80,
                    25);

            Texto.Size =
                new Size(
                    250,
                    45);

            Button BotonAceptar =
                new Button();

            BotonAceptar.Text =
                "Aceptar";

            BotonAceptar.Size =
                new Size(
                    80,
                    28);

            BotonAceptar.Location =
                new Point(
                    250,
                    85);

            BotonAceptar.Click +=
                (s, e) =>
                {
                    Ventana.Close();
                };

            Ventana.Controls.Add(
                Icono);

            Ventana.Controls.Add(
                Texto);

            Ventana.Controls.Add(
                BotonAceptar);

            Ventana.AcceptButton =
                BotonAceptar;

            Ventana.ShowDialog(
                this);
        }

        // ================================================================
        // DIÁLOGO DE ERROR
        // ================================================================

        private void ReporteadorMetMostrarError(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ReporteadorBtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Reporteador/proyectoasis22k26-Reporteador/ayuda/componentes/reporteador/AyudaReporteador.chm", "Ayuda_General_Reporteador.html");
        }

        // ================================================================
        // CARGAR REPORTES ASOCIADOS A IDAPLICACIÓN
        // ================================================================
        public void ReporteadorMetCargarReportes(int IdAplicacion, Dictionary<string, object> FuentesDeDatos)
        {
            _IdAplicacionSeleccionada = IdAplicacion;
            _FuentesDeDatosReporteador = FuentesDeDatos;
            CargarTabla();
        }
    }
}

// Codigo a utilizar para cargar reportes desde otra aplicación:


/* NOTA: PARA GUARDAR UN REPORTE SE DEBE AGREGAR UN ID DE APLICACIÓN, PARA PODER CARGAR LOS REPORTES DE ESA APLICACIÓN
 * 
 * NOTA:
 * Este metodo es el que tiene la funcionalidad del navegador 
 * debe colocarse en el forumalirio donde este el boton de imprimir para hacer la
 * referencia con la capa vista de este CapaVista_Reporteador, 
 * y asi poder cargar los reportes de la aplicacion que se desee.
 
  private void btnImprimir_Click(object sender, EventArgs e)
        {
            int idAplicacion = 1;

            Dictionary<string, object> fuentes = new Dictionary<string, object>();

            fuentes.Add("ReporteTipoSanciones", tipo_sancion.GetAll());

            FrmReportes FormularioReportes = new FrmReportes();

            FormularioReportes.ReporteadorMetCargarReportes(idAplicacion, fuentes);

            FormularioReportes.ShowDialog(this);
        }
 */