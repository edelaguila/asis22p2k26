/*
 * Autor: Julio Roberto Rosales Mejía.
 * Carné: 0901-23-1426
 * Creación de clase "ClsConexionBD.cs"
 * Documentación Interna del código.
 */

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Navegador
{
    //Clase encargada de administrar la conexión entre el componente
    //Navegaor y la base de datos.
    public class ClsConexionBD
    {
        //Conexión utilizada durante una transacción.
        private OdbcConnection ConexionTransaccion = null;

        //Transacción actualmente activa.
        private OdbcTransaction TransaccionActual = null;

        //Crea y abre una conexión con la base de datos mediante ODBC (Abrir ODBC con la bases de datos).
        //El método devuelve el objeot de conexión para que otras clases puedan utilizarlo para realizar
        //Operaciones sobre la misma base de datos. 

        public OdbcConnection NavegadorFuncConexion()
        {
            //Si existe una conexión activa para una transacción,
            //se reutiliza la misma conexión.
            if (ConexionTransaccion != null &&
                ConexionTransaccion.State == System.Data.ConnectionState.Open)
            {
                return ConexionTransaccion;
            }

            //Se crea la conexión utilizando el DSN configurado para la base de datos.
            //El valor entre corchetes debe sustituirse por el nombre correspondiente de la base de datos.

            // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
            // Se apunta al DSN "EmbutidosS.A", que es el mismo que usa el componente Seguridad
            // (base de datos dbSistemaEmbutidos), para poder leer los permisos reales de los usuarios.
            OdbcConnection Conexion = new OdbcConnection("Dsn=dbsistemaembutidos");
            // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

            try
            {
                //Intenta abrir la conexión con la base de datos.
                Conexion.Open();
            }
            catch (OdbcException)
            {
                // Si ocurre un error relacionado con la conexión ODBC,
                // Se informa del problema medainte un mensaje de consola (cambiar por un mensaje en pantalla).

                Console.WriteLine("Error al conectar a la base de datos");
            }

            //Se devuleve la conexión creada para que pueda ser utilizada
            //Por las clases que necesiten acceder a la base de datos.

            return Conexion;
        }

        //Cierra una conexión existente con la base de datos.
        //Recibe como parámetro la conexión que se desea cerrar.

        public void NavegadorMetDesconexion(OdbcConnection Conexion)
        {
            try
            {
                //No se debe cerrar la conexión si pertenece
                //a una transacción que todavía está activa.
                if (Conexion == ConexionTransaccion && TransaccionActual != null)
                {
                    return;
                }

                // Primero se verifica qque la conexión exista y que no
                // Se encuentre cerrada antes de intentar cerrarla.

                if (Conexion != null && Conexion.State != System.Data.ConnectionState.Closed)
                {
                    // Se cierra la conexión para liberar el recurso
                    // Utilizado por la comunicación con la base de datos.
                    Conexion.Close();
                }
            }
            catch (OdbcException)
            {
                // Si ocurre un error durante el cierre de la conexión, 
                // Se muestar un mensaje indicando el problema (Cambiar por un meensaje de error en pantalla).

                Console.WriteLine("Error al desconectar de la base de datos");
            }
        }

       
        // Inicia una transacción utilizando la misma conexión que posteriormente será utilizada por las operacione de INSERT, UPDATE y DELETE.
       
        public bool NavegadorFuncIniciarTransaccion()
        {
            try
            {
                if (TransaccionActual != null)
                    return false;

                ConexionTransaccion = NavegadorFuncConexion();

                if (ConexionTransaccion == null ||
                    ConexionTransaccion.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }

                TransaccionActual = ConexionTransaccion.BeginTransaction();

                return true;
            }
            catch (OdbcException)
            {
                TransaccionActual = null;
                ConexionTransaccion = null;

                Console.WriteLine("Error al iniciar la transacción");
                return false;
            }
        }

       // Confirma todas las operaciones realizadas dentro de la transacción actual.
        public bool NavegadorMetCommit()
        {
            try
            {
                if (TransaccionActual == null)
                    return false;

                TransaccionActual.Commit();

                TransaccionActual.Dispose();
                TransaccionActual = null;

                if (ConexionTransaccion != null)
                {
                    ConexionTransaccion.Close();
                    ConexionTransaccion.Dispose();
                }

                ConexionTransaccion = null;

                return true;
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al confirmar la transacción");
                return false;
            }
        }

        //Revierte todas las operaciones realizadas dentro de la transacción actual.
        public bool NavegadorMetRollback()
        {
            try
            {
                if (TransaccionActual == null)
                    return false;

                TransaccionActual.Rollback();

                TransaccionActual.Dispose();
                TransaccionActual = null;

                if (ConexionTransaccion != null)
                {
                    ConexionTransaccion.Close();
                    ConexionTransaccion.Dispose();
                }

                ConexionTransaccion = null;

                return true;
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error al revertir la transacción");
                return false;
            }
        }

        // Permite verificar si actualmente existe una transacción activa.
        public bool NavegadorFuncTransaccionActiva()
        {
            return TransaccionActual != null;
        }

        // Devuelve la transacción actualmente activa para que los comandos SQL puedan utilizarla.
        public OdbcTransaction NavegadorFuncTransaccionActual()
        {
            return TransaccionActual;
        }
    }
}


/*
 *
 *FIN DEL PROGRAMA
 *AUTOR: Julio Roberto Rosales Mejía
 *Carné: 0901-23-1426
 *
 **/