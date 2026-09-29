/*
 * ==================================================================
 * Área : Seguridad - Mantenimiento2k26
 * Autor : Byron Alexander
 * Carné : 0901-23-3747
 * Fecha : 29/09/2026
 * ==================================================================
 * Propósito :
 *  Entidad de la tabla departamento. Cada propiedad lleva el mismo
 *  nombre exacto de la columna en la base de datos.
 * ===================================================================
*/

namespace CapaModelo_Mantenimiento2k26
{
    // IMPORTANTE: los nombres de las propiedades deben ser iguales a las columnas de la BD.
    public class ClsDepartamento
    {
        public const string Tabla = "departamento";

        public string codigo_departamento { get; set; }   // VARCHAR(5)  PK
        public string nombre_departamento { get; set; }   // VARCHAR(80)
        public string estatus_departamento { get; set; }  // VARCHAR(1)  A = Activo, I = Inactivo
    }
}
