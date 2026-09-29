using CapaModelo_Seguridad.Contratos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioRecuperacionContrasena : ClsSentencias, IRepositorioRecuperacionContrasena
    {
        private string _BuscarUsuarioPorCorreo;
        private string _BuscarFechaUltimaSolicitud;
        private string _EliminarPorUsuario;
        private string _EliminarVencidos;
        private string _Insert;
        private string _BuscarIdUsuarioPorToken;

        public ClsRepositorioRecuperacionContrasena()
        {
            _BuscarUsuarioPorCorreo = "SELECT u.idUsuario FROM tblUsuario u"
                                     + " INNER JOIN tblEmpleado e ON e.idEmpleado = u.idEmpleado"
                                     + " WHERE u.nombreUsuario = ? AND e.correoEmpleado = ?"
                                     + " AND u.is_active = 1 AND e.is_active = 1";

            _BuscarFechaUltimaSolicitud = "SELECT created_at FROM tblRecuperacionContrasena"
                                         + " WHERE idUsuario = ? ORDER BY created_at DESC LIMIT 1";

            _EliminarPorUsuario = "DELETE FROM tblRecuperacionContrasena WHERE idUsuario = ?";

            _EliminarVencidos = "DELETE FROM tblRecuperacionContrasena WHERE fechaExpiracionRecuperacionContrasena < NOW()";

            _Insert = "INSERT INTO tblRecuperacionContrasena (idUsuario, tokenRecuperacionContrasena, fechaExpiracionRecuperacionContrasena, usadoRecuperacionContrasena)"
                    + " VALUES (?, ?, ?, FALSE)";
            _BuscarIdUsuarioPorToken = "SELECT idUsuario FROM tblRecuperacionContrasena"
                                      + " WHERE tokenRecuperacionContrasena = ?"
                                      + " AND usadoRecuperacionContrasena = FALSE"
                                      + " AND fechaExpiracionRecuperacionContrasena > NOW()";
        }

        public int? SeguridadMetBuscarIdUsuarioPorUsuarioYCorreo(string NombreUsuario, string CorreoEmpleado)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_nombreUsuario", NombreUsuario));
            Parametros.Add(new OdbcParameter("p_correoEmpleado", CorreoEmpleado));

            var TablaDatos = SeguridadMetEjecucionConsulta(_BuscarUsuarioPorCorreo, CommandType.Text, Parametros);
            if (TablaDatos.Rows.Count == 0) return null;
            return Convert.ToInt32(TablaDatos.Rows[0][0]);
        }

        public DateTime? SeguridadMetBuscarFechaUltimaSolicitud(int IdUsuario)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", IdUsuario));

            var TablaDatos = SeguridadMetEjecucionConsulta(_BuscarFechaUltimaSolicitud, CommandType.Text, Parametros);
            if (TablaDatos.Rows.Count == 0) return null;
            return Convert.ToDateTime(TablaDatos.Rows[0][0]);
        }

        public void SeguridadMetEliminarPorUsuario(int IdUsuario)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", IdUsuario));
            SeguridadMetEjecucionNonQuery(_EliminarPorUsuario, Parametros, CommandType.Text);
        }

        public void SeguridadMetEliminarVencidos()
        {
            SeguridadMetEjecucionNonQuery(_EliminarVencidos, new List<OdbcParameter>(), CommandType.Text);
        }

        public void SeguridadMetGuardarToken(int IdUsuario, string Token, DateTime FechaExpiracion)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", IdUsuario));
            Parametros.Add(new OdbcParameter("p_token", Token));
            Parametros.Add(new OdbcParameter("p_fechaExpiracion", FechaExpiracion));
            SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int? SeguridadMetBuscarIdUsuarioPorToken(string Token)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_token", Token));

            var TablaDatos = SeguridadMetEjecucionConsulta(_BuscarIdUsuarioPorToken, CommandType.Text, Parametros);
            if (TablaDatos.Rows.Count == 0) return null;
            return Convert.ToInt32(TablaDatos.Rows[0][0]);
        }
    }
}
