using System.Collections.Generic;

namespace CapaModelo_Reporteador.Contratos
{
    /// <summary>
    /// Contrato genérico para las operaciones básicas
    /// de los repositorios.
    /// </summary>
    /// <typeparam name="Entity">
    /// Tipo de entidad que manejará el repositorio.
    /// </typeparam>
    public interface ClsIRepositorioGenerico<Entity>
        where Entity : class
    {
        // Agrega una entidad.
        int ReporteadorMetAgregar(
            Entity Entidad);

        // Edita una entidad existente.
        int ReporteadorMetEditar(
            Entity Entidad);

        // Elimina una entidad.
        int ReporteadorMetRemover(
            Entity Entidad);

        // Obtiene todas las entidades.
        IEnumerable<Entity>
            ReporteadorMetObtenerTodos();
    }
}