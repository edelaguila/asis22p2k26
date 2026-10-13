using System.Collections.Generic;
using System.Linq;

namespace CapaModelo_BtnEliminar_Reporteador
{
    public class ClsRepositorioBtnEliminarReporteador
        : ClsRepositorio
    {
        public bool ReporteadorMetEstaDeshabilitado(
            int NumeroReporte)
        {
            return ReporteadorMetLeerNumeros()
                .Contains(NumeroReporte);
        }

        public bool ReporteadorMetDeshabilitar(
            int NumeroReporte)
        {
            List<int> Actuales =
                ReporteadorMetLeerNumeros();

            if (Actuales.Contains(NumeroReporte))
            {
                return false;
            }

            Actuales.Add(NumeroReporte);

            ReporteadorMetEscribirNumeros(
                Actuales);

            return true;
        }

        public IEnumerable<int>
            ReporteadorMetObtenerTodos()
        {
            return ReporteadorMetLeerNumeros();
        }
    }
}