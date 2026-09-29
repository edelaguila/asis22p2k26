using System;

namespace CapaControlador_Consultas
{
    public static class ClsTablaSeleccionada
    {
        private static string _NombreTabla;
        // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        private static string[] _ArregloTablas;

        public static void ConsultasMetGuardarTablas(string[] Tablas)
        {
            if (Tablas == null || Tablas.Length == 0)
            {
                throw new ArgumentException("El arreglo de tablas no puede estar vacío.");
            }
            _ArregloTablas = Tablas;
        }
        // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"

        public static void ConsultasMetGuardarTabla(string NombreTabla)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
            {
                throw new ArgumentException(
                    "El nombre de la tabla no puede estar vacío.");
            }

            _NombreTabla = NombreTabla;
        }

        public static string ConsultasFuncObtenerTabla()
        {
            return _NombreTabla;
        }

        // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        public static string[] ConsultasFuncObtenerArreglo()
        {
            return _ArregloTablas;
        }
        // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"

        public static void ConsultasMetLimpiarTabla()
        {
            _NombreTabla = null;
            // Inicio de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
            _ArregloTablas = null;
            // Fin de código de "Pedro José Gómez Villalobos" - carné: "0901-23-4868" - Fecha: "20/09/26"
        }
    }
}