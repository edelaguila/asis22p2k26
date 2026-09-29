using System.Data.Odbc;

namespace CapaModelo_BtnBusqueda.Repositorios
{
    public abstract class ClsRepositorio
    {
        private readonly string _CadenaConexion;

        protected ClsRepositorio()
        {
            _CadenaConexion =
                "Dsn=dbreporteador";
        }

        protected OdbcConnection
            ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(
                _CadenaConexion);
        }
    }
}