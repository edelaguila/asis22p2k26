using System;
using System.Collections.Generic;
using CapaModelo_BtnEliminar_Reporteador;

namespace CapaControlador_BtnEliminar_Reporteador
{
    public class ClsModeloBtnEliminarReporteador
    {
        private readonly ClsRepositorioBtnEliminarReporteador
            _RepositorioBtnEliminarReporteador;

        public ClsModeloBtnEliminarReporteador()
        {
            _RepositorioBtnEliminarReporteador =
                new ClsRepositorioBtnEliminarReporteador();
        }

        public string ReporteadorMetDeshabilitar(
            int NumeroReporte)
        {
            try
            {
                if (NumeroReporte <= 0)
                {
                    return
                        "El número del reporte no es válido.";
                }

                if (_RepositorioBtnEliminarReporteador
                    .ReporteadorMetEstaDeshabilitado(
                        NumeroReporte))
                {
                    return
                        "El reporte ya se encuentra " +
                        "deshabilitado.";
                }

                bool Exito =
                    _RepositorioBtnEliminarReporteador
                    .ReporteadorMetDeshabilitar(
                        NumeroReporte);

                if (!Exito)
                {
                    return
                        "No se pudo deshabilitar el reporte.";
                }

                return string.Empty;
            }
            catch (Exception)
            {
                return
                    "Ocurrió un error al deshabilitar " +
                    "el reporte.";
            }
        }

        public bool ReporteadorMetEstaDeshabilitado(
            int NumeroReporte)
        {
            try
            {
                return _RepositorioBtnEliminarReporteador
                    .ReporteadorMetEstaDeshabilitado(
                        NumeroReporte);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<int>
            ReporteadorMetObtenerNumerosDeshabilitados()
        {
            try
            {
                return _RepositorioBtnEliminarReporteador
                    .ReporteadorMetObtenerTodos();
            }
            catch (Exception)
            {
                return new List<int>();
            }
        }
    }
}