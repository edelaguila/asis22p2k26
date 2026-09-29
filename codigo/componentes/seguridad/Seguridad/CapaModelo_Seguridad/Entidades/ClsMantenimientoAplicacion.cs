using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsMantenimientoAplicacion
    {
        public int IdAplicacion { get; set; }
        public int IdModulo { get; set; }
        public string NombreAplicacion { get; set; }
        public string DescripcionAplicacion { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}