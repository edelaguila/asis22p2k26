/*
 * ==================================================================
 * Área : Seguridad - Mantenimiento2k26
 * Autor : Byron Alexander
 * Carné : 0901-23-3747
 * Fecha : 29/09/2026
 * ==================================================================
 * Propósito :
 *  Entrega a la Vista los datos para configurar el Navegador
 *  (tabla, Módulo 4 Seguridad, Aplicación 16 Departamentos) y los
 *  datos del reporte, registrando el reporte en la Bitácora de
 *  Seguridad.
 * ===================================================================
*/

using System.Data;
using CapaControlador_Seguridad;
using CapaModelo_Mantenimiento2k26;

namespace CapaControlador_Mantenimiento2k26
{
    public class ClsControladorDepartamento
    {
        private const int _IdModulo = 4;
        private const int _IdAplicacion = 16;

        private readonly ClsRepositorioDepartamento _Repositorio = new ClsRepositorioDepartamento();

        public string Mantenimiento2k26FuncTabla()
        {
            return ClsDepartamento.Tabla;
        }

        public int Mantenimiento2k26FuncIdModulo()
        {
            return _IdModulo;
        }

        public int Mantenimiento2k26FuncIdAplicacion()
        {
            return _IdAplicacion;
        }

        // Datos del reporte. La acción queda en la bitácora con el usuario en sesión.
        public DataTable Mantenimiento2k26FuncObtenerReporte()
        {
            DataTable Datos = _Repositorio.Mantenimiento2k26FuncObtenerTodos();

            ClsModeloBitacora.SeguridadMetRegistrarAccion(
                "Reporte", ClsDepartamento.Tabla, 0, "Reporte de departamentos (" + Datos.Rows.Count + " registros)");

            return Datos;
        }
    }
}
