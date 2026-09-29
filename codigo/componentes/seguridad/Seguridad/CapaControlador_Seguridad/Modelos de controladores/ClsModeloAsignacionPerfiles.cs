using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Odbc;
using System.Linq;

namespace CapaControlador_Seguridad
{
    public class ClsModeloAsignacionPerfiles
    {
        private int _IdUsuario;
        private int _IdRol;
        private DateTime _FechaAsignacionUsuarioRol;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private string _NombreUsuario;
        private string _NombreRol;
        private ClsRepositorioAsignacionPerfiles _RepositorioAsignacionPerfiles;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloAsignacionPerfiles> _ListaAsignacionPerfiles;

        [Required(ErrorMessage = "El campo Usuario es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Usuario válido")]
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        [Required(ErrorMessage = "El campo Perfil es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Perfil válido")]
        public int IdRol { get => _IdRol; set => _IdRol = value; }

        [Required(ErrorMessage = "El campo Fecha de Asignación es requerido")]
        public DateTime FechaAsignacionUsuarioRol { get => _FechaAsignacionUsuarioRol; set => _FechaAsignacionUsuarioRol = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public string NombreUsuario { get => _NombreUsuario; private set => _NombreUsuario = value; }
        public string NombreRol { get => _NombreRol; private set => _NombreRol = value; }

        public ClsModeloAsignacionPerfiles()
        {
            _RepositorioAsignacionPerfiles = new ClsRepositorioAsignacionPerfiles();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsAsignacionPerfiles();
                ModeloDatos.IdUsuario = _IdUsuario;
                ModeloDatos.IdRol = _IdRol;
                ModeloDatos.FechaAsignacionUsuarioRol = _FechaAsignacionUsuarioRol;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioAsignacionPerfiles.SeguridadMetAgregar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblUsuarioRol", ModeloDatos.IdUsuario, "Se asignó el perfil " + _IdRol + " al usuario " + _IdUsuario);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioAsignacionPerfiles.SeguridadMetEditar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblUsuarioRol", ModeloDatos.IdUsuario, "Se actualizó la fecha de asignación del perfil " + _IdRol + " al usuario " + _IdUsuario);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioAsignacionPerfiles.SeguridadMetRemover(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblUsuarioRol", ModeloDatos.IdUsuario, "Se eliminó la asignación del perfil " + _IdRol + " al usuario " + _IdUsuario);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (OdbcException OdbcEx)
            {
                if (OdbcEx.Errors.Count > 0 && OdbcEx.Errors[0].NativeError == 1062)
                    Mensaje = "Ese perfil ya está asignado a ese usuario.";
                else
                    Mensaje = OdbcEx.ToString();
            }
            catch (Exception Ex)
            {
                Mensaje = Ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloAsignacionPerfiles> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioAsignacionPerfiles.SeguridadMetObtenerTodos();
            _ListaAsignacionPerfiles = new List<ClsModeloAsignacionPerfiles>();
            foreach (ClsAsignacionPerfiles Item in ResultadoConsulta)
            {
                _ListaAsignacionPerfiles.Add(new ClsModeloAsignacionPerfiles
                {
                    _IdUsuario = Item.IdUsuario,
                    _IdRol = Item.IdRol,
                    _FechaAsignacionUsuarioRol = Item.FechaAsignacionUsuarioRol,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt,
                    _NombreUsuario = Item.NombreUsuario,
                    _NombreRol = Item.NombreRol
                });
            }
            return _ListaAsignacionPerfiles;
        }

        public IEnumerable<ClsModeloAsignacionPerfiles> SeguridadMetBuscarPorId(int IdUsuario, int IdRol)
        {
            return _ListaAsignacionPerfiles.FindAll(e =>
                e._IdUsuario == IdUsuario &&
                e._IdRol == IdRol);
        }

        public IEnumerable<ClsModeloAsignacionPerfiles> SeguridadMetBuscarPorUsuario(int IdUsuario)
        {
            return _ListaAsignacionPerfiles.FindAll(e => e._IdUsuario == IdUsuario);
        }

        public DataTable SeguridadMetObtenerUsuarios()
        {
            return _RepositorioAsignacionPerfiles.SeguridadMetObtenerUsuarios();
        }

        public DataTable SeguridadMetObtenerRoles()
        {
            return _RepositorioAsignacionPerfiles.SeguridadMetObtenerRoles();
        }
    }
}
