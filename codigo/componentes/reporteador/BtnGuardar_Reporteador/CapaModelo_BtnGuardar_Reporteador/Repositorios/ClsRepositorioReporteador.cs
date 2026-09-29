using System.Data.Odbc;

namespace CapaModelo_BtnGuardar_Reporteador.Repositorios
{
    public abstract class ClsRepositorioReporteador
    {
        protected readonly string _CadenaConexion;

        protected ClsRepositorioReporteador()
        {
            _CadenaConexion =
                "Dsn=EmbutidosS.A";
        }

        protected OdbcConnection ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(
                _CadenaConexion);
        }
    }
}