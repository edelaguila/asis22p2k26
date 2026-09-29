using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        int SeguridadMetAgregar(Entidad Entidad);
        int SeguridadMetEditar(Entidad Entidad);
        int SeguridadMetRemover(Entidad Entidad); 
        IEnumerable<Entidad> SeguridadMetObtenerTodos(); 
    }
}