using System.Data.Odbc;

namespace CapaModelo_BtnBusqueda.Repositorios
{
    public abstract class ClsRepositorio
    {
        public readonly string connectionString;

        public ClsRepositorio()
        {
            connectionString = "Dsn=dbreporteador";
        }

        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(connectionString);
        }
    }
}