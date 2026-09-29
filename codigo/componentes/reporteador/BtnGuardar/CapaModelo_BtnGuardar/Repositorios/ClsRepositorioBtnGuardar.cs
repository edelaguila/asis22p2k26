using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnGuardar.Repositorios
{
    public class ClsRepositorioBtnGuardar : ClsRepositorio
    {
        public bool GuardarReporte(int numeroReporte, string nombreReporte, string rutaReporte, DateTime fechaReporte, bool esEdicion, out string mensajeError)
        {
            mensajeError = string.Empty;

            string queryInsert = @"INSERT INTO tblReporte (numeroReporte, nombreReporte, rutaReporte, fechaReporte) 
                                   VALUES (?, ?, ?, ?)";

            string queryUpdate = @"UPDATE tblReporte 
                                   SET nombreReporte = ?, rutaReporte = ?, fechaReporte = ? 
                                   WHERE numeroReporte = ?";

            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
                    using (var comando = new OdbcCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandType = CommandType.Text;

                        if (!esEdicion)
                        {
                            comando.CommandText = queryInsert;
                            comando.Parameters.Add(new OdbcParameter("p_numeroReporte", numeroReporte));
                            comando.Parameters.Add(new OdbcParameter("p_nombreReporte", nombreReporte));
                            comando.Parameters.Add(new OdbcParameter("p_rutaReporte", rutaReporte));
                            comando.Parameters.Add(new OdbcParameter("p_fechaReporte", fechaReporte.Date));
                        }
                        else
                        {
                            comando.CommandText = queryUpdate;
                            comando.Parameters.Add(new OdbcParameter("p_nombreReporte", nombreReporte));
                            comando.Parameters.Add(new OdbcParameter("p_rutaReporte", rutaReporte));
                            comando.Parameters.Add(new OdbcParameter("p_fechaReporte", fechaReporte.Date));
                            comando.Parameters.Add(new OdbcParameter("p_numeroReporte", numeroReporte));
                        }

                        int filasAfectadas = comando.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeError = ex.Message;
                return false;
            }
        }
    }
}