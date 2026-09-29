using System;
using System.Data.Odbc;

/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito : Clase base para conectarse a la base de datos por ODBC
 * usando el DSN EmbutidosS.A. De aquí heredan los
 * repositorios para abrir y cerrar la conexión.
 * ===================================================================
 */

namespace CapaModelo_Seguridad
{
    public abstract class ClsConexion
    {
        protected readonly string _ConnectionString;

        public ClsConexion()
        {
            _ConnectionString = "Dsn=EmbutidosS.A";
        }

        protected OdbcConnection SeguridadMetObtenerConexion()
        {
            return new OdbcConnection(_ConnectionString);
        }

        public void SeguridadMetDesconexion(OdbcConnection ConexionOdbc)
        {
            try
            {
                ConexionOdbc.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se desconecto");
            }
        }
    }
}