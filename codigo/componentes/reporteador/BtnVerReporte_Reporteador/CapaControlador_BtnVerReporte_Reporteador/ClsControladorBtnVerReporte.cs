using CapaModelo_BtnVerReporte_Reporteador.Repositorios;

namespace CapaControlador_BtnVerReporte_Reporteador
{
    public class ClsControladorBtnVerReporte
    {
        private readonly ClsRepositorioBtnVerReporte _Repositorio;

        public ClsControladorBtnVerReporte()
        {
            _Repositorio = new ClsRepositorioBtnVerReporte();
        }

        // SOLICITAR AL MODELO LA RUTA ASOCIADA AL NUMERO DE REPORTE
        public string ReporteadorMetObtenerRutaReporte(int NumeroReporte)
        {
            return _Repositorio.ReporteadorMetObtenerRutaReporte(NumeroReporte);
        }
    }
}
