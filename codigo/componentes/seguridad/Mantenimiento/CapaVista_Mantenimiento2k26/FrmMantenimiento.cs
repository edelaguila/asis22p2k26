using System;
using System.Windows.Forms;
using CapaControlador_Mantenimiento2k26;

namespace CapaVista_Mantenimiento2k26
{
    public partial class FrmMantenimiento : Form
    {
        private readonly ClsModeloMantenimiento _Controlador;
        private int _IdPaciente;

        public FrmMantenimiento()
        {
            InitializeComponent();

            _Controlador = new ClsModeloMantenimiento();

            MantenimientoMetMostrarPacientes();
        }

        // =====================================================
        // MOSTRAR PACIENTES
        // =====================================================
        private void MantenimientoMetMostrarPacientes()
        {
            try
            {
                tbl_paciente.DataSource =
                    _Controlador.MantenimientoMetMostrarPacientes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "Error al consultar pacientes: " + Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // LIMPIAR CAMPOS
        // =====================================================
        private void MantenimientoMetLimpiar()
        {
            _IdPaciente = 0;

            nombrePaci.Clear();
            apellidoPaci.Clear();
            generoPaci.Clear();
            direccionPaci.Clear();
            telefonoPaci.Clear();
            estadoPaci.Clear();

            nombrePaci.Focus();
        }

        // =====================================================
        // VALIDAR CAMPOS
        // =====================================================
        private bool MantenimientoFuncValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(nombrePaci.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del paciente.");

                nombrePaci.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidoPaci.Text))
            {
                MessageBox.Show(
                    "Ingrese el apellido del paciente.");

                apellidoPaci.Focus();
                return false;
            }

            int Genero;

            if (!int.TryParse(generoPaci.Text, out Genero))
            {
                MessageBox.Show(
                    "Ingrese un género válido.");

                generoPaci.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(direccionPaci.Text))
            {
                MessageBox.Show(
                    "Ingrese la dirección del paciente.");

                direccionPaci.Focus();
                return false;
            }

            int Telefono;

            if (!int.TryParse(telefonoPaci.Text, out Telefono))
            {
                MessageBox.Show(
                    "Ingrese un teléfono válido.");

                telefonoPaci.Focus();
                return false;
            }

            int Estado;

            if (!int.TryParse(estadoPaci.Text, out Estado))
            {
                MessageBox.Show(
                    "Ingrese un estado válido.");

                estadoPaci.Focus();
                return false;
            }

            return true;
        }

        // =====================================================
        // GUARDAR
        // =====================================================
        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!MantenimientoFuncValidarCampos())
                {
                    return;
                }

                int Genero =
                    Convert.ToInt32(generoPaci.Text);

                int Telefono =
                    Convert.ToInt32(telefonoPaci.Text);

                int Estado =
                    Convert.ToInt32(estadoPaci.Text);

                _Controlador.MantenimientoMetInsertarPaciente(
                    nombrePaci.Text.Trim(),
                    apellidoPaci.Text.Trim(),
                    Genero,
                    direccionPaci.Text.Trim(),
                    Telefono,
                    Estado);

                MessageBox.Show(
                    "Paciente guardado correctamente.",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MantenimientoMetMostrarPacientes();
                MantenimientoMetLimpiar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "Error al guardar: " + Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // MODIFICAR
        // =====================================================
        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (_IdPaciente == 0)
                {
                    MessageBox.Show(
                        "Seleccione un paciente para modificar.");

                    return;
                }

                if (!MantenimientoFuncValidarCampos())
                {
                    return;
                }

                int Genero =
                    Convert.ToInt32(generoPaci.Text);

                int Telefono =
                    Convert.ToInt32(telefonoPaci.Text);

                int Estado =
                    Convert.ToInt32(estadoPaci.Text);

                _Controlador.MantenimientoMetModificarPaciente(
                    _IdPaciente,
                    nombrePaci.Text.Trim(),
                    apellidoPaci.Text.Trim(),
                    Genero,
                    direccionPaci.Text.Trim(),
                    Telefono,
                    Estado);

                MessageBox.Show(
                    "Paciente modificado correctamente.",
                    "Modificar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MantenimientoMetMostrarPacientes();
                MantenimientoMetLimpiar();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "Error al modificar: " + Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // ELIMINAR
        // =====================================================
        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (_IdPaciente == 0)
                {
                    MessageBox.Show(
                        "Seleccione un paciente para eliminar.");

                    return;
                }

                DialogResult Resultado =
                    MessageBox.Show(
                        "¿Desea eliminar este paciente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (Resultado == DialogResult.Yes)
                {
                    _Controlador.MantenimientoMetEliminarPaciente(
                        _IdPaciente);

                    MessageBox.Show(
                        "Paciente eliminado correctamente.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    MantenimientoMetMostrarPacientes();
                    MantenimientoMetLimpiar();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "Error al eliminar: " + Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // NUEVO
        // =====================================================
        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            MantenimientoMetLimpiar();
        }

        // =====================================================
        // SELECCIONAR PACIENTE DEL DATAGRIDVIEW
        // =====================================================
        private void tbl_paciente_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                DataGridViewRow Fila =
                    tbl_paciente.Rows[e.RowIndex];

                _IdPaciente =
                    Convert.ToInt32(
                        Fila.Cells["pk_idPaciente"].Value);

                nombrePaci.Text =
                    Fila.Cells["nombrePaci"]
                        .Value.ToString();

                apellidoPaci.Text =
                    Fila.Cells["apellidoPaci"]
                        .Value.ToString();

                generoPaci.Text =
                    Fila.Cells["Genero"]
                        .Value.ToString();

                direccionPaci.Text =
                    Fila.Cells["direccionPaci"]
                        .Value.ToString();

                telefonoPaci.Text =
                    Fila.Cells["telefonoPaci"]
                        .Value.ToString();

                estadoPaci.Text =
                    Fila.Cells["estadoPaci"]
                        .Value.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(
                    "Error al seleccionar paciente: " +
                    Ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}