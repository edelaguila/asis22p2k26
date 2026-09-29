/*
    BRAYAN MOISES PINZON LOPEZ
 */

using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace CapaVista_BtnEditar_Reporteador
{
    public partial class ReporteadorUcEditar : UserControl
    {
        public TextBox ReporteadorTxtNombreReporte
        {
            get;
            set;
        }

        public TextBox ReporteadorTxtRutaReporte
        {
            get;
            set;
        }

        [Category("Reporteador")]
        [DefaultValue("BtnEditar_Click")]
        public string MetodoEditarFormulario
        {
            get;
            set;
        } = "BtnEditar_Click";

        public ReporteadorUcEditar()
        {
            InitializeComponent();

            ReporteadorBtnEditar.Click +=
                ReporteadorBtnEditar_Click;
        }

        private void ReporteadorBtnEditar_Click(
            object Sender,
            EventArgs E)
        {
            ReporteadorMetInvocarEditarFormulario();
        }

        private void ReporteadorMetInvocarEditarFormulario()
        {
            try
            {
                Form Contenedor =
                    FindForm();

                if (Contenedor == null)
                {
                    ReporteadorMetMostrarError(
                        "No se encontró el formulario para editar el reporte.");

                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    MetodoEditarFormulario))
                {
                    ReporteadorMetMostrarError(
                        "No se configuró el método de edición.");

                    return;
                }

                MethodInfo Metodo =
                    Contenedor.GetType().GetMethod(
                        MetodoEditarFormulario,
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.Instance,
                        null,
                        new[]
                        {
                            typeof(object),
                            typeof(EventArgs)
                        },
                        null);

                if (Metodo != null)
                {
                    Metodo.Invoke(
                        Contenedor,
                        new object[]
                        {
                            Contenedor,
                            EventArgs.Empty
                        });

                    return;
                }

                Metodo =
                    Contenedor.GetType().GetMethod(
                        MetodoEditarFormulario,
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

                ReporteadorMetMostrarError(
                    "No se encontró el método de edición configurado.");
            }
            catch (TargetInvocationException)
            {
                ReporteadorMetMostrarError(
                    "Ocurrió un error al preparar la edición del reporte.");
            }
            catch (Exception)
            {
                ReporteadorMetMostrarError(
                    "Ocurrió un error al preparar la edición del reporte.");
            }
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
    }
}