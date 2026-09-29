using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    public abstract class RepositorioMaestro : Repositorio
    {
        private DataTable dtTablaDatos; // Establece la tabla de datos para las consultas
        public int EjecucionNonQuery(string _comandoTexto, List<OdbcParameter> _parametros, CommandType _comandoTipo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comandoTexto;
                    ocComando.CommandType = _comandoTipo;
                    ocComando.Parameters.AddRange(_parametros.ToArray()); // Agregar la colecciòn de paràmetros
                    return ocComando.ExecuteNonQuery();
                }
            }
        }
        public DataTable EjecucionConsulta (string _comandoTexto, CommandType _comandoTipo)
        {
            dtTablaDatos = new DataTable();
            using (var conexion = ObtenerConexion()) //Obtener conexion a la BD
            {
                conexion.Open();
                using (var ocComando = new OdbcCommand())
                {
                    ocComando.Connection = conexion;
                    ocComando.CommandText = _comandoTexto;
                    ocComando.CommandType = _comandoTipo;
                    using (var reader = ocComando.ExecuteReader())
                        dtTablaDatos.Load(reader);  //Llenar la tabla de datos 
                }
                return dtTablaDatos; // retorno de la tabla de datos
            }
        }
    }
}
