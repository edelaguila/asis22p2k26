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
    public class ClsBitacora
    {
        public int IdBitacora { get; set; }
        public int? IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string AccionBitacora { get; set; }
        public string TablaBitacora { get; set; }
        public int IdRegistroBitacora { get; set; }
        public string DetallesBitacora { get; set; }
        public string IpBitacora { get; set; }
        public DateTime FechaHoraBitacora { get; set; }
    }
}
