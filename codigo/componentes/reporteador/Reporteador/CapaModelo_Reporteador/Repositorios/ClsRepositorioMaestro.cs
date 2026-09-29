using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Reporteador.Repositorios
{
    public abstract class ClsRepositorioMaestro : ClsRepositorio
    {
        protected int EjecucionNonQuery(
            string comandoTexto,
            List<OdbcParameter> parametros,
            CommandType comandoTipo)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new OdbcCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = comandoTexto;
                    comando.CommandType = comandoTipo;

                    if (parametros != null && parametros.Count > 0)
                    {
                        comando.Parameters.AddRange(parametros.ToArray());
                    }

                    return comando.ExecuteNonQuery();
                }
            }
        }

        protected DataTable EjecucionConsulta(
            string comandoTexto,
            List<OdbcParameter> parametros = null,
            CommandType comandoTipo = CommandType.Text)
        {
            DataTable tabla = new DataTable();

            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new OdbcCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = comandoTexto;
                    comando.CommandType = comandoTipo;

                    if (parametros != null && parametros.Count > 0)
                    {
                        comando.Parameters.AddRange(parametros.ToArray());
                    }

                    using (var reader = comando.ExecuteReader())
                    {
                        tabla.Load(reader);
                    }
                }
            }

            return tabla;
        }
    }
}