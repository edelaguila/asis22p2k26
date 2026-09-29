using System.Data.Odbc;

namespace CapaModelo_BtnVerReporte_Reporteador.Repositorios
{
    public abstract class ClsRepositorio
    {
        private readonly string _CadenaConexion;

        public ClsRepositorio()
        {
            _CadenaConexion = "Dsn=dbReporteador";
        }

        // OBTENER LA CONEXION ODBC CONFIGURADA PARA EL REPORTEADOR
        protected OdbcConnection ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(_CadenaConexion);
        }
    }
}
