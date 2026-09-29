using CapaControlador_Seguridad.Objetos_de_valor;

// Inicio - José Javier Torres Martínez 0901-23-1091.
namespace CapaVista_Navegador
{
    // Único punto por donde el Navegador consulta la sesión de Seguridad. La sesión (usuario, empleado y
    // roles) la crea el Login de Seguridad en ClsSesionSeguridad; el Navegador NO tiene sesión propia ni
    // de prueba. Con esos roles y el Módulo/Aplicación configurados, Seguridad calcula los permisos
    // (Insertar, Editar, Eliminar, Imprimir) que habilitan o deshabilitan los botones (ver ClsCrudSeguridad).
    public static class ClsNavegadorSesion
    {
        // True si alguien inició sesión en el Login de Seguridad.
        public static bool NavegadorFuncHaySesion()
        {
            return ClsSesionSeguridad.HaySesionActiva;
        }

        // Id del usuario en sesión (el que queda en la bitácora).
        public static int NavegadorFuncIdUsuario()
        {
            return ClsSesionSeguridad.IdUsuario;
        }

        public static string NavegadorFuncNombreUsuario()
        {
            return ClsSesionSeguridad.NombreUsuario;
        }

        // Roles del usuario en sesión, separados por coma.
        public static string NavegadorFuncRoles()
        {
            return ClsSesionSeguridad.SeguridadMetRolesComoTexto();
        }
    }
}
// Fin - José Javier Torres Martínez 0901-23-1091.
