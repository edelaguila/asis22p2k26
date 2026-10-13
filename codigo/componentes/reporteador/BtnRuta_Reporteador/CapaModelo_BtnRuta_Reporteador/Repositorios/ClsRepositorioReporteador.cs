using System.Data.Odbc;

namespace CapaModelo_BtnRuta_Reporteador.Repositorios
{
    public abstract class ClsRepositorioReporteador
    {
        // Cadena utilizada para conectarse mediante el DSN
        // configurado para el componente Reporteador.
        protected readonly string _CadenaConexion;

        protected ClsRepositorioReporteador()
        {
            _CadenaConexion =
                "Dsn=dbreporteador";
        }

        // Crea la conexión ODBC para las operaciones
        // que necesiten acceso a la base de datos.
        protected OdbcConnection
            ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(
                _CadenaConexion);
        }
    }
}