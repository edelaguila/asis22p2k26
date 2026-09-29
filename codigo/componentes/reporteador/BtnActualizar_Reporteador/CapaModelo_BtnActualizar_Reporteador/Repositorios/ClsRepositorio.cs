using System.Data.Odbc;

namespace CapaModelo_BtnActualizar.Repositorios
{
    public abstract class ClsRepositorio
    {
        private readonly string _CadenaConexion;

        protected ClsRepositorio()
        {
            _CadenaConexion = "Dsn=dbReporteador";
        }

        protected OdbcConnection ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(_CadenaConexion);
        }
    }
}