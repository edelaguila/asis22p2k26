using System;

namespace CapaModelo_prototipoumg2k26.Entidades
{
    // Se conserva el nombre físico/clase del prototipo para no alterar la estructura del proyecto.
    // Internamente representa un registro de tbl_roles.
    public class Empleados
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string DescripcionRol { get; set; }
    }
}
