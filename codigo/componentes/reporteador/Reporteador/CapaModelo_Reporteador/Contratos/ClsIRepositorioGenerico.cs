using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaModelo_Reporteador.Contratos
{
    public interface ClsIRepositorioGenerico<Entity> where Entity : class
    {
        int Agregar(Entity entidad);

        int Editar(Entity entidad);

        int Remover(Entity entidad);

        IEnumerable<Entity> GetAll();
    }
}