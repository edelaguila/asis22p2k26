using System;
using CapaModelo_BtnGuardar.Repositorios;

namespace CapaControlador_BtnGuardar
{
    public class ClsModeloBtnGuardar
    {
        private readonly ClsRepositorioBtnGuardar repositorio;

        public ClsModeloBtnGuardar()
        {
            repositorio = new ClsRepositorioBtnGuardar();
        }

        public bool EjecutarGuardado(int numeroReporte, string nombreReporte, string rutaReporte, DateTime fechaReporte, bool esEdicion, out string mensaje)
        {
            if (numeroReporte <= 0)
            {
                mensaje = "El número de reporte debe ser mayor a cero.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombreReporte))
            {
                mensaje = "El nombre del reporte no puede estar vacío.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(rutaReporte))
            {
                mensaje = "La ruta del reporte es requerida.";
                return false;
            }

            bool exito = repositorio.GuardarReporte(numeroReporte, nombreReporte, rutaReporte, fechaReporte, esEdicion, out string errorBD);

            if (exito)
            {
                mensaje = esEdicion ? "Actualización exitosa" : "Grabación exitosa";
                return true;
            }
            else
            {
                mensaje = errorBD;
                return false;
            }
        }
    }
}