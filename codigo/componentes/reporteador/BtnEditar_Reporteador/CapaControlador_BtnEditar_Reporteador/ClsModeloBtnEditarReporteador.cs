using CapaModelo_BtnEditar_Reporteador.Repositorios;
using System;

namespace CapaControlador_BtnEditar_Reporteador
{
    public class ClsModeloBtnEditarReporteador
    {
        private readonly ClsRepositorioBtnEditarReporteador _Repositorio;

        public ClsModeloBtnEditarReporteador()
        {
            _Repositorio =
                new ClsRepositorioBtnEditarReporteador();
        }

        public bool ReporteadorMetEjecutarEdicion(
            int NumeroReporte,
            string NombreReporte,
            string RutaReporte,
            DateTime FechaReporte,
            out string Mensaje)
        {
            if (NumeroReporte <= 0)
            {
                Mensaje =
                    "Debe seleccionar un reporte.";

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                NombreReporte))
            {
                Mensaje =
                    "El nombre del reporte no puede estar vacío.";

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                RutaReporte))
            {
                Mensaje =
                    "La ruta del reporte es requerida.";

                return false;
            }

            bool Exito =
                _Repositorio.ReporteadorMetEditarReporte(
                    NumeroReporte,
                    NombreReporte,
                    RutaReporte,
                    FechaReporte,
                    out string MensajeError);

            if (Exito)
            {
                Mensaje =
                    "Actualización exitosa";

                return true;
            }

            Mensaje =
                string.IsNullOrWhiteSpace(MensajeError)
                ? "No se pudo actualizar el reporte."
                : MensajeError;

            return false;
        }
    }
}