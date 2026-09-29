using System;

namespace CapaModelo_BtnLimpiar_Reporteador
    .RepositoriosBtnLimpiarReporteador
{
    public class ClsRepositorioBtnLimpiarReporteador
    {
        public bool ReporteadorMetLimpiarDatos(
            out string MensajeError)
        {
            MensajeError =
                string.Empty;

            try
            {
                return true;
            }
            catch (Exception)
            {
                MensajeError =
                    "Ocurrió un error al limpiar " +
                    "los datos del formulario.";

                return false;
            }
        }
    }
}