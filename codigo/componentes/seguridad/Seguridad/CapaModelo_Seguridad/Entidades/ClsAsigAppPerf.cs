using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsAsigAppPerf
    {
        //IMPORTANTE TODOS ESTOS CAMPOS DEBEN SER IGUAL A COMO
        //LO TENGAN EN SU BASE DE DATOS PARA QUE HAGAN MATCH
        public int IdRol { get; set; }
        public int IdModulo { get; set; }
        public int IdAplicacion { get; set; }
        public string NombreRol { get; set; }          
        public string NombreModulo { get; set; }      
        public string NombreAplicacion { get; set; }

        public bool DerInsertarRolModuloAplicacion { get; set; }
        public bool DerEditarRolModuloAplicacion { get; set; }
        public bool DerEliminarRolModuloAplicacion { get; set; }
        public bool DerImprimirRolModuloAplicacion { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}