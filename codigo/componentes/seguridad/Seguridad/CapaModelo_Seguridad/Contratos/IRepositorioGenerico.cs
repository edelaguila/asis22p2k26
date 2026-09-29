using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Contratos
{
    /*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito : Interface genérica que define las funciones básicas
 * que debe tener cualquier repositorio del sistema:
 * agregar, editar, eliminar y obtener todos los registros.
 * ===================================================================
 */

    public interface IRepositorioGenerico<Entidad> where Entidad : class
    {
        int SeguridadMetAgregar(Entidad Entidad);
        int SeguridadMetEditar(Entidad Entidad);
        int SeguridadMetRemover(Entidad Entidad); 
        IEnumerable<Entidad> SeguridadMetObtenerTodos(); 
    }
}