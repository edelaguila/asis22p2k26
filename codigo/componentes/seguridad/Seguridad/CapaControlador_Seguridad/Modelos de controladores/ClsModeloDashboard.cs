using CapaModelo_Seguridad.Repositorios;
/*
 * ==================================================================
 * Área : Seguridad
 * Autor : André De Jesús Gonzalez Camey
 * Fecha : 23/09/2026
 * ==================================================================
 * Propósito :
 * Modelo de controlador que actúa como intermediario entre la capa
 * de vista y el repositorio ClsRepositorioDashboard. Expone seis
 * métodos que delegan la consulta de conteos al repositorio,
 * permitiendo que el formulario MDI obtenga los datos de los KPIs
 * sin acoplarse directamente a la capa de acceso a datos.
 * ===================================================================
*/
namespace CapaControlador_Seguridad
{
    public class ClsModeloDashboard
    {
        private readonly ClsRepositorioDashboard _Repositorio;

        public ClsModeloDashboard()
        {
            _Repositorio = new ClsRepositorioDashboard();
        }

        public int SeguridadMetUsuarios() => _Repositorio.SeguridadMetContarUsuarios();
        public int SeguridadMetAplicaciones() => _Repositorio.SeguridadMetContarAplicaciones();
        public int SeguridadMetPerfiles() => _Repositorio.SeguridadMetContarPerfiles();
        public int SeguridadMetModulos() => _Repositorio.SeguridadMetContarModulos();
        public int SeguridadMetBitacora() => _Repositorio.SeguridadMetContarBitacora();
        public int SeguridadMetAsignaciones() => _Repositorio.SeguridadMetContarAsignaciones();
    }
}
