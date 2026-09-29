using System.Data.Odbc;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaVista_Navegador
{
    // Fachada de la bitácora de Seguridad para el componente Navegador.
    // Quien use el navegador (por ejemplo el CRUD) solo pide "registra esta acción" y no necesita
    // conocer las clases de Seguridad. El usuario que queda en la bitácora es el de la sesión activa.
    public class ClsNavegadorBitacora
    {
        private readonly ClsModeloBitacora _Bitacora = new ClsModeloBitacora();

        // Se usa el método de instancia con IdUsuario explícito porque el método estático
        // SeguridadMetRegistrarAccion usa otra clase de sesión (ClsSesion) fija en el usuario 1.
        // La IP se pasa en null y Seguridad la calcula sola.
        //
        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // La bitácora se registra SIEMPRE por Seguridad, pero dentro de la transacción del CRUD:
        // se usa la sobrecarga transaccional de ClsModeloBitacora (recibe la conexión y la transacción).
        // No atrapa errores a propósito: si la bitácora falla, el error sube al CRUD y la transacción
        // completa (operación + bitácora) se revierte, así nunca queda una sin la otra.
        // El usuario de la bitácora es el de la sesión activa y la IP se pasa en null (Seguridad la calcula).
        public void NavegadorMetRegistrarBitacora(string Accion, string Tabla, int IdRegistro, string Detalles, OdbcConnection Conexion, OdbcTransaction Transaccion)
        {
            _Bitacora.SeguridadMetRegistrarBitacora(
                ClsNavegadorSesion.NavegadorFuncIdUsuario(), Accion, Tabla, IdRegistro, Detalles, null, Conexion, Transaccion);
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
    }
}
