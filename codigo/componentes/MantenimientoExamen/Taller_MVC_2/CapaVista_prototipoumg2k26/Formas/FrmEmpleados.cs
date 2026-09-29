using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaControlador_prototipoumg2k26;
using CapaVista_prototipoumg2k26.Reportes;

namespace CapaVista_prototipoumg2k26.Formas
{
    public partial class FrmEmpleados : Form
    {
        private readonly ModeloEmpleado rol = new ModeloEmpleado();

        public FrmEmpleados()
        {
            InitializeComponent();
            panIngresoDatos.Enabled = false;
            ConfigurarVistaRoles();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            ListaRoles();

            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible cargar el combo de roles.\n\n" + ex.Message,
                    "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarVistaRoles()
        {
            Text = "Mantenimiento de Roles - UMG Didáctica";
            lblNombre.Text = "Nombre del rol";
            lblCorreo.Text = "Descripción del rol";
            txtCorreo.Multiline = true;
            txtCorreo.Height = 85;
            txtCorreo.MaxLength = 200;
            txtNombre.MaxLength = 50;

            // Controles del prototipo de empleados que no aplican a tbl_roles.
            lblNumeroID.Visible = false;
            txtNumeroID.Visible = false;
            lblCumpleaños.Visible = false;
            txtCumpleaños.Visible = false;

            // Reubicar los controles utilizados para roles dentro del mismo formulario.
            lblNombre.Top = 30;
            txtNombre.Top = 55;
            lblCorreo.Top = 100;
            txtCorreo.Top = 125;
            btnGrabar.Top = 240;

            dgvEmpleados.AutoGenerateColumns = true;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
        }

        private void ListaRoles()
        {
            try
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = rol.GetAll();
                AjustarEncabezados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible cargar los roles.\n\n" + ex.Message,
                    "Base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarEncabezados()
        {
            if (dgvEmpleados.Columns["IdRol"] != null)
                dgvEmpleados.Columns["IdRol"].HeaderText = "ID Rol";
            if (dgvEmpleados.Columns["NombreRol"] != null)
                dgvEmpleados.Columns["NombreRol"].HeaderText = "Nombre del rol";
            if (dgvEmpleados.Columns["DescripcionRol"] != null)
                dgvEmpleados.Columns["DescripcionRol"].HeaderText = "Descripción";

            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarRoles();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BuscarRoles();
        }

        private void BuscarRoles()
        {
            try
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = rol.FindbyId(txtSearch.Text);
                AjustarEncabezados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible realizar la búsqueda.\n\n" + ex.Message,
                    "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            rol.NombreRol = txtNombre.Text;
            rol.DescripcionRol = txtCorreo.Text;

            var contexto = new ValidationContext(rol);
            var resultados = new List<ValidationResult>();
            bool valido = Validator.TryValidateObject(rol, contexto, resultados, true);

            if (!valido)
            {
                string mensaje = string.Join("\n", resultados.ConvertAll(r => r.ErrorMessage));
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = rol.GrabarCambios();
            MessageBox.Show(resultado);
            ListaRoles();
            Reinicio();
        }

        private void Reinicio()
        {
            panIngresoDatos.Enabled = false;
            txtNombre.Clear();
            txtCorreo.Clear();
            rol.IdRol = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Reinicio();
            panIngresoDatos.Enabled = true;
            rol.Estado = EstadoEntidad.Added;
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            panIngresoDatos.Enabled = true;
            rol.Estado = EstadoEntidad.Modified;
            rol.IdRol = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdRol"].Value);
            txtNombre.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells["NombreRol"].Value);
            txtCorreo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells["DescripcionRol"].Value);
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            int idRol = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["IdRol"].Value);
            string nombreRol = Convert.ToString(dgvEmpleados.CurrentRow.Cells["NombreRol"].Value);

            var respuesta = MessageBox.Show(
                "¿Desea eliminar el rol '" + nombreRol + "'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            rol.Estado = EstadoEntidad.Deleted;
            rol.IdRol = idRol;
            string resultado = rol.GrabarCambios();
            MessageBox.Show(resultado);
            ListaRoles();
            Reinicio();
        }


        void CargarDatos()
        {
            comboI1.llenarCombo("tbl_roles", "id_rol", "nombre_rol");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteRoles reporte = new FrmReporteRoles();
            reporte.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/AyudaRisko/CapaRisko.chm", "Roles.html");
        }
    }
}

