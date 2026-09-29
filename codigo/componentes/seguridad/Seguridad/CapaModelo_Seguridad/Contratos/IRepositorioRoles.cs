/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Cristian David Sipac Ispache
 * Carné : 9959-23-1567
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  El IRepositorioRoles nos permite hacer una herencia del
 *  repositorio generico para poder agregar, editar y eliminar
 * ===================================================================
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Entidades;


namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioRoles : IRepositorioGenerico<ClsRoles>
    {

    }
}
