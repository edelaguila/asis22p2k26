using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Mantenimiento2k26.Modelo
{
    public class ClsModeloPaciente
    {
        private readonly ClsConexion _conexion = new ClsConexion();

        public bool InsertarPaciente(ClsPaciente paciente)
        {
            using (OdbcConnection conn = _conexion.ObtenerConexion())
            {
                string query = "INSERT INTO tbl_paciente (pk_idPaciente, nombrePaci, apellidoPaci, FechaNacimiento, Genero, direccionPaci, Telefono, estadoPaci) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@pk_idPaciente", OdbcType.Int).Value = paciente.PkIdPaciente;
                    cmd.Parameters.Add("@nombrePaci", OdbcType.VarChar, 50).Value = paciente.NombrePaci;
                    cmd.Parameters.Add("@apellidoPaci", OdbcType.VarChar, 50).Value = paciente.ApellidoPaci;
                    cmd.Parameters.Add("@FechaNacimiento", OdbcType.Date).Value = paciente.FechaNacimiento.Date;
                    cmd.Parameters.Add("@Genero", OdbcType.Int).Value = paciente.Genero;
                    cmd.Parameters.Add("@direccionPaci", OdbcType.VarChar, 30).Value = paciente.DireccionPaci;
                    cmd.Parameters.Add("@Telefono", OdbcType.Int).Value = paciente.Telefono;
                    cmd.Parameters.Add("@estadoPaci", OdbcType.Int).Value = paciente.EstadoPaci;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ModificarPaciente(ClsPaciente paciente)
        {
            using (OdbcConnection conn = _conexion.ObtenerConexion())
            {
                string query = "UPDATE tbl_paciente SET nombrePaci = ?, apellidoPaci = ?, FechaNacimiento = ?, Genero = ?, " +
                               "direccionPaci = ?, Telefono = ?, estadoPaci = ? WHERE pk_idPaciente = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@nombrePaci", OdbcType.VarChar, 50).Value = paciente.NombrePaci;
                    cmd.Parameters.Add("@apellidoPaci", OdbcType.VarChar, 50).Value = paciente.ApellidoPaci;
                    cmd.Parameters.Add("@FechaNacimiento", OdbcType.Date).Value = paciente.FechaNacimiento.Date;
                    cmd.Parameters.Add("@Genero", OdbcType.Int).Value = paciente.Genero;
                    cmd.Parameters.Add("@direccionPaci", OdbcType.VarChar, 30).Value = paciente.DireccionPaci;
                    cmd.Parameters.Add("@Telefono", OdbcType.Int).Value = paciente.Telefono;
                    cmd.Parameters.Add("@estadoPaci", OdbcType.Int).Value = paciente.EstadoPaci;
                    cmd.Parameters.Add("@pk_idPaciente", OdbcType.Int).Value = paciente.PkIdPaciente;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EliminarPaciente(int idPaciente)
        {
            using (OdbcConnection conn = _conexion.ObtenerConexion())
            {
                string query = "DELETE FROM tbl_paciente WHERE pk_idPaciente = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@pk_idPaciente", OdbcType.Int).Value = idPaciente;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public ClsPaciente ConsultarPorId(int idPaciente)
        {
            using (OdbcConnection conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT pk_idPaciente, nombrePaci, apellidoPaci, FechaNacimiento, Genero, direccionPaci, Telefono, estadoPaci " +
                               "FROM tbl_paciente WHERE pk_idPaciente = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("@pk_idPaciente", OdbcType.Int).Value = idPaciente;
                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ClsPaciente
                            {
                                PkIdPaciente = Convert.ToInt32(reader["pk_idPaciente"]),
                                NombrePaci = reader["nombrePaci"].ToString(),
                                ApellidoPaci = reader["apellidoPaci"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                Genero = Convert.ToInt32(reader["Genero"]),
                                DireccionPaci = reader["direccionPaci"].ToString(),
                                Telefono = Convert.ToInt32(reader["Telefono"]),
                                EstadoPaci = Convert.ToInt32(reader["estadoPaci"])
                            };
                        }
                    }
                }
            }
            return null;
        }

        public DataTable ObtenerPacientesDataTable()
        {
            using (OdbcConnection conn = _conexion.ObtenerConexion())
            {
                string query = "SELECT pk_idPaciente AS ID, nombrePaci AS Nombre, apellidoPaci AS Apellido, FechaNacimiento AS Fecha_Nacimiento, " +
                               "CASE Genero WHEN 1 THEN 'Masculino' ELSE 'Femenino' END AS Genero, " +
                               "direccionPaci AS Direccion, Telefono, " +
                               "CASE estadoPaci WHEN 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado " +
                               "FROM tbl_paciente";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
