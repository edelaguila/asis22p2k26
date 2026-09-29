using CapaControlador_Seguridad.Objetos_de_valor;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Odbc;
using System.Linq;
/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito : Clase del controlador que guarda, edita y elimina las
 * asignaciones de aplicación a un perfil, dejando registro
 * en bitácora, y calcula los permisos del usuario en sesión
 * para cada módulo y aplicación.
 * ===================================================================
 */
namespace CapaControlador_Seguridad
{
    public class ClsModeloAsigAppPerf
    {
        private int _IdRol;
        private string _NombreRol;
        private int _IdModulo;
        private string _NombreModulo;
        private int _IdAplicacion;
        private string _NombreAplicacion;
        private bool _DerInsertar;
        private bool _DerEditar;
        private bool _DerEliminar;
        private bool _DerImprimir;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioAsigAppPerf _RepositorioAsigAppPerf;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloAsigAppPerf> _ListaAsigAppPerf;

        [Required(ErrorMessage = "El campo Rol es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Rol válido")]
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string NombreRol { get => _NombreRol; set => _NombreRol = value; }

        [Required(ErrorMessage = "El campo Módulo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un Módulo válido")]
        public int IdModulo { get => _IdModulo; set => _IdModulo = value; }
        public string NombreModulo { get => _NombreModulo; set => _NombreModulo = value; }

        [Required(ErrorMessage = "El campo Aplicación es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una Aplicación válida")]
        public int IdAplicacion { get => _IdAplicacion; set => _IdAplicacion = value; }
        public string NombreAplicacion { get => _NombreAplicacion; set => _NombreAplicacion = value; }

        public bool DerInsertarRolModuloAplicacion { get => _DerInsertar; set => _DerInsertar = value; }
        public bool DerEditarRolModuloAplicacion { get => _DerEditar; set => _DerEditar = value; }
        public bool DerEliminarRolModuloAplicacion { get => _DerEliminar; set => _DerEliminar = value; }
        public bool DerImprimirRolModuloAplicacion { get => _DerImprimir; set => _DerImprimir = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloAsigAppPerf()
        {
            _RepositorioAsigAppPerf = new ClsRepositorioAsigAppPerf();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsAsigAppPerf();
                ModeloDatos.IdRol = _IdRol;
                ModeloDatos.IdModulo = _IdModulo;
                ModeloDatos.IdAplicacion = _IdAplicacion;
                ModeloDatos.DerInsertarRolModuloAplicacion = _DerInsertar;
                ModeloDatos.DerEditarRolModuloAplicacion = _DerEditar;
                ModeloDatos.DerEliminarRolModuloAplicacion = _DerEliminar;
                ModeloDatos.DerImprimirRolModuloAplicacion = _DerImprimir;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioAsigAppPerf.SeguridadMetAgregar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblAsigAppPerf", ModeloDatos.IdRol, "Se asignó aplicación " + _IdAplicacion + " al rol " + _IdRol);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioAsigAppPerf.SeguridadMetEditar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblAsigAppPerf", ModeloDatos.IdRol, "Se actualizaron permisos de aplicación " + _IdAplicacion + " al rol " + _IdRol);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioAsigAppPerf.SeguridadMetRemover(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblAsigAppPerf", ModeloDatos.IdRol, "Se eliminó asignación de aplicación " + _IdAplicacion + " al rol " + _IdRol);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (OdbcException OdbcEx)
            {
                if (OdbcEx.Errors.Count > 0 && OdbcEx.Errors[0].NativeError == 1062)
                    Mensaje = "Ya existe un perfil asignado con esos permisos para ese Rol, Módulo y Aplicación.";
                else
                    Mensaje = OdbcEx.ToString();
            }
            catch (Exception Ex)
            {
                Mensaje = Ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloAsigAppPerf> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioAsigAppPerf.SeguridadMetObtenerTodos();
            _ListaAsigAppPerf = new List<ClsModeloAsigAppPerf>();
            foreach (ClsAsigAppPerf Item in ResultadoConsulta)
            {
                _ListaAsigAppPerf.Add(new ClsModeloAsigAppPerf
                {
                    _IdRol = Item.IdRol,
                    _NombreRol = Item.NombreRol,
                    _IdModulo = Item.IdModulo,
                    _NombreModulo = Item.NombreModulo,
                    _IdAplicacion = Item.IdAplicacion,
                    _NombreAplicacion = Item.NombreAplicacion,
                    _DerInsertar = Item.DerInsertarRolModuloAplicacion,
                    _DerEditar = Item.DerEditarRolModuloAplicacion,
                    _DerEliminar = Item.DerEliminarRolModuloAplicacion,
                    _DerImprimir = Item.DerImprimirRolModuloAplicacion,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaAsigAppPerf;
        }

        public IEnumerable<ClsModeloAsigAppPerf> SeguridadMetBuscarPorId(int IdRol, int IdModulo, int IdAplicacion)
        {
            return _ListaAsigAppPerf.FindAll(e =>
                e._IdRol == IdRol &&
                e._IdModulo == IdModulo &&
                e._IdAplicacion == IdAplicacion);
        }

        public DataTable SeguridadMetObtenerRoles()
        {
            return _RepositorioAsigAppPerf.SeguridadMetObtenerRoles();
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return _RepositorioAsigAppPerf.SeguridadMetObtenerModulos();
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return _RepositorioAsigAppPerf.SeguridadMetObtenerAplicaciones();
        }

        public IEnumerable<ClsModeloAsigAppPerf> SeguridadMetBuscarPorRol(int IdRol)
        {
            return _ListaAsigAppPerf.FindAll(e => e._IdRol == IdRol);
        }

        public IEnumerable<ClsModeloAsigAppPerf> SeguridadMetBuscarPorNombreRol(string NombreRol)
        {
            return _ListaAsigAppPerf.FindAll(e =>
                e._NombreRol.IndexOf(NombreRol, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // Permisos para UN rol específico en un módulo y aplicación dados
        public ClsPermisoAplicacion SeguridadMetObtenerPermisos(
            int IdRol, int IdModulo, int IdAplicacion)
        {
            try
            {
                if (_ListaAsigAppPerf == null)
                    SeguridadMetObtenerTodos();

                var Registro = _ListaAsigAppPerf.Find(e =>
                    e._IdRol == IdRol &&
                    e._IdModulo == IdModulo &&
                    e._IdAplicacion == IdAplicacion);

                if (Registro == null)
                    return new ClsPermisoAplicacion(); // sin permisos

                return new ClsPermisoAplicacion
                {
                    TieneAcceso = true,
                    PuedeInsertar = Registro._DerInsertar,
                    PuedeEditar = Registro._DerEditar,
                    PuedeEliminar = Registro._DerEliminar,
                    PuedeImprimir = Registro._DerImprimir
                };
            }
            catch (Exception)
            {
                return new ClsPermisoAplicacion();
            }
        }

        // Permisos combinados de TODOS los roles del usuario en sesión
        public ClsPermisoAplicacion SeguridadMetObtenerPermisosSesion(
            int IdModulo, int IdAplicacion)
        {
            var PermisoCombinado = new ClsPermisoAplicacion();

            foreach (int IdRol in ClsSesionSeguridad.IdsRoles)
            {
                var Permiso = SeguridadMetObtenerPermisos(IdRol, IdModulo, IdAplicacion);
                PermisoCombinado = PermisoCombinado.SeguridadMetCombinar(Permiso);
            }

            return PermisoCombinado;
        }
    }
}