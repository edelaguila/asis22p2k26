using System;
using System.Collections.Generic;
using System.Linq;
/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito : Clase estática que guarda los datos del usuario que
 * inició sesión como: usuario, empleado y sus roles mientras
 * el sistema está abierto. Desde aquí se consulta si hay
 * sesión activa, se verifica si el usuario tiene cierto
 * rol y se maneja el inicio y cierre de sesión.
 * ===================================================================
 */

namespace CapaControlador_Seguridad.Objetos_de_valor
{
    public static class ClsSesionSeguridad
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NombreEmpleado { get; set; }
        public static List<ClsRolInfo> Roles { get; set; } = new List<ClsRolInfo>();

        public static bool HaySesionActiva => IdUsuario > 0;

        public static List<int> IdsRoles => Roles.Select(r => r.IdRol).ToList();

        public static bool SeguridadMetTieneRol(int idRol)
            => Roles.Any(r => r.IdRol == idRol);

        public static bool SeguridadMetTieneRol(string nombreRol)
            => Roles.Any(r => r.NombreRol.Equals(nombreRol, StringComparison.OrdinalIgnoreCase));

        public static string SeguridadMetRolesComoTexto()
            => string.Join(", ", Roles.Select(r => r.NombreRol));

        public static string SeguridadMetObtenerIPLocal()
        {
            try
            {
                var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
            }
            catch { }
            return "127.0.0.1";
        }

        public static void SeguridadMetIniciarSesion(int idUsuario,
            string nombreUsuario, string nombreEmpleado, List<ClsRolInfo> roles)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            NombreEmpleado = nombreEmpleado;
            Roles = roles ?? new List<ClsRolInfo>();
        }

        public static void SeguridadMetCerrarSesion()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            NombreEmpleado = null;
            Roles.Clear();
        }
    }
}