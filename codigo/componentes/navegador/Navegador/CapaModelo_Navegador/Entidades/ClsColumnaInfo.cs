// Inicio - José Javier Torres Martínez 0901-23-1091.
using System;

namespace CapaModelo_Navegador
{
    // Guarda toda la info de una Columna en un solo objeto, la usan las 3 capas (vive en el modelo)
    public class ClsColumnaInfo
    {
        public string Nombre { get; set; }
        public string TipoDato { get; set; }
        public string TipoNet { get; set; }
        public string TipoColumnaTexto { get; set; }
        public long Longitud { get; set; }
        public long TamanoColumna { get; set; }
        public bool Nullable { get; set; }
        public bool EsPK { get; set; }
        public bool EsFK { get; set; }
        public bool EsAutoincremento { get; set; }
        public string TablaFK { get; set; }
        public string ColumnaFK { get; set; }
    }
}
// Fin - José Javier Torres Martínez 0901-23-1091.
