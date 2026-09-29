/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Byron Alexander Chiquito Paredes
 * Carné : 0901-23-3747
 * Fecha : 24/09/2026
 * ==================================================================
 * Propósito :
 * Aqui en esta clase se encuentran los get y set necesarios y 
 * utilizados en la vista del formulario.
 * ===================================================================
*/

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
