using CapaModelo_BtnImprimir.Repositorios;

namespace CapaControlador_BtnImprimir
{
    public class ClsModeloBtnImprimir
    {
        private readonly ClsRepositorioBtnImprimir repositorio;

        public ClsModeloBtnImprimir()
        {
            repositorio =
                new ClsRepositorioBtnImprimir();
        }

        public bool EjecutarImpresion(
            string rutaReporte,
            out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(rutaReporte))
            {
                mensaje =
                    "Debe seleccionar un reporte para imprimir.";

                return false;
            }

            bool resultado =
                repositorio.ImprimirPdf(
                    rutaReporte,
                    out string error);

            if (resultado)
            {
                mensaje =
                    "El reporte fue enviado a impresión.";

                return true;
            }

            mensaje = error;

            return false;
        }
    }
}