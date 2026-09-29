/*
 * ==================================================================
 * Área : Seguridad - Mantenimiento2k26
 * Autor : Byron Alexander
 * Carné : 0901-23-3747
 * Fecha : 29/09/2026
 * ==================================================================
 * Propósito :
 *  Acceso a datos de la tabla departamento por ODBC (DSN
 *  segundoparcial2k26b). Aquí y solo aquí existe SQL. Lo usa el
 *  reporte; el CRUD lo hace el componente Navegador.
 * ===================================================================
*/

using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Mantenimiento2k26
{
    public class ClsRepositorioDepartamento
    {
        private const string _ConnectionString = "Dsn=segundoparcial2k26b";

        private const string _SelectAll =
            "SELECT codigo_departamento, nombre_departamento, estatus_departamento " +
            "FROM departamento ORDER BY codigo_departamento";

        public DataTable Mantenimiento2k26FuncObtenerTodos()
        {
            DataTable Datos = new DataTable();

            using (OdbcConnection Conexion = new OdbcConnection(_ConnectionString))
            using (OdbcDataAdapter Adaptador = new OdbcDataAdapter(_SelectAll, Conexion))
            {
                Adaptador.Fill(Datos);
            }

            return Datos;
        }
    }
}
