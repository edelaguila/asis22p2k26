using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Contratos;
using System.Data.Odbc;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad
{
    public class ClsModeloEmpleado
    {
        private int _IdEmpleado;
        private string _CodigoEmpleado;
        private string _DpiEmpleado;
        private string _NitEmpleado;
        private string _NombresEmpleado;
        private string _ApellidosEmpleado;
        private string _PuestoEmpleado;
        private string _GeneroEmpleado;
        private DateTime _FechaNacimientoEmpleado;
        private DateTime _FechaContratacionEmpleado;
        private string _TelefonoEmpleado;
        private string _CorreoEmpleado;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioEmpleado _RepositorioEmpleado;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloEmpleado> _ListaEmpleado;

        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }

        [Required(ErrorMessage = "El campo Código Empleado es requerido")]
        public string CodigoEmpleado { get => _CodigoEmpleado; set => _CodigoEmpleado = value; }

        [Required(ErrorMessage = "El campo Dpi es requerido")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "El Dpi debe tener 13 dígitos")]
        public string DpiEmpleado { get => _DpiEmpleado; set => _DpiEmpleado = value; }

        public string NitEmpleado { get => _NitEmpleado; set => _NitEmpleado = value; }

        [Required(ErrorMessage = "El campo Nombres es requerido")]
        public string NombresEmpleado { get => _NombresEmpleado; set => _NombresEmpleado = value; }

        [Required(ErrorMessage = "El campo Apellidos es requerido")]
        public string ApellidosEmpleado { get => _ApellidosEmpleado; set => _ApellidosEmpleado = value; }

        [Required(ErrorMessage = "El campo Puesto es requerido")]
        public string PuestoEmpleado { get => _PuestoEmpleado; set => _PuestoEmpleado = value; }

        [Required(ErrorMessage = "El campo Género es requerido")]
        public string GeneroEmpleado { get => _GeneroEmpleado; set => _GeneroEmpleado = value; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es requerido")]
        public DateTime FechaNacimientoEmpleado { get => _FechaNacimientoEmpleado; set => _FechaNacimientoEmpleado = value; }

        [Required(ErrorMessage = "El campo Fecha de Contratación es requerido")]
        public DateTime FechaContratacionEmpleado { get => _FechaContratacionEmpleado; set => _FechaContratacionEmpleado = value; }

        public string TelefonoEmpleado { get => _TelefonoEmpleado; set => _TelefonoEmpleado = value; }

        public string CorreoEmpleado { get => _CorreoEmpleado; set => _CorreoEmpleado = value; }

        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloEmpleado()
        {
            _RepositorioEmpleado = new ClsRepositorioEmpleado();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FechaNacimientoEmpleado > FechaContratacionEmpleado)
            {
                yield return new ValidationResult(
                    "La fecha de nacimiento no puede ser mayor a la fecha de contratación",
                    new[] { nameof(FechaNacimientoEmpleado) });
            }
        }



        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsEmpleado();
                ModeloDatos.IdEmpleado = _IdEmpleado;
                ModeloDatos.CodigoEmpleado = _CodigoEmpleado;
                ModeloDatos.DpiEmpleado = _DpiEmpleado;
                ModeloDatos.NitEmpleado = _NitEmpleado;
                ModeloDatos.NombresEmpleado = _NombresEmpleado;
                ModeloDatos.ApellidosEmpleado = _ApellidosEmpleado;
                ModeloDatos.PuestoEmpleado = _PuestoEmpleado;
                ModeloDatos.GeneroEmpleado = _GeneroEmpleado;
                ModeloDatos.FechaNacimientoEmpleado = _FechaNacimientoEmpleado;
                ModeloDatos.FechaContratacionEmpleado = _FechaContratacionEmpleado;
                ModeloDatos.TelefonoEmpleado = _TelefonoEmpleado;
                ModeloDatos.CorreoEmpleado = _CorreoEmpleado;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioEmpleado.SeguridadMetAgregar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblEmpleado", ModeloDatos.IdEmpleado, "Se agregó el empleado: " + _NombresEmpleado + " " + _ApellidosEmpleado);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioEmpleado.SeguridadMetEditar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblEmpleado", ModeloDatos.IdEmpleado, "Se actualizó el empleado: " + _NombresEmpleado + " " + _ApellidosEmpleado);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioEmpleado.SeguridadMetRemover(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblEmpleado", ModeloDatos.IdEmpleado, "Se eliminó el empleado ID: " + ModeloDatos.IdEmpleado);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (OdbcException Ex)
            {
                bool esErrorLlaveForanea = false;
                foreach (OdbcError error in Ex.Errors)
                {
                    if (error.NativeError == 1451)
                    {
                        esErrorLlaveForanea = true;
                        break;
                    }
                }

                if (esErrorLlaveForanea)
                {
                    Mensaje = "No se puede eliminar este empleado porque tiene información relacionada en otro módulo del sistema. Elimine o reasigne esa información primero.";
                }
                else
                {
                    Mensaje = Ex.ToString();
                }
            }
            catch (Exception Ex)
            {
                Mensaje = Ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloEmpleado> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioEmpleado.SeguridadMetObtenerTodos();
            _ListaEmpleado = new List<ClsModeloEmpleado>();
            foreach (ClsEmpleado Item in ResultadoConsulta)
            {
                _ListaEmpleado.Add(new ClsModeloEmpleado
                {
                    _IdEmpleado = Item.IdEmpleado,
                    _CodigoEmpleado = Item.CodigoEmpleado,
                    _DpiEmpleado = Item.DpiEmpleado,
                    _NitEmpleado = Item.NitEmpleado,
                    _NombresEmpleado = Item.NombresEmpleado,
                    _ApellidosEmpleado = Item.ApellidosEmpleado,
                    _PuestoEmpleado = Item.PuestoEmpleado,
                    _GeneroEmpleado = Item.GeneroEmpleado,
                    _FechaNacimientoEmpleado = Item.FechaNacimientoEmpleado,
                    _FechaContratacionEmpleado = Item.FechaContratacionEmpleado,
                    _TelefonoEmpleado = Item.TelefonoEmpleado,
                    _CorreoEmpleado = Item.CorreoEmpleado,
                    _IsActive = Item.IsActive,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaEmpleado;
        }

        public IEnumerable<ClsModeloEmpleado> SeguridadMetBuscarPorId(int IdEmpleado)
        {
            return _ListaEmpleado.FindAll(e => e._IdEmpleado == IdEmpleado);
        }
    }
}