using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaModelo_BtnGuardar.Repositorios
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