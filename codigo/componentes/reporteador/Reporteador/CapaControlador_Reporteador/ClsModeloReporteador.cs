using CapaModelo_Reporteador.Entidades;
using CapaModelo_Reporteador.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Odbc;

namespace CapaControlador_Reporteador
{
    public class ClsModeloReporteador
    {
        public int NumeroReporte { get; set; }

        public string NombreReporte { get; set; }

        public string RutaReporte { get; set; }

        public DateTime FechaReporte { get; set; }

        public ClsEstadoEntidad Estado { get; set; }

        private readonly ClsRepositorioReporteador _Repositorio;

        public ClsModeloReporteador()
        {
            _Repositorio =
                new ClsRepositorioReporteador();
        }

        // ============================================================
        // OBTENER SIGUIENTE NÚMERO
        // ============================================================

        public int ReporteadorMetObtenerSiguienteNumeroReporte(
            int CodigoModulo)
        {
            int MaximoNumero =
                _Repositorio
                .ReporteadorMetObtenerMaximoNumeroReporte(
                    CodigoModulo);

            return MaximoNumero + 1;
        }

        // ============================================================
        // GUARDAR / ACTUALIZAR
        // ============================================================

        public string ReporteadorMetGuardarReporte()
        {
            try
            {
                if (NumeroReporte <= 0)
                {
                    return
                        "El número de reporte debe ser mayor que cero.";
                }

                if (string.IsNullOrWhiteSpace(
                    NombreReporte))
                {
                    return
                        "Debe ingresar el nombre del reporte.";
                }

                if (string.IsNullOrWhiteSpace(
                    RutaReporte))
                {
                    return
                        "Debe seleccionar el archivo del reporte.";
                }

                NombreReporte =
                    NombreReporte.Trim();

                RutaReporte =
                    RutaReporte.Trim();

                int? NumeroReporteExcluir = null;

                if (Estado ==
                    ClsEstadoEntidad.Modified)
                {
                    NumeroReporteExcluir =
                        NumeroReporte;
                }

                // ----------------------------------------------------
                // VALIDAR NÚMERO
                // ----------------------------------------------------

                if (_Repositorio
                    .ReporteadorMetExisteNumeroReporte(
                        NumeroReporte,
                        NumeroReporteExcluir))
                {
                    return
                        "El número de reporte ya existe. No se puede guardar.";
                }

                // ----------------------------------------------------
                // VALIDAR NOMBRE
                // ----------------------------------------------------

                if (_Repositorio
                    .ReporteadorMetExisteNombreReporte(
                        NombreReporte,
                        NumeroReporteExcluir))
                {
                    return
                        "El nombre del reporte ya existe. No se puede guardar.";
                }

                // ----------------------------------------------------
                // VALIDAR RUTA
                // ----------------------------------------------------

                if (_Repositorio
                    .ReporteadorMetExisteRutaReporte(
                        RutaReporte,
                        NumeroReporteExcluir))
                {
                    return
                        "La ruta del reporte ya está registrada. No se puede guardar.";
                }

                ClsReporteador Reporte =
                    new ClsReporteador();

                Reporte.NumeroReporte =
                    NumeroReporte;

                Reporte.NombreReporte =
                    NombreReporte;

                Reporte.RutaReporte =
                    RutaReporte;

                Reporte.FechaReporte =
                    FechaReporte;

                // ----------------------------------------------------
                // EDITAR
                // ----------------------------------------------------

                if (Estado ==
                    ClsEstadoEntidad.Modified)
                {
                    _Repositorio
                        .ReporteadorMetEditar(
                            Reporte);

                    return "Actualización exitosa";
                }

                // ----------------------------------------------------
                // AGREGAR
                // ----------------------------------------------------

                if (Estado ==
                    ClsEstadoEntidad.Added)
                {
                    _Repositorio
                        .ReporteadorMetAgregar(
                            Reporte);

                    return "Grabación exitosa";
                }

                return
                    "No se especificó una operación válida.";
            }
            catch (OdbcException)
            {
                return
                    "No se pudo guardar el reporte. "
                    + "Verifique que el número, nombre y ruta "
                    + "no estén registrados.";
            }
            catch (Exception)
            {
                return
                    "No se pudo guardar el reporte. "
                    + "Verifique los datos e inténtelo nuevamente.";
            }
        }

        // ============================================================
        // OBTENER TODOS
        // ============================================================

        public IEnumerable<ClsReporteador>
            ReporteadorMetObtenerTodos()
        {
            return
                _Repositorio
                .ReporteadorMetObtenerTodos();
        }

        // ============================================================
        // BUSCAR POR NOMBRE
        // ============================================================

        public IEnumerable<ClsReporteador>
            ReporteadorMetBuscarPorNombre(
                string Filtro)
        {
            return
                _Repositorio
                .ReporteadorMetBuscarPorNombre(
                    Filtro);
        }

        // ============================================================
        // BUSCAR POR FECHA
        // ============================================================

        public IEnumerable<ClsReporteador>
            ReporteadorMetBuscarPorFecha(
                DateTime Fecha)
        {
            return
                _Repositorio
                .ReporteadorMetBuscarPorFecha(
                    Fecha);
        }

        // ============================================================
        // ELIMINAR
        // ============================================================

        public void ReporteadorMetEliminarReporte(
            ClsReporteador Reporte)
        {
            _Repositorio
                .ReporteadorMetRemover(
                    Reporte);
        }
    }
}