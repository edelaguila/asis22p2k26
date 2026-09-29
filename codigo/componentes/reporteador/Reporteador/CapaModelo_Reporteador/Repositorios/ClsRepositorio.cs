using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Odbc;


namespace CapaModelo_Reporteador.Repositorios
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