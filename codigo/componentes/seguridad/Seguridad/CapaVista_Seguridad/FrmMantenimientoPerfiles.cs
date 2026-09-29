using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using System.Collections.Generic;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using System;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{

    public partial class FrmMantenimientoPerfiles : Form
    {
        private ClsModeloRoles _SeguridadRoles = new ClsModeloRoles();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 8;
        public FrmMantenimientoPerfiles()
        {
            InitializeComponent();
            SeguridadPnlFiltros.Enabled = false;
            SeguridadBtnGuardar.Enabled = false;
        }

        private void FrmMantenimientoPerfiles_Load(object sender, System.EventArgs e)
        {

            var MapaBotones = new Dictionary<Control, TipoPermiso>
                {
                    { SeguridadBtnIngresar,   TipoPermiso.Insertar },
                    { SeguridadBtnModificar, TipoPermiso.Editar },
                    { SeguridadBtnEliminar, TipoPermiso.Eliminar }
                };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso)
                return;

            SeguridadMetListarRoles();
        }
        

        private void SeguridadMetListarRoles()
        {
            try
            {
                SeguridadDgvListaRoles.DataSource = _SeguridadRoles.SeguridadMetObtenerTodos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetReinicio()
        {
            SeguridadTxtCodigoRol.Clear();
            SeguridadTxtNombreRol.Clear();
            SeguridadTxtDescripcionRol.Clear();
            SeguridadChkActivo.Checked = false;
        }



        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _SeguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                _SeguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                _SeguridadRoles.IsActive = SeguridadChkActivo.Checked;
                _SeguridadRoles.Estado = EstadoEntidad.Added;

                bool Valido = new Ayudas.ClsValidacionDatos(_SeguridadRoles).SeguridadMetValidar();
                if (Valido == true)
                {
                    string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarRoles();
                    SeguridadMetReinicio();
                    SeguridadPnlFiltros.Enabled = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            SeguridadPnlFiltros.Enabled = true;
            _SeguridadRoles.Estado = EstadoEntidad.Added;
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                _SeguridadRoles.Estado = EstadoEntidad.Deleted;
                _SeguridadRoles.IdRol = Convert.ToInt32(SeguridadDgvListaRoles.CurrentRow.Cells[0].Value);

                string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                MessageBox.Show(Resultado);
                SeguridadMetListarRoles();
                SeguridadMetReinicio();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
        }

        private void SeguridadBtnIngresar_Click(object sender, EventArgs e)
        {
            SeguridadPnlFiltros.Enabled = true;
            SeguridadBtnGuardar.Enabled = true;
            _SeguridadRoles.Estado = EstadoEntidad.Added;
            SeguridadMetReinicio();
            
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                _SeguridadRoles.Estado = EstadoEntidad.Modified;
                _SeguridadRoles.IdRol = Convert.ToInt32(SeguridadDgvListaRoles.CurrentRow.Cells[0].Value);
                _SeguridadRoles.NombreRol = SeguridadTxtNombreRol.Text;
                _SeguridadRoles.DescripcionRol = SeguridadTxtDescripcionRol.Text;
                _SeguridadRoles.IsActive = SeguridadChkActivo.Checked;

                bool Valido = new Ayudas.ClsValidacionDatos(_SeguridadRoles).SeguridadMetValidar();
                if (Valido == true)
                {
                    string Resultado = _SeguridadRoles.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarRoles();
                    SeguridadMetReinicio();
                    SeguridadPnlFiltros.Enabled = false;
                }
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complete los datos del perfil y presione Guardar.");
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.Rows.Count > 0 && SeguridadDgvListaRoles.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvListaRoles.CurrentCell.RowIndex;
                if (FilaActual < SeguridadDgvListaRoles.Rows.Count - 1)
                {
                    SeguridadDgvListaRoles.ClearSelection();
                    SeguridadDgvListaRoles.Rows[FilaActual + 1].Selected = true;
                    SeguridadDgvListaRoles.CurrentCell = SeguridadDgvListaRoles.Rows[FilaActual + 1].Cells[0];
                }
            }
            SeguridadPnlFiltros.Enabled = false;
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.Rows.Count > 0 && SeguridadDgvListaRoles.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvListaRoles.CurrentCell.RowIndex;
                if (FilaActual > 0)
                {
                    SeguridadDgvListaRoles.ClearSelection();
                    SeguridadDgvListaRoles.Rows[FilaActual - 1].Selected = true;
                    SeguridadDgvListaRoles.CurrentCell = SeguridadDgvListaRoles.Rows[FilaActual - 1].Cells[0];
                }
            }
            SeguridadPnlFiltros.Enabled = false;
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.Rows.Count > 0)
            {
                int UltimaFila = SeguridadDgvListaRoles.Rows.Count - 1;
                SeguridadDgvListaRoles.ClearSelection();
                SeguridadDgvListaRoles.Rows[UltimaFila].Selected = true;
                SeguridadDgvListaRoles.CurrentCell = SeguridadDgvListaRoles.Rows[UltimaFila].Cells[0];
            }
            SeguridadPnlFiltros.Enabled = false;
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.Rows.Count > 0)
            {
                SeguridadDgvListaRoles.ClearSelection();
                SeguridadDgvListaRoles.Rows[0].Selected = true;
                SeguridadDgvListaRoles.CurrentCell = SeguridadDgvListaRoles.Rows[0].Cells[0];
            }
        }

        private void SeguridadDgvListaRoles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                _SeguridadRoles.Estado = EstadoEntidad.Modified;
                SeguridadTxtCodigoRol.Text = SeguridadDgvListaRoles.CurrentRow.Cells[0].Value.ToString();
                SeguridadTxtNombreRol.Text = SeguridadDgvListaRoles.CurrentRow.Cells[1].Value.ToString();
                SeguridadTxtDescripcionRol.Text = SeguridadDgvListaRoles.CurrentRow.Cells[2].Value.ToString();
                SeguridadChkActivo.Checked = Convert.ToBoolean(SeguridadDgvListaRoles.CurrentRow.Cells[3].Value);
            }
            SeguridadPnlFiltros.Enabled = false;
        }

        private void SeguridadDgvListaRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.SelectedRows.Count > 0)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    _SeguridadRoles.Estado = EstadoEntidad.Modified;
                    SeguridadTxtCodigoRol.Text = SeguridadDgvListaRoles.CurrentRow.Cells[0].Value.ToString();
                    SeguridadTxtNombreRol.Text = SeguridadDgvListaRoles.CurrentRow.Cells[1].Value.ToString();
                    SeguridadTxtDescripcionRol.Text = SeguridadDgvListaRoles.CurrentRow.Cells[2].Value.ToString();
                    SeguridadChkActivo.Checked = Convert.ToBoolean(SeguridadDgvListaRoles.CurrentRow.Cells[3].Value);
                });
            }
            SeguridadPnlFiltros.Enabled = false;

        }
    }
}