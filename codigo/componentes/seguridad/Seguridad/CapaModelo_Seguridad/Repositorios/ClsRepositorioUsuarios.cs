using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Repositorios;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioUsuarios : ClsSentencias, IRepositorioUsuarios
    {
        private string _SelectAll;
        private string _Insert;
        private string _Delete;
        private string _Update;
        private string _UpdateContrasena;


        private string login = "SELECT u.idUsuario, u.idEmpleado, u.nombreUsuario, u.contrasenaUsuario, u.is_active, " +
             "CONCAT(e.nombresEmpleado, ' ', e.apellidosEmpleado) AS nombreEmpleado " +
             "FROM tblusuario u " +
             "INNER JOIN tblempleado e ON u.idEmpleado = e.idEmpleado " +
             "WHERE u.nombreUsuario=? AND u.is_active=1";


        private string rolesPorUsuario = "SELECT ur.idRol, r.nombreRol " +
             "FROM tblusuariorol ur " +
             "INNER JOIN tblrol r ON ur.idRol = r.idRol " +
             "WHERE ur.idUsuario=?";


        public ClsUsuarios SeguridadMetValidarLogin(string usuario, string contrasena)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_usuario", usuario));

            var tabla = SeguridadMetEjecucionConsulta(login, CommandType.Text, _parametros);

            if (tabla.Rows.Count == 0) return null;

            var row = tabla.Rows[0];
            return new ClsUsuarios
            {
                IdUsuario = Convert.ToInt32(row[0]),
                IdEmpleado = Convert.ToInt32(row[1]),
                NombreUsuario = row[2].ToString(),
                ContrasenaUsuario = row[3].ToString(),
                IsActive = Convert.ToInt32(row[4]),
                NombreEmpleado = row[5].ToString()
            };
        }
        public DataTable SeguridadMetObtenerRolesPorUsuario(int idUsuario)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", idUsuario));

            return SeguridadMetEjecucionConsulta(rolesPorUsuario, CommandType.Text, Parametros);
        }

        public ClsRepositorioUsuarios()
        {
            _SelectAll = "SELECT idUsuario"
                         + ", idEmpleado"
                         + ",nombreUsuario"
                         + ", contrasenaUsuario"
                         + ", ultimoAccesoUsuario"
                         + ", is_active"
                         + " FROM tblusuario";
            _Insert = "INSERT INTO tblusuario (idEmpleado,nombreUsuario, contrasenaUsuario, ultimoAccesoUsuario, is_active) VALUES (?,?,?,?,?)";

            _Update = "UPDATE tblusuario SET idEmpleado=?,nombreUsuario=?, contrasenaUsuario=?, ultimoAccesoUsuario=?,is_active=? WHERE idUsuario=?";

            _Delete = "DELETE FROM tblusuario WHERE idUsuario=?";

            _UpdateContrasena = "UPDATE tblusuario SET contrasenaUsuario=? WHERE idUsuario=?";
        }

        public int SeguridadMetAgregar(ClsUsuarios Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idEmpleado", Entidad.IdEmpleado));
            Parametros.Add(new OdbcParameter("p_nombreUsuario", Entidad.NombreUsuario));
            Parametros.Add(new OdbcParameter("p_contrasenaUsuario", Entidad.ContrasenaUsuario));
            Parametros.Add(new OdbcParameter("p_ultimoAccesoUsuario", Entidad.UltimoAccesoUsuario));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsUsuarios Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idEmpleado", Entidad.IdEmpleado));
            Parametros.Add(new OdbcParameter("p_nombreUsuario", Entidad.NombreUsuario));
            Parametros.Add(new OdbcParameter("p_contrasenaUsuario", Entidad.ContrasenaUsuario));
            Parametros.Add(new OdbcParameter("p_ultimoAccesoUsuario", Entidad.UltimoAccesoUsuario));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsUsuarios Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsUsuarios> SeguridadMetObtenerTodos()
        {
            var ListaUsuarios = new List<ClsUsuarios>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Usuario = new ClsUsuarios();
                Usuario.IdUsuario = Convert.ToInt32(Fila[0]);
                Usuario.IdEmpleado = Convert.ToInt32(Fila[1]);
                Usuario.NombreUsuario = Fila[2].ToString();
                Usuario.ContrasenaUsuario = Fila[3].ToString();
                Usuario.UltimoAccesoUsuario = Convert.ToDateTime(Fila[4]);
                Usuario.IsActive = Convert.ToInt32(Fila[5]);
                ListaUsuarios.Add(Usuario);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaUsuarios;
        }

        public DataTable SeguridadMetObtenerEmpleados()
        {
            return SeguridadMetEjecucionConsulta("SELECT idEmpleado, nombresEmpleado FROM tblempleado", CommandType.Text);
        }
        public void SeguridadMetActualizarContrasena(int IdUsuario, string ContrasenaHasheada)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_contrasenaUsuario", ContrasenaHasheada));
            Parametros.Add(new OdbcParameter("p_idUsuario", IdUsuario));
            SeguridadMetEjecucionNonQuery(_UpdateContrasena, Parametros, CommandType.Text);
        }
    }
}