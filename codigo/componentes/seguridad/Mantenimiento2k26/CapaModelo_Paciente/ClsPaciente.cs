using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Paciente
{
        public class ClsPaciente
        {
            public int idPaciente { get; set; }

            public string nombrePaci { get; set; }

            public string apellidoPaci { get; set; }

            public DateTime fechaNacimiento { get; set; }

            public int generoPaci { get; set; }

            public string direccionPaci { get; set; }

            public int telefonoPaci { get; set; }

            public int estadoPaci { get; set; }
        }
    
}
