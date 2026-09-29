using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Odbc;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloPruebaReporte
    {
        private int _NumeroReporte;
        private string _NombreReporte;
        private string _RutaReporte;
        private DateTime _FechaReporte;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;

        private ClsRepositorioPruebaReporte
            _RepositorioPruebaReporte;

        private List<ClsModeloPruebaReporte>
            _ListaReportes;

        public EstadoEntidad Estado
        {
            private get;
            set;
        }

        [Required(
            ErrorMessage =
            "El campo Número de Reporte es requerido")]
        public int NumeroReporte
        {
            get => _NumeroReporte;
            set => _NumeroReporte = value;
        }

        [Required(
            ErrorMessage =
            "El campo Nombre del Reporte es requerido")]
        [StringLength(
            150,
            ErrorMessage =
            "El nombre del reporte no puede superar los 150 caracteres")]
        public string NombreReporte
        {
            get => _NombreReporte;
            set => _NombreReporte = value;
        }

        [Required(
            ErrorMessage =
            "El campo Ruta del Reporte es requerido")]
        [StringLength(
            500,
            ErrorMessage =
            "La ruta del reporte no puede superar los 500 caracteres")]
        public string RutaReporte
        {
            get => _RutaReporte;
            set => _RutaReporte = value;
        }

        [Required(
            ErrorMessage =
            "El campo Fecha del Reporte es requerido")]
        public DateTime FechaReporte
        {
            get => _FechaReporte;
            set => _FechaReporte = value;
        }

        public DateTime CreatedAt
        {
            get => _CreatedAt;
            private set => _CreatedAt = value;
        }

        public DateTime UpdatedAt
        {
            get => _UpdatedAt;
            private set => _UpdatedAt = value;
        }

        public ClsModeloPruebaReporte()
        {
            _RepositorioPruebaReporte =
                new ClsRepositorioPruebaReporte();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;

            try
            {
                var ModeloDatos =
                    new ClsPruebaReporte();

                ModeloDatos.NumeroReporte =
                    _NumeroReporte;

                ModeloDatos.NombreReporte =
                    _NombreReporte;

                ModeloDatos.RutaReporte =
                    _RutaReporte;

                ModeloDatos.FechaReporte =
                    _FechaReporte;

                switch (Estado)
                {
                    case EstadoEntidad.Added:

                        _RepositorioPruebaReporte
                            .SeguridadMetAgregar(
                                ModeloDatos);

                        ClsModeloBitacora
                            .SeguridadMetRegistrarAccion(
                                "INSERT",
                                "tblReporte",
                                ModeloDatos.NumeroReporte,
                                "Se agregó el reporte: "
                                + _NombreReporte);

                        Mensaje =
                            "Grabacion exitosa";

                        break;

                    case EstadoEntidad.Modified:

                        _RepositorioPruebaReporte
                            .SeguridadMetEditar(
                                ModeloDatos);

                        ClsModeloBitacora
                            .SeguridadMetRegistrarAccion(
                                "UPDATE",
                                "tblReporte",
                                ModeloDatos.NumeroReporte,
                                "Se actualizó el reporte: "
                                + _NombreReporte);

                        Mensaje =
                            "Actualizacion exitosa";

                        break;

                    case EstadoEntidad.Deleted:

                        _RepositorioPruebaReporte
                            .SeguridadMetRemover(
                                ModeloDatos);

                        ClsModeloBitacora
                            .SeguridadMetRegistrarAccion(
                                "DELETE",
                                "tblReporte",
                                ModeloDatos.NumeroReporte,
                                "Se eliminó el reporte ID: "
                                + ModeloDatos.NumeroReporte);

                        Mensaje =
                            "Eliminacion exitosa";

                        break;
                }
            }
            catch (OdbcException Ex)
            {
                bool esErrorLlaveForanea = false;
                bool esValorDuplicado = false;
                bool esDatoDemasiadoLargo = false;

                foreach (OdbcError error in Ex.Errors)
                {
                    if (error.NativeError == 1451 ||
                        error.NativeError == 1452)
                    {
                        esErrorLlaveForanea = true;
                    }
                    else if (error.NativeError == 1062)
                    {
                        esValorDuplicado = true;
                    }
                    else if (error.NativeError == 1406)
                    {
                        esDatoDemasiadoLargo = true;
                    }
                }

                if (esErrorLlaveForanea)
                {
                    Mensaje =
                        "No se puede eliminar este reporte porque se encuentra relacionado con una aplicación.";
                }
                else if (esValorDuplicado)
                {
                    Mensaje =
                        "Ya existe un reporte con ese número o nombre.";
                }
                else if (esDatoDemasiadoLargo)
                {
                    Mensaje =
                        "Uno de los campos ingresados excede la longitud permitida.";
                }
                else
                {
                    Mensaje =
                        "Ocurrió un problema al procesar la solicitud. Verifique los datos e intente nuevamente.";
                }
            }
            catch (Exception Ex)
            {
                Mensaje =
                    "Ocurrió un error inesperado en el sistema. Intente nuevamente o contacte al administrador.";
            }

            return Mensaje;
        }

        public List<ClsModeloPruebaReporte>
            SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta =
                _RepositorioPruebaReporte
                    .SeguridadMetObtenerTodos();

            _ListaReportes =
                new List<ClsModeloPruebaReporte>();

            foreach (
                ClsPruebaReporte Item
                in ResultadoConsulta)
            {
                _ListaReportes.Add(
                    new ClsModeloPruebaReporte
                    {
                        _NumeroReporte =
                            Item.NumeroReporte,

                        _NombreReporte =
                            Item.NombreReporte,

                        _RutaReporte =
                            Item.RutaReporte,

                        _FechaReporte =
                            Item.FechaReporte,

                        _CreatedAt =
                            Item.CreatedAt,

                        _UpdatedAt =
                            Item.UpdatedAt
                    });
            }

            return _ListaReportes;
        }

        public IEnumerable<ClsModeloPruebaReporte>
            SeguridadMetBuscarPorNumero(
                int NumeroReporte)
        {
            if (_ListaReportes == null)
            {
                SeguridadMetObtenerTodos();
            }

            return _ListaReportes.FindAll(
                r =>
                    r._NumeroReporte ==
                    NumeroReporte);
        }

        public IEnumerable<ClsModeloPruebaReporte>
            SeguridadMetBuscarPorNombre(
                string NombreReporte)
        {
            if (_ListaReportes == null)
            {
                SeguridadMetObtenerTodos();
            }

            return _ListaReportes.FindAll(
                r =>
                    r._NombreReporte
                        .IndexOf(
                            NombreReporte,
                            StringComparison
                                .OrdinalIgnoreCase)
                        >= 0);
        }
    }
}
