using System;

namespace CapaModelo_Reporteador.Entidades
{
    /// <summary>
    /// Entidad que representa un reporte dentro
    /// del componente Reporteador.
    /// </summary>
    public class ClsReporteador
    {
        // =========================================================
        // PROPIEDADES DE LA ENTIDAD
        // =========================================================

        // Número único del reporte.
        public int NumeroReporte
        {
            get;
            set;
        }

        // Nombre descriptivo del reporte.
        public string NombreReporte
        {
            get;
            set;
        }

        // Ruta física del archivo PDF.
        public string RutaReporte
        {
            get;
            set;
        }

        // Fecha asociada al reporte.
        public DateTime FechaReporte
        {
            get;
            set;
        }
    }
}
