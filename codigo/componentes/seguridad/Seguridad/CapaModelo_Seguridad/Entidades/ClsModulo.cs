using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsModulo
    {
        // Deben hacer match con los campos de tu base de datos
        public int IdModulo { get; set; }
        public string NombreModulo { get; set; }
        public string DescripcionModulo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}