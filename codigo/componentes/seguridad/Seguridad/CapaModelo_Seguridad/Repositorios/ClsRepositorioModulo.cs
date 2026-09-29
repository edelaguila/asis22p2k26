using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioModulo : ClsSentencias, IRepositorioGenerico<ClsModulo>
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioModulo()
        {
            _SelectAll = "SELECT idModulo, nombreModulo, descripcionModulo, is_active FROM tblModulo";
            _Insert = "INSERT INTO tblModulo (nombreModulo, descripcionModulo, is_active) VALUES (?, ?, ?)";
            _Update = "UPDATE tblModulo SET nombreModulo=?, descripcionModulo=?, is_active=? WHERE idModulo=?";
            _Delete = "DELETE FROM tblModulo WHERE idModulo=?";
        }

        public int SeguridadMetAgregar(ClsModulo Entidad)
        {
            var Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombreModulo", Entidad.NombreModulo),
                new OdbcParameter("p_descripcionModulo", Entidad.DescripcionModulo),
                new OdbcParameter("p_is_active", Entidad.IsActive ? 1 : 0)
            };
            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsModulo Entidad)
        {
            var Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombreModulo", Entidad.NombreModulo),
                new OdbcParameter("p_descripcionModulo", Entidad.DescripcionModulo),
                new OdbcParameter("p_is_active", Entidad.IsActive ? 1 : 0),
                new OdbcParameter("p_idModulo", Entidad.IdModulo)
            };
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsModulo Entidad)
        {
            var Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_idModulo", Entidad.IdModulo)
            };
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsModulo> SeguridadMetObtenerTodos()
        {
            var ListaModulos = new List<ClsModulo>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);

            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Modulo = new ClsModulo
                {
                    IdModulo = Convert.ToInt32(Fila[0]),
                    NombreModulo = Fila[1].ToString(),
                    DescripcionModulo = Fila[2] != DBNull.Value ? Fila[2].ToString() : "",
                    IsActive = Convert.ToBoolean(Fila[3])
                };
                ListaModulos.Add(Modulo);
            }
            return ListaModulos;
        }

        public DataTable SeguridadMetObtenerModulosTabla()
        {
            return SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
        }
    }
}