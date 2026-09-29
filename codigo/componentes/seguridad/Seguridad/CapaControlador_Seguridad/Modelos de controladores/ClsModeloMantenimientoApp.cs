using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Andy Alfonso Garcia Lopez
 * Carné : 9959-23-1494
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  La clase de Modelo De Controlador del módulo de Mantenimiento
 *  de Aplicación actúa como un intermediario entre la vista y el
 *  repositorio de datos (_RepositorioMantenimientoApp) gestionando el
 *  estado CRUD de cada registro: agregar, modificar y eliminar, 
 *  mediante el EstadoEntidad, aplicando validaciones con Data 
 *  Annotations y registrando cada operación en la bitácora del 
 *  sistema de seguridad.
 * ===================================================================
*/

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloMantenimientoApp
    {
        private int _IdAplicacion;
        private int _IdModulo;
        private string _NombreAplicacion;
        private string _DescripcionAplicacion;
        private string _NombreModulo;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioMantenimientoApp _RepositorioMantenimientoApp;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloMantenimientoApp> _ListaMantenimientoApp;

        public int IdAplicacion { get => _IdAplicacion; set => _IdAplicacion = value; }

        [Required(ErrorMessage = "El campo Id Modulo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un modulo válido")]
        public int IdModulo { get => _IdModulo; set => _IdModulo = value; }
        public string NombreModulo { get => _NombreModulo; set => _NombreModulo = value; }

        [Required(ErrorMessage = "El campo Nombre Aplicación es requerido")]
        public string NombreAplicacion { get => _NombreAplicacion; set => _NombreAplicacion = value; }

        public string DescripcionAplicacion { get => _DescripcionAplicacion; set => _DescripcionAplicacion = value; }

        [Required(ErrorMessage = "El campo Estado es requerido")]
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }

        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloMantenimientoApp()
        {
            _RepositorioMantenimientoApp = new ClsRepositorioMantenimientoApp();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var DatosAplicacion = new ClsMantenimientoAplicacion();
                DatosAplicacion.IdAplicacion = _IdAplicacion;
                DatosAplicacion.IdModulo = _IdModulo;
                DatosAplicacion.NombreAplicacion = _NombreAplicacion;
                DatosAplicacion.DescripcionAplicacion = _DescripcionAplicacion;
                DatosAplicacion.IsActive = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioMantenimientoApp.SeguridadMetAgregar(DatosAplicacion);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblAplicacion", DatosAplicacion.IdAplicacion, "Se agregó la aplicación: " + _NombreAplicacion);
                        Mensaje = "Grabacion exitosa";
                        break;

                    case EstadoEntidad.Modified:
                        _RepositorioMantenimientoApp.SeguridadMetEditar(DatosAplicacion);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblAplicacion", DatosAplicacion.IdAplicacion, "Se actualizó la aplicación: " + _NombreAplicacion);
                        Mensaje = "Actualizacion exitosa";
                        break;

                    case EstadoEntidad.Deleted:
                        _RepositorioMantenimientoApp.SeguridadMetRemover(DatosAplicacion);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblAplicacion", DatosAplicacion.IdAplicacion, "Se eliminó la aplicación ID: " + DatosAplicacion.IdAplicacion);
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

        public List<ClsModeloMantenimientoApp> SeguridadMetObtenerTodos()
        {
            var DatosAplicacion = _RepositorioMantenimientoApp.SeguridadMetObtenerTodos();
            _ListaMantenimientoApp = new List<ClsModeloMantenimientoApp>();
            foreach (ClsMantenimientoAplicacion Item in DatosAplicacion)
            {
                _ListaMantenimientoApp.Add(new ClsModeloMantenimientoApp
                {
                    _IdAplicacion = Item.IdAplicacion,
                    _IdModulo = Item.IdModulo,
                    _NombreModulo = Item.NombreModulo,
                    _NombreAplicacion = Item.NombreAplicacion,
                    _DescripcionAplicacion = Item.DescripcionAplicacion,
                    _IsActive = Item.IsActive,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaMantenimientoApp;
        }

        public ClsModeloMantenimientoApp SeguridadMetBuscarPorId(int IdAplicacion)
        {
            return _ListaMantenimientoApp.Find(e => e._IdAplicacion == IdAplicacion);
        }

        public DataTable SeguridadMetObtenerModulos()
        {
            return _RepositorioMantenimientoApp.SeguridadMetObtenerModulos();
        }

        public DataTable SeguridadMetObtenerAplicaciones()
        {
            return _RepositorioMantenimientoApp.SeguridadMetObtenerAplicaciones();
        }
    }
}