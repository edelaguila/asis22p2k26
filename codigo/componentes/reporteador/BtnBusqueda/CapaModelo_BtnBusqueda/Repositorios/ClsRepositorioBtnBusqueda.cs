using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnBusqueda.Repositorios
{
    public class ClsRepositorioBtnBusqueda : ClsRepositorio
    {
        public DataTable BuscarReportes(
            string nombreReporte,
            DateTime? fechaReporte,
            bool buscarPorNombre,
            bool buscarPorFecha)
        {
            DataTable tabla = new DataTable();

            string query = @"
                SELECT
                    numeroReporte,
                    nombreReporte,
                    rutaReporte,
                    fechaReporte
                FROM tblReporte
                WHERE 1 = 1";

            if (buscarPorNombre)
            {
                query += " AND nombreReporte LIKE ?";
            }

            if (buscarPorFecha)
            {
                query += " AND fechaReporte = ?";
            }

            query += " ORDER BY numeroReporte";

            using (OdbcConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                using (OdbcCommand comando = new OdbcCommand(query, conexion))
                {
                    if (buscarPorNombre)
                    {
                        comando.Parameters.Add(
                            new OdbcParameter(
                                "p_nombreReporte",
                                "%" + nombreReporte + "%"
                            )
                        );
                    }

                    if (buscarPorFecha && fechaReporte.HasValue)
                    {
                        comando.Parameters.Add(
                            new OdbcParameter(
                                "p_fechaReporte",
                                fechaReporte.Value.Date
                            )
                        );
                    }

                    using (OdbcDataAdapter adaptador =
                        new OdbcDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }
    }
}