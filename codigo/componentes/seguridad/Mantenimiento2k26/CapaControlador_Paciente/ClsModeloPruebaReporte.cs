using CapaModelo_Paciente;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Paciente
{
    public class ClsModeloPaciente
    {
        private int _PkIdPaciente;
        private string _NombrePac;
        private string _ApellidoPac;
        private DateTime _FechaNacimiento;
        private int _Genero;
        private string _DireccionPac;
        private int _Telefono;
        private int _EstadoPac;

        private ClsRepositorioPaciente
            _RepositorioPaciente;

        private List<ClsModeloPaciente>
            _ListaPacientes;

        public EstadoEntidad Estado
        {
            private get;
            set;
        }

        public int PkIdPaciente
        {
            get => _PkIdPaciente;
            set => _PkIdPaciente = value;
        }

        [Required(
            ErrorMessage =
            "El campo Nombre del Paciente es requerido")]
        [StringLength(
            50,
            ErrorMessage =
            "El nombre del paciente no puede superar los 50 caracteres")]
        public string NombrePac
        {
            get => _NombrePac;
            set => _NombrePac = value;
        }

        [Required(
            ErrorMessage =
            "El campo Apellido del Paciente es requerido")]
        [StringLength(
            50,
            ErrorMessage =
            "El apellido del paciente no puede superar los 50 caracteres")]
        public string ApellidoPac
        {
            get => _ApellidoPac;
            set => _ApellidoPac = value;
        }

        [Required(
            ErrorMessage =
            "El campo Fecha de Nacimiento es requerido")]
        public DateTime FechaNacimiento
        {
            get => _FechaNacimiento;
            set => _FechaNacimiento = value;
        }

        [Required(
            ErrorMessage =
            "El campo Género es requerido")]
        public int Genero
        {
            get => _Genero;
            set => _Genero = value;
        }

        [Required(
            ErrorMessage =
            "El campo Dirección es requerido")]
        [StringLength(
            30,
            ErrorMessage =
            "La dirección no puede superar los 30 caracteres")]
        public string DireccionPac
        {
            get => _DireccionPac;
            set => _DireccionPac = value;
        }

        [Required(
            ErrorMessage =
            "El campo Teléfono es requerido")]
        public int Telefono
        {
            get => _Telefono;
            set => _Telefono = value;
        }

        [Required(
            ErrorMessage =
            "El campo Estado es requerido")]
        public int EstadoPac
        {
            get => _EstadoPac;
            set => _EstadoPac = value;
        }

        public ClsModeloPaciente()
        {
            _RepositorioPaciente =
                new ClsRepositorioPaciente();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;

            try
            {
                var ModeloDatos =
                    new ClsPaciente();

                ModeloDatos.PkIdPaciente =
                    _PkIdPaciente;

                ModeloDatos.NombrePac =
                    _NombrePac;

                ModeloDatos.ApellidoPac =
                    _ApellidoPac;

                ModeloDatos.FechaNacimiento =
                    _FechaNacimiento;

                ModeloDatos.Genero =
                    _Genero;

                ModeloDatos.DireccionPac =
                    _DireccionPac;

                ModeloDatos.Telefono =
                    _Telefono;

                ModeloDatos.EstadoPac =
                    _EstadoPac;

                switch (Estado)
                {
                    case EstadoEntidad.Added:

                        _RepositorioPaciente
                            .SeguridadMetAgregar(
                                ModeloDatos);

                        ClsModeloBitacora
                            .SeguridadMetRegistrarAccion(
                                "INSERT",
                                "tbl_paciente",
                                ModeloDatos.PkIdPaciente,
                                "Se agregó el paciente: "
                                + _NombrePac
                                + " "
                                + _ApellidoPac);

                        Mensaje =
                            "Grabacion exitosa";

                        break;

                    case EstadoEntidad.Modified:

                        _RepositorioPaciente
                            .SeguridadMetEditar(
                                ModeloDatos);

                        ClsModeloBitacora
                            .SeguridadMetRegistrarAccion(
                                "UPDATE",
                                "tbl_paciente",
                                ModeloDatos.PkIdPaciente,
                                "Se actualizó el paciente: "
                                + _NombrePac
                                + " "
                                + _ApellidoPac);

                        Mensaje =
                            "Actualizacion exitosa";

                        break;

                    case EstadoEntidad.Deleted:

                        _RepositorioPaciente
                            .SeguridadMetRemover(
                                ModeloDatos);

                        ClsModeloBitacora
                            .SeguridadMetRegistrarAccion(
                                "DELETE",
                                "tbl_paciente",
                                ModeloDatos.PkIdPaciente,
                                "Se eliminó el paciente ID: "
                                + ModeloDatos.PkIdPaciente);

                        Mensaje =
                            "Eliminacion exitosa";

                        break;
                }
            }
            catch (OdbcException Ex)
            {
                bool EsErrorLlaveForanea = false;
                bool EsValorDuplicado = false;
                bool EsDatoDemasiadoLargo = false;

                foreach (OdbcError Error in Ex.Errors)
                {
                    if (Error.NativeError == 1451 ||
                        Error.NativeError == 1452)
                    {
                        EsErrorLlaveForanea = true;
                    }
                    else if (Error.NativeError == 1062)
                    {
                        EsValorDuplicado = true;
                    }
                    else if (Error.NativeError == 1406)
                    {
                        EsDatoDemasiadoLargo = true;
                    }
                }

                if (EsErrorLlaveForanea)
                {
                    Mensaje =
                        "No se puede eliminar este paciente porque se encuentra relacionado con otro registro.";
                }
                else if (EsValorDuplicado)
                {
                    Mensaje =
                        "Ya existe un paciente con ese identificador.";
                }
                else if (EsDatoDemasiadoLargo)
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

        public List<ClsModeloPaciente>
            SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta =
                _RepositorioPaciente
                    .SeguridadMetObtenerTodos();

            _ListaPacientes =
                new List<ClsModeloPaciente>();

            foreach (
                ClsPaciente Item
                in ResultadoConsulta)
            {
                _ListaPacientes.Add(
                    new ClsModeloPaciente
                    {
                        _PkIdPaciente =
                            Item.PkIdPaciente,

                        _NombrePac =
                            Item.NombrePac,

                        _ApellidoPac =
                            Item.ApellidoPac,

                        _FechaNacimiento =
                            Item.FechaNacimiento,

                        _Genero =
                            Item.Genero,

                        _DireccionPac =
                            Item.DireccionPac,

                        _Telefono =
                            Item.Telefono,

                        _EstadoPac =
                            Item.EstadoPac
                    });
            }

            return _ListaPacientes;
        }

        public IEnumerable<ClsModeloPaciente>
            SeguridadMetBuscarPorId(
                int IdPaciente)
        {
            if (_ListaPacientes == null)
            {
                SeguridadMetObtenerTodos();
            }

            return _ListaPacientes.FindAll(
                p =>
                    p._PkIdPaciente ==
                    IdPaciente);
        }

        public IEnumerable<ClsModeloPaciente>
            SeguridadMetBuscarPorNombre(
                string NombrePaciente)
        {
            if (_ListaPacientes == null)
            {
                SeguridadMetObtenerTodos();
            }

            return _ListaPacientes.FindAll(
                p =>
                    p._NombrePac
                        .IndexOf(
                            NombrePaciente,
                            StringComparison
                                .OrdinalIgnoreCase)
                        >= 0);
        }

        public IEnumerable<ClsModeloPaciente>
            SeguridadMetBuscarPorApellido(
                string ApellidoPaciente)
        {
            if (_ListaPacientes == null)
            {
                SeguridadMetObtenerTodos();
            }

            return _ListaPacientes.FindAll(
                p =>
                    p._ApellidoPac
                        .IndexOf(
                            ApellidoPaciente,
                            StringComparison
                                .OrdinalIgnoreCase)
                        >= 0);
        }
    }
}
