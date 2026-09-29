using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Consultas
{
    internal class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=umg_didactica");
            try
            {
                conn.Open();
            }
            catch (OdbcException e)
            {
                Console.WriteLine("Conexion fallida. Error: " + e.Message);
            }
            return conn;
        }

        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException e)
            {
                Console.WriteLine("Error al cerrar la conexión. Error: " + e.Message);
            }
        }
    }
}
