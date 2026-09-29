using System;
using System.IO;
using CapaModelo_BtnRuta_Reporteador.Repositorios;

namespace CapaModelo_BtnRuta_Reporteador
{
    public class ClsModeloBtnRutaReporteador
    {
        // Referencia al repositorio del componente.
        private readonly ClsRepositorioBtnRutaReporteador
            _Repositorio;

        public ClsModeloBtnRutaReporteador()
        {
            _Repositorio =
                new ClsRepositorioBtnRutaReporteador();
        }

        // Valida la ruta seleccionada por el usuario.
        public bool ReporteadorMetValidarRuta(
            string RutaReporte,
            out string Mensaje)
        {
            Mensaje =
                string.Empty;

            // Verifica que se haya seleccionado una ruta.
            if (string.IsNullOrWhiteSpace(
                RutaReporte))
            {
                Mensaje =
                    "La ruta del reporte es requerida.";

                return false;
            }

            // Verifica que el archivo exista.
            if (!File.Exists(RutaReporte))
            {
                Mensaje =
                    "El archivo seleccionado no existe.";

                return false;
            }

            // Obtiene la extensión del archivo.
            string Extension =
                Path.GetExtension(RutaReporte);

            // Solo se permiten archivos PDF.
            if (!Extension.Equals(
                ".rdlc",
                StringComparison.OrdinalIgnoreCase))
            {
                Mensaje =
                    "El archivo seleccionado debe ser " +
                    "un documento .rdlc";

                return false;
            }

            return true;
        }
    }
}