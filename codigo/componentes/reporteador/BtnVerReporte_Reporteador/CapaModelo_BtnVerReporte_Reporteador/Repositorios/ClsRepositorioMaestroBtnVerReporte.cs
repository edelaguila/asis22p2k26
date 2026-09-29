using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnVerReporte_Reporteador.Repositorios
{
    public abstract class ClsRepositorioMaestroBtnVerReporte : ClsRepositorio
    {
        // EJECUTAR UNA CONSULTA QUE DEVUELVE UN SOLO VALOR
        public object ReporteadorMetEjecutarConsultaEscalar(string ComandoTexto, CommandType TipoComando, params OdbcParameter[] Parametros)
        {
            using (OdbcConnection Conexion = ReporteadorMetObtenerConexion())
            {
                Conexion.Open();
                using (OdbcCommand Comando = new OdbcCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = TipoComando;
                    Comando.Parameters.AddRange(Parametros);
                    return Comando.ExecuteScalar();
                }
            }
        }
    }
}
