using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsUsuarios
    {
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public int IsActive { get; set; }
        public string ContrasenaUsuario { get; set; }
        public DateTime UltimoAccesoUsuario { get; set; }
        public string NombreEmpleado { get; set; }
    }
}