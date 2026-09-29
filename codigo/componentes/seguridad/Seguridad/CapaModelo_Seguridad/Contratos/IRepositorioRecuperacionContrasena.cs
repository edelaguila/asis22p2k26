/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Byron Alexander Chiquito Paredes
 * Carné : 0901-23-3747
 * Fecha : 24/09/2026
 * ==================================================================
 * Propósito :
 *  Contrato de repositorio para la entidad Bitacora.
 *  Define la interfaz que debe implementar el repositorio
 *  de bitacora, heredando las operaciones genéricas del repositorio 
 *  base.
 * ===================================================================
*/

using System;

namespace CapaModelo_Seguridad.Contratos
{
    
    public interface IRepositorioRecuperacionContrasena
    {
        
        int? SeguridadMetBuscarIdUsuarioPorUsuarioYCorreo(string NombreUsuario, string CorreoEmpleado);

        DateTime? SeguridadMetBuscarFechaUltimaSolicitud(int IdUsuario);

        void SeguridadMetEliminarPorUsuario(int IdUsuario);

        void SeguridadMetEliminarVencidos();

        void SeguridadMetGuardarToken(int IdUsuario, string Token, DateTime FechaExpiracion);

        int? SeguridadMetBuscarIdUsuarioPorToken(string Token);
    }
}
