using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsRecuperacionContrasena
    {
        public int IdRecuperacionContrasena { get; set; }
        public int IdUsuario { get; set; }
        public string TokenRecuperacionContrasena { get; set; }
        public DateTime FechaExpiracionRecuperacionContrasena { get; set; }
        public bool UsadoRecuperacionContrasena { get; set; }
    }
}
