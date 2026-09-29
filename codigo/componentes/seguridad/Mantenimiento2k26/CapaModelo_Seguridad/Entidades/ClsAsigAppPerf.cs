using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito : Entidad de la capa Modelo Sus propiedades (get/set)
 * guardan el Rol, Módulo y Aplicación relacionados, los
 * permisos de Insertar, Editar, Eliminar e Imprimir, y las
 * fechas de creación y última actualización del registro.
 * ===================================================================
 */


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