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
