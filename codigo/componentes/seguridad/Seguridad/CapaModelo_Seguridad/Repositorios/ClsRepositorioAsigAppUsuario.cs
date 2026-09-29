using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioAsigAppUsuario : ClsSentencias, IRepositorioAsigAppUsuario
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioAsigAppUsuario()
        {
            _SelectAll = "SELECT * FROM tblUsuarioModuloAplicacion";
            _Insert = "INSERT INTO tblUsuarioModuloAplicacion (idUsuario, idModulo, idAplicacion, derInsertarUsuarioModuloAplicacion, derEditarUsuarioModuloAplicacion, derEliminarUsuarioModuloAplicacion, derImprimirUsuarioModuloAplicacion) VALUES (?, ?, ?, ?, ?, ?, ?)";
            _Update = "UPDATE tblUsuarioModuloAplicacion SET derInsertarUsuarioModuloAplicacion=?, derEditarUsuarioModuloAplicacion=?, derEliminarUsuarioModuloAplicacion=?, derImprimirUsuarioModuloAplicacion=? WHERE idUsuario=? AND idModulo=? AND idAplicacion=?";
            _Delete = "DELETE FROM tblUsuarioModuloAplicacion WHERE idUsuario=? AND idModulo=? AND idAplicacion=?";
        }

        public int SeguridadMetAgregar(ClsAsigAppUsuario Entidad)
        {
            var Parametros = new List<OdbcParameter>();

            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));
            Parametros.Add(new OdbcParameter("p_derInsertar", Entidad.DerInsertarUsuarioModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEditar", Entidad.DerEditarUsuarioModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEliminar", Entidad.DerEliminarUsuarioModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derImprimir", Entidad.DerImprimirUsuarioModuloAplicacion));

            return SeguridadMetEjecucionNonQuery(
                _Insert,
                Parametros,
                CommandType.Text
            );
        }

        public int SeguridadMetEditar(ClsAsigAppUsuario Entidad)
        {
            var Parametros = new List<OdbcParameter>();

            Parametros.Add(new OdbcParameter("p_derInsertar", Entidad.DerInsertarUsuarioModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEditar", Entidad.DerEditarUsuarioModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derEliminar", Entidad.DerEliminarUsuarioModuloAplicacion));
            Parametros.Add(new OdbcParameter("p_derImprimir", Entidad.DerImprimirUsuarioModuloAplicacion));

            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));

            return SeguridadMetEjecucionNonQuery(
                _Update,
                Parametros,
                CommandType.Text
            );
        }

        public int SeguridadMetRemover(ClsAsigAppUsuario Entidad)
        {
            var Parametros = new List<OdbcParameter>();

            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario));
            Parametros.Add(new OdbcParameter("p_idModulo", Entidad.IdModulo));
            Parametros.Add(new OdbcParameter("p_idAplicacion", Entidad.IdAplicacion));

            return SeguridadMetEjecucionNonQuery(
                _Delete,
                Parametros,
                CommandType.Text
            );
        }

        public IEnumerable<ClsAsigAppUsuario> SeguridadMetObtenerTodos()
        {
            var ListaAsigAppUsuario = new List<ClsAsigAppUsuario>();

            var TablaDatos = SeguridadMetEjecucionConsulta(
                _SelectAll,
                CommandType.Text
            );

            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Asignacion = new ClsAsigAppUsuario();

                Asignacion.IdUsuario = Convert.ToInt32(Fila[0]);
                Asignacion.IdModulo = Convert.ToInt32(Fila[1]);
                Asignacion.IdAplicacion = Convert.ToInt32(Fila[2]);

                Asignacion.DerInsertarUsuarioModuloAplicacion =
                    Convert.ToBoolean(Fila[3]);

                Asignacion.DerEditarUsuarioModuloAplicacion =
                    Convert.ToBoolean(Fila[4]);

                Asignacion.DerEliminarUsuarioModuloAplicacion =
                    Convert.ToBoolean(Fila[5]);

                Asignacion.DerImprimirUsuarioModuloAplicacion =
                    Convert.ToBoolean(Fila[6]);

                Asignacion.CreatedAt = Convert.ToDateTime(Fila[7]);
                Asignacion.UpdatedAt = Convert.ToDateTime(Fila[8]);

                ListaAsigAppUsuario.Add(Asignacion);
            }

            TablaDatos.Clear();
            TablaDatos = null;

            return ListaAsigAppUsuario;
        }

        public DataTable SeguridadMetObtenerUsuarios()
        {
            return SeguridadMetEjecucionConsulta(
                "SELECT idUsuario, nombreUsuario FROM tblUsuario",
                CommandType.Text
            );
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return SeguridadMetEjecucionConsulta(
                "SELECT idModulo, nombreModulo FROM tblModulo",
                CommandType.Text
            );
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return SeguridadMetEjecucionConsulta(
                "SELECT idAplicacion, nombreAplicacion FROM tblAplicacion",
                CommandType.Text
            );
        }
    }
}