using CapaModelo_Reporteador.Contratos;
using CapaModelo_Reporteador.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace CapaModelo_Reporteador.Repositorios
{
    public class ClsRepositorioReporteador
        : ClsRepositorio,
          ClsIRepositorioReporteador
    {
        public ClsRepositorioReporteador()
            : base()
        {
        }

        // ============================================================
        // OBTENER SIGUIENTE NÚMERO DE REPORTE
        // ============================================================

        public int ReporteadorMetObtenerMaximoNumeroReporte(
            int CodigoModulo)
        {
            int MaximoNumero = 0;

            int LimiteInferior =
                CodigoModulo * 100;

            int LimiteSuperior =
                LimiteInferior + 99;

            string Consulta = @"
                SELECT MAX(numeroReporte)
                FROM tblReporte
                WHERE numeroReporte BETWEEN ? AND ?";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_limiteInferior",
                            LimiteInferior));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_limiteSuperior",
                            LimiteSuperior));

                    object Resultado =
                        Comando.ExecuteScalar();

                    if (Resultado != null &&
                        Resultado != DBNull.Value)
                    {
                        MaximoNumero =
                            Convert.ToInt32(Resultado);
                    }
                }
            }

            return MaximoNumero;
        }

        // ============================================================
        // VERIFICAR NÚMERO
        // ============================================================

        public bool ReporteadorMetExisteNumeroReporte(
            int NumeroReporte,
            int? NumeroReporteExcluir = null)
        {
            try
            {
                string Consulta = @"
                    SELECT COUNT(*)
                    FROM tblReporte
                    WHERE numeroReporte = ?";

                if (NumeroReporteExcluir.HasValue)
                {
                    Consulta +=
                        " AND numeroReporte <> ?";
                }

                using (OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
                {
                    Conexion.Open();

                    using (OdbcCommand Comando =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_numeroReporte",
                                NumeroReporte));

                        if (NumeroReporteExcluir.HasValue)
                        {
                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "p_numeroReporteExcluir",
                                    NumeroReporteExcluir.Value));
                        }

                        int Cantidad =
                            Convert.ToInt32(
                                Comando.ExecuteScalar());

                        return Cantidad > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ============================================================
        // VERIFICAR NOMBRE
        // ============================================================

        public bool ReporteadorMetExisteNombreReporte(
            string NombreReporte,
            int? NumeroReporteExcluir = null)
        {
            try
            {
                string Consulta = @"
                    SELECT COUNT(*)
                    FROM tblReporte
                    WHERE LOWER(TRIM(nombreReporte))
                        = LOWER(TRIM(?))";

                if (NumeroReporteExcluir.HasValue)
                {
                    Consulta +=
                        " AND numeroReporte <> ?";
                }

                using (OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
                {
                    Conexion.Open();

                    using (OdbcCommand Comando =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_nombreReporte",
                                NombreReporte.Trim()));

                        if (NumeroReporteExcluir.HasValue)
                        {
                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "p_numeroReporteExcluir",
                                    NumeroReporteExcluir.Value));
                        }

                        int Cantidad =
                            Convert.ToInt32(
                                Comando.ExecuteScalar());

                        return Cantidad > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ============================================================
        // VERIFICAR RUTA
        // ============================================================

        public bool ReporteadorMetExisteRutaReporte(
            string RutaReporte,
            int? NumeroReporteExcluir = null)
        {
            try
            {
                string Consulta = @"
                    SELECT COUNT(*)
                    FROM tblReporte
                    WHERE LOWER(TRIM(rutaReporte))
                        = LOWER(TRIM(?))";

                if (NumeroReporteExcluir.HasValue)
                {
                    Consulta +=
                        " AND numeroReporte <> ?";
                }

                using (OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
                {
                    Conexion.Open();

                    using (OdbcCommand Comando =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_rutaReporte",
                                RutaReporte.Trim()));

                        if (NumeroReporteExcluir.HasValue)
                        {
                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "p_numeroReporteExcluir",
                                    NumeroReporteExcluir.Value));
                        }

                        int Cantidad =
                            Convert.ToInt32(
                                Comando.ExecuteScalar());

                        return Cantidad > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ============================================================
        // AGREGAR
        // ============================================================

        public void ReporteadorMetAgregar(
            ClsReporteador Reporte)
        {
            string Consulta = @"
                INSERT INTO tblReporte
                (
                    numeroReporte,
                    nombreReporte,
                    rutaReporte,
                    fechaReporte
                )
                VALUES
                (
                    ?,
                    ?,
                    ?,
                    ?
                )";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_numeroReporte",
                            Reporte.NumeroReporte));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_nombreReporte",
                            Reporte.NombreReporte));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_rutaReporte",
                            Reporte.RutaReporte));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_fechaReporte",
                            Reporte.FechaReporte.Date));

                    int FilasAfectadas =
                        Comando.ExecuteNonQuery();

                    if (FilasAfectadas <= 0)
                    {
                        throw new InvalidOperationException(
                            "No se pudo guardar el reporte.");
                    }
                }
            }
        }

        // ============================================================
        // EDITAR
        // ============================================================

        public void ReporteadorMetEditar(
            ClsReporteador Reporte)
        {
            string Consulta = @"
                UPDATE tblReporte
                SET
                    nombreReporte = ?,
                    rutaReporte = ?,
                    fechaReporte = ?
                WHERE numeroReporte = ?";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_nombreReporte",
                            Reporte.NombreReporte));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_rutaReporte",
                            Reporte.RutaReporte));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_fechaReporte",
                            Reporte.FechaReporte.Date));

                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_numeroReporte",
                            Reporte.NumeroReporte));

                    int FilasAfectadas =
                        Comando.ExecuteNonQuery();

                    if (FilasAfectadas <= 0)
                    {
                        throw new InvalidOperationException(
                            "No se encontró el reporte seleccionado.");
                    }
                }
            }
        }

        // ============================================================
        // ELIMINAR
        // ============================================================

        public void ReporteadorMetRemover(
            ClsReporteador Reporte)
        {
            string Consulta = @"
                DELETE FROM tblReporte
                WHERE numeroReporte = ?";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_numeroReporte",
                            Reporte.NumeroReporte));

                    Comando.ExecuteNonQuery();
                }
            }
        }

        // ============================================================
        // OBTENER TODOS
        // ============================================================

        public IEnumerable<ClsReporteador>
            ReporteadorMetObtenerTodos()
        {
            List<ClsReporteador> Lista =
                new List<ClsReporteador>();

            string Consulta = @"
                SELECT
                    numeroReporte,
                    nombreReporte,
                    rutaReporte,
                    fechaReporte
                FROM tblReporte
                ORDER BY numeroReporte";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    using (OdbcDataReader Lector =
                        Comando.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Lista.Add(
                                ReporteadorMetCrearEntidad(
                                    Lector));
                        }
                    }
                }
            }

            return Lista;
        }

        // ============================================================
        // BUSCAR POR NOMBRE
        // ============================================================

        public IEnumerable<ClsReporteador>
            ReporteadorMetBuscarPorNombre(
                string Filtro)
        {
            List<ClsReporteador> Lista =
                new List<ClsReporteador>();

            string Consulta = @"
                SELECT
                    numeroReporte,
                    nombreReporte,
                    rutaReporte,
                    fechaReporte
                FROM tblReporte
                WHERE nombreReporte LIKE ?
                ORDER BY numeroReporte";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_nombreReporte",
                            "%" + Filtro + "%"));

                    using (OdbcDataReader Lector =
                        Comando.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Lista.Add(
                                ReporteadorMetCrearEntidad(
                                    Lector));
                        }
                    }
                }
            }

            return Lista;
        }

        // ============================================================
        // BUSCAR POR FECHA
        // ============================================================

        public IEnumerable<ClsReporteador>
            ReporteadorMetBuscarPorFecha(
                DateTime Fecha)
        {
            List<ClsReporteador> Lista =
                new List<ClsReporteador>();

            string Consulta = @"
                SELECT
                    numeroReporte,
                    nombreReporte,
                    rutaReporte,
                    fechaReporte
                FROM tblReporte
                WHERE fechaReporte = ?
                ORDER BY numeroReporte";

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand(
                        Consulta,
                        Conexion))
                {
                    Comando.Parameters.Add(
                        new OdbcParameter(
                            "p_fechaReporte",
                            Fecha.Date));

                    using (OdbcDataReader Lector =
                        Comando.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Lista.Add(
                                ReporteadorMetCrearEntidad(
                                    Lector));
                        }
                    }
                }
            }

            return Lista;
        }

        // ============================================================
        // CREAR ENTIDAD
        // ============================================================

        private ClsReporteador
            ReporteadorMetCrearEntidad(
                OdbcDataReader Lector)
        {
            ClsReporteador Reporte =
                new ClsReporteador();

            Reporte.NumeroReporte =
                Convert.ToInt32(
                    Lector["numeroReporte"]);

            Reporte.NombreReporte =
                Lector["nombreReporte"].ToString();

            Reporte.RutaReporte =
                Lector["rutaReporte"].ToString();

            Reporte.FechaReporte =
                Convert.ToDateTime(
                    Lector["fechaReporte"]);

            return Reporte;
        }
    }
}