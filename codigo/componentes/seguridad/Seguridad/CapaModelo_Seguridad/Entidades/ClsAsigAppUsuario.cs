using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsAsigAppUsuario
    {
        public int IdUsuario { get; set; }
        public int IdModulo { get; set; }
        public int IdAplicacion { get; set; }

        public bool DerInsertarUsuarioModuloAplicacion { get; set; }
        public bool DerEditarUsuarioModuloAplicacion { get; set; }
        public bool DerEliminarUsuarioModuloAplicacion { get; set; }
        public bool DerImprimirUsuarioModuloAplicacion { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}