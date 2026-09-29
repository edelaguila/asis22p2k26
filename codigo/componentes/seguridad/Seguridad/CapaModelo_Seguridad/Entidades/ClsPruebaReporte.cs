using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsPruebaReporte
    {
        public int NumeroReporte { get; set; }
        public string NombreReporte { get; set; }
        public string RutaReporte { get; set; }
        public DateTime FechaReporte { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
