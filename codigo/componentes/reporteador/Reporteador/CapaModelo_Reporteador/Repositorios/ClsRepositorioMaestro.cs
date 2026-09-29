using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Reporteador.Repositorios
{
    /// <summary>
    /// Repositorio maestro que proporciona métodos
    /// generales para ejecutar consultas y comandos SQL.
    /// </summary>
    public abstract class ClsRepositorioMaestro
        : ClsRepositorio
    {
        protected ClsRepositorioMaestro()
            : base()
        {
        }

        // =========================================================
        // EJECUTAR NON QUERY
        // =========================================================

        /// <summary>
        /// Ejecuta comandos INSERT, UPDATE o DELETE.
        /// </summary>
        protected int ReporteadorMetEjecucionNonQuery(
            string ComandoTexto,
            List<OdbcParameter> Parametros,
            CommandType ComandoTipo)
        {
            using (
                OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (
                    OdbcCommand Comando =
                        new OdbcCommand())
                {
                    Comando.Connection =
                        Conexion;

                    Comando.CommandText =
                        ComandoTexto;

                    Comando.CommandType =
                        ComandoTipo;

                    if (Parametros != null &&
                        Parametros.Count > 0)
                    {
                        Comando.Parameters.AddRange(
                            Parametros.ToArray());
                    }

                    return
                        Comando.ExecuteNonQuery();
                }
            }
        }

        // =========================================================
        // EJECUTAR CONSULTA
        // =========================================================

        /// <summary>
        /// Ejecuta una consulta SELECT y devuelve
        /// los resultados en un DataTable.
        /// </summary>
        protected DataTable
            ReporteadorMetEjecucionConsulta(
                string ComandoTexto,
                List<OdbcParameter> Parametros = null,
                CommandType ComandoTipo =
                    CommandType.Text)
        {
            DataTable Tabla =
                new DataTable();

            using (
                OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (
                    OdbcCommand Comando =
                        new OdbcCommand())
                {
                    Comando.Connection =
                        Conexion;

                    Comando.CommandText =
                        ComandoTexto;

                    Comando.CommandType =
                        ComandoTipo;

                    if (Parametros != null &&
                        Parametros.Count > 0)
                    {
                        Comando.Parameters.AddRange(
                            Parametros.ToArray());
                    }

                    using (
                        OdbcDataReader Lector =
                            Comando.ExecuteReader())
                    {
                        Tabla.Load(Lector);
                    }
                }
            }

            return Tabla;
        }
    }
}