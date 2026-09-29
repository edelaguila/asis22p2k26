using CapaModelo_Reporteador.Contratos;
using CapaModelo_Reporteador.Entidades;
using CapaModelo_Reporteador.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CapaControlador_Reporteador
{
    public class ClsModeloReporteador
    {
        private int _numeroReporte = 0;
        private string _nombreReporte;
        private string _rutaReporte;
        private DateTime _fechaReporte =
            DateTime.Now.Date;

        private readonly ClsIRepositorioReporteador
            RepositorioReporteador;

        private List<ClsModeloReporteador>
            ListaReportes;


        public int CodigoModulo { get; set; } = 30;


        public ClsEstadoEntidad Estado { get; set; }



        public int NumeroReporte
        {
            get
            {
                if (_numeroReporte <= 0 &&
                    Estado == ClsEstadoEntidad.Added)
                {
                    _numeroReporte =
                        GenerarSiguienteNumeroReporte(
                            CodigoModulo
                        );
                }

                return _numeroReporte;
            }

            set
            {
                _numeroReporte = value;
            }
        }


        [Required(
            ErrorMessage =
                "El nombre del reporte es requerido."
        )]
        [StringLength(
            150,
            ErrorMessage =
                "El nombre del reporte no puede superar los 150 caracteres."
        )]
        public string NombreReporte
        {
            get
            {
                return _nombreReporte;
            }

            set
            {
                _nombreReporte = value;
            }
        }

        [Required(
            ErrorMessage =
                "La ruta del reporte es requerida."
        )]
        [StringLength(
            500,
            ErrorMessage =
                "La ruta del reporte no puede superar los 500 caracteres."
        )]
        public string RutaReporte
        {
            get
            {
                return _rutaReporte;
            }

            set
            {
                _rutaReporte = value;
            }
        }



        [Required(
            ErrorMessage =
                "La fecha del reporte es requerida."
        )]
        public DateTime FechaReporte
        {
            get
            {
                return _fechaReporte;
            }

            set
            {
                _fechaReporte = value;
            }
        }

        public ClsModeloReporteador()
        {
            RepositorioReporteador =
                new ClsRepositorioReporteador();

            Estado =
                ClsEstadoEntidad.Added;
        }


        public int GenerarSiguienteNumeroReporte(
            int codigoModulo)
        {
            int ultimoId =
                RepositorioReporteador
                .ObtenerMaximoNumeroReporte(
                    codigoModulo
                );

            if (ultimoId == 0)
            {
                return (codigoModulo * 100) + 1;
            }

            return ultimoId + 1;
        }



        private string ValidarDatos()
        {
            var resultados =
                new List<ValidationResult>();

            var contexto =
                new ValidationContext(this);

            bool valido =
                Validator.TryValidateObject(
                    this,
                    contexto,
                    resultados,
                    true
                );

            if (!valido)
            {
                string mensaje = "";

                foreach (ValidationResult resultado
                         in resultados)
                {
                    mensaje +=
                        resultado.ErrorMessage +
                        Environment.NewLine;
                }

                return mensaje.Trim();
            }

            if (_numeroReporte <= 0)
            {
                return
                    "El número del reporte no es válido.";
            }

            if (_fechaReporte == DateTime.MinValue)
            {
                return
                    "La fecha del reporte no es válida.";
            }

            return null;
        }


        public string GrabarCambios()
        {
            try
            {
                // Generar número si es nuevo
                if (Estado ==
                        ClsEstadoEntidad.Added &&
                    _numeroReporte <= 0)
                {
                    _numeroReporte =
                        GenerarSiguienteNumeroReporte(
                            CodigoModulo
                        );
                }


                // Validar
                string error =
                    ValidarDatos();

                if (!string.IsNullOrWhiteSpace(error))
                {
                    return error;
                }


                // Crear entidad
                ClsReporteador reporte =
                    new ClsReporteador
                    {
                        NumeroReporte =
                            _numeroReporte,

                        NombreReporte =
                            _nombreReporte,

                        RutaReporte =
                            _rutaReporte,

                        FechaReporte =
                            _fechaReporte.Date
                    };


                if (Estado ==
                    ClsEstadoEntidad.Added)
                {
                    RepositorioReporteador.Agregar(
                        reporte
                    );

                    return "Grabación exitosa";
                }


                if (Estado ==
                    ClsEstadoEntidad.Modified)
                {
                    RepositorioReporteador.Editar(
                        reporte
                    );

                    return "Actualización exitosa";
                }

                if (Estado ==
                    ClsEstadoEntidad.Deleted)
                {
                    RepositorioReporteador.Remover(
                        reporte
                    );

                    return "Eliminación exitosa";
                }


                return
                    "El estado del reporte no es válido.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ClsModeloReporteador> GetAll()
        {
            var datos =
                RepositorioReporteador.GetAll();

            ListaReportes =
                new List<ClsModeloReporteador>();

            foreach (ClsReporteador item in datos)
            {
                ListaReportes.Add(
                    new ClsModeloReporteador
                    {
                        NumeroReporte =
                            item.NumeroReporte,

                        NombreReporte =
                            item.NombreReporte,

                        RutaReporte =
                            item.RutaReporte,

                        FechaReporte =
                            item.FechaReporte
                    }
                );
            }

            return ListaReportes;
        }

        public IEnumerable<ClsModeloReporteador>
            BuscarPorNombre(string filtro)
        {
            var datos =
                RepositorioReporteador
                .BuscarPorNombre(filtro);

            ListaReportes =
                new List<ClsModeloReporteador>();

            foreach (ClsReporteador item in datos)
            {
                ListaReportes.Add(
                    new ClsModeloReporteador
                    {
                        NumeroReporte =
                            item.NumeroReporte,

                        NombreReporte =
                            item.NombreReporte,

                        RutaReporte =
                            item.RutaReporte,

                        FechaReporte =
                            item.FechaReporte
                    }
                );
            }

            return ListaReportes;
        }


        public IEnumerable<ClsModeloReporteador>
            BuscarPorFecha(DateTime fecha)
        {
            var datos =
                RepositorioReporteador
                .BuscarPorFecha(fecha);

            ListaReportes =
                new List<ClsModeloReporteador>();

            foreach (ClsReporteador item in datos)
            {
                ListaReportes.Add(
                    new ClsModeloReporteador
                    {
                        NumeroReporte =
                            item.NumeroReporte,

                        NombreReporte =
                            item.NombreReporte,

                        RutaReporte =
                            item.RutaReporte,

                        FechaReporte =
                            item.FechaReporte
                    }
                );
            }

            return ListaReportes;
        }
    }
}