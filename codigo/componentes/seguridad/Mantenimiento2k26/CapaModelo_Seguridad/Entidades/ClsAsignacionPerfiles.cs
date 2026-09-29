using System;


/* ============================================================
 * Área : Seguridad
 * Autor : Daniella Jurado
 * Carné : 0901-23-3679
 * Fecha : 23/09/2026
 * ============================================================
 * Propósito :
 * Esta clase representa la información relacionada con la
 * asignación de perfiles a los usuarios del sistema. Contiene
 * los identificadores del usuario y del perfil, la fecha en que
 * se realizó la asignación y las fechas de creación y
 * actualización del registro. También permite manejar los
 * nombres del usuario y del perfil para mostrar la información
 * de forma más clara.
 * ============================================================
 */

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
