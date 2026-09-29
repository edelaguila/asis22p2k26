using System;
using System.Data.Odbc;

namespace CapaModelo_Consultas
{

    //Inicio del código realizado por Diego Fernando Santizo Samayoa 0901-22-15950 21/09/2026
    internal class ClsConexion
    {
        public OdbcConnection ConsultasFuncConexion()
        {
            OdbcConnection Conexion = new OdbcConnection("Dsn=EmbutidosS.A");
            try
            {
                Conexion.Open();
            }
            catch (OdbcException Excepcion)
            {
                Console.WriteLine("Conexion fallida. Error: " + Excepcion.Message);
            }
            return Conexion;
        }

        public void ConsultasProcDesconexion(OdbcConnection Conexion)
        {
            try
            {
                Conexion.Close();
            }
            catch (OdbcException Excepcion)
            {
                Console.WriteLine("Error al cerrar la conexión. Error: " + Excepcion.Message);
            }
        }
        //Fin del código realizado por Diego Fernando Santizo Samayoa 0901-22-15950 21/09/2026
    }
}
