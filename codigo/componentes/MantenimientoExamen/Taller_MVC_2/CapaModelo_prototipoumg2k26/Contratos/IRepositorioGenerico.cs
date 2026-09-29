using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_prototipoumg2k26.Contratos
{
    public interface IRepositorioGenerico<Entity> where Entity : class
    {
        int Agregar(Entity entidad); // Agregar 
        int Editar(Entity entidad); //Editar
        int Remover (Entity entidad); // Eliminar
        IEnumerable<Entity> GetAll(); // Listar los datos
    }
}
