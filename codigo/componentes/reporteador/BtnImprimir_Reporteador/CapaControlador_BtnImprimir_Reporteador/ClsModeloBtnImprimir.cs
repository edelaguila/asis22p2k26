using CapaModelo_BtnImprimir_Reporteador.Repositorios;

namespace CapaControlador_BtnImprimir_Reporteador
{
    public class ClsModeloBtnImprimir
    {
        private readonly ClsRepositorioBtnImprimir
            _Repositorio;

        public ClsModeloBtnImprimir()
        {
            _Repositorio =
                new ClsRepositorioBtnImprimir();
        }

        public bool ReporteadorMetEjecutarImpresion(
            string RutaReporte,
            out string Mensaje)
        {
            if (string.IsNullOrWhiteSpace(
                RutaReporte))
            {
                Mensaje =
                    "Debe seleccionar un reporte " +
                    "para imprimir.";

                return false;
            }

            bool Resultado =
                _Repositorio.ReporteadorMetImprimirPdf(
                    RutaReporte,
                    out string MensajeError);

            if (Resultado)
            {
                Mensaje =
                    "El reporte fue enviado a impresión.";

                return true;
            }

            if (string.IsNullOrWhiteSpace(
                MensajeError))
            {
                Mensaje =
                    "No se pudo enviar el reporte " +
                    "a impresión.";
            }
            else
            {
                Mensaje = MensajeError;
            }

            return false;
        }
    }
}