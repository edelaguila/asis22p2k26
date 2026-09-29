using CapaControlador_Seguridad.Correo;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CapaControlador_Seguridad
{

    public class ClsModeloSolicitarCodigo
    {
        private const int _MinutosValidez = 5;
        private const int _SegundosCooldown = 60;
        private static readonly Random _Random = new Random();

        private IRepositorioRecuperacionContrasena _RepositorioRecuperacion;

        [Required(ErrorMessage = "Debe ingresar el usuario")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Debe ingresar el correo")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "El correo no tiene un formato válido")]
        public string CorreoUsuario { get; set; }

        public ClsModeloSolicitarCodigo()
        {
            _RepositorioRecuperacion = new ClsRepositorioRecuperacionContrasena();
        }

        public string SeguridadMetSolicitarCodigo()
        {
            string Mensaje = null;
            try
            {
                _RepositorioRecuperacion.SeguridadMetEliminarVencidos();

                var IdUsuario = _RepositorioRecuperacion.SeguridadMetBuscarIdUsuarioPorUsuarioYCorreo(NombreUsuario, CorreoUsuario);
                if (IdUsuario == null)
                {
                    return "El usuario y el correo no coinciden con ninguna cuenta activa";
                }

                var UltimaSolicitud = _RepositorioRecuperacion.SeguridadMetBuscarFechaUltimaSolicitud(IdUsuario.Value);
                if (UltimaSolicitud != null)
                {
                    var SegundosTranscurridos = (DateTime.Now - UltimaSolicitud.Value).TotalSeconds;
                    if (SegundosTranscurridos < _SegundosCooldown)
                    {
                        var SegundosRestantes = (int)Math.Ceiling(_SegundosCooldown - SegundosTranscurridos);
                        return $"Espera {SegundosRestantes} segundos antes de solicitar otro código";
                    }
                }

                _RepositorioRecuperacion.SeguridadMetEliminarPorUsuario(IdUsuario.Value);

                var Codigo = SeguridadMetGenerarCodigo();
                var FechaExpiracion = DateTime.Now.AddMinutes(_MinutosValidez);
                _RepositorioRecuperacion.SeguridadMetGuardarToken(IdUsuario.Value, Codigo, FechaExpiracion);

                var CuerpoCorreo = ClsPlantillaCorreoRecuperacion.SeguridadMetGenerarHtml(NombreUsuario, Codigo, _MinutosValidez);
                new ClsEnvioCorreo().SeguridadMetEnviarCorreo(CorreoUsuario, "Recuperación de contraseña", CuerpoCorreo);

                Mensaje = "Codigo enviado";
            }
            catch (Exception ex)
            {
                Mensaje = ex.ToString();
            }
            return Mensaje;
        }

        private string SeguridadMetGenerarCodigo()
        {
            const string Caracteres = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            var Codigo = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                Codigo.Append(Caracteres[_Random.Next(Caracteres.Length)]);
            }
            return Codigo.ToString();
        }
    }
}
