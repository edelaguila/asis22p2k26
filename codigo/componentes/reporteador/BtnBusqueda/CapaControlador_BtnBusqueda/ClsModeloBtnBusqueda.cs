using System;
using System.Data;
using CapaModelo_BtnBusqueda.Repositorios;

namespace CapaControlador_BtnBusqueda
{
    public class ClsModeloBtnBusqueda
    {
        private readonly ClsRepositorioBtnBusqueda repositorio;

        public ClsModeloBtnBusqueda()
        {
            repositorio = new ClsRepositorioBtnBusqueda();
        }

        public DataTable BuscarReportes(
            string nombreReporte,
            DateTime? fechaReporte,
            bool buscarPorNombre,
            bool buscarPorFecha)
        {
            return repositorio.BuscarReportes(
                nombreReporte,
                fechaReporte,
                buscarPorNombre,
                buscarPorFecha
            );
        }
    }
}