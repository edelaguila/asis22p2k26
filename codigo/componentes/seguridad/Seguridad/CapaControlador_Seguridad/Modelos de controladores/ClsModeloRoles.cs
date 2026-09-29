//using CapaControlador_Seguridad.Objetos_de_valor.EstadoEntidad;

using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloRoles
    {
        private int _IdRol;
        private string _NombreRol;
        private string _DescripcionRol;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioRoles _RepositorioRoles;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloRoles> _ListaRoles;

        // Autoincremental
        public int IdRol { get => _IdRol; set => _IdRol = value; }

        [Required(ErrorMessage = "El campo Nombre de Rol es requerido")]
        [RegularExpression("^[a-zA-Zá-ú\\s]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El campo Nombre debe tener entre 10 y 100 caracteres")]
        public string NombreRol { get => _NombreRol; set => _NombreRol = value; }

        [Required(ErrorMessage = "El campo Descripción de Rol es requerido")]
        [RegularExpression("^[a-zA-Zá-ú\\s]+$", ErrorMessage = "El campo Descripción debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "El campo Descripción debe tener entre 10 y 100 caracteres")]
        public string DescripcionRol { get => _DescripcionRol; set => _DescripcionRol = value; }

        // Se enlaza directamente con SeguridadChkActivo.Checked
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloRoles()
        {
            _RepositorioRoles = new ClsRepositorioRoles();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                // Validación manual del idRol
                if (Estado == EstadoEntidad.Modified || Estado == EstadoEntidad.Deleted)
                {
                    if (_IdRol <= 0)
                        return "Debe indicar un Rol válido para esta operación";
                }

                var ModeloDatosRoles = new ClsRoles();
                ModeloDatosRoles.IdRol = _IdRol;
                ModeloDatosRoles.NombreRol = _NombreRol;
                ModeloDatosRoles.DescripcionRol = _DescripcionRol;
                ModeloDatosRoles.IsActive = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioRoles.SeguridadMetAgregar(ModeloDatosRoles);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblRol", ModeloDatosRoles.IdRol, "Se agregó el perfil: " + _NombreRol);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioRoles.SeguridadMetEditar(ModeloDatosRoles);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblRol", ModeloDatosRoles.IdRol, "Se actualizó el perfil: " + _NombreRol);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioRoles.SeguridadMetRemover(ModeloDatosRoles);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblRol", ModeloDatosRoles.IdRol, "Se eliminó el rol perfil: " + ModeloDatosRoles.IdRol);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.ToString();
            }
            return Mensaje;
        }

        public List<ClsModeloRoles> SeguridadMetObtenerTodos()
        {
            var ModeloDatosRoles = _RepositorioRoles.SeguridadMetObtenerTodos();
            _ListaRoles = new List<ClsModeloRoles>();
            foreach (ClsRoles Item in ModeloDatosRoles)
            {
                _ListaRoles.Add(new ClsModeloRoles
                {
                    _IdRol = Item.IdRol,
                    _NombreRol = Item.NombreRol,
                    _DescripcionRol = Item.DescripcionRol,
                    _IsActive = Item.IsActive,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaRoles;
        }

        public IEnumerable<ClsModeloRoles> SeguridadMetBuscarPorId(int IdRol)
        {
            return _ListaRoles.FindAll(e => e._IdRol == IdRol);
        }
    }
}