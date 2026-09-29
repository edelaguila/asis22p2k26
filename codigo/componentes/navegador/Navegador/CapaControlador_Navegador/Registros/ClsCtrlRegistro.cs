// Dylan Rene Hernandez Recinos 16/09/2026
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using CapaModelo_Navegador;

namespace CapaControlador_Navegador
{
    // Controlador para las operaciones que modifican registros: Insertar, Actualizar y Eliminar.
    // La validación de datos se hace en ClsModeloRegistro (CapaControlador_Navegador.Validaciones).
    public class ClsCtrlRegistro
    {
        private ClsRegistros _Registros = new ClsRegistros();

        // Verifica si ya existe un registro con esa llave primaria (evita duplicados).
        public bool NavegadorFuncExisteLlavePrimaria(string NombreTabla, string[] CamposPK, string[] ValoresPK)
        {
            return _Registros.NavegadorFuncExisteLlavePrimaria(NombreTabla, CamposPK, ValoresPK);
        }

        // Verifica si un valor ya existe en un campo (para campos únicos).
        public bool NavegadorFuncExisteValorCampo(string NombreTabla, string NombreCampo, string Valor)
        {
            return _Registros.NavegadorFuncExisteValorCampo(NombreTabla, NombreCampo, Valor);
        }

        // Inserta un nuevo registro en la tabla.
        public bool NavegadorFuncInsertarRegistro(string NombreTabla, Dictionary<string, string> Datos)
        {
            return _Registros.NavegadorFuncInsertarRegistro(NombreTabla, Datos);
        }

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Sobrecarga transaccional: inserta usando la conexión y la transacción recibidas
        // (la transacción la crea y la confirma quien llama, junto con la bitácora).
        public bool NavegadorFuncInsertarRegistro(string NombreTabla, Dictionary<string, string> Datos, OdbcConnection Conexion, OdbcTransaction Transaccion)
        {
            return _Registros.NavegadorFuncInsertarRegistro(NombreTabla, Datos, Conexion, Transaccion);
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // Actualiza un registro existente según su llave primaria.
        public bool NavegadorFuncActualizarRegistro(string NombreTabla, Dictionary<string, string> Valores, Dictionary<string, string> ClavesPrimarias)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
                throw new ArgumentException("El nombre de la tabla es obligatorio.");

            if (Valores == null || Valores.Count == 0)
                throw new ArgumentException("No existen datos para actualizar.");

            if (ClavesPrimarias == null || ClavesPrimarias.Count == 0)
                throw new ArgumentException("No se encontró la llave primaria del registro.");

            return _Registros.NavegadorFuncActualizarRegistro(NombreTabla, Valores, ClavesPrimarias);
        }

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Sobrecarga transaccional: actualiza usando la conexión y la transacción recibidas.
        public bool NavegadorFuncActualizarRegistro(string NombreTabla, Dictionary<string, string> Valores, Dictionary<string, string> ClavesPrimarias, OdbcConnection Conexion, OdbcTransaction Transaccion)
        {
            NavegadorMetValidarLlaves(NombreTabla, ClavesPrimarias);

            if (Valores == null || Valores.Count == 0)
                throw new ArgumentException("No existen datos para actualizar.");

            return _Registros.NavegadorFuncActualizarRegistro(NombreTabla, Valores, ClavesPrimarias, Conexion, Transaccion);
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // Elimina un registro según su llave primaria.
        public bool NavegadorFuncEliminarRegistro(string NombreTabla, Dictionary<string, string> ClavesPrimarias)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
                throw new ArgumentException("El nombre de la tabla es obligatorio.");

            if (ClavesPrimarias == null || ClavesPrimarias.Count == 0)
                throw new ArgumentException("No se encontró la llave primaria del registro.");

            return _Registros.NavegadorFuncEliminarRegistro(NombreTabla, ClavesPrimarias);
        }

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Sobrecarga transaccional: elimina usando la conexión y la transacción recibidas.
        public bool NavegadorFuncEliminarRegistro(string NombreTabla, Dictionary<string, string> ClavesPrimarias, OdbcConnection Conexion, OdbcTransaction Transaccion)
        {
            NavegadorMetValidarLlaves(NombreTabla, ClavesPrimarias);

            return _Registros.NavegadorFuncEliminarRegistro(NombreTabla, ClavesPrimarias, Conexion, Transaccion);
        }

        // Validaciones comunes de las sobrecargas transaccionales (mismos mensajes que las originales).
        private void NavegadorMetValidarLlaves(string NombreTabla, Dictionary<string, string> ClavesPrimarias)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
                throw new ArgumentException("El nombre de la tabla es obligatorio.");

            if (ClavesPrimarias == null || ClavesPrimarias.Count == 0)
                throw new ArgumentException("No se encontró la llave primaria del registro.");
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
    }
}
