using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnEditar_Reporteador.Repositorios
{
    public class ClsRepositorioBtnEditarReporteador
        : ClsRepositorioReporteador
    {
        public bool ReporteadorMetEditarReporte(
            int NumeroReporte,
            string NombreReporte,
            string RutaReporte,
            DateTime FechaReporte,
            out string MensajeError)
        {
            MensajeError = string.Empty;

            string Query =
                @"UPDATE tblReporte
                  SET nombreReporte = ?,
                      rutaReporte = ?,
                      fechaReporte = ?
                  WHERE numeroReporte = ?";

            try
            {
                using (OdbcConnection Conexion =
                    ReporteadorMetObtenerConexion())
                {
                    Conexion.Open();

                    using (OdbcCommand Comando =
                        new OdbcCommand())
                    {
                        Comando.Connection =
                            Conexion;

                        Comando.CommandType =
                            CommandType.Text;

                        Comando.CommandText =
                            Query;

                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_nombreReporte",
                                NombreReporte));

                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_rutaReporte",
                                RutaReporte));

                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_fechaReporte",
                                FechaReporte.Date));

                        Comando.Parameters.Add(
                            new OdbcParameter(
                                "p_numeroReporte",
                                NumeroReporte));

                        int FilasAfectadas =
                            Comando.ExecuteNonQuery();

                        if (FilasAfectadas > 0)
                        {
                            return true;
                        }

                        MensajeError =
                            "No se encontró el reporte seleccionado.";

                        return false;
                    }
                }
            }
            catch (OdbcException)
            {
                MensajeError =
                    "No se pudo actualizar el reporte. " +
                    "Verifique la conexión con la base de datos.";

                return false;
            }
            catch (Exception)
            {
                MensajeError =
                    "Ocurrió un error al actualizar el reporte.";

                return false;
            }
        }
    }
}