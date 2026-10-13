

using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaModelo_Mantenimiento2k26u.Entidades;
using CapaModelo_Mantenimiento2k26u.Repositorios;

namespace CapaControlador_Mantenimiento2k26u
{
    public enum EstadoPelicula
    {
        Ninguno = 0,
        Agregado = 1,
        Modificado = 2,
        Eliminado = 3
    }

    public class ClsModeloPelicula
    {
        private const string TABLA_BITACORA = "tblpelicula";

        private readonly ClsRepositorioPelicula _RepositorioPelicula;

        private int _IdPelicula;
        private string _NombrePelicula;
        private string _ClasificacionPelicula;
        private string _GeneroPelicula;
        private string _SubtituladoPelicula;
        private string _IdiomaPelicula;
        private double _PrecioPelicula;
        private bool _IsActive;

        public EstadoPelicula Estado { private get; set; }

        public int IdPelicula { get => _IdPelicula; set => _IdPelicula = value; }
        public string NombrePelicula { get => _NombrePelicula; set => _NombrePelicula = value; }
        public string ClasificacionPelicula { get => _ClasificacionPelicula; set => _ClasificacionPelicula = value; }
        public string GeneroPelicula { get => _GeneroPelicula; set => _GeneroPelicula = value; }
        public string SubtituladoPelicula { get => _SubtituladoPelicula; set => _SubtituladoPelicula = value; }
        public string IdiomaPelicula { get => _IdiomaPelicula; set => _IdiomaPelicula = value; }
        public double PrecioPelicula { get => _PrecioPelicula; set => _PrecioPelicula = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public string UltimoMensajeBitacora { get; private set; }

        public ClsModeloPelicula()
        {
            _RepositorioPelicula = new ClsRepositorioPelicula();
            Estado = EstadoPelicula.Ninguno;
            UltimoMensajeBitacora = string.Empty;
        }

        public string MantenimientoFuncValidar()
        {
            if (Estado == EstadoPelicula.Eliminado)
            {
                return _IdPelicula > 0 ? null : "Seleccione una película de la tabla para eliminar.";
            }

            if (string.IsNullOrWhiteSpace(_NombrePelicula))      { return "El nombre de la película es obligatorio."; }
            if (_NombrePelicula.Trim().Length > 45)              { return "El nombre no puede exceder 45 caracteres."; }
            if (string.IsNullOrWhiteSpace(_ClasificacionPelicula)) { return "La clasificación es obligatoria."; }
            if (_ClasificacionPelicula.Trim().Length > 45)       { return "La clasificación no puede exceder 45 caracteres."; }
            if (string.IsNullOrWhiteSpace(_GeneroPelicula))      { return "El género es obligatorio."; }
            if (_GeneroPelicula.Trim().Length > 45)              { return "El género no puede exceder 45 caracteres."; }
            if (string.IsNullOrWhiteSpace(_SubtituladoPelicula)) { return "Indique si la película está subtitulada."; }
            if (_SubtituladoPelicula.Trim().Length > 45)         { return "El subtitulado no puede exceder 45 caracteres."; }
            if (string.IsNullOrWhiteSpace(_IdiomaPelicula))      { return "El idioma es obligatorio."; }
            if (_IdiomaPelicula.Trim().Length > 45)              { return "El idioma no puede exceder 45 caracteres."; }
            if (_PrecioPelicula < 0)                             { return "El precio no puede ser negativo."; }
            if (_PrecioPelicula > 999999)                        { return "El precio excede el máximo permitido."; }

            return null;
        }

        public static bool MantenimientoFuncInterpretarPrecio(string Texto, out double Precio)
        {
            Precio = 0;
            if (string.IsNullOrWhiteSpace(Texto)) { return false; }

            string Limpio = Texto.Trim().Replace("Q", string.Empty).Replace(" ", string.Empty);

            return double.TryParse(Limpio, NumberStyles.Any, CultureInfo.CurrentCulture, out Precio)
                || double.TryParse(Limpio, NumberStyles.Any, CultureInfo.InvariantCulture, out Precio);
        }

        public string MantenimientoFuncGrabarCambios()
        {
            string Invalido = MantenimientoFuncValidar();
            if (Invalido != null) { return Invalido; }

            try
            {
                ClsPelicula Pelicula = new ClsPelicula
                {
                    IdPelicula            = _IdPelicula,
                    NombrePelicula        = (_NombrePelicula ?? string.Empty).Trim(),
                    ClasificacionPelicula = (_ClasificacionPelicula ?? string.Empty).Trim(),
                    GeneroPelicula        = (_GeneroPelicula ?? string.Empty).Trim(),
                    SubtituladoPelicula   = (_SubtituladoPelicula ?? string.Empty).Trim(),
                    IdiomaPelicula        = (_IdiomaPelicula ?? string.Empty).Trim(),
                    PrecioPelicula        = _PrecioPelicula,
                    IsActive              = _IsActive
                };

                switch (Estado)
                {
                    case EstadoPelicula.Agregado:
                        int IdGenerado = _RepositorioPelicula.MantenimientoFuncAgregar(Pelicula);
                        _IdPelicula = IdGenerado;
                        MantenimientoProcRegistrarBitacora(
                            "INSERT", IdGenerado,
                            "Alta de la película: " + Pelicula.NombrePelicula +
                            " | Clasificación: " + Pelicula.ClasificacionPelicula +
                            " | Género: " + Pelicula.GeneroPelicula +
                            " | Precio: " + Pelicula.PrecioPelicula.ToString("N2", CultureInfo.CurrentCulture));
                        return "Película registrada exitosamente.";

                    case EstadoPelicula.Modificado:
                        _RepositorioPelicula.MantenimientoFuncEditar(Pelicula);
                        MantenimientoProcRegistrarBitacora(
                            "UPDATE", Pelicula.IdPelicula,
                            "Modificación de la película ID " + Pelicula.IdPelicula +
                            " | Nombre: " + Pelicula.NombrePelicula +
                            " | Precio: " + Pelicula.PrecioPelicula.ToString("N2", CultureInfo.CurrentCulture) +
                            " | Estado: " + (Pelicula.IsActive ? "Activa" : "Inactiva"));
                        return "Película actualizada exitosamente.";

                    case EstadoPelicula.Eliminado:
                        // Se lee antes de borrar para poder dejar el nombre en la bitácora.
                        ClsPelicula Previa = _RepositorioPelicula.MantenimientoFuncObtenerPorId(Pelicula.IdPelicula);
                        _RepositorioPelicula.MantenimientoFuncRemover(Pelicula);
                        MantenimientoProcRegistrarBitacora(
                            "DELETE", Pelicula.IdPelicula,
                            "Eliminación de la película ID " + Pelicula.IdPelicula +
                            (Previa == null ? string.Empty : " | Nombre: " + Previa.NombrePelicula));
                        return "Película eliminada exitosamente.";

                    default:
                        return "No hay ninguna operación pendiente de grabar.";
                }
            }
            catch (OdbcException Error)
            {
                if (Error.Errors.Count > 0 && Error.Errors[0].NativeError == 1062)
                {
                    return "Ya existe una película registrada con ese nombre. Use un nombre diferente.";
                }
                if (Error.Errors.Count > 0 && Error.Errors[0].NativeError == 1451)
                {
                    return "No se puede eliminar: la película está referenciada por otros registros.";
                }
                return "Ocurrió un problema al procesar la solicitud. Verifique los datos e intente nuevamente.";
            }
            catch (Exception)
            {
                return "Ocurrió un error inesperado en el sistema. Intente nuevamente o contacte al administrador.";
            }
        }


        public DataTable MantenimientoFuncObtenerTabla()
        {
            DataTable Tabla = _RepositorioPelicula.MantenimientoFuncObtenerTabla();

            MantenimientoProcRegistrarBitacora(
                "CONSULTA", 0,
                "Consulta del catálogo de películas | Registros devueltos: " + Tabla.Rows.Count);

            return Tabla;
        }

        public DataTable MantenimientoFuncBuscarPorNombre(string Filtro)
        {
            DataTable Tabla = _RepositorioPelicula.MantenimientoFuncBuscarPorNombre(Filtro);

            MantenimientoProcRegistrarBitacora(
                "CONSULTA", 0,
                "Consulta filtrada del catálogo de películas | Criterio: \"" +
                (Filtro ?? string.Empty).Trim() + "\" | Coincidencias: " + Tabla.Rows.Count);

            return Tabla;
        }


        public DataTable MantenimientoFuncObtenerTablaSilenciosa()
        {
            return _RepositorioPelicula.MantenimientoFuncObtenerTabla();
        }

        public DataTable MantenimientoFuncObtenerReporte()
        {
            DataTable Tabla = _RepositorioPelicula.MantenimientoFuncObtenerReporte();

            MantenimientoProcRegistrarBitacora(
                "REPORTE", 0,
                "Generación del reporte del catálogo de películas | Registros impresos: " + Tabla.Rows.Count);

            return Tabla;
        }

     
        private void MantenimientoProcRegistrarBitacora(string Accion, int IdRegistro, string Detalles)
        {
            if (!ClsSesionSeguridad.HaySesionActiva)
            {
                UltimoMensajeBitacora =
                    "No hay sesión activa: la acción no se registró en la bitácora. Inicie sesión en Seguridad.";
                return;
            }

            UltimoMensajeBitacora = ClsModeloBitacora.SeguridadMetRegistrarAccion(
                Accion, TABLA_BITACORA, IdRegistro, Detalles);
        }


        public bool MantenimientoFuncBitacoraFallo()
        {
            return !string.IsNullOrEmpty(UltimoMensajeBitacora)
                && UltimoMensajeBitacora.IndexOf("Error", StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
