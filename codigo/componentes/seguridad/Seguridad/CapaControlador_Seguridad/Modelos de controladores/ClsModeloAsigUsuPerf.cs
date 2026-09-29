using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloAsigUsuPerf
    {
        private int _IdUsuario;
        private int _IdRol;
        private DateTime _FechaAsignacionUsuarioRol;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private string _NombreUsuario;
        private string _NombreRol;
        private ClsRepositorioAsigUsuPerf _RepositorioAsigUsuPerf;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloAsigUsuPerf> _ListaAsigUsuPerf;

        [Required(ErrorMessage = "El campo Usuario es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Usuario válido")]
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        [Required(ErrorMessage = "El campo Rol es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Rol válido")]
        public int IdRol { get => _IdRol; set => _IdRol = value; }

        [Required(ErrorMessage = "El campo Fecha de Asignación es requerido")]
        public DateTime FechaAsignacionUsuarioRol { get => _FechaAsignacionUsuarioRol; set => _FechaAsignacionUsuarioRol = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public string NombreUsuario { get => _NombreUsuario; private set => _NombreUsuario = value; }
        public string NombreRol { get => _NombreRol; private set => _NombreRol = value; }

        public ClsModeloAsigUsuPerf()
        {
            _RepositorioAsigUsuPerf = new ClsRepositorioAsigUsuPerf();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsAsigUsuPerf();
                ModeloDatos.idUsuario = _IdUsuario;
                ModeloDatos.idRol = _IdRol;
                ModeloDatos.FechaAsignacionUsuarioRol = _FechaAsignacionUsuarioRol;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioAsigUsuPerf.SeguridadMetAgregar(ModeloDatos);
                        // PENDIENTE DE AGREGAR BITACORA
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioAsigUsuPerf.SeguridadMetEditar(ModeloDatos);
                        // PENDIENTE DE AGREGAR BITACORA
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioAsigUsuPerf.SeguridadMetRemover(ModeloDatos);
                        // PENDIENTE DE AGREGAR BITACORA
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

        public List<ClsModeloAsigUsuPerf> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioAsigUsuPerf.SeguridadMetObtenerTodos();
            _ListaAsigUsuPerf = new List<ClsModeloAsigUsuPerf>();
            foreach (ClsAsigUsuPerf Item in ResultadoConsulta)
            {
                _ListaAsigUsuPerf.Add(new ClsModeloAsigUsuPerf
                {
                    _IdUsuario = Item.idUsuario,
                    _IdRol = Item.idRol,
                    _FechaAsignacionUsuarioRol = Item.FechaAsignacionUsuarioRol,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt,
                    _NombreUsuario = Item.NombreUsuario,
                    _NombreRol = Item.NombreRol
                });
            }
            return _ListaAsigUsuPerf;
        }

        public IEnumerable<ClsModeloAsigUsuPerf> SeguridadMetBuscarPorId(int IdUsuario, int IdRol)
        {
            return _ListaAsigUsuPerf.FindAll(e =>
                e._IdUsuario == IdUsuario &&
                e._IdRol == IdRol);
        }

        public DataTable SeguridadMetObtenerUsuarios()
        {
            return _RepositorioAsigUsuPerf.SeguridadMetObtenerUsuarios();
        }

        public DataTable SeguridadMetObtenerRoles()
        {
            return _RepositorioAsigUsuPerf.SeguridadMetObtenerRoles();
        }

        public IEnumerable<ClsModeloAsigUsuPerf> SeguridadMetBuscarPorUsuario(int IdUsuario)
        {
            return _ListaAsigUsuPerf.FindAll(e => e._IdUsuario == IdUsuario);
        }

    }
}
