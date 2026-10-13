using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnGuardar_Reporteador.Repositorios
{
    public class ClsRepositorioBtnGuardarReporteador
        : ClsRepositorioReporteador
    {
        public bool ReporteadorMetGuardarReporte(
            int NumeroReporte,
            string NombreReporte,
            string RutaReporte,
            DateTime FechaReporte,
            bool EsEdicion,
            out string MensajeError)
        {
            MensajeError = string.Empty;

            string ConsultaInsert =
                @"INSERT INTO tblReporte
                  (
                      numeroReporte,
                      nombreReporte,
                      rutaReporte,
                      fechaReporte
                  )
                  VALUES (?, ?, ?, ?)";

            string ConsultaUpdate =
                @"UPDATE tblReporte
                  SET
                      nombreReporte = ?,
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

                        if (!EsEdicion)
                        {
                            Comando.CommandText =
                                ConsultaInsert;

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "NumeroReporte",
                                    NumeroReporte));

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "NombreReporte",
                                    NombreReporte));

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "RutaReporte",
                                    RutaReporte));

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "FechaReporte",
                                    FechaReporte.Date));
                        }
                        else
                        {
                            Comando.CommandText =
                                ConsultaUpdate;

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "NombreReporte",
                                    NombreReporte));

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "RutaReporte",
                                    RutaReporte));

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "FechaReporte",
                                    FechaReporte.Date));

                            Comando.Parameters.Add(
                                new OdbcParameter(
                                    "NumeroReporte",
                                    NumeroReporte));
                        }

                        int FilasAfectadas =
                            Comando.ExecuteNonQuery();

                        if (FilasAfectadas > 0)
                        {
                            return true;
                        }

                        if (EsEdicion)
                        {
                            MensajeError =
                                "No se encontró el reporte " +
                                "seleccionado para actualizar.";
                        }
                        else
                        {
                            MensajeError =
                                "No se pudo guardar el reporte.";
                        }

                        return false;
                    }
                }
            }
            catch (OdbcException)
            {
                if (EsEdicion)
                {
                    MensajeError =
                        "No se pudo actualizar el reporte. " +
                        "Verifique que el registro exista " +
                        "y que los datos sean válidos.";
                }
                else
                {
                    MensajeError =
                        "No se pudo guardar el reporte. " +
                        "Es posible que el número de reporte " +
                        "ya exista.";
                }

                return false;
            }
            catch (Exception)
            {
                MensajeError =
                    "Ocurrió un problema al procesar el " +
                    "reporte. Verifique los datos e " +
                    "inténtelo nuevamente.";

                return false;
            }
        }
    }
}