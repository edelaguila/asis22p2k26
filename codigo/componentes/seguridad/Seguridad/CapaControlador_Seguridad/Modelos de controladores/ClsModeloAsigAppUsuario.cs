using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad
{
    public class ClsModeloAsigAppUsuario
    {
        private int _IdUsuario;
        private int _IdModulo;
        private int _IdAplicacion;
        private bool _DerInsertar;
        private bool _DerEditar;
        private bool _DerEliminar;
        private bool _DerImprimir;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioAsigAppUsuario _RepositorioAsigAppUsuario;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloAsigAppUsuario> _ListaAsigAppUsuario;

        [Required(ErrorMessage = "El campo Usuario es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Usuario válido")]
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        [Required(ErrorMessage = "El campo Módulo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Módulo válido")]
        public int IdModulo { get => _IdModulo; set => _IdModulo = value; }

        [Required(ErrorMessage = "El campo Aplicación es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una Aplicación válida")]
        public int IdAplicacion { get => _IdAplicacion; set => _IdAplicacion = value; }

        public bool DerInsertarUsuarioModuloAplicacion { get => _DerInsertar; set => _DerInsertar = value; }
        public bool DerEditarUsuarioModuloAplicacion { get => _DerEditar; set => _DerEditar = value; }
        public bool DerEliminarUsuarioModuloAplicacion { get => _DerEliminar; set => _DerEliminar = value; }
        public bool DerImprimirUsuarioModuloAplicacion { get => _DerImprimir; set => _DerImprimir = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloAsigAppUsuario()
        {
            _RepositorioAsigAppUsuario = new ClsRepositorioAsigAppUsuario();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsAsigAppUsuario();
                ModeloDatos.IdUsuario = _IdUsuario;
                ModeloDatos.IdModulo = _IdModulo;
                ModeloDatos.IdAplicacion = _IdAplicacion;
                ModeloDatos.DerInsertarUsuarioModuloAplicacion = _DerInsertar;
                ModeloDatos.DerEditarUsuarioModuloAplicacion = _DerEditar;
                ModeloDatos.DerEliminarUsuarioModuloAplicacion = _DerEliminar;
                ModeloDatos.DerImprimirUsuarioModuloAplicacion = _DerImprimir;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioAsigAppUsuario.SeguridadMetAgregar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblAsigAppUsuario", ModeloDatos.IdModulo, "Se asignó aplicación " + _IdAplicacion + " al módulo " + _IdModulo);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioAsigAppUsuario.SeguridadMetEditar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblAsigAppUsuario", ModeloDatos.IdModulo, "Se actualizo acceso de aplicación " + _IdAplicacion + " al módulo " + _IdModulo);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioAsigAppUsuario.SeguridadMetRemover(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblAsigAppUsuario", ModeloDatos.IdModulo, "Se elimino el acceso de aplicación " + _IdAplicacion + " al módulo " + _IdModulo);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception Ex)
            {
                Mensaje = Ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloAsigAppUsuario> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioAsigAppUsuario.SeguridadMetObtenerTodos();
            _ListaAsigAppUsuario = new List<ClsModeloAsigAppUsuario>();

            foreach (ClsAsigAppUsuario Item in ResultadoConsulta)
            {
                _ListaAsigAppUsuario.Add(new ClsModeloAsigAppUsuario
                {
                    _IdUsuario = Item.IdUsuario,
                    _IdModulo = Item.IdModulo,
                    _IdAplicacion = Item.IdAplicacion,
                    _DerInsertar = Item.DerInsertarUsuarioModuloAplicacion,
                    _DerEditar = Item.DerEditarUsuarioModuloAplicacion,
                    _DerEliminar = Item.DerEliminarUsuarioModuloAplicacion,
                    _DerImprimir = Item.DerImprimirUsuarioModuloAplicacion,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }

            return _ListaAsigAppUsuario;
        }

        public IEnumerable<ClsModeloAsigAppUsuario> SeguridadMetBuscarPorId(int IdUsuario, int IdModulo, int IdAplicacion)
        {
            return _ListaAsigAppUsuario.FindAll(e =>
                e._IdUsuario == IdUsuario &&
                e._IdModulo == IdModulo &&
                e._IdAplicacion == IdAplicacion);
        }

        public DataTable SeguridadMetObtenerUsuarios()
        {
            return _RepositorioAsigAppUsuario.SeguridadMetObtenerUsuarios();
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return _RepositorioAsigAppUsuario.SeguridadMetObtenerModulos();
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return _RepositorioAsigAppUsuario.SeguridadMetObtenerAplicaciones();
        }

        public IEnumerable<ClsModeloAsigAppUsuario> SeguridadMetBuscarPorUsuario(int IdUsuario)
        {
            return _ListaAsigAppUsuario.FindAll(e => e._IdUsuario == IdUsuario);
        }
    }
}