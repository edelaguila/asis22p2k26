/*
    bRIAN ANDREE DE LA CRUZ
 */
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using CapaControlador_BtnLimpiar_Reporteador;

namespace CapaVista_BtnLimpiar_Reporteador
{
    [ToolboxItem(true)]
    [Description(
        "Botón reutilizable para limpiar los campos del reporte.")]
    public partial class ReporteadorUcLimpiar
        : UserControl
    {
        // =========================================================
        // CONTROLADOR
        // =========================================================

        private readonly ClsModeloBtnLimpiarReporteador
            _Controlador;

        // =========================================================
        // CONFIGURACIÓN
        // =========================================================

        [Category("Reporteador")]
        [DefaultValue("LimpiarFormulario")]
        public string MetodoLimpiarFormulario
        {
            get;
            set;
        } = "LimpiarFormulario";

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public ReporteadorUcLimpiar()
        {
            InitializeComponent();

            _Controlador =
                new ClsModeloBtnLimpiarReporteador();

            // Conecta el botón interno del UserControl
            // con el método de limpieza.
            ReporteadorMetConectarEvento();
        }

        // =========================================================
        // CONECTAR EVENTO
        // =========================================================

        private void ReporteadorMetConectarEvento()
        {
            ReporteadorBtnLimpiar.Click +=
                ReporteadorMetLimpiarClick;
        }

        // =========================================================
        // EVENTO DEL BOTÓN
        // =========================================================

        private void ReporteadorMetLimpiarClick(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetEjecutarLimpieza();
        }

        // =========================================================
        // EJECUTAR LIMPIEZA
        // =========================================================

        private void ReporteadorMetEjecutarLimpieza()
        {
            try
            {
                bool Resultado =
                    _Controlador
                    .ReporteadorMetEjecutarLimpieza(
                        out string Mensaje);

                // Si la operación del componente
                // no fue exitosa, mostrar el mensaje.
                if (!Resultado)
                {
                    MessageBox.Show(
                        Mensaje,
                        "Limpiar formulario",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =================================================
                // LIMPIAR FORMULARIO PRINCIPAL
                // =================================================

                ReporteadorMetInvocarLimpiarFormulario();

                // Mostrar confirmación después de limpiar.
                MessageBox.Show(
                    Mensaje,
                    "Limpiar formulario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar " +
                    "limpiar el formulario.",
                    "Limpiar formulario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // INVOCAR MÉTODO DEL FORMULARIO
        // =========================================================

        private void
            ReporteadorMetInvocarLimpiarFormulario()
        {
            Form Contenedor =
                FindForm();

            if (Contenedor == null)
            {
                throw new InvalidOperationException();
            }

            if (string.IsNullOrWhiteSpace(
                MetodoLimpiarFormulario))
            {
                throw new InvalidOperationException();
            }

            // Busca el método LimpiarFormulario()
            // dentro de FrmReportes.
            MethodInfo Metodo =
                Contenedor.GetType().GetMethod(
                    MetodoLimpiarFormulario,
                    BindingFlags.Public |
                    BindingFlags.NonPublic |
                    BindingFlags.Instance,
                    null,
                    Type.EmptyTypes,
                    null);

            if (Metodo == null)
            {
                throw new MissingMethodException();
            }

            // Ejecuta FrmReportes.LimpiarFormulario().
            Metodo.Invoke(
                Contenedor,
                null);
        }
    }
}