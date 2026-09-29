/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Samayoa y Oscar Morales
 * Carné : 9959-23-3424 y 9959-23-3070
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