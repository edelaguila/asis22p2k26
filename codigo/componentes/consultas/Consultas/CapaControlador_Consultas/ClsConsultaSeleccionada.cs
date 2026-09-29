using CapaModelo_Consultas;
using System.Data;

namespace CapaControlador_Consultas
{
    public class ClsConsultaSeleccionada
    {
        //Inicio del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026

        private readonly ClsSentenciasTablas _SentenciasTablas = new ClsSentenciasTablas();

        public DataTable ConsultasFuncCargarConsultas()
        {
            return _SentenciasTablas.ConsultasFuncObtenerConsultas();
        }

        public DataTable ConsultasFuncCargarConsulta(
            string Consulta,
            int Pagina,
            int RegistrosPorPagina)
        {
            return _SentenciasTablas.ConsultasFuncCargarConsulta(
                Consulta,
                Pagina,
                RegistrosPorPagina);
        }

        public int ConsultasFuncContarResultadosQuery(string Consulta)
        {
            return _SentenciasTablas.ConsultasFuncContarResultadosQuery(Consulta);
        }

        //Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026
    }
}