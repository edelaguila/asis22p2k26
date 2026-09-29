/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Omar Gomez Carrascosa
 * Carné : 9959-23-10733
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  El IRepositorioUsuarios nos permite hacer una herencia del
 *  repositorio generico para poder agregar, editar y eliminar
 * ===================================================================
*/
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioUsuarios : IRepositorioGenerico<ClsUsuarios>
    {
        ClsUsuarios SeguridadMetValidarLogin(string NombreUsuario, string ContrasenaUsuario);

        // AGREGADO para recuperación de contraseña
        void SeguridadMetActualizarContrasena(int IdUsuario, string ContrasenaHasheada);
    }
}