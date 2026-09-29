using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsAsignacionPerfiles
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaAsignacionUsuarioRol { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreRol { get; set; }
    }
}
