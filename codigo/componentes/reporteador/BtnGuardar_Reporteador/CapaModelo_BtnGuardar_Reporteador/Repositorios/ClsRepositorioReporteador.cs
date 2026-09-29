using System.Data.Odbc;

namespace CapaModelo_BtnGuardar_Reporteador.Repositorios
{
    public abstract class ClsRepositorioReporteador
    {
        protected readonly string _CadenaConexion;

        protected ClsRepositorioReporteador()
        {
            _CadenaConexion =
                "Dsn=dbreporteador";
        }

        protected OdbcConnection ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(
                _CadenaConexion);
        }
    }
}