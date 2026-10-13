namespace CapaModelo_Reporteador.Entidades
{
    /// <summary>
    /// Estados utilizados para identificar la operación
    /// que se realizará sobre una entidad.
    /// </summary>
    public enum ClsEstadoEntidad
    {
        // Registro nuevo.
        Added,

        // Registro existente que será actualizado.
        Modified,

        // Registro que será eliminado.
        Removed,

        // Estado heredado de versiones anteriores.
        // Se conserva para evitar romper referencias existentes.
        Agregar
    }
}