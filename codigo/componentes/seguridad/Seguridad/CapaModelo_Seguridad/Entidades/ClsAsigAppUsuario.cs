/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Guillermo Daniel Morales Mendizabal 
 * Carné : 0901-23-3329
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
    public class ClsAsigAppUsuario
    {
        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public int IdAplicacion { get; set; }

        public bool DerInsertarUsuarioModuloAplicacion { get; set; }
        public bool DerEditarUsuarioModuloAplicacion { get; set; }
        public bool DerEliminarUsuarioModuloAplicacion { get; set; }
        public bool DerImprimirUsuarioModuloAplicacion { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}