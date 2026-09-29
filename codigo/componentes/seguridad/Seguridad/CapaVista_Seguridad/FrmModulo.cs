using CapaVista_Seguridad.Ayudas;
using System.Collections.Generic;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmModulo : Form
    {
        private ClsModeloModulo _ControladorModulo = new ClsModeloModulo();
        private BindingSource bindingSource = new BindingSource();
        private bool esCargando = false;

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;      
        private const int ID_APLICACION = 6;

        public FrmModulo()
        {
            InitializeComponent();
            CargarDatos();
            EstadoInicial();

            var MapaBotones = new Dictionary<Control, TipoPermiso>
                {
                    { SeguridadBtnIngresar,   TipoPermiso.Insertar },
                    { SeguridadBtnModificar, TipoPermiso.Editar },
                    { SeguridadBtnEliminar, TipoPermiso.Eliminar },
                    { SeguridadBtnImprimir,   TipoPermiso.Imprimir }                    
                };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);
        }

        #region Gestión de Datos

        private void CargarDatos()
        {
            try
            {
                esCargando = true;

                DataTable dtModulos = _ControladorModulo.SeguridadMetObtenerModulosTabla();
                bindingSource.DataSource = dtModulos;
                SeguridadDgvModulos.DataSource = bindingSource;

                FormatearGrid();

                esCargando = false;
            }
            catch (Exception ex)
            {
                esCargando = false;
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrid()
        {
            if (SeguridadDgvModulos.Columns.Contains("is_active"))
            {
                int colIndex = SeguridadDgvModulos.Columns["is_active"].Index;
                SeguridadDgvModulos.Columns.Remove("is_active");

                DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
                {
                    Name = "is_active",
                    DataPropertyName = "is_active",
                    HeaderText = "Estado",
                    TrueValue = 1,
                    FalseValue = 0
                };
                SeguridadDgvModulos.Columns.Insert(colIndex, chkCol);
            }

            if (SeguridadDgvModulos.Columns.Contains("idModulo"))
                SeguridadDgvModulos.Columns["idModulo"].HeaderText = "Id Módulo";
            if (SeguridadDgvModulos.Columns.Contains("nombreModulo"))
                SeguridadDgvModulos.Columns["nombreModulo"].HeaderText = "Nombre Módulo";
            if (SeguridadDgvModulos.Columns.Contains("descripcionModulo"))
                SeguridadDgvModulos.Columns["descripcionModulo"].HeaderText = "Descripción";
        }

        private void CargarRegistroActual()
        {
            if (esCargando) return;

            if (bindingSource.Current is DataRowView row)
            {
                SeguridadTxtIdModulo.Text = row["idModulo"].ToString();
                SeguridadTxtNombreModulo.Text = row["nombreModulo"].ToString();
                SeguridadTxtDescripcion.Text = row["descripcionModulo"].ToString();

                object val = row["is_active"];
                SeguridadChkEstado.Checked = (val != DBNull.Value &&
                    (Convert.ToInt32(val) == 1 || Convert.ToBoolean(val)));
            }
            else
            {
                LimpiarCampos();
            }
        }

        #endregion

        #region Estados del Formulario

        private void EstadoInicial()
        {
            SeguridadTxtIdModulo.Enabled = false;
            SeguridadTxtNombreModulo.Enabled = false;
            SeguridadTxtDescripcion.Enabled = false;
            SeguridadChkEstado.Enabled = false;

            CargarRegistroActual();

            SeguridadBtnIngresar.Enabled = true;
            SeguridadBtnModificar.Enabled = true;
            SeguridadBtnEliminar.Enabled = true;
            SeguridadBtnConsultar.Enabled = true;
            SeguridadBtnRefrescar.Enabled = true;
            SeguridadBtnGuardar.Enabled = false;
            SeguridadBtnCancelar.Enabled = false;
        }

        private void EstadoEdicion()
        {
            SeguridadTxtNombreModulo.Enabled = true;
            SeguridadTxtDescripcion.Enabled = true;
            SeguridadChkEstado.Enabled = true;

            SeguridadBtnIngresar.Enabled = false;
            SeguridadBtnModificar.Enabled = false;
            SeguridadBtnEliminar.Enabled = false;
            SeguridadBtnConsultar.Enabled = false;
            SeguridadBtnRefrescar.Enabled = false;
            SeguridadBtnGuardar.Enabled = true;
            SeguridadBtnCancelar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            SeguridadTxtIdModulo.Text = "";
            SeguridadTxtNombreModulo.Text = "";
            SeguridadTxtDescripcion.Text = "";
            SeguridadChkEstado.Checked = true;
        }

        #endregion

        #region Eventos CRUD

        private void SeguridadBtnIngresar_Click(object sender, EventArgs e)
        {
            EstadoEdicion();
            LimpiarCampos();
            SeguridadTxtNombreModulo.Focus();
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeguridadTxtIdModulo.Text))
            {
                EstadoEdicion();
                SeguridadTxtNombreModulo.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla para modificar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            EstadoInicial();
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SeguridadTxtNombreModulo.Text) ||
                string.IsNullOrWhiteSpace(SeguridadTxtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre de Módulo y una Descripción antes de guardar.",
                    "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _ControladorModulo.NombreModulo = SeguridadTxtNombreModulo.Text.Trim();
            _ControladorModulo.DescripcionModulo = SeguridadTxtDescripcion.Text.Trim();
            _ControladorModulo.IsActive = SeguridadChkEstado.Checked;

            if (string.IsNullOrEmpty(SeguridadTxtIdModulo.Text))
            {
                _ControladorModulo.Estado = EstadoEntidad.Added;
            }
            else
            {
                _ControladorModulo.IdModulo = Convert.ToInt32(SeguridadTxtIdModulo.Text);
                _ControladorModulo.Estado = EstadoEntidad.Modified;
            }

            string resultado = _ControladorModulo.SeguridadMetGrabarCambios();
            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatos();
            EstadoInicial();
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeguridadTxtIdModulo.Text))
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este módulo definitivamente?",
                    "Confirmación de Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    _ControladorModulo.IdModulo = Convert.ToInt32(SeguridadTxtIdModulo.Text);
                    _ControladorModulo.Estado = EstadoEntidad.Deleted;

                    string resultado = _ControladorModulo.SeguridadMetGrabarCambios();
                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                    EstadoInicial();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un módulo de la tabla para eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Eventos Navegación y Otros

        private void SeguridadBtnConsultar_Click(object sender, EventArgs e) { CargarDatos(); EstadoInicial(); }
        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e) { CargarDatos(); EstadoInicial(); }

        private void SeguridadBtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generando reporte de módulos...",
                "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e) => bindingSource.MoveFirst();
        private void SeguridadBtnAnterior_Click(object sender, EventArgs e) => bindingSource.MovePrevious();
        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e) => bindingSource.MoveNext();
        private void SeguridadBtnFin_Click(object sender, EventArgs e) => bindingSource.MoveLast();

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario para mantenimiento de módulos del sistema.",
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SeguridadBtnSalir_Click(object sender, EventArgs e) => this.Close();

        private void BindingSource_CurrentChanged(object sender, EventArgs e) => CargarRegistroActual();

        private void SeguridadDgvModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) CargarRegistroActual();
        }

        #endregion
    }
}