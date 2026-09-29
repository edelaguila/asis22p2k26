/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Cristian David Sipac Ispache
 * Carné : 9959-23-1567
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  El FrmMantenimientoPerfiles es el formulario donde el usuario
 *  gestiona los perfiles del sistema: puede agregar, modificar,
 *  eliminar, consultar por nombre y navegar entre los registros
 *  listados en el grid, controlando el acceso según los permisos
 *  asignados al usuario.
 * ===================================================================
*/

using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
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
                SeguridadMetActualizarContador();
                SeguridadMetConfigurarEncabezadosGrid();
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetConfigurarEncabezadosGrid()
        {
            if (SeguridadDgvListaRoles.Columns["IdRol"] != null)
                SeguridadDgvListaRoles.Columns["IdRol"].HeaderText = "Código Perfil";

            if (SeguridadDgvListaRoles.Columns["NombreRol"] != null)
                SeguridadDgvListaRoles.Columns["NombreRol"].HeaderText = "Nombre del Perfil";

            if (SeguridadDgvListaRoles.Columns["DescripcionRol"] != null)
                SeguridadDgvListaRoles.Columns["DescripcionRol"].HeaderText = "Descripción";

            if (SeguridadDgvListaRoles.Columns["IsActive"] != null)
                SeguridadDgvListaRoles.Columns["IsActive"].HeaderText = "Estado";

            if (SeguridadDgvListaRoles.Columns["CreatedAt"] != null)
                SeguridadDgvListaRoles.Columns["CreatedAt"].HeaderText = "Fecha Creación";

            if (SeguridadDgvListaRoles.Columns["UpdatedAt"] != null)
                SeguridadDgvListaRoles.Columns["UpdatedAt"].HeaderText = "Última Actualización";
        }

        private void SeguridadMetActualizarContador()
        {
            int Total = SeguridadDgvListaRoles.Rows.Count;

            if (Total == 0)
            {
                LblSeguridadContador.Text = "Mostrando 0 de 0 registros";
                return;
            }

            int FilaActual = (SeguridadDgvListaRoles.CurrentCell != null)
                ? SeguridadDgvListaRoles.CurrentCell.RowIndex + 1
                : 1;

            LblSeguridadContador.Text = $"Mostrando {FilaActual} de {Total} registros";
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
                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
            SeguridadBtnGuardar.Enabled = false;
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
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
                    
                }
            }
            else MessageBox.Show("Seleccione una fila");
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
            SeguridadTxtCodigoRol.Enabled = false;
            _SeguridadRoles.Estado = EstadoEntidad.Added;
            SeguridadMetReinicio();
            
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {

            SeguridadMetListarRoles();
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "Perfiles_Seguridad.html");
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
            SeguridadBtnGuardar.Enabled = false;
            SeguridadMetActualizarContador();

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
            SeguridadBtnGuardar.Enabled = false;
            SeguridadMetActualizarContador();
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
            SeguridadBtnGuardar.Enabled = false;
            SeguridadMetActualizarContador();

        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvListaRoles.Rows.Count > 0)
            {
                SeguridadDgvListaRoles.ClearSelection();
                SeguridadDgvListaRoles.Rows[0].Selected = true;
                SeguridadDgvListaRoles.CurrentCell = SeguridadDgvListaRoles.Rows[0].Cells[0];
            }
            SeguridadBtnGuardar.Enabled = false;
            SeguridadMetActualizarContador();
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
            SeguridadBtnGuardar.Enabled = false;
            SeguridadMetActualizarContador();

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
            SeguridadBtnGuardar.Enabled = false;
            SeguridadMetActualizarContador();

        }

        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadBtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SeguridadTxtNombreRol.Text))
                {
                    MessageBox.Show("Ingrese un Nombre de Rol para filtrar");
                    return;
                }

                SeguridadDgvListaRoles.DataSource = _SeguridadRoles.SeguridadMetBuscarPorNombre(SeguridadTxtNombreRol.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteMantenimientoPerfiles reporte = new FrmReporteMantenimientoPerfiles();
            reporte.Show();
        }
    }
}