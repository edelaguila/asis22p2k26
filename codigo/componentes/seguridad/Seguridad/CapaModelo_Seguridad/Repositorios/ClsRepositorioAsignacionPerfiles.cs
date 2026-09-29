using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioAsignacionPerfiles : ClsSentencias, IRepositorioAsignacionPerfiles
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioAsignacionPerfiles()
        {
            _SelectAll = "SELECT ur.idUsuario, ur.idRol, ur.fechaAsignacionUsuarioRol, ur.created_at, ur.updated_at, u.nombreUsuario, r.nombreRol " +
                         "FROM tblUsuarioRol ur " +
                         "INNER JOIN tblUsuario u ON ur.idUsuario = u.idUsuario " +
                         "INNER JOIN tblRol r ON ur.idRol = r.idRol";

            _Insert = "INSERT INTO tblUsuarioRol VALUES (?, ?, ?, DEFAULT, DEFAULT)";
            _Update = "UPDATE tblUsuarioRol SET fechaAsignacionUsuarioRol=? WHERE idUsuario=? AND idRol=?";
            _Delete = "DELETE FROM tblUsuarioRol WHERE idUsuario=? AND idRol=?";
        }

        public int SeguridadMetAgregar(ClsAsignacionPerfiles Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            Parametros.Add(new OdbcParameter("p_idRol", Entidad.IdRol));
            Parametros.Add(new OdbcParameter("p_fechaAsignacion", Entidad.FechaAsignacionUsuarioRol));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsAsignacionPerfiles Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_fechaAsignacion", Entidad.FechaAsignacionUsuarioRol));
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            Parametros.Add(new OdbcParameter("p_idRol", Entidad.IdRol));

            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsAsignacionPerfiles Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            Parametros.Add(new OdbcParameter("p_idRol", Entidad.IdRol));

            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsAsignacionPerfiles> SeguridadMetObtenerTodos()
        {
            var ListaAsignacionPerfiles = new List<ClsAsignacionPerfiles>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var AsigPerf = new ClsAsignacionPerfiles();
                AsigPerf.IdUsuario = Convert.ToInt32(Fila[0]);
                AsigPerf.IdRol = Convert.ToInt32(Fila[1]);
                AsigPerf.FechaAsignacionUsuarioRol = Convert.ToDateTime(Fila[2]);
                AsigPerf.CreatedAt = Convert.ToDateTime(Fila[3]);
                AsigPerf.UpdatedAt = Convert.ToDateTime(Fila[4]);
                AsigPerf.NombreUsuario = Fila[5].ToString();
                AsigPerf.NombreRol = Fila[6].ToString();
                ListaAsignacionPerfiles.Add(AsigPerf);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaAsignacionPerfiles;
        }

        public DataTable SeguridadMetObtenerUsuarios()
        {
            return SeguridadMetEjecucionConsulta("SELECT idUsuario, nombreUsuario FROM tblUsuario WHERE is_active = 1", CommandType.Text);
        }

        public DataTable SeguridadMetObtenerRoles()
        {
            return SeguridadMetEjecucionConsulta("SELECT idRol, nombreRol FROM tblRol WHERE is_active = 1", CommandType.Text);
        }
    }
}
