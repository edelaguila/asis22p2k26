using System;
using System.Diagnostics;
using System.IO;

namespace CapaModelo_BtnImprimir.Repositorios
{
    public class ClsRepositorioBtnImprimir
    {
        public bool ImprimirPdf(
            string rutaArchivo,
            out string mensajeError)
        {
            mensajeError = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(rutaArchivo))
                {
                    mensajeError =
                        "No se ha seleccionado un reporte.";

                    return false;
                }

                if (!File.Exists(rutaArchivo))
                {
                    mensajeError =
                        "El archivo del reporte no existe.";

                    return false;
                }

                if (!rutaArchivo.EndsWith(
                    ".pdf",
                    StringComparison.OrdinalIgnoreCase))
                {
                    mensajeError =
                        "El archivo seleccionado no es un PDF.";

                    return false;
                }

                ProcessStartInfo proceso =
                    new ProcessStartInfo();

                proceso.FileName = rutaArchivo;
                proceso.Verb = "print";
                proceso.UseShellExecute = true;
                proceso.CreateNoWindow = true;

                Process.Start(proceso);

                return true;
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;

                return false;
            }
        }
    }
}