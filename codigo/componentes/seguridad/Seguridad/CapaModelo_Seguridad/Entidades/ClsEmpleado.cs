using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsEmpleado
    {
        public int IdEmpleado { get; set; }
        public string CodigoEmpleado { get; set; }
        public string DpiEmpleado { get; set; }
        public string NitEmpleado { get; set; }
        public string NombresEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string PuestoEmpleado { get; set; }
        public string GeneroEmpleado { get; set; }
        public DateTime FechaNacimientoEmpleado { get; set; }
        public DateTime FechaContratacionEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string CorreoEmpleado { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}