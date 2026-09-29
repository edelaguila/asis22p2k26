using CapaModelo_BtnVerReporte_Reporteador.Contratos;
using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnVerReporte_Reporteador.Repositorios
{
    public class ClsRepositorioBtnVerReporte : ClsRepositorioMaestroBtnVerReporte, IRepositorioBtnVerReporte
    {
        // BUSCAR EN LA BASE DE DATOS LA RUTA DEL REPORTE SOLICITADO
        public string ReporteadorMetObtenerRutaReporte(int NumeroReporte)
        {
            string ConsultaRutaReporte = "SELECT rutaReporte FROM tblReporte WHERE numeroReporte = ?";

            object ResultadoConsulta = ReporteadorMetEjecutarConsultaEscalar(ConsultaRutaReporte, CommandType.Text, new OdbcParameter("numeroReporte", NumeroReporte));

            if (ResultadoConsulta == null || ResultadoConsulta == DBNull.Value)
            {
                return string.Empty;
            }

            return ResultadoConsulta.ToString();
        }
    }
}
