using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnBusqueda.Repositorios
{
    public class ClsRepositorioBtnBusqueda
        : ClsRepositorio
    {
        public DataTable ReporteadorMetBuscarReportes(
            string NombreReporte,
            DateTime? FechaReporte,
            bool BuscarPorNombre,
            bool BuscarPorFecha)
        {
            DataTable Tabla =
                new DataTable();

            string Consulta =
                @"
                SELECT
                    numeroReporte,
                    nombreReporte,
                    rutaReporte,
                    fechaReporte
                FROM tblReporte
                WHERE 1 = 1";

            if (BuscarPorNombre)
            {
                Consulta +=
                    " AND nombreReporte LIKE ?";
            }

            if (BuscarPorFecha)
            {
                Consulta +=
                    " AND fechaReporte = ?";
            }

            Consulta +=
                " ORDER BY numeroReporte";

            try
            {
                using (OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
                {
                    Conexion.Open();

                    using (OdbcCommand Comando =
                        new OdbcCommand(
                            Consulta,
                            Conexion))
                    {
                        if (BuscarPorNombre)
                        {
                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "p_nombreReporte",
                                    "%" +
                                    (NombreReporte ?? string.Empty) +
                                    "%"));
                        }

                        if (BuscarPorFecha &&
                            FechaReporte.HasValue)
                        {
                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "p_fechaReporte",
                                    FechaReporte.Value.Date));
                        }

                        using (OdbcDataAdapter Adaptador =
                            new OdbcDataAdapter(
                                Comando))
                        {
                            Adaptador.Fill(Tabla);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return Tabla;
        }
    }
}