using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsPaciente
    {
        public int idPaciente { get; set; }
        public string nombrePaci { get; set; }
        public string apellidoPaci { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public bool is_active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
