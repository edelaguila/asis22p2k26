using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_BtnActualizar.Repositorios
{
    public class ClsRepositorioBtnActualizar
        : ClsRepositorio
    {
        private readonly string _ConsultaTodos;

        public ClsRepositorioBtnActualizar()
        {
            _ConsultaTodos =
                "SELECT numeroReporte AS NumeroReporte, " +
                "nombreReporte AS NombreReporte, " +
                "rutaReporte AS RutaReporte, " +
                "fechaReporte AS FechaReporte " +
                "FROM tblReporte";
        }

        public DataTable ReporteadorMetObtenerTodos()
        {
            return ReporteadorMetEjecucionConsulta(
                _ConsultaTodos,
                CommandType.Text);
        }

        public DataTable ReporteadorMetEjecucionConsulta(
            string ComandoTexto,
            CommandType ComandoTipo)
        {
            return ReporteadorMetEjecucionConsulta(
                ComandoTexto,
                null,
                ComandoTipo);
        }

        public DataTable ReporteadorMetEjecucionConsulta(
            string ComandoTexto,
            List<OdbcParameter> Parametros,
            CommandType ComandoTipo)
        {
            DataTable TablaDatos =
                new DataTable();

            using (OdbcConnection Conexion =
                ReporteadorMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando =
                    new OdbcCommand())
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = ComandoTexto;
                    Comando.CommandType = ComandoTipo;

                    if (Parametros != null)
                    {
                        Comando.Parameters.AddRange(
                            Parametros.ToArray());
                    }

                    using (OdbcDataReader Lector =
                        Comando.ExecuteReader())
                    {
                        TablaDatos.Load(Lector);
                    }
                }
            }

            return TablaDatos;
        }
    }
}