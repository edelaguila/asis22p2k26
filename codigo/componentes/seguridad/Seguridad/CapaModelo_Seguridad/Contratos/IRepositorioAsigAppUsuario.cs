using CapaModelo_Seguridad.Entidades;

/*
 * ============================================================
 * Área         : Seguridad
 * Autor        : Evelyn Sofía Andrade Luna
 * Carné        : 9959-23-1224
 * Autor        : Guillermo Daniel Morales Mendizabal
 * Carné        : 0901-23-3329
 * Fecha        : 24/09/2026
 * ============================================================
 * Propósito    :
 *   Contrato de repositorio para la entidad AsigAppUsuario.
 *   Define la interfaz que debe implementar el repositorio
 *   de asignación de aplicaciones a usuarios, heredando las
 *   operaciones genéricas del repositorio base.
 * ============================================================
 */

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioAsigAppUsuario : IRepositorioGenerico<ClsAsigAppUsuario>
    {
    }
}