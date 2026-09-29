using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmMantenimientoEmpleado : Form
    {
        private ClsModeloEmpleado _Empleado = new ClsModeloEmpleado();
        private ClsPermisoAplicacion _MisPermisos;

        private const int ID_MODULO = 4;       
        private const int ID_APLICACION = 4;   

        public FrmMantenimientoEmpleado()
        {
            InitializeComponent();
        }

        private const string PrefijoCodigoEmpleado = "EMP-";

        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            var MapaBotones = new Dictionary<Control, TipoPermiso>
    {
        { SeguridadBtnGuardar,   TipoPermiso.Insertar },
        { SeguridadBtnModificar, TipoPermiso.Editar },
        { SeguridadBtnEliminar,  TipoPermiso.Eliminar }
    };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso)
                return;

            SeguridadMetListarEmpleados();
            SeguridadTxtCodigo.Text = PrefijoCodigoEmpleado;
            SeguridadTxtCodigo.SelectionStart = SeguridadTxtCodigo.Text.Length;
        }

        private void SeguridadMetListarEmpleados()
        {
            try
            {
                SeguridadDgvEmpleados.DataSource = _Empleado.SeguridadMetObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete los datos del empleado y presione Guardar.");
        }

        private void SeguridadBtnAgregar_Click(object sender, EventArgs e)
        {
            SeguridadTxtCodigo.Text = "";
            SeguridadTxtDpi.Text = "";
            SeguridadTxtNit.Text = "";
            SeguridadTxtNombres.Text = "";
            SeguridadTxtApellidos.Text = "";
            SeguridadTxtPuesto.Text = "";
            SeguridadCboGenero.SelectedIndex = -1;
            SeguridadTxtTelefono.Text = "";
            SeguridadTxtCorreo.Text = "";

            _Empleado.Estado = EstadoEntidad.Added;

            SeguridadCboGenero.Enabled = true;
        }

        private void SeguridadBtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SeguridadTxtIdEmpleado.Text))
                {
                    MessageBox.Show("Ingrese un Id de Empleado para filtrar");
                    return;
                }

                int IdEmpleado = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                SeguridadDgvEmpleados.DataSource = _Empleado.SeguridadMetBuscarPorId(IdEmpleado);
            }
            catch (FormatException)
            {
                MessageBox.Show("El Id de Empleado debe ser un número");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.SelectedRows.Count > 0)
            {
                _Empleado.Estado = EstadoEntidad.Deleted;
                _Empleado.IdEmpleado = Convert.ToInt32(SeguridadDgvEmpleados.CurrentRow.Cells[0].Value);

                string Resultado = _Empleado.SeguridadMetGrabarCambios();
                MessageBox.Show(Resultado);
                SeguridadMetListarEmpleados();
            }
            else MessageBox.Show("Seleccione una fila");
        }


        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadDgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SeguridadDgvEmpleados.SelectedRows.Count > 0)
            {
                _Empleado.Estado = EstadoEntidad.Modified;
                SeguridadTxtIdEmpleado.Text = SeguridadDgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                SeguridadTxtCodigo.Text = SeguridadDgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                SeguridadTxtDpi.Text = SeguridadDgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                SeguridadTxtNit.Text = SeguridadDgvEmpleados.CurrentRow.Cells[3].Value?.ToString();
                SeguridadTxtNombres.Text = SeguridadDgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                SeguridadTxtApellidos.Text = SeguridadDgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                SeguridadTxtPuesto.Text = SeguridadDgvEmpleados.CurrentRow.Cells[6].Value.ToString();
                SeguridadCboGenero.SelectedItem = SeguridadDgvEmpleados.CurrentRow.Cells[7].Value.ToString();
                SeguridadDtpFechaNacimiento.Value = Convert.ToDateTime(SeguridadDgvEmpleados.CurrentRow.Cells[8].Value);
                SeguridadDtpFechaContratacion.Value = Convert.ToDateTime(SeguridadDgvEmpleados.CurrentRow.Cells[9].Value);
                SeguridadTxtTelefono.Text = SeguridadDgvEmpleados.CurrentRow.Cells[10].Value?.ToString();
                SeguridadTxtCorreo.Text = SeguridadDgvEmpleados.CurrentRow.Cells[11].Value?.ToString();
                SeguridadChkActivo.Checked = Convert.ToBoolean(SeguridadDgvEmpleados.CurrentRow.Cells[12].Value);
            }
        }

        private void SeguridadMetReinicio()
        {
            SeguridadTxtCodigo.Text = PrefijoCodigoEmpleado; 
            SeguridadTxtDpi.Text = "";
            SeguridadTxtNit.Text = "";
            SeguridadTxtNombres.Text = "";
            SeguridadTxtApellidos.Text = "";
            SeguridadTxtPuesto.Text = "";
            SeguridadCboGenero.SelectedIndex = -1;
            SeguridadTxtTelefono.Text = "";
            SeguridadTxtCorreo.Text = "";
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvEmpleados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para modificar");
                    return;

                }
                  if (!ValidarFechas()) return;
                _Empleado.IdEmpleado = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                _Empleado.CodigoEmpleado = SeguridadTxtCodigo.Text;
                _Empleado.DpiEmpleado = SeguridadTxtDpi.Text;
                _Empleado.NitEmpleado = SeguridadTxtNit.Text;
                _Empleado.NombresEmpleado = SeguridadTxtNombres.Text;
                _Empleado.ApellidosEmpleado = SeguridadTxtApellidos.Text;
                _Empleado.PuestoEmpleado = SeguridadTxtPuesto.Text;
                _Empleado.GeneroEmpleado = SeguridadCboGenero.SelectedItem?.ToString();
                _Empleado.FechaNacimientoEmpleado = SeguridadDtpFechaNacimiento.Value;
                _Empleado.FechaContratacionEmpleado = SeguridadDtpFechaContratacion.Value;
                _Empleado.TelefonoEmpleado = SeguridadTxtTelefono.Text;
                _Empleado.CorreoEmpleado = SeguridadTxtCorreo.Text;
                _Empleado.Estado = EstadoEntidad.Modified;

                bool Valido = new ClsValidacionDatos(_Empleado).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _Empleado.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarEmpleados();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFechas()) return;
                _Empleado.CodigoEmpleado = SeguridadTxtCodigo.Text;
                _Empleado.DpiEmpleado = SeguridadTxtDpi.Text;
                _Empleado.NitEmpleado = SeguridadTxtNit.Text;
                _Empleado.NombresEmpleado = SeguridadTxtNombres.Text;
                _Empleado.ApellidosEmpleado = SeguridadTxtApellidos.Text;
                _Empleado.PuestoEmpleado = SeguridadTxtPuesto.Text;
                _Empleado.GeneroEmpleado = SeguridadCboGenero.SelectedItem?.ToString();
                _Empleado.FechaNacimientoEmpleado = SeguridadDtpFechaNacimiento.Value;
                _Empleado.FechaContratacionEmpleado = SeguridadDtpFechaContratacion.Value;
                _Empleado.TelefonoEmpleado = SeguridadTxtTelefono.Text;
                _Empleado.CorreoEmpleado = SeguridadTxtCorreo.Text;
                _Empleado.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_Empleado).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _Empleado.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarEmpleados();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnLimpiar_Click(object sender, EventArgs e)
        {
            SeguridadTxtIdEmpleado.Clear();
            SeguridadMetReinicio();
            SeguridadMetListarEmpleados();
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadTxtIdEmpleado.Clear();
            SeguridadMetListarEmpleados();
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0)
            {
                SeguridadDgvEmpleados.ClearSelection();
                SeguridadDgvEmpleados.Rows[0].Selected = true;
                SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[0].Cells[0];
            }
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0 && SeguridadDgvEmpleados.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvEmpleados.CurrentCell.RowIndex;
                if (FilaActual > 0)
                {
                    SeguridadDgvEmpleados.ClearSelection();
                    SeguridadDgvEmpleados.Rows[FilaActual - 1].Selected = true;
                    SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[FilaActual - 1].Cells[0];
                }
            }
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0 && SeguridadDgvEmpleados.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvEmpleados.CurrentCell.RowIndex;
                if (FilaActual < SeguridadDgvEmpleados.Rows.Count - 1)
                {
                    SeguridadDgvEmpleados.ClearSelection();
                    SeguridadDgvEmpleados.Rows[FilaActual + 1].Selected = true;
                    SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[FilaActual + 1].Cells[0];
                }
            }
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvEmpleados.Rows.Count > 0)
            {
                int UltimaFila = SeguridadDgvEmpleados.Rows.Count - 1;
                SeguridadDgvEmpleados.ClearSelection();
                SeguridadDgvEmpleados.Rows[UltimaFila].Selected = true;
                SeguridadDgvEmpleados.CurrentCell = SeguridadDgvEmpleados.Rows[UltimaFila].Cells[0];
            }
        }

        private void SeguridadTxtDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SeguridadTxtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool _formateandoNit = false;

        private void SeguridadTxtNit_TextChanged(object sender, EventArgs e)
        {
            if (_formateandoNit) return;

            _formateandoNit = true;

            string soloDigitos = SeguridadTxtNit.Text.Replace("-", "");

            if (soloDigitos.Length > 8)
                soloDigitos = soloDigitos.Substring(0, 8);

            string textoFormateado = soloDigitos;
            if (soloDigitos.Length == 8)
            {
                textoFormateado = soloDigitos.Substring(0, 7) + "-" + soloDigitos.Substring(7, 1);
            }

            SeguridadTxtNit.Text = textoFormateado;
            SeguridadTxtNit.SelectionStart = SeguridadTxtNit.Text.Length;

            _formateandoNit = false;
        }

        private void SeguridadTxtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!SeguridadTxtCodigo.Text.StartsWith(PrefijoCodigoEmpleado))
            {
                SeguridadTxtCodigo.Text = PrefijoCodigoEmpleado;
                SeguridadTxtCodigo.SelectionStart = SeguridadTxtCodigo.Text.Length;
            }
        }

        private void SeguridadTxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                && SeguridadTxtCodigo.SelectionStart <= PrefijoCodigoEmpleado.Length)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private bool ValidarFechas()
        {
            if (SeguridadDtpFechaNacimiento.Value > SeguridadDtpFechaContratacion.Value)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha de contratación");
                return false;
            }
            return true;
        }
    }
}