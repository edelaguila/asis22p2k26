// Inicio cambio - Mario Alberto Taracena Pérez - 0901-23-9335
// Archivo nuevo. Sirve para "simular" un login mientras Navegador todavía no tiene su propia
// pantalla de inicio de sesión.
using System.Collections.Generic;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaControlador_Navegador
{
    // Reemplaza temporalmente el login real mientras Navegador no integra una pantalla de login
    // (ver plan de integración con Seguridad, 2026-09-17). Inicializa ClsSesionSeguridad (compartida
    // con las DLL de Seguridad) con uno de los 3 usuarios sembrados por dbSistemaEmbutidos_v1.7.sql.
    //
    // Cambiar UsuarioPrueba para alternar entre los 3 roles sembrados y comprobar que
    // ClsSeguridadFormHelper habilita/deshabilita botones distinto según el rol.
    public static class ClsSesionPrueba
    {
        // Los 3 usuarios de prueba que ya vienen sembrados en la base de datos.
        public enum UsuarioDemo
        {
            Administrador,
            Supervisor,
            Operativo
        }

        // Cambiar esta línea a Supervisor u Operativo para probar cada rol.
        private const UsuarioDemo UsuarioPrueba = UsuarioDemo.Supervisor;

        // Según el usuario elegido arriba, llena la sesión con su Id, nombre y rol reales.
        public static void NavegadorMetIniciarSesionPrueba()
        {
            switch (UsuarioPrueba)
            {
                case UsuarioDemo.Supervisor:
                    ClsSesionSeguridad.SeguridadMetIniciarSesion(
                        2, "cramirez", "Carlos Ramírez",
                        new List<ClsRolInfo> { new ClsRolInfo { IdRol = 2, NombreRol = "Supervisor" } });
                    break;

                case UsuarioDemo.Operativo:
                    ClsSesionSeguridad.SeguridadMetIniciarSesion(
                        3, "mlopez", "María López",
                        new List<ClsRolInfo> { new ClsRolInfo { IdRol = 3, NombreRol = "Operativo" } });
                    break;

                default:
                    ClsSesionSeguridad.SeguridadMetIniciarSesion(
                        1, "imelendez", "Isabel Meléndez",
                        new List<ClsRolInfo> { new ClsRolInfo { IdRol = 1, NombreRol = "Administrador" } });
                    break;
            }
        }
    }
}
// Fin cambio - Mario Alberto Taracena Pérez - 0901-23-9335
