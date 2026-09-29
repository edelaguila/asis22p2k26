using System;
using System.Diagnostics;
using System.IO;

namespace CapaModelo_BtnImprimir_Reporteador.Repositorios
{
    public class ClsRepositorioBtnImprimir
    {
        public bool ReporteadorMetImprimirPdf(
            string RutaArchivo,
            out string MensajeError)
        {
            MensajeError = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(
                    RutaArchivo))
                {
                    MensajeError =
                        "No se ha seleccionado " +
                        "un reporte.";

                    return false;
                }

                if (!File.Exists(RutaArchivo))
                {
                    MensajeError =
                        "El archivo del reporte " +
                        "no existe.";

                    return false;
                }

                if (!RutaArchivo.EndsWith(
                    ".pdf",
                    StringComparison.OrdinalIgnoreCase))
                {
                    MensajeError =
                        "El archivo seleccionado " +
                        "no es un PDF.";

                    return false;
                }

                ProcessStartInfo Proceso =
                    new ProcessStartInfo();

                Proceso.FileName =
                    RutaArchivo;

                Proceso.Verb =
                    "print";

                Proceso.UseShellExecute =
                    true;

                Proceso.CreateNoWindow =
                    true;

                Process.Start(Proceso);

                return true;
            }
            catch (FileNotFoundException)
            {
                MensajeError =
                    "No se encontró el archivo " +
                    "del reporte.";

                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MensajeError =
                    "No se tiene permiso para " +
                    "imprimir el reporte.";

                return false;
            }
            catch (InvalidOperationException)
            {
                MensajeError =
                    "No se pudo iniciar la impresión " +
                    "del reporte.";

                return false;
            }
            catch (Exception)
            {
                MensajeError =
                    "Ocurrió un error al intentar " +
                    "imprimir el reporte.";

                return false;
            }
        }
    }
}