using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    public class RepositorioComboI : Repositorio
    {
        public DataTable obtenerDatos(string _tabla, string _campo1, string _campo2)
        {
            string sql = "SELECT " + _campo1 + ", " + _campo2 +
                         " FROM " + _tabla + ";";

            OdbcCommand command = new OdbcCommand(sql, ObtenerConexion());
            OdbcDataAdapter adapter = new OdbcDataAdapter(command);

            DataTable dtDatos = new DataTable();
            adapter.Fill(dtDatos);

            return dtDatos;
        }
    }
}