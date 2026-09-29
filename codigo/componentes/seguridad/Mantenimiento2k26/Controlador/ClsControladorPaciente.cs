using System;
using System.Data;
using Mantenimiento2k26.Modelo;
using CapaControlador_Seguridad;

namespace Mantenimiento2k26.Controlador
{
    public class ClsControladorPaciente
    {
        private readonly ClsModeloPaciente _modelo = new ClsModeloPaciente();

        public bool Insertar(ClsPaciente paciente, out string mensaje)
        {
            try
            {
                if (paciente == null || paciente.PkIdPaciente <= 0)
                {
                    mensaje = "El ID del paciente debe ser un numero positivo.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(paciente.NombrePaci) || string.IsNullOrWhiteSpace(paciente.ApellidoPaci))
                {
                    mensaje = "El nombre y apellido son obligatorios.";
                    return false;
                }

                bool resultado = _modelo.InsertarPaciente(paciente);
                if (resultado)
                {
                    ClsModeloBitacora.SeguridadMetRegistrarAccion("ALTA", "tbl_paciente", paciente.PkIdPaciente, 
                        $"Se registro el paciente {paciente.NombrePaci} {paciente.ApellidoPaci}");
                    mensaje = "Paciente registrado exitosamente.";
                    return true;
                }

                mensaje = "No se pudo insertar el registro.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al insertar: " + ex.Message;
                return false;
            }
        }

        public bool Modificar(ClsPaciente paciente, out string mensaje)
        {
            try
            {
                if (paciente == null || paciente.PkIdPaciente <= 0)
                {
                    mensaje = "ID de paciente no valido para modificar.";
                    return false;
                }

                bool resultado = _modelo.ModificarPaciente(paciente);
                if (resultado)
                {
                    ClsModeloBitacora.SeguridadMetRegistrarAccion("MODIFICACION", "tbl_paciente", paciente.PkIdPaciente, 
                        $"Se modifico el paciente {paciente.NombrePaci} {paciente.ApellidoPaci}");
                    mensaje = "Paciente modificado exitosamente.";
                    return true;
                }

                mensaje = "No se encontro el paciente para modificar.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al modificar: " + ex.Message;
                return false;
            }
        }

        public bool Eliminar(int idPaciente, out string mensaje)
        {
            try
            {
                if (idPaciente <= 0)
                {
                    mensaje = "ID no valido para eliminar.";
                    return false;
                }

                bool resultado = _modelo.EliminarPaciente(idPaciente);
                if (resultado)
                {
                    ClsModeloBitacora.SeguridadMetRegistrarAccion("ELIMINACION", "tbl_paciente", idPaciente, 
                        $"Se elimino el paciente con ID {idPaciente}");
                    mensaje = "Paciente eliminado exitosamente.";
                    return true;
                }

                mensaje = "No se encontro el paciente para eliminar.";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = "Error al eliminar: " + ex.Message;
                return false;
            }
        }

        public ClsPaciente ConsultarPorId(int idPaciente, out string mensaje)
        {
            try
            {
                var paciente = _modelo.ConsultarPorId(idPaciente);
                if (paciente != null)
                {
                    ClsModeloBitacora.SeguridadMetRegistrarAccion("CONSULTA", "tbl_paciente", idPaciente, 
                        $"Se consulto informacion del paciente ID {idPaciente}");
                    mensaje = "Paciente encontrado.";
                    return paciente;
                }

                mensaje = "Paciente no encontrado.";
                return null;
            }
            catch (Exception ex)
            {
                mensaje = "Error al consultar: " + ex.Message;
                return null;
            }
        }

        public DataTable ObtenerPacientes()
        {
            try
            {
                return _modelo.ObtenerPacientesDataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        public void RegistrarAccionReporte(string detalles)
        {
            try
            {
                ClsModeloBitacora.SeguridadMetRegistrarAccion("REPORTE", "tbl_paciente", 0, detalles);
            }
            catch { }
        }
    }
}
