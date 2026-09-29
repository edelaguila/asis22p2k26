using CapaModelo_Reporteador.Contratos;
using CapaModelo_Reporteador.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace CapaModelo_Reporteador.Repositorios
{
    public class ClsRepositorioReporteador
        : ClsIRepositorioReporteador
    {
        // CONEXIÓN


        private readonly string cadenaConexion =
            "Dsn=dbReporteador";



        // OBTENER MAXIMO NUMERO


        public int ObtenerMaximoNumeroReporte(
            int codigoModulo)
        {
            int maxId = 0;

            int limiteInferior =
                codigoModulo * 100;

            int limiteSuperior =
                limiteInferior + 99;

            string sql =
                @"SELECT MAX(numeroReporte)
                  FROM tblReporte
                  WHERE numeroReporte BETWEEN ? AND ?";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "limiteInferior",
                        limiteInferior
                    );

                    cmd.Parameters.AddWithValue(
                        "limiteSuperior",
                        limiteSuperior
                    );

                    object resultado =
                        cmd.ExecuteScalar();

                    if (resultado != null &&
                        resultado != DBNull.Value)
                    {
                        maxId =
                            Convert.ToInt32(resultado);
                    }
                }
            }

            return maxId;
        }


        // AGREGAR

        public void Agregar(
            ClsReporteador reporte)
        {
            string sql =
                @"INSERT INTO tblReporte
                  (
                      numeroReporte,
                      nombreReporte,
                      rutaReporte,
                      fechaReporte
                  )
                  VALUES (?, ?, ?, ?)";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "numeroReporte",
                        reporte.NumeroReporte
                    );

                    cmd.Parameters.AddWithValue(
                        "nombreReporte",
                        reporte.NombreReporte
                    );

                    cmd.Parameters.AddWithValue(
                        "rutaReporte",
                        reporte.RutaReporte
                    );

                    cmd.Parameters.AddWithValue(
                        "fechaReporte",
                        reporte.FechaReporte.Date
                    );

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // EDITAR

        public void Editar(
            ClsReporteador reporte)
        {
            string sql =
                @"UPDATE tblReporte
                  SET
                      nombreReporte = ?,
                      rutaReporte = ?,
                      fechaReporte = ?
                  WHERE numeroReporte = ?";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "nombreReporte",
                        reporte.NombreReporte
                    );

                    cmd.Parameters.AddWithValue(
                        "rutaReporte",
                        reporte.RutaReporte
                    );

                    cmd.Parameters.AddWithValue(
                        "fechaReporte",
                        reporte.FechaReporte.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "numeroReporte",
                        reporte.NumeroReporte
                    );

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // ELIMINAR

        public void Remover(
            ClsReporteador reporte)
        {
            string sql =
                @"DELETE FROM tblReporte
                  WHERE numeroReporte = ?";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "numeroReporte",
                        reporte.NumeroReporte
                    );

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // OBTENER TODOS


        public IEnumerable<ClsReporteador>
            GetAll()
        {
            List<ClsReporteador> lista =
                new List<ClsReporteador>();

            string sql =
                @"SELECT
                      numeroReporte,
                      nombreReporte,
                      rutaReporte,
                      fechaReporte
                  FROM tblReporte
                  ORDER BY numeroReporte";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    using (OdbcDataReader reader =
                           cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new ClsReporteador
                                {
                                    NumeroReporte =
                                        Convert.ToInt32(
                                            reader["numeroReporte"]
                                        ),

                                    NombreReporte =
                                        reader[
                                            "nombreReporte"
                                        ].ToString(),

                                    RutaReporte =
                                        reader[
                                            "rutaReporte"
                                        ].ToString(),

                                    FechaReporte =
                                        Convert.ToDateTime(
                                            reader[
                                                "fechaReporte"
                                            ]
                                        )
                                }
                            );
                        }
                    }
                }
            }

            return lista;
        }



        // BUSCAR POR NOMBRE

        public IEnumerable<ClsReporteador>
            BuscarPorNombre(string filtro)
        {
            List<ClsReporteador> lista =
                new List<ClsReporteador>();

            string sql =
                @"SELECT
                      numeroReporte,
                      nombreReporte,
                      rutaReporte,
                      fechaReporte
                  FROM tblReporte
                  WHERE nombreReporte LIKE ?
                  ORDER BY numeroReporte";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "nombreReporte",
                        "%" + filtro + "%"
                    );

                    using (OdbcDataReader reader =
                           cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new ClsReporteador
                                {
                                    NumeroReporte =
                                        Convert.ToInt32(
                                            reader["numeroReporte"]
                                        ),

                                    NombreReporte =
                                        reader[
                                            "nombreReporte"
                                        ].ToString(),

                                    RutaReporte =
                                        reader[
                                            "rutaReporte"
                                        ].ToString(),

                                    FechaReporte =
                                        Convert.ToDateTime(
                                            reader[
                                                "fechaReporte"
                                            ]
                                        )
                                }
                            );
                        }
                    }
                }
            }

            return lista;
        }


        // BUSCAR POR FECHA

        public IEnumerable<ClsReporteador>
            BuscarPorFecha(DateTime fecha)
        {
            List<ClsReporteador> lista =
                new List<ClsReporteador>();

            string sql =
                @"SELECT
                      numeroReporte,
                      nombreReporte,
                      rutaReporte,
                      fechaReporte
                  FROM tblReporte
                  WHERE fechaReporte = ?
                  ORDER BY numeroReporte";

            using (OdbcConnection conn =
                   new OdbcConnection(cadenaConexion))
            {
                conn.Open();

                using (OdbcCommand cmd =
                       new OdbcCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(
                        "fechaReporte",
                        fecha.Date
                    );

                    using (OdbcDataReader reader =
                           cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new ClsReporteador
                                {
                                    NumeroReporte =
                                        Convert.ToInt32(
                                            reader["numeroReporte"]
                                        ),

                                    NombreReporte =
                                        reader[
                                            "nombreReporte"
                                        ].ToString(),

                                    RutaReporte =
                                        reader[
                                            "rutaReporte"
                                        ].ToString(),

                                    FechaReporte =
                                        Convert.ToDateTime(
                                            reader[
                                                "fechaReporte"
                                            ]
                                        )
                                }
                            );
                        }
                    }
                }
            }

            return lista;
        }
    }
}