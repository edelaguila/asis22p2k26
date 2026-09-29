using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad
{
    public enum EstadoEntidad
    {
        Added,
        Deleted,
        Modified

  
    }
    public class EstadoEntidadValor
    {
        public string Texto { get; set; }
        public int Valor { get; set; }
    }

}
