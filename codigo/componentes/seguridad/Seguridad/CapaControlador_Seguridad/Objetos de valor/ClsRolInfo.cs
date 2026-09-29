using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 24/09/2026
 * ==================================================================
 * Propósito : Clase que guarda el id y el nombre de un rol, usada
 * para llevar la lista de roles del usuario en sesión.
 * ===================================================================
 */
namespace CapaControlador_Seguridad.Objetos_de_valor
{
    public class ClsRolInfo
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }
}
