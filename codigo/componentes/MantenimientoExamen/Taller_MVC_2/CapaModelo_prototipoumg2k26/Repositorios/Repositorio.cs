using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    public abstract class Repositorio
    {
        public readonly string connectionString;
        public Repositorio()
        {
            connectionString = "Dsn=bd_proyectonominasfin";
        }
        protected OdbcConnection ObtenerConexion()
        {
            return new OdbcConnection(connectionString);
        }
    }
}
