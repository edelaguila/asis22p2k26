
using System.Collections.Generic;
using System.Data;
using CapaModelo_Mantenimiento2k26u.Entidades;

namespace CapaModelo_Mantenimiento2k26u.Contratos
{
    public interface IRepositorioPelicula
    {
        int MantenimientoFuncAgregar(ClsPelicula Entidad);
        int MantenimientoFuncEditar(ClsPelicula Entidad);
        int MantenimientoFuncRemover(ClsPelicula Entidad);

        IEnumerable<ClsPelicula> MantenimientoFuncObtenerTodas();
        DataTable MantenimientoFuncObtenerTabla();
        DataTable MantenimientoFuncObtenerReporte();
        DataTable MantenimientoFuncBuscarPorNombre(string Filtro);
        ClsPelicula MantenimientoFuncObtenerPorId(int IdPelicula);
    }
}
