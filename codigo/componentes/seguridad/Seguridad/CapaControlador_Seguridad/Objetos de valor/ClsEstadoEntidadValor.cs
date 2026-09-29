using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad
{

    /*
     * ==================================================================
     * Área: Seguridad
     * Autores: Lourdes Isabel Melendez Pineda
     * Fecha o ultima edicion: 23/09/2026
     * ==================================================================
     * Propósito : indica en qué estado está un registro antes
     * de grabarlo (Agregado, Modificado o Eliminado), para
     * que el modelo sepa qué operación ejecutar al guardar.
     * ===================================================================
     */
    public enum EstadoEntidad
    {
        Added,
        Deleted,
        Modified


    }
   

}