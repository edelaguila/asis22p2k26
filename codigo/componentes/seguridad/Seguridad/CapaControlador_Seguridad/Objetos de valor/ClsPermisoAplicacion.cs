using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad.Objetos_de_valor
{
    /*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito: Clase que representa los permisos de un usuario sobre
 * una aplicación (Insertar, Editar, Eliminar, Imprimir).
 * Incluye un método para combinar los permisos de varios
 * roles, quedándose con el permiso más alto entre ellos.
 * ===================================================================
 */
    public class ClsPermisoAplicacion
    {
        public bool TieneAcceso { get; set; }
        public bool PuedeInsertar { get; set; }
        public bool PuedeEditar { get; set; }
        public bool PuedeEliminar { get; set; }
        public bool PuedeImprimir { get; set; }

        public ClsPermisoAplicacion SeguridadMetCombinar(ClsPermisoAplicacion Otro)
        {
            if (Otro == null) return this;

            return new ClsPermisoAplicacion
            {
                TieneAcceso = this.TieneAcceso || Otro.TieneAcceso,
                PuedeInsertar = this.PuedeInsertar || Otro.PuedeInsertar,
                PuedeEditar = this.PuedeEditar || Otro.PuedeEditar,
                PuedeEliminar = this.PuedeEliminar || Otro.PuedeEliminar,
                PuedeImprimir = this.PuedeImprimir || Otro.PuedeImprimir
            };
        }
    }
}
