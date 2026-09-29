using System.Data.Odbc;

namespace CapaModelo_Reporteador.Repositorios
{
    /// <summary>
    /// Repositorio base del componente Reporteador.
    /// Contiene la configuración general de conexión.
    /// </summary>
    public abstract class ClsRepositorio
    {
        // =========================================================
        // CADENA DE CONEXIÓN
        // =========================================================

        private readonly string
            _CadenaConexion;

        protected ClsRepositorio()
        {
            _CadenaConexion =
                "Dsn=dbreporteador";
        }

        // =========================================================
        // OBTENER CONEXIÓN
        // =========================================================

        /// <summary>
        /// Crea una conexión ODBC utilizando el DSN
        /// configurado para Reporteador.
        /// </summary>
        protected OdbcConnection
            ReporteadorMetObtenerConexion()
        {
            return new OdbcConnection(
                _CadenaConexion);
        }
    }
}