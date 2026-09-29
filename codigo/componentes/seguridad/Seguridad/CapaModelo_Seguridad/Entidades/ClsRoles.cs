/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Cristian David Sipac Ispache
 * Carné : 9959-23-1567
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  La clase ClsRoles representa la entidad Rol, con los mismos
 *  campos que la tabla tblRol en la base de datos. Se usa para
 *  transportar los datos de un perfil entre el repositorio y el
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
    public class ClsRoles
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string DescripcionRol { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}