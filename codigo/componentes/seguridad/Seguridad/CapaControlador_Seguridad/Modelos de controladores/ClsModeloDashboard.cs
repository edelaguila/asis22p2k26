using CapaModelo_Seguridad.Repositorios;

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
