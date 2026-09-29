using System.Data;
using CapaModelo_Mantenimiento2k26;

namespace CapaControlador_Mantenimiento2k26
{
    public class ClsModeloMantenimiento
    {
        private readonly ClsRepositorioPaciente _Repositorio;

        public ClsModeloMantenimiento()
        {
            _Repositorio = new ClsRepositorioPaciente();
        }

        // CONSULTAR
        public DataTable MantenimientoMetMostrarPacientes()
        {
            return _Repositorio.MantenimientoMetMostrarPacientes();
        }

        // INSERTAR
        public void MantenimientoMetInsertarPaciente(
            string NombrePaci,
            string ApellidoPaci,
            int Genero,
            string DireccionPaci,
            int TelefonoPaci,
            int EstadoPaci)
        {
            ClsPaciente Paciente = new ClsPaciente
            {
                NombrePaci = NombrePaci,
                ApellidoPaci = ApellidoPaci,
                Genero = Genero,
                DireccionPaci = DireccionPaci,
                TelefonoPaci = TelefonoPaci,
                EstadoPaci = EstadoPaci
            };

            _Repositorio.MantenimientoMetInsertarPaciente(
                Paciente);
        }

        // MODIFICAR
        public void MantenimientoMetModificarPaciente(
            int IdPaciente,
            string NombrePaci,
            string ApellidoPaci,
            int Genero,
            string DireccionPaci,
            int TelefonoPaci,
            int EstadoPaci)
        {
            ClsPaciente Paciente = new ClsPaciente
            {
                Pk_idPaciente = IdPaciente,
                NombrePaci = NombrePaci,
                ApellidoPaci = ApellidoPaci,
                Genero = Genero,
                DireccionPaci = DireccionPaci,
                TelefonoPaci = TelefonoPaci,
                EstadoPaci = EstadoPaci
            };

            _Repositorio.MantenimientoMetModificarPaciente(
                Paciente);
        }

        // ELIMINAR
        public void MantenimientoMetEliminarPaciente(
            int IdPaciente)
        {
            _Repositorio.MantenimientoMetEliminarPaciente(
                IdPaciente);
        }
    }
}