using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmUsuarios : Form
    {
        private ClsModeloUsuario _Usuario = new ClsModeloUsuario();
        private ClsPermisoAplicacion _MisPermisos;

        private const int ID_MODULO = 4;       
        private const int ID_APLICACION = 5;  

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                var MapaBotones = new Dictionary<Control, TipoPermiso>
                {
                    { btnGuardar,   TipoPermiso.Insertar },
                    { btnModificar, TipoPermiso.Editar },
                    { btnReporte,   TipoPermiso.Imprimir }

                };

                _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                    this, ID_MODULO, ID_APLICACION, MapaBotones);

                if (!_MisPermisos.TieneAcceso)
                    return;

                SeguridadMetListarUsuarios();
                SeguridadMetCargarCombos();
                SeguridadMetCargarComboEstado();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeguridadMetCargarComboEstado()
        {
            cboEstado.DataSource = _Usuario.SeguridadMetObtenerEstados();
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = -1;
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                cboEmpleado.DataSource = _Usuario.SeguridadMetObtenerEmpleados();
                cboEmpleado.DisplayMember = "NombresEmpleado";
                cboEmpleado.ValueMember = "IdEmpleado";
                cboEmpleado.SelectedIndex = -1;
                cboEmpleado.SelectedIndexChanged += CboEmpleado_SelectedIndexChanged;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedValue != null)
            {
                txtIdEmpleado.Text = cboEmpleado.SelectedValue.ToString();
            }
        }

        private void SeguridadMetListarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = _Usuario.SeguridadMetObtenerTodos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeInsertar)
            {
                MessageBox.Show("No tienes permiso para agregar usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _Usuario.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                _Usuario.NombreUsuario = txtUsuario.Text;
                _Usuario.ContrasenaUsuario = txtContrasena.Text;
                _Usuario.UltimoAccesoUsuario = DateTime.Now;
                _Usuario.IsActive = Convert.ToInt32(cboEstado.SelectedValue);
                _Usuario.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_Usuario).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _Usuario.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarUsuarios();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeEditar)
            {
                MessageBox.Show("No tienes permiso para modificar usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeImprimir)
            {
                MessageBox.Show("No tienes permiso para generar reportes.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdEmpleado.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            cboEmpleado.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}