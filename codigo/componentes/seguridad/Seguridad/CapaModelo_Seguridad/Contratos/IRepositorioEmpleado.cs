using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Entidades;

/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Carlos David Calderón Ramirez
 * Carné : 9959-23-848
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  La clase de IRepositorioEmpleado en la CapaModelo_Seguridad
 *  aqui se encuentra la interfaz generica dedicha ClsEmpleado
 * ===================================================================
*/

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioEmpleado: IRepositorioGenerico<ClsEmpleado> 
    { }
    
}
