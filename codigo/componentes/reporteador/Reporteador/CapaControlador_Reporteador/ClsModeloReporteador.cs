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

        public int IdAplicacion { get; set; }

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
        // OBTENER SIGUIENTE NÚMERO DE REPORTE
        // ============================================================

        public int ReporteadorMetObtenerSiguienteNumeroReporte(
            int CodigoModulo)
        {
            int MaximoNumero =
                _Repositorio
                .ReporteadorMetObtenerMaximoNumeroReporte(
                    CodigoModulo);

            // Si todavía no existen reportes del módulo 3000,
            // el primer número será 3001.
            if (MaximoNumero < CodigoModulo)
            {
                return CodigoModulo + 1;
            }

            // Si ya existen reportes, continúa desde el siguiente.
            return MaximoNumero + 1;
        }

        // ============================================================
        // GUARDAR / ACTUALIZAR
        // ============================================================

        public string ReporteadorMetGuardarReporte()
        {
            try
            {
                if (IdAplicacion <= 0)
                {
                    return
                        "Debe seleccionar una aplicación antes de guardar el reporte.";
                }

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
                            Reporte,
                            IdAplicacion);

                    return "Grabación exitosa";
                }

                return
                    "No se especificó una operación válida.";
            }
            catch (OdbcException)
            {
                return
                    "No se pudo guardar el reporte. "
                    + "Verifique el ID de aplicación y que "
                    + "el número, nombre y ruta sean válidos.";
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
            ReporteadorMetObtenerTodos(int IdAplicacion)
        {
            return
                _Repositorio
                .ReporteadorMetObtenerTodos(
                    IdAplicacion);
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