// Inicio - Gabriel André Guillén Pocón 0901-23-1998.
// Transacción de base de datos del Navegador.
using System;
using System.Data.Odbc;

namespace CapaModelo_Navegador
{
    // Agrupa UNA conexión y UNA transacción para que la operación (insertar, modificar o eliminar)
    // y su bitácora se ejecuten juntas: o se confirman las dos (Commit) o se deshacen las dos (Rollback).
    // La conexión se obtiene de Seguridad (herencia de ClsConexion), por eso es la misma base de datos
    // y el mismo DSN que usa la bitácora de Seguridad.
    // Uso: dentro de un "using"; si no se llama a NavegadorMetConfirmar antes de salir del bloque
    // (por un error o un return), Dispose hace Rollback solo.
    public class ClsTransaccion : CapaModelo_Seguridad.ClsConexion, IDisposable
    {
        private OdbcConnection _Conexion;
        private OdbcTransaction _Transaccion;
        private bool _Finalizada;

        public OdbcConnection Conexion { get { return _Conexion; } }
        public OdbcTransaction Transaccion { get { return _Transaccion; } }

        // Abre la conexión e inicia la transacción.
        public ClsTransaccion()
        {
            _Conexion = SeguridadMetObtenerConexion();

            try
            {
                _Conexion.Open();
                _Transaccion = _Conexion.BeginTransaction();
            }
            catch
            {
                SeguridadMetDesconexion(_Conexion);
                throw;
            }
        }

        // Confirma todo lo ejecutado dentro de la transacción.
        public void NavegadorMetConfirmar()
        {
            _Transaccion.Commit();
            _Finalizada = true;
        }

        // Deshace todo lo ejecutado dentro de la transacción.
        public void NavegadorMetRevertir()
        {
            if (_Finalizada) return;

            _Finalizada = true;
            _Transaccion.Rollback();
        }

        // Si la transacción no se confirmó, se revierte; después se libera y se cierra la conexión.
        public void Dispose()
        {
            try
            {
                NavegadorMetRevertir();
            }
            catch (OdbcException)
            {
                // Si la conexión ya se perdió, el motor descarta la transacción por sí solo.
            }
            finally
            {
                _Transaccion.Dispose();
                SeguridadMetDesconexion(_Conexion);
            }
        }
    }
}
// Fin - Gabriel André Guillén Pocón 0901-23-1998.
