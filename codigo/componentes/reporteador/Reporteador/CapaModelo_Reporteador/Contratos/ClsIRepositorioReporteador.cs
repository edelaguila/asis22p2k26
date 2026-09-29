using CapaModelo_Reporteador.Entidades;
using System;
using System.Collections.Generic;

namespace CapaModelo_Reporteador.Contratos
{
    public interface ClsIRepositorioReporteador
    {
        void Agregar(ClsReporteador reporte);
        void Editar(ClsReporteador reporte);
        void Remover(ClsReporteador reporte);
        IEnumerable<ClsReporteador> GetAll();
        IEnumerable<ClsReporteador> BuscarPorNombre(string filtro);
        IEnumerable<ClsReporteador> BuscarPorFecha(DateTime fecha);

        // OBTENER MÁXIMO NÚMERO
        int ObtenerMaximoNumeroReporte(int codigoModulo);
    }
}