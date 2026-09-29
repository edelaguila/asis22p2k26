using CapaModelo_Reporteador.Entidades;
using System;
using System.Collections.Generic;

namespace CapaModelo_Reporteador.Contratos
{
    public interface ClsIRepositorioReporteador
    {
        void ReporteadorMetAgregar(
            ClsReporteador Reporte,
            int IdAplicacion);

        void ReporteadorMetEditar(
            ClsReporteador Reporte);

        void ReporteadorMetRemover(
            ClsReporteador Reporte);

        IEnumerable<ClsReporteador>
            ReporteadorMetObtenerTodos(int IdAplicacion);

        IEnumerable<ClsReporteador>
            ReporteadorMetBuscarPorNombre(
                string Filtro);

        IEnumerable<ClsReporteador>
            ReporteadorMetBuscarPorFecha(
                DateTime Fecha);

        int ReporteadorMetObtenerMaximoNumeroReporte(
            int CodigoModulo);
    }
}