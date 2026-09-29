using CapaModelo_Consultas;
using System;
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

        public DataTable ConsultasFuncCargarConsulta(string Consulta, int Pagina, int RegistrosPorPagina)
        {
            return _SentenciasTablas.ConsultasFuncCargarConsulta(Consulta, Pagina,RegistrosPorPagina);
        }

        public int ConsultasFuncContarResultadosQuery(string Consulta)
        {
            return _SentenciasTablas.ConsultasFuncContarResultadosQuery(Consulta);
        }

        // Fin del código de Carlos Andres Arriaza Lara 0901-23-13862 el 16/09/2026

        // Inicio de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "19/09/26"

        public DataTable ConsultasFuncCargarConsultasPorTabla(string NombreTabla)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
            {
                throw new ArgumentException("El nombre de la tabla no puede estar vacío.");
            }
            return _SentenciasTablas.ConsultasFuncCargarConsultasPorTabla(NombreTabla);
        }

        public void ConsultasProcEliminarConsulta(int IdConsulta)
        {
            if (IdConsulta <= 0)
            {
                throw new ArgumentException("El identificador de la consulta no es válido.");
            }

            _SentenciasTablas.ConsultasProcEliminarConsulta(IdConsulta);
        }

        // Fin de código de "Diego Fernando Santizo Samayoa" - carné: "0901-22-15950" - Fecha: "19/09/26"
    }
}