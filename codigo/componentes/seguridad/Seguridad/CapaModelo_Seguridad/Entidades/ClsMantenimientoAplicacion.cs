using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Andy Alfonso Garcia Lopez
 * Carné : 9959-23-1494
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  La clase ClsMantenimientoAplicacion es la entidad que representa
 *  el modelo de datos de una Aplicación del sistema, contiene las
 *  propiedades que mapean los campos de la tabla tblAplicacion en la 
 *  base de datos que es utilizada por el repositorio y el controlador 
 *  del módulo de Mantenimiento de Aplicación
 * ===================================================================
*/

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsMantenimientoAplicacion
    {
        public int IdAplicacion { get; set; }
        public int IdModulo { get; set; }
        public String NombreModulo { get; set; }
        public string NombreAplicacion { get; set; }
        public string DescripcionAplicacion { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}