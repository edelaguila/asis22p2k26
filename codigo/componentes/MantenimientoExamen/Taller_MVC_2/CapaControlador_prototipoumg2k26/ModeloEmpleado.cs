using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaModelo_prototipoumg2k26.Contratos;
using CapaModelo_prototipoumg2k26.Entidades;
using CapaModelo_prototipoumg2k26.Repositorios;

namespace CapaControlador_prototipoumg2k26
{
    // Se conserva el nombre de la clase por compatibilidad con el prototipo original.
    // El modelo representa ahora un Rol.
    public class ModeloEmpleado
    {
        private int _idRol;
        private string _nombreRol;
        private string _descripcionRol;
        private readonly IRepositorioEmpleados repositorioRoles;
        private List<ModeloEmpleado> listaRoles;

        public EstadoEntidad Estado { private get; set; }

        public int IdRol
        {
            get => _idRol;
            set => _idRol = value;
        }

        [Required(ErrorMessage = "El nombre del rol es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre del rol debe tener entre 2 y 50 caracteres")]
        public string NombreRol
        {
            get => _nombreRol;
            set => _nombreRol = value;
        }

        [StringLength(200, ErrorMessage = "La descripción no puede exceder 200 caracteres")]
        public string DescripcionRol
        {
            get => _descripcionRol;
            set => _descripcionRol = value;
        }

        public ModeloEmpleado()
        {
            repositorioRoles = new RepositorioEmpleados();
            listaRoles = new List<ModeloEmpleado>();
        }

        public string GrabarCambios()
        {
            try
            {
                var rol = new Empleados
                {
                    IdRol = _idRol,
                    NombreRol = _nombreRol?.Trim(),
                    DescripcionRol = string.IsNullOrWhiteSpace(_descripcionRol)
                        ? null
                        : _descripcionRol.Trim()
                };

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        repositorioRoles.Agregar(rol);
                        return "Rol registrado correctamente.";

                    case EstadoEntidad.Modified:
                        repositorioRoles.Editar(rol);
                        return "Rol actualizado correctamente.";

                    case EstadoEntidad.Deleted:
                        repositorioRoles.Remover(rol);
                        return "Rol eliminado correctamente.";

                    default:
                        return "No se ha seleccionado una operación válida.";
                }
            }
            catch (Exception ex)
            {
                return "Error al procesar el rol: " + ex.Message;
            }
        }

        public List<ModeloEmpleado> GetAll()
        {
            var datos = repositorioRoles.GetAll();
            listaRoles = new List<ModeloEmpleado>();

            foreach (Empleados item in datos)
            {
                listaRoles.Add(new ModeloEmpleado
                {
                    _idRol = item.IdRol,
                    _nombreRol = item.NombreRol,
                    _descripcionRol = item.DescripcionRol
                });
            }

            return listaRoles;
        }

        public IEnumerable<ModeloEmpleado> FindbyId(string filter)
        {
            if (listaRoles == null || listaRoles.Count == 0)
                GetAll();

            if (string.IsNullOrWhiteSpace(filter))
                return listaRoles;

            string criterio = filter.Trim();
            return listaRoles.FindAll(r =>
                r.IdRol.ToString().Contains(criterio) ||
                (!string.IsNullOrEmpty(r.NombreRol) && r.NombreRol.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(r.DescripcionRol) && r.DescripcionRol.IndexOf(criterio, StringComparison.OrdinalIgnoreCase) >= 0));
        }
    }
}
