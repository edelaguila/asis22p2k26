using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsAsigUsuPerf
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public DateTime FechaAsignacionUsuarioRol { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public string NombreUsuario { get; set; }
        public string NombreRol { get; set; }
    }
}
