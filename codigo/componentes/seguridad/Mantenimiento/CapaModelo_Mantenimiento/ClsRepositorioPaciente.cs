using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Mantenimiento2k26
{
    public class ClsRepositorioPaciente
    {
        private readonly string _CadenaConexion =
            "Dsn=segundoparcial2k26f";

        // ==========================================
        // CONSULTAR
        // ==========================================

        public DataTable MantenimientoMetMostrarPacientes()
        {
            DataTable TablaPacientes = new DataTable();

            using (OdbcConnection Conexion =
                new OdbcConnection(_CadenaConexion))
            {
                string Consulta =
                    @"SELECT pk_idPaciente,
                             nombrePaci,
                             apellidoPaci,
                             Genero,
                             direccionPaci,
                             telefonoPaci,
                             estadoPaci
                      FROM tbl_paciente";

                using (OdbcDataAdapter Adaptador =
                    new OdbcDataAdapter(Consulta, Conexion))
                {
                    Adaptador.Fill(TablaPacientes);
                }
            }

            return TablaPacientes;
        }

        // ==========================================
        // INSERTAR
        // ==========================================

        public void MantenimientoMetInsertarPaciente(
            ClsPaciente Paciente)
        {
            using (OdbcConnection Conexion =
                new OdbcConnection(_CadenaConexion))
            {
                Conexion.Open();

                string Consulta =
                    @"INSERT INTO tbl_paciente
                      (
                          nombrePaci,
                          apellidoPaci,
                          Genero,
                          direccionPaci,
                          telefonoPaci,
                          estadoPaci
                      )
                      VALUES (?, ?, ?, ?, ?, ?)";

                using (OdbcCommand Comando =
                    new OdbcCommand(Consulta, Conexion))
                {
                    Comando.Parameters.AddWithValue(
                        "@Nombre",
                        Paciente.NombrePaci);

                    Comando.Parameters.AddWithValue(
                        "@Apellido",
                        Paciente.ApellidoPaci);

                    Comando.Parameters.AddWithValue(
                        "@Genero",
                        Paciente.Genero);

                    Comando.Parameters.AddWithValue(
                        "@Direccion",
                        Paciente.DireccionPaci);

                    Comando.Parameters.AddWithValue(
                        "@Telefono",
                        Paciente.TelefonoPaci);

                    Comando.Parameters.AddWithValue(
                        "@Estado",
                        Paciente.EstadoPaci);

                    Comando.ExecuteNonQuery();
                }
            }
        }

        // ==========================================
        // MODIFICAR
        // ==========================================

        public void MantenimientoMetModificarPaciente(
            ClsPaciente Paciente)
        {
            using (OdbcConnection Conexion =
                new OdbcConnection(_CadenaConexion))
            {
                Conexion.Open();

                string Consulta =
                    @"UPDATE tbl_paciente
                      SET nombrePaci = ?,
                          apellidoPaci = ?,
                          Genero = ?,
                          direccionPaci = ?,
                          telefonoPaci = ?,
                          estadoPaci = ?
                      WHERE pk_idPaciente = ?";

                using (OdbcCommand Comando =
                    new OdbcCommand(Consulta, Conexion))
                {
                    Comando.Parameters.AddWithValue(
                        "@Nombre",
                        Paciente.NombrePaci);

                    Comando.Parameters.AddWithValue(
                        "@Apellido",
                        Paciente.ApellidoPaci);

                    Comando.Parameters.AddWithValue(
                        "@Genero",
                        Paciente.Genero);

                    Comando.Parameters.AddWithValue(
                        "@Direccion",
                        Paciente.DireccionPaci);

                    Comando.Parameters.AddWithValue(
                        "@Telefono",
                        Paciente.TelefonoPaci);

                    Comando.Parameters.AddWithValue(
                        "@Estado",
                        Paciente.EstadoPaci);

                    Comando.Parameters.AddWithValue(
                        "@Id",
                        Paciente.Pk_idPaciente);

                    Comando.ExecuteNonQuery();
                }
            }
        }

        // ==========================================
        // ELIMINAR
        // ==========================================

        public void MantenimientoMetEliminarPaciente(
            int IdPaciente)
        {
            using (OdbcConnection Conexion =
                new OdbcConnection(_CadenaConexion))
            {
                Conexion.Open();

                string Consulta =
                    @"DELETE FROM tbl_paciente
                      WHERE pk_idPaciente = ?";

                using (OdbcCommand Comando =
                    new OdbcCommand(Consulta, Conexion))
                {
                    Comando.Parameters.AddWithValue(
                        "@Id",
                        IdPaciente);

                    Comando.ExecuteNonQuery();
                }
            }
        }
    }
}