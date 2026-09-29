using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioRoles : ClsSentencias, IRepositorioRoles
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioRoles()
        {
            _SelectAll = "Select * FROM tblRol";
            _Insert = "INSERT INTO tblRol (nombreRol, descripcionRol, is_active) values (?, ?, ?)";
            _Update = "UPDATE tblRol SET nombreRol=?, descripcionRol=?, is_active=? WHERE idRol=?";
            _Delete = "DELETE FROM tblRol WHERE idRol=?";
        }

        public int SeguridadMetAgregar(ClsRoles Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("P_nombreRol", Entidad.NombreRol));
            Parametros.Add(new OdbcParameter("P_descripcionRol", Entidad.DescripcionRol));
            Parametros.Add(new OdbcParameter("P_is_active", Entidad.IsActive));
            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsRoles Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("P_nombreRol", Entidad.NombreRol));
            Parametros.Add(new OdbcParameter("P_descripcionRol", Entidad.DescripcionRol));
            Parametros.Add(new OdbcParameter("P_is_active", Entidad.IsActive));
            Parametros.Add(new OdbcParameter("P_idRol", Entidad.IdRol));
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsRoles Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("P_idRol", Entidad.IdRol));
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsRoles> SeguridadMetObtenerTodos()
        {
            var ListaRoles = new List<ClsRoles>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Rol = new ClsRoles();
                Rol.IdRol = Convert.ToInt32(Fila[0]);
                Rol.NombreRol = Fila[1].ToString();
                Rol.DescripcionRol = Fila[2].ToString();
                Rol.IsActive = Convert.ToBoolean(Fila[3]);
                Rol.CreatedAt = Convert.ToDateTime(Fila[4]);
                Rol.UpdatedAt = Convert.ToDateTime(Fila[5]);
                ListaRoles.Add(Rol);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaRoles;
        }
    }
}