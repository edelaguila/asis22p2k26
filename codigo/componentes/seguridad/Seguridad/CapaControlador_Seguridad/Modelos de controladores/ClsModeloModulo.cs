using System;
using System.Data;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad
{
    public class ClsModeloModulo
    {
        private int _IdModulo;
        private string _NombreModulo;
        private string _DescripcionModulo;
        private bool _IsActive;
        private ClsRepositorioModulo _RepositorioModulo;

        // Propiedad clave para saber si Guardamos, Editamos o Eliminamos
        public EstadoEntidad Estado { private get; set; }

        public int IdModulo { get => _IdModulo; set => _IdModulo = value; }
        public string NombreModulo { get => _NombreModulo; set => _NombreModulo = value; }
        public string DescripcionModulo { get => _DescripcionModulo; set => _DescripcionModulo = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public ClsModeloModulo()
        {
            _RepositorioModulo = new ClsRepositorioModulo();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var Modulo = new ClsModulo
                {
                    IdModulo = _IdModulo,
                    NombreModulo = _NombreModulo,
                    DescripcionModulo = _DescripcionModulo,
                    IsActive = _IsActive
                };

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioModulo.SeguridadMetAgregar(Modulo);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblModulo", Modulo.IdModulo, "Se agregó el módulo: " + _NombreModulo);
                        Mensaje = "Registro guardado exitosamente.";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioModulo.SeguridadMetEditar(Modulo);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblModulo", Modulo.IdModulo, "Se actualizó el módulo: " + _NombreModulo);
                        Mensaje = "Registro actualizado exitosamente.";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioModulo.SeguridadMetRemover(Modulo);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblModulo", Modulo.IdModulo, "Se eliminó el módulo ID: " + Modulo.IdModulo);
                        Mensaje = "Registro eliminado exitosamente.";
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensaje = "Error: " + ex.Message;
            }
            return Mensaje;
        }

        public DataTable SeguridadMetObtenerModulosTabla()
        {
            return _RepositorioModulo.SeguridadMetObtenerModulosTabla();
        }
    }
}