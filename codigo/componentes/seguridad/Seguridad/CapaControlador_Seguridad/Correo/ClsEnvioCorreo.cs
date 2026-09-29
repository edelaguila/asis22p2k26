using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CapaControlador_Seguridad.Correo
{
    
    public class ClsEnvioCorreo
    {
        public void SeguridadMetEnviarCorreo(string CorreoDestino, string Asunto, string CuerpoHtml)
        {
            var Servidor = ConfigurationManager.AppSettings["SmtpServidor"];
            var Puerto = int.Parse(ConfigurationManager.AppSettings["SmtpPuerto"]);
            var Usuario = ConfigurationManager.AppSettings["SmtpUsuario"];
            var ContrasenaApp = ConfigurationManager.AppSettings["SmtpContrasenaApp"];

            var Mensaje = new MimeMessage();
            Mensaje.From.Add(MailboxAddress.Parse(Usuario));
            Mensaje.To.Add(MailboxAddress.Parse(CorreoDestino));
            Mensaje.Subject = Asunto;

            var Cuerpo = new BodyBuilder { HtmlBody = CuerpoHtml };
            
            SeguridadMetAdjuntarImagenEmbebida(Cuerpo, "header.jpg", "encabezado");
            SeguridadMetAdjuntarImagenEmbebida(Cuerpo, "footer.jpg", "pie");
            Mensaje.Body = Cuerpo.ToMessageBody();

            using (var Cliente = new SmtpClient())
            {
                Cliente.Connect(Servidor, Puerto, SecureSocketOptions.StartTls);
                Cliente.Authenticate(Usuario, ContrasenaApp);
                Cliente.Send(Mensaje);
                Cliente.Disconnect(true);
            }
        }

        private void SeguridadMetAdjuntarImagenEmbebida(BodyBuilder Cuerpo, string NombreArchivo, string ContentId)
        {
            var Ensamblado = Assembly.GetExecutingAssembly();
            var NombreRecurso = Ensamblado.GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith("." + NombreArchivo));

            if (NombreRecurso == null)
            {
                throw new FileNotFoundException($"No se encontró la imagen '{NombreArchivo}' como Embedded Resource. " +
                    "Verifica que Correo/Recursos/" + NombreArchivo + " tenga Build Action = Embedded Resource.");
            }

            using (var Flujo = Ensamblado.GetManifestResourceStream(NombreRecurso))
            {
                var Imagen = Cuerpo.LinkedResources.Add(NombreArchivo, Flujo);
                Imagen.ContentId = ContentId;
            }
        }
    }
}
