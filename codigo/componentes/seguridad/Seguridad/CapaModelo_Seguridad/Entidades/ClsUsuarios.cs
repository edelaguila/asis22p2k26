/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Omar Gomez Carrascosa
 * Carné : 9959-23-10733
 * Fecha : 23/09/2026
 * ==================================================================
 * Propósito :
 *  La clase ClsUsuarios representa la entidad Usuario, con los mismos
 *  campos que la tabla tblUsuario en la base de datos. Se usa para
 *  transportar los datos de un usuario entre el repositorio y el
 *  controlador.
 * ===================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsUsuarios
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public int IsActive { get; set; }
        public string ContrasenaUsuario { get; set; }
        public DateTime UltimoAccesoUsuario { get; set; }
        public string NombreEmpleado { get; set; }
    }
}