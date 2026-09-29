/*
 * Brian Andre de la Cruz Sosa
 */
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
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

                if (!Resultado)
                {
                    ReporteadorMetMostrarError(
                        Mensaje);

                    return;
                }

                ReporteadorMetInvocarLimpiarFormulario();

                ReporteadorMetMostrarExito(
                    "Los campos fueron limpiados correctamente.");
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "Ocurrió un error al intentar limpiar el formulario.");
            }
        }

        // =========================================================
        // MOSTRAR MENSAJE DE ÉXITO
        // =========================================================

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

        // =========================================================
        // MOSTRAR MENSAJE DE ERROR
        // =========================================================

        private void ReporteadorMetMostrarError(
            string Mensaje)
        {
            MessageBox.Show(
                Mensaje,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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