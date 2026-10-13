/*
 * ==================================================================
 * Área   : Mantenimiento2k26u
 * Autor  : José Pablo Cano Cóbar
 * Carné  : 0901-23-1727
 * Fecha  : 13/10/2026
 * ==================================================================
 * Propósito :
 *   VARIANTE del mantenimiento que, en lugar de un CRUD propio, hospeda
 *   el control Navegador del componente del mismo nombre y lo configura
 *   sobre tblpelicula. Existe por si en el examen piden explícitamente
 *   consumir ese componente.
 *
 * Reglas específicas :
 *   - El formulario hereda de Form. NO debe heredar de FrmNavegadorCrud:
 *     esa clase no está en los <Compile Include> de CapaVista_Navegador,
 *     no existe en la DLL compilada y ni siquiera compilaría contra las
 *     firmas actuales.
 *   - El Navegador registra en bitácora INSERT, UPDATE y DELETE por su
 *     cuenta, dentro de la misma transacción del CRUD. Pero NO registra
 *     consulta ni reporte, y el enunciado exige las cinco acciones: por
 *     eso este formulario escucha el evento NavegadorAccionSolicitada y
 *     agrega esas dos.
 *   - El evento es solo informativo: avisa y después el control ejecuta
 *     la acción igual. No se puede cancelar desde aquí.
 *   - Requiere junto al ejecutable las DLL del Navegador y las cinco del
 *     componente Consultas: el botón CONSULTAR instancia FrmConsultasSimples.
 * ===================================================================
*/

using System;
using System.Windows.Forms;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaVista_Mantenimiento2k26u
{
    public partial class FrmPeliculasNavegador : Form
    {
        private const string TABLA = "tblpelicula";
        private const int ID_MODULO = 20;       // Catálogos
        private const int ID_APLICACION = 21;   // Películas

        public FrmPeliculasNavegador()
        {
            InitializeComponent();

            MantenimientoPnlNavegador.Text = string.Empty;

            MantenimientoLblUsuario.Text = ClsSesionSeguridad.HaySesionActiva
                ? "Usuario: " + ClsSesionSeguridad.NombreUsuario +
                  "   |   " + ClsSesionSeguridad.NombreEmpleado +
                  "   |   Rol: " + ClsSesionSeguridad.SeguridadMetRolesComoTexto()
                : "Sin sesión activa";

            // Observador: solo para completar la bitácora de consulta y reporte.
            MantenimientoNavegador.NavegadorAccionSolicitada += MantenimientoMetAccionSolicitada;

            // La línea que configura todo el CRUD: tabla, módulo y aplicación.
            MantenimientoNavegador.NavegadorMetConfigurar(TABLA, ID_MODULO, ID_APLICACION);
        }

        private void MantenimientoMetAccionSolicitada(string Accion)
        {
            MantenimientoLblAccion.Text = "Última acción: " + Accion;

            if (!ClsSesionSeguridad.HaySesionActiva) { return; }

            // El componente ya registra INSERT, UPDATE y DELETE.
            // Aquí se completan las dos que le faltan al enunciado.
            switch (Accion)
            {
                case "CONSULTAR":
                    ClsModeloBitacora.SeguridadMetRegistrarAccion(
                        "CONSULTA", TABLA, 0,
                        "Consulta del catálogo de películas desde el componente Navegador");
                    break;

                case "IMPRIMIR":
                    ClsModeloBitacora.SeguridadMetRegistrarAccion(
                        "REPORTE", TABLA, 0,
                        "Solicitud de reporte del catálogo de películas desde el componente Navegador");
                    break;
            }
        }
    }
}
