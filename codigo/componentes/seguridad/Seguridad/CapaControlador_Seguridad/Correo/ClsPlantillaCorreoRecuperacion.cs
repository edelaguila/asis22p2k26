namespace CapaControlador_Seguridad.Correo
{
    
    public static class ClsPlantillaCorreoRecuperacion
    {
        private const string _ColorTitulo = "#006D77";
        private const string _ColorAcento = "#D97757";
        private const string _ColorFondoCodigo = "#EDC9A1";
        private const string _ColorTextoSecundario = "#6B6B6B";

        public static string SeguridadMetGenerarHtml(string NombreUsuario, string Codigo, int MinutosValidez)
        {
            return $@"
<html>
<body style=""margin:0;padding:0;background-color:#FFFFFF;font-family:Segoe UI, Arial, sans-serif;"">
  <table width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""background-color:#FFFFFF;"">
    <tr>
      <td align=""center"">
        <table width=""600"" cellpadding=""0"" cellspacing=""0"">

          <tr>
            <td><img src=""cid:encabezado"" width=""600"" style=""display:block;width:100%;max-width:600px;"" alt=""Embutidos de calidad S.A.""/></td>
          </tr>

          <tr>
            <td style=""padding:32px 40px;"">
              <h2 style=""color:{_ColorTitulo};margin:0 0 20px 0;font-size:22px;"">Recuperación de contraseña</h2>
              <p style=""color:#333333;font-size:14px;line-height:1.6;margin:0 0 4px 0;"">
                Hola, <strong>{NombreUsuario}</strong>.
              </p>
              <p style=""color:#333333;font-size:14px;line-height:1.6;margin:0 0 20px 0;"">
                Recibimos una solicitud para restablecer la contraseña de tu cuenta en Embutidos de calidad S.A.
                Utiliza el siguiente código para continuar con el proceso:
              </p>
              <div style=""text-align:center;margin:8px 0 24px 0;"">
                <span style=""display:inline-block;background-color:{_ColorFondoCodigo};color:{_ColorTitulo};font-size:28px;font-weight:bold;letter-spacing:6px;padding:14px 30px;border-radius:8px;"">
                  {Codigo}
                </span>
              </div>
              <p style=""color:{_ColorTextoSecundario};font-size:13px;line-height:1.6;margin:0 0 20px 0;"">
                Este código vence en <strong>{MinutosValidez} minutos</strong> y solo puede utilizarse una vez.
              </p>
              <table cellpadding=""0"" cellspacing=""0"" style=""background-color:#F4F4F4;border-left:4px solid {_ColorAcento};border-radius:4px;width:100%;"">
                <tr>
                  <td style=""padding:14px 18px;"">
                    <p style=""color:#333333;font-size:13px;line-height:1.6;margin:0;"">
                      <strong>Tu seguridad es importante:</strong> si no solicitaste este cambio, puedes ignorar
                      este correo. Si crees que alguien más intentó acceder a tu cuenta, comunícate con el
                      equipo de seguridad de Terminus.
                    </p>
                  </td>
                </tr>
              </table>
              <p style=""color:#333333;font-size:13px;line-height:1.6;margin:24px 0 0 0;"">
                Saludos,<br/>
                <strong>Embutidos de calidad S.A.</strong>
              </p>
            </td>
          </tr>

          <tr>
            <td><img src=""cid:pie"" width=""600"" style=""display:block;width:100%;max-width:600px;"" alt=""Embutidos de calidad S.A.""/></td>
          </tr>

        </table>
      </td>
    </tr>
  </table>
</body>
</html>";
        }
    }
}
