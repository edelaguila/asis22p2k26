/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Samayoa y Oscar Morales
 * Carné : 9959-23-3424 y 9959-23-3070
 * Fecha : 24/09/2026
 * ==================================================================
 * Propósito :
 *  Contrato de repositorio para la entidad Bitacora.
 *  Define la interfaz que debe implementar el repositorio
 *  de bitacora, heredando las operaciones genéricas del repositorio 
 *  base.
 * ===================================================================
*/

using CapaModelo_Seguridad.Entidades;

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioBitacora : IRepositorioGenerico<ClsBitacora>
    {
    }
}
