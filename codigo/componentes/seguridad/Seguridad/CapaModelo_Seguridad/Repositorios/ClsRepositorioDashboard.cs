using System.Data;
/*
 * ==================================================================
 * Área : Seguridad
 * Autor : André De Jesús Gonzalez Camey
 * Fecha : 23/09/2026
 * ==================================================================
 * Propósito :
 * Repositorio de datos encargado de ejecutar las consultas SQL
 * necesarias para obtener el conteo de registros de las tablas
 * principales del módulo de Seguridad: tblUsuario (usuarios
 * activos), tblRol (perfiles activos), tblModulo, tblAplicacion,
 * tblBitacora y tblUsuarioRol (asignaciones). Cada método retorna
 * un entero con el total obtenido directamente desde la base de
 * datos, siguiendo el patrón de herencia de ClsSentencias.
 * ===================================================================
*/
namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioDashboard : ClsSentencias
    {
        public int SeguridadMetContarUsuarios()
        {
            var Tabla = SeguridadMetEjecucionConsulta(
                "SELECT COUNT(*) FROM tblUsuario WHERE is_active = 1", CommandType.Text);
            return Tabla.Rows.Count > 0 ? int.Parse(Tabla.Rows[0][0].ToString()) : 0;
        }

        public int SeguridadMetContarAplicaciones()
        {
            var Tabla = SeguridadMetEjecucionConsulta(
                "SELECT COUNT(*) FROM tblAplicacion", CommandType.Text);
            return Tabla.Rows.Count > 0 ? int.Parse(Tabla.Rows[0][0].ToString()) : 0;
        }

        public int SeguridadMetContarPerfiles()
        {
            var Tabla = SeguridadMetEjecucionConsulta(
                "SELECT COUNT(*) FROM tblRol WHERE is_active = 1", CommandType.Text);
            return Tabla.Rows.Count > 0 ? int.Parse(Tabla.Rows[0][0].ToString()) : 0;
        }

        public int SeguridadMetContarModulos()
        {
            var Tabla = SeguridadMetEjecucionConsulta(
                "SELECT COUNT(*) FROM tblModulo", CommandType.Text);
            return Tabla.Rows.Count > 0 ? int.Parse(Tabla.Rows[0][0].ToString()) : 0;
        }

        public int SeguridadMetContarBitacora()
        {
            var Tabla = SeguridadMetEjecucionConsulta(
                "SELECT COUNT(*) FROM tblBitacora", CommandType.Text);
            return Tabla.Rows.Count > 0 ? int.Parse(Tabla.Rows[0][0].ToString()) : 0;
        }

        public int SeguridadMetContarAsignaciones()
        {
            var Tabla = SeguridadMetEjecucionConsulta(
                "SELECT COUNT(*) FROM tblUsuarioRol", CommandType.Text);
            return Tabla.Rows.Count > 0 ? int.Parse(Tabla.Rows[0][0].ToString()) : 0;
        }
    }
}
