using System;
using System.Data;
using CapaModelo_BtnBusqueda.Repositorios;

namespace CapaControlador_BtnBusqueda
{
    public class ClsModeloBtnBusqueda
    {
        private readonly ClsRepositorioBtnBusqueda
            _Repositorio;

        public ClsModeloBtnBusqueda()
        {
            _Repositorio =
                new ClsRepositorioBtnBusqueda();
        }

        public DataTable ReporteadorMetBuscarReportes(
            string NombreReporte,
            DateTime? FechaReporte,
            bool BuscarPorNombre,
            bool BuscarPorFecha)
        {
            return _Repositorio
                .ReporteadorMetBuscarReportes(
                    NombreReporte,
                    FechaReporte,
                    BuscarPorNombre,
                    BuscarPorFecha);
        }

        /*
         * Método de compatibilidad.
         *
         * El BtnBusqueda.cs existente utiliza
         * BuscarReportes().
         *
         * No es necesario modificar ese archivo
         * para que siga funcionando.
         */
        public DataTable BuscarReportes(
            string NombreReporte,
            DateTime? FechaReporte,
            bool BuscarPorNombre,
            bool BuscarPorFecha)
        {
            return ReporteadorMetBuscarReportes(
                NombreReporte,
                FechaReporte,
                BuscarPorNombre,
                BuscarPorFecha);
        }
    }
}