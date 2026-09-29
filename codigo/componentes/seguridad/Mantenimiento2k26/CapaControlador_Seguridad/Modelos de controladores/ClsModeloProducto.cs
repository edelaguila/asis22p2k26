using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Data;
using System.Data.Odbc;

namespace CapaControlador_Seguridad
{
    public class ClsModeloProducto
    {
        private int _IdProducto;
        private string _NombreProducto;
        private string _DescripcionProducto;
        private decimal _PrecioUnitario;
        private bool _IsActive;
        private ClsRepositorioProducto _RepositorioProducto;

        public EstadoEntidad Estado { private get; set; }

        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public string DescripcionProducto { get => _DescripcionProducto; set => _DescripcionProducto = value; }
        public decimal PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public ClsModeloProducto()
        {
            _RepositorioProducto = new ClsRepositorioProducto();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var Producto = new ClsProducto
                {
                    IdProducto = _IdProducto,
                    NombreProducto = _NombreProducto,
                    DescripcionProducto = _DescripcionProducto,
                    PrecioUnitario = _PrecioUnitario,
                    IsActive = _IsActive
                };

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioProducto.SeguridadMetAgregar(Producto);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblProducto", Producto.IdProducto, "Se agregó el producto: " + _NombreProducto);
                        Mensaje = "Registro guardado exitosamente.";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioProducto.SeguridadMetEditar(Producto);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblProducto", Producto.IdProducto, "Se actualizó el producto: " + _NombreProducto);
                        Mensaje = "Registro actualizado exitosamente.";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioProducto.SeguridadMetRemover(Producto);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblProducto", Producto.IdProducto, "Se eliminó el producto ID: " + Producto.IdProducto);
                        Mensaje = "Registro eliminado exitosamente.";
                        break;
                }
            }
            catch (OdbcException ex)
            {
                if (ex.Errors.Count > 0 && ex.Errors[0].NativeError == 1062)
                    Mensaje = "Ya existe un producto con ese nombre. Use un nombre diferente.";
                else
                    Mensaje = "Ocurrió un problema al procesar la solicitud. Verifique los datos e intente nuevamente.";
            }
            catch (Exception)
            {
                Mensaje = "Ocurrió un error inesperado en el sistema. Intente nuevamente o contacte al administrador.";
            }
            return Mensaje;
        }

        public DataTable SeguridadMetObtenerProductosTabla()
        {
            return _RepositorioProducto.SeguridadMetObtenerProductosTabla();
        }

        public DataTable SeguridadMetObtenerProductosReporte()
        {
            return _RepositorioProducto.SeguridadMetObtenerProductosReporte();
        }
    }
}