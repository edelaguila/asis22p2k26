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
    public class ClsModeloTipoPuesto
    {
        private int _IdTipoPuesto;
        private string _NombreTipoPuesto;
        private string _DescripcionTipoPuesto;
        private bool _IsActive;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;
        private ClsRepositorioTipoPuesto _RepositorioTipoPuesto;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloTipoPuesto> _ListaTipoPuesto;

        public int IdTipoPuesto { get => _IdTipoPuesto; set => _IdTipoPuesto = value; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [RegularExpression("^[a-zA-ZÁ-Úá-ú ]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede exceder 100 caracteres")]
        public string NombreTipoPuesto { get => _NombreTipoPuesto; set => _NombreTipoPuesto = value; }

        [StringLength(255, ErrorMessage = "El campo Descripción no puede exceder 255 caracteres")]
        public string DescripcionTipoPuesto { get => _DescripcionTipoPuesto; set => _DescripcionTipoPuesto = value; }

        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public DateTime CreatedAt { get => _CreatedAt; private set => _CreatedAt = value; }
        public DateTime UpdatedAt { get => _UpdatedAt; private set => _UpdatedAt = value; }

        public ClsModeloTipoPuesto()
        {
            _RepositorioTipoPuesto = new ClsRepositorioTipoPuesto();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsTipoPuesto();
                ModeloDatos.IdTipoPuesto = _IdTipoPuesto;
                ModeloDatos.NombreTipoPuesto = _NombreTipoPuesto?.Trim();
                ModeloDatos.DescripcionTipoPuesto = _DescripcionTipoPuesto;
                ModeloDatos.IsActive = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioTipoPuesto.SeguridadMetAgregar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblTipoPuesto", ModeloDatos.IdTipoPuesto, "Se agregó el tipo de puesto: " + _NombreTipoPuesto);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioTipoPuesto.SeguridadMetEditar(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblTipoPuesto", ModeloDatos.IdTipoPuesto, "Se actualizó el tipo de puesto: " + _NombreTipoPuesto);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioTipoPuesto.SeguridadMetRemover(ModeloDatos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblTipoPuesto", ModeloDatos.IdTipoPuesto, "Se eliminó el tipo de puesto ID: " + ModeloDatos.IdTipoPuesto);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (OdbcException Ex)
            {
                bool esErrorLlaveForanea = false;
                bool esValorDuplicado = false;
                bool esDatoDemasiadoLargo = false;

                foreach (OdbcError error in Ex.Errors)
                {
                    if (error.NativeError == 1451 || error.NativeError == 1452)
                        esErrorLlaveForanea = true;
                    else if (error.NativeError == 1062)
                        esValorDuplicado = true;
                    else if (error.NativeError == 1406)
                        esDatoDemasiadoLargo = true;
                }

                if (esErrorLlaveForanea)
                    Mensaje = "No se puede eliminar este tipo de puesto porque tiene una relacion en otro módulo del sistema.";
                else if (esValorDuplicado)
                    Mensaje = "Ya existe un tipo de puesto con ese nombre. Verifique los datos ingresados.";
                else if (esDatoDemasiadoLargo)
                    Mensaje = "Uno de los campos ingresados excede la longitud permitida.";
                else
                    Mensaje = "Ocurrió un problema al procesar la solicitud. Verifique los datos e intente nuevamente.";
            }
            catch (Exception)
            {
                Mensaje = "Ocurrió un error inesperado en el sistema. Intente nuevamente o contacte al administrador.";
            }
            return Mensaje;
        }

        public List<ClsModeloTipoPuesto> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioTipoPuesto.SeguridadMetObtenerTodos();
            _ListaTipoPuesto = new List<ClsModeloTipoPuesto>();
            foreach (ClsTipoPuesto Item in ResultadoConsulta)
            {
                _ListaTipoPuesto.Add(new ClsModeloTipoPuesto
                {
                    _IdTipoPuesto = Item.IdTipoPuesto,
                    _NombreTipoPuesto = Item.NombreTipoPuesto,
                    _DescripcionTipoPuesto = Item.DescripcionTipoPuesto,
                    _IsActive = Item.IsActive,
                    _CreatedAt = Item.CreatedAt,
                    _UpdatedAt = Item.UpdatedAt
                });
            }
            return _ListaTipoPuesto;
        }

        // Busca por nombre (coincidencia parcial, sin distinguir mayúsculas)
        public IEnumerable<ClsModeloTipoPuesto> SeguridadMetBuscarPorNombre(string Nombre)
        {
            if (_ListaTipoPuesto == null)
                SeguridadMetObtenerTodos();

            return _ListaTipoPuesto.FindAll(t =>
                t._NombreTipoPuesto.IndexOf(Nombre.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
