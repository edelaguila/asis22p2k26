using System.Data.Odbc;

namespace CapaModelo_BtnEditar_Reporteador.Repositorios
{
    public abstract class ClsRepositorioReporteador
    {
        private readonly string _CadenaConexion;

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