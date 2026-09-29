using CapaModelo_Seguridad.Entidades;

 /* ============================================================
 * Área : Seguridad
 * Autor : Daniella Jurado
 * Carné : 0901-23-3679
 * Fecha : 23/09/2026
 * ============================================================
 * Propósito :
 * Define las operaciones que debe cumplir el repositorio encargado
 * de administrar las asignaciones de perfiles a los usuarios.
 * Hereda las operaciones generales del repositorio genérico y
 * establece que estas trabajarán con la información de la entidad
 * ClsAsignacionPerfiles.
 * ============================================================
 */

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioAsignacionPerfiles : IRepositorioGenerico<ClsAsignacionPerfiles>
    {
    }
}
