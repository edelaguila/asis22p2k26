using System;
using System.Data.Odbc;

namespace Mantenimiento2k26.Modelo
{
    public class ClsConexion
    {
        private const string CadenaConexion = "Dsn=segundoparcial2k26f";

        public OdbcConnection ObtenerConexion()
        {
            OdbcConnection conexion = new OdbcConnection(CadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
