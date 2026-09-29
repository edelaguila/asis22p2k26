using CapaModelo_BtnRuta_Reporteador;

namespace CapaControlador_BtnRuta_Reporteador
{
    public class ClsControladorBtnRutaReporteador
    {
        // Referencia al modelo encargado de validar la ruta.
        private readonly ClsModeloBtnRutaReporteador
            _Modelo;

        public ClsControladorBtnRutaReporteador()
        {
            _Modelo =
                new ClsModeloBtnRutaReporteador();
        }

        // Valida que la ruta corresponda a un archivo PDF existente.
        public bool ReporteadorMetValidarRuta(
            string RutaReporte,
            out string Mensaje)
        {
            return _Modelo.ReporteadorMetValidarRuta(
                RutaReporte,
                out Mensaje);
        }
    }
}