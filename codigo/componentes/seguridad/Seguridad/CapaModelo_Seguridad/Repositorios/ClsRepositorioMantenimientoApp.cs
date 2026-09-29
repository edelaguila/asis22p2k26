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
    public class ClsRepositorioMantenimientoApp : ClsSentencias, IRepositorioMantenimientoApp
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioMantenimientoApp()
        {
            _SelectAll = "SELECT * FROM tblAplicacion";
            _Insert = "INSERT INTO tblAplicacion VALUES (DEFAULT,?, ?, ?, ?, DEFAULT, DEFAULT)";
            _Update = "UPDATE tblAplicacion SET idModulo=?, nombreAplicacion=?, descripcionAplicacion=?, is_active=? WHERE idAplicacion=?";
            _Delete = "DELETE FROM tblAplicacion WHERE idAplicacion=?";
        }

        public int SeguridadMetAgregar(ClsMantenimientoAplicacion Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_nombreAplicacion", Entidad.NombreAplicacion));
            Parametros.Add(new OdbcParameter("p_descripcionAplicacion", Entidad.DescripcionAplicacion));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));
            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsMantenimientoAplicacion Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_nombreAplicacion", Entidad.NombreAplicacion));
            Parametros.Add(new OdbcParameter("p_descripcionAplicacion", Entidad.DescripcionAplicacion));
            Parametros.Add(new OdbcParameter("p_is_active", Entidad.IsActive));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsMantenimientoAplicacion Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsMantenimientoAplicacion> SeguridadMetObtenerTodos()
        {
            var ListaAplicaciones = new List<ClsMantenimientoAplicacion>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Row in TablaDatos.Rows)
            {
                var Aplicacion = new ClsMantenimientoAplicacion();
                Aplicacion.IdAplicacion = Convert.ToInt32(Row[0]);
                Aplicacion.IdModulo = Convert.ToInt32(Row[1]);
                Aplicacion.NombreAplicacion = Convert.ToString(Row[2]);
                Aplicacion.DescripcionAplicacion = Convert.ToString(Row[3]);
                Aplicacion.IsActive = Convert.ToBoolean(Row[4]);
                Aplicacion.CreatedAt = Convert.ToDateTime(Row[5]);
                Aplicacion.UpdatedAt = Convert.ToDateTime(Row[6]);
                ListaAplicaciones.Add(Aplicacion);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaAplicaciones;
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return SeguridadMetEjecucionConsulta("SELECT idModulo, nombreModulo FROM tblModulo", CommandType.Text);
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return SeguridadMetEjecucionConsulta("SELECT idAplicacion, CONCAT(idAplicacion, ' - ', nombreAplicacion) AS nombreAplicacion FROM tblAplicacion", CommandType.Text);
        }
    }
}