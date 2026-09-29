/*
     NILLS BERDUCIDO GOMEZ
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using CapaControlador_BtnEliminar_Reporteador;

namespace CapaVista_BtnEliminar_Reporteador
{
    public partial class ReporteadorUcEliminar
        : UserControl
    {
        private readonly ClsModeloBtnEliminarReporteador
            _Controlador;

        public DataGridView GridReportes
        {
            get;
            set;
        }

        public TextBox TxtNombreReporte
        {
            get;
            set;
        }

        public TextBox TxtRutaReporte
        {
            get;
            set;
        }

        [Category("Reporteador")]
        [DefaultValue("ReporteadorDgvReportes")]
        public string NombreGridReportes
        {
            get;
            set;
        } = "ReporteadorDgvReportes";

        [Category("Reporteador")]
        [DefaultValue("ReporteadorTxtNombreReporte")]
        public string NombreTxtNombreReporte
        {
            get;
            set;
        } = "ReporteadorTxtNombreReporte";

        [Category("Reporteador")]
        [DefaultValue("ReporteadorTxtRutaReporte")]
        public string NombreTxtRutaReporte
        {
            get;
            set;
        } = "ReporteadorTxtRutaReporte";

        [Category("Reporteador")]
        [DefaultValue("NumeroReporte")]
        public string ColumnaNumeroReporte
        {
            get;
            set;
        } = "NumeroReporte";

        [Category("Reporteador")]
        [DefaultValue("NombreReporte")]
        public string ColumnaNombreReporte
        {
            get;
            set;
        } = "NombreReporte";

        [Category("Reporteador")]
        [DefaultValue("CargarTabla")]
        public string MetodoRecargar
        {
            get;
            set;
        } = "CargarTabla";

        public event EventHandler Deshabilitado;

        protected virtual void ReporteadorMetOnDeshabilitado()
        {
            if (Deshabilitado != null)
            {
                Deshabilitado(
                    this,
                    EventArgs.Empty);
            }
        }

        public ReporteadorUcEliminar()
        {
            InitializeComponent();

            _Controlador =
                new ClsModeloBtnEliminarReporteador();

            ReporteadorBtnEliminar.Click +=
                ReporteadorBtnEliminar_Click;
        }

        protected override void OnLoad(EventArgs E)
        {
            base.OnLoad(E);

            if (DesignMode)
            {
                return;
            }

            ReporteadorMetBuscarControles();

            if (GridReportes != null)
            {
                GridReportes.DataBindingComplete +=
                    ReporteadorMetGridDataBindingComplete;

                GridReportes.SelectionChanged +=
                    ReporteadorMetGridSelectionChanged;

                ReporteadorMetMarcarFilasDeshabilitadas();

                ReporteadorMetActualizarBloqueoCampos();
            }
        }

        private void ReporteadorMetBuscarControles()
        {
            if (GridReportes == null)
            {
                GridReportes =
                    ReporteadorMetBuscarControl<DataGridView>(
                        NombreGridReportes);
            }

            if (TxtNombreReporte == null)
            {
                TxtNombreReporte =
                    ReporteadorMetBuscarControl<TextBox>(
                        NombreTxtNombreReporte);
            }

            if (TxtRutaReporte == null)
            {
                TxtRutaReporte =
                    ReporteadorMetBuscarControl<TextBox>(
                        NombreTxtRutaReporte);
            }
        }

        private T ReporteadorMetBuscarControl<T>(
            string Nombre)
            where T : Control
        {
            try
            {
                Form Contenedor =
                    FindForm();

                if (Contenedor == null ||
                    string.IsNullOrWhiteSpace(Nombre))
                {
                    return null;
                }

                Control[] Encontrados =
                    Contenedor.Controls.Find(
                        Nombre,
                        true);

                foreach (
                    Control ControlEncontrado
                    in Encontrados)
                {
                    T ControlTipado =
                        ControlEncontrado as T;

                    if (ControlTipado != null)
                    {
                        return ControlTipado;
                    }
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void ReporteadorBtnEliminar_Click(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetDeshabilitarSeleccionado();
        }

        public void ReporteadorMetDeshabilitarSeleccionado()
        {
            try
            {
                ReporteadorMetBuscarControles();

                if (GridReportes == null)
                {
                    ReporteadorMetMostrarError(
                        "No se encontró la tabla de " +
                        "reportes en el formulario.");

                    return;
                }

                DataGridViewRow Fila =
                    GridReportes.CurrentRow;

                if (Fila == null ||
                    Fila.IsNewRow)
                {
                    ReporteadorMetMostrarError(
                        "Seleccione el reporte que desea " +
                        "deshabilitar.");

                    return;
                }

                object ValorNumero =
                    ReporteadorMetObtenerValor(
                        Fila,
                        ColumnaNumeroReporte);

                int NumeroReporte;

                if (ValorNumero == null ||
                    !int.TryParse(
                        ValorNumero.ToString(),
                        out NumeroReporte))
                {
                    ReporteadorMetMostrarError(
                        "No se pudo leer el número del " +
                        "reporte seleccionado.");

                    return;
                }

                object ValorNombre =
                    ReporteadorMetObtenerValor(
                        Fila,
                        ColumnaNombreReporte);

                string NombreReporte =
                    ValorNombre == null
                    ? string.Empty
                    : ValorNombre.ToString();

                string Pregunta =
                    "¿Está seguro que desea deshabilitar " +
                    "este reporte?" +
                    Environment.NewLine +
                    Environment.NewLine +
                    "Número: " +
                    NumeroReporte +
                    Environment.NewLine +
                    "Nombre: " +
                    NombreReporte +
                    Environment.NewLine +
                    Environment.NewLine +
                    "El reporte no se eliminará de la " +
                    "base de datos. Quedará marcado " +
                    "como inactivo y sus campos no " +
                    "podrán editarse.";

                if (!ReporteadorMetMostrarConfirmacion(
                    Pregunta))
                {
                    return;
                }

                string Mensaje =
                    _Controlador
                    .ReporteadorMetDeshabilitar(
                        NumeroReporte);

                if (string.IsNullOrWhiteSpace(
                    Mensaje))
                {
                    ReporteadorMetMostrarExito(
                        "El reporte se deshabilitó " +
                        "correctamente.");

                    ReporteadorMetRecargarTabla();

                    ReporteadorMetMarcarFilasDeshabilitadas();

                    ReporteadorMetActualizarBloqueoCampos();

                    ReporteadorMetOnDeshabilitado();

                    return;
                }

                ReporteadorMetMostrarError(
                    Mensaje);
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "Ocurrió un error inesperado al " +
                    "deshabilitar el reporte.");
            }
        }

        private void ReporteadorMetActualizarBloqueoCampos()
        {
            try
            {
                if (GridReportes == null)
                {
                    return;
                }

                DataGridViewRow Fila =
                    GridReportes.CurrentRow;

                bool Bloquear = false;

                if (Fila != null &&
                    !Fila.IsNewRow)
                {
                    object Valor =
                        ReporteadorMetObtenerValor(
                            Fila,
                            ColumnaNumeroReporte);

                    int Numero;

                    if (Valor != null &&
                        int.TryParse(
                            Valor.ToString(),
                            out Numero))
                    {
                        Bloquear =
                            _Controlador
                            .ReporteadorMetEstaDeshabilitado(
                                Numero);
                    }
                }

                if (TxtNombreReporte != null)
                {
                    TxtNombreReporte.Enabled =
                        !Bloquear;
                }

                if (TxtRutaReporte != null)
                {
                    TxtRutaReporte.Enabled =
                        !Bloquear;
                }

                ReporteadorMetActualizarBloqueoBotones(
                    Bloquear);
            }
            catch (Exception)
            {
            }
        }

        private void ReporteadorMetActualizarBloqueoBotones(
            bool Bloquear)
        {
            Form Contenedor =
                FindForm();

            if (Contenedor == null)
            {
                return;
            }

            ReporteadorMetActualizarBotonesRecursivo(
                Contenedor.Controls,
                Bloquear);
        }

        private void ReporteadorMetActualizarBotonesRecursivo(
            Control.ControlCollection Controles,
            bool Bloquear)
        {
            foreach (Control ControlActual
                     in Controles)
            {
                bool EsBoton =
                    ControlActual is Button ||
                    (
                        ControlActual is UserControl &&
                        (
                            ControlActual.Name.Contains("Btn") ||
                            ControlActual.Name.Contains(
                                "Reporteador")
                        )
                    );

                if (EsBoton &&
                    ControlActual != this)
                {
                    string NombreControl =
                        ControlActual.Name.ToLower();

                    bool EsPermitido =
                        NombreControl.Contains("buscar") ||
                        NombreControl.Contains("busqueda") ||
                        NombreControl.Contains("filtro") ||
                        NombreControl.Contains("aplicar") ||
                        NombreControl.Contains("filter") ||
                        NombreControl.Contains("search") ||
                        NombreControl.Contains("refrescar") ||
                        NombreControl.Contains("refresh") ||
                        NombreControl.Contains("actualizar");

                    if (EsPermitido)
                    {
                        ControlActual.Enabled = true;
                    }
                    else
                    {
                        ControlActual.Enabled =
                            !Bloquear;
                    }
                }

                if (ControlActual.HasChildren)
                {
                    ReporteadorMetActualizarBotonesRecursivo(
                        ControlActual.Controls,
                        Bloquear);
                }
            }
        }

        private void ReporteadorMetMarcarFilasDeshabilitadas()
        {
            try
            {
                if (GridReportes == null)
                {
                    return;
                }

                HashSet<int> Deshabilitados =
                    new HashSet<int>(
                        _Controlador
                        .ReporteadorMetObtenerNumerosDeshabilitados());

                Font FuenteNormal =
                    GridReportes.DefaultCellStyle.Font
                    ?? GridReportes.Font;

                Font FuenteCursiva =
                    new Font(
                        FuenteNormal,
                        FontStyle.Italic);

                foreach (
                    DataGridViewRow Fila
                    in GridReportes.Rows)
                {
                    if (Fila.IsNewRow)
                    {
                        continue;
                    }

                    object Valor =
                        ReporteadorMetObtenerValor(
                            Fila,
                            ColumnaNumeroReporte);

                    int Numero;

                    bool EstaDeshabilitado =
                        Valor != null &&
                        int.TryParse(
                            Valor.ToString(),
                            out Numero) &&
                        Deshabilitados.Contains(Numero);

                    if (EstaDeshabilitado)
                    {
                        Fila.DefaultCellStyle.BackColor =
                            Color.Gainsboro;

                        Fila.DefaultCellStyle.ForeColor =
                            Color.DimGray;

                        Fila.DefaultCellStyle.Font =
                            FuenteCursiva;
                    }
                    else
                    {
                        Fila.DefaultCellStyle.BackColor =
                            Color.Empty;

                        Fila.DefaultCellStyle.ForeColor =
                            Color.Empty;

                        Fila.DefaultCellStyle.Font =
                            null;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private object ReporteadorMetObtenerValor(
            DataGridViewRow Fila,
            string NombreColumna)
        {
            if (Fila == null ||
                string.IsNullOrWhiteSpace(
                    NombreColumna))
            {
                return null;
            }

            if (Fila.DataGridView == null ||
                !Fila.DataGridView.Columns.Contains(
                    NombreColumna))
            {
                return null;
            }

            return Fila.Cells[
                NombreColumna].Value;
        }

        private void ReporteadorMetRecargarTabla()
        {
            try
            {
                Form Contenedor =
                    FindForm();

                if (Contenedor == null ||
                    string.IsNullOrWhiteSpace(
                        MetodoRecargar))
                {
                    return;
                }

                MethodInfo Metodo =
                    Contenedor.GetType().GetMethod(
                        MetodoRecargar,
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.Instance,
                        null,
                        Type.EmptyTypes,
                        null);

                if (Metodo != null)
                {
                    Metodo.Invoke(
                        Contenedor,
                        null);

                    return;
                }

                if (GridReportes != null)
                {
                    GridReportes.Refresh();
                }
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "El reporte se deshabilitó, pero no " +
                    "se pudo refrescar la tabla.");
            }
        }

        private void ReporteadorMetMostrarExito(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Operación exitosa",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ReporteadorMetMostrarError(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private bool ReporteadorMetMostrarConfirmacion(
            string Mensaje)
        {
            DialogResult Resultado =
                MessageBox.Show(
                    Mensaje,
                    "Confirmar deshabilitación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

            return Resultado == DialogResult.Yes;
        }

        private void ReporteadorMetGridDataBindingComplete(
            object Sender,
            DataGridViewBindingCompleteEventArgs E)
        {
            ReporteadorMetMarcarFilasDeshabilitadas();
            ReporteadorMetActualizarBloqueoCampos();
        }

        private void ReporteadorMetGridSelectionChanged(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetActualizarBloqueoCampos();
        }
    }
}