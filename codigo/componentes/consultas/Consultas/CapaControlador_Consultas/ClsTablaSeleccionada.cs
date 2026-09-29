using System;

namespace CapaControlador_Consultas
{
    public static class ClsTablaSeleccionada
    {
        private static string _NombreTabla;

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

        public static void ConsultasMetLimpiarTabla()
        {
            _NombreTabla = null;
        }
    }
}