using System;
using System.Windows.Forms;
using CapaVista_Navegador;
namespace Ejecucion_Navegador
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
            // Ya no hay sesión de prueba: el usuario y sus roles salen de la sesión que crea el Login de
            // Seguridad (ClsSesionSeguridad); el Navegador la consulta con ClsNavegadorSesion.
            // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

            Application.Run(new FrmPrincipal());
        }
    }
}
