using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaModelo_Seguridad.Entidades
{
    public class ClsTipoPuesto
    {
        public int IdTipoPuesto { get; set; }
        public string NombreTipoPuesto { get; set; }
        public string DescripcionTipoPuesto { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}