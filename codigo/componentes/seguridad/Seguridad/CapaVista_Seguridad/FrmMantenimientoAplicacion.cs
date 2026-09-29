using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Modelos_de_controladores;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad;
using CapaVista_Seguridad.Ayudas;
using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Andy Alfonso Garcia Lopez
 * Carné : 9959-23-1494
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  El formulario del módulo de Mantenimiento de Aplicación nos 
 *  permite registrar, consultar, modificar y eliminar las 
 *  aplicaciones del sistema, administrando el catálogo referenciado 
 *  por el módulo de Asignación de Aplicaciones a Perfiles para el 
 *  control de accesos de cada usuario.
 * ===================================================================
*/

namespace CapaVista_Seguridad
{
    public partial class FrmMantenimientoAplicacion : Form
    {
        private ClsModeloMantenimientoApp _ModeloMantenimientoApp = new ClsModeloMantenimientoApp();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 7;
        public FrmMantenimientoAplicacion()
        {
            InitializeComponent();
            SeguridadMetReinicio();
        }

        private void FrmMantenimientoAplicacion_Load(object sender, EventArgs e)
        {
            SeguridadMetCargarCombos();
            SeguridadMetListaAplicaciones();

            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { SeguridadBtnGuardar, TipoPermiso.Insertar },
                { SeguridadBtnModificar, TipoPermiso.Editar },
                { SeguridadBtnEliminar, TipoPermiso.Eliminar }
            };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso) 
                return;
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                SeguridadCboIdModulo.DataSource = _ModeloMantenimientoApp.SeguridadMetObtenerModulos();
                SeguridadCboIdModulo.DisplayMember = "NombreModulo";
                SeguridadCboIdModulo.ValueMember = "IdModulo";
                SeguridadCboIdModulo.SelectedValue = 4;

                SeguridadCboBuscar.DataSource = _ModeloMantenimientoApp.SeguridadMetObtenerAplicaciones();
                SeguridadCboBuscar.DisplayMember = "NombreAplicacion";
                SeguridadCboBuscar.ValueMember = "IdAplicacion";

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetListaAplicaciones()
        {
            try
            {
                SeguridadDgvAplicaciones.DataSource = _ModeloMantenimientoApp.SeguridadMetObtenerTodos();

                SeguridadDgvAplicaciones.Columns[0].HeaderText = "Aplicacion";
                SeguridadDgvAplicaciones.Columns[1].Visible = false;
                SeguridadDgvAplicaciones.Columns[2].HeaderText = "Nombre Modulo";
                SeguridadDgvAplicaciones.Columns[3].HeaderText = "Nombre Aplicacion";
                SeguridadDgvAplicaciones.Columns[4].HeaderText = "Descripcion";
                SeguridadDgvAplicaciones.Columns[5].HeaderText = "Activo";
                SeguridadDgvAplicaciones.Columns[6].HeaderText = "Fecha Creacion";
                SeguridadDgvAplicaciones.Columns[7].HeaderText = "Ultima Actualizacion";

                SeguridadDgvAplicaciones.Columns[0].Width = 70;
                SeguridadDgvAplicaciones.Columns[2].Width = 70;
                SeguridadDgvAplicaciones.Columns[3].Width = 120;
                SeguridadDgvAplicaciones.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SeguridadDgvAplicaciones.Columns[5].Width = 50;
                SeguridadDgvAplicaciones.Columns[6].Width = 120;
                SeguridadDgvAplicaciones.Columns[7].Width = 120;
                SeguridadMetActualizarContador();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SeguridadPnlFormulario.Enabled)
                {
                    MessageBox.Show("Primero se debe presionar Ingresar para desbloquear el formulario");
                        return;
                }

                var Lista = _ModeloMantenimientoApp.SeguridadMetObtenerTodos();
                if (Lista.Any(Aplicacion => Aplicacion.NombreAplicacion.Trim().Equals(
                    SeguridadTxtNombreAplicacion.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Ya existe una aplicación con este nombre");
                    return;
                }

                _ModeloMantenimientoApp.IdModulo = Convert.ToInt32(SeguridadCboIdModulo.SelectedValue);
                _ModeloMantenimientoApp.NombreAplicacion = SeguridadTxtNombreAplicacion.Text;
                _ModeloMantenimientoApp.DescripcionAplicacion = SeguridadTxtDescripcion.Text;
                _ModeloMantenimientoApp.IsActive = SeguridadChkEstado.Checked;
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_ModeloMantenimientoApp).SeguridadMetValidar();

                if (Valido)
                {
                    string Resultado = _ModeloMantenimientoApp.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetCargarCombos();
                    SeguridadMetListaAplicaciones();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnModificar_Click(Object sender, EventArgs e)
        {
            try
            {

                if (!SeguridadPnlFormulario.Enabled)
                {
                    MessageBox.Show("Primero se debe presionar Ingresar para desbloquear el formulario");
                    return;
                }

                if (SeguridadDgvAplicaciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para poder modificar");
                    return;
                }

                _ModeloMantenimientoApp.IdAplicacion = Convert.ToInt32(SeguridadTxtIdAplicacion.Text);
                _ModeloMantenimientoApp.IdModulo = Convert.ToInt32(SeguridadCboIdModulo.SelectedValue);
                _ModeloMantenimientoApp.NombreAplicacion = SeguridadTxtNombreAplicacion.Text;
                _ModeloMantenimientoApp.DescripcionAplicacion = SeguridadTxtDescripcion.Text;
                _ModeloMantenimientoApp.IsActive = SeguridadChkEstado.Checked;
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;

                bool Valido = new ClsValidacionDatos(_ModeloMantenimientoApp).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _ModeloMantenimientoApp.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetCargarCombos();
                    SeguridadMetListaAplicaciones();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnBuscar_Click(Object sender, EventArgs e)
        {
            try
            {
                if (!SeguridadPnlFormulario.Enabled)
                {
                    MessageBox.Show("Primero se debe presionar Ingresar para desbloquear el formulario");
                    return;
                }

                int IdAplicacion = Convert.ToInt32(SeguridadCboBuscar.SelectedValue);
                var Resultado = _ModeloMantenimientoApp.SeguridadMetBuscarPorId(IdAplicacion);

                if (Resultado != null)
                {
                    SeguridadTxtIdAplicacion.Text = Resultado.IdAplicacion.ToString();
                    SeguridadCboIdModulo.SelectedValue = Resultado.IdModulo;
                    SeguridadTxtNombreAplicacion.Text = Resultado.NombreAplicacion;
                    SeguridadTxtDescripcion.Text = Resultado.DescripcionAplicacion;
                    SeguridadChkEstado.Checked = Resultado.IsActive;
                    _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;

                    SeguridadDgvAplicaciones.DataSource = new List<ClsModeloMantenimientoApp> { Resultado };
                    SeguridadDgvAplicaciones.Columns[0].HeaderText = "Aplicacion";
                    SeguridadDgvAplicaciones.Columns[1].Visible = false;
                    SeguridadDgvAplicaciones.Columns[2].HeaderText = "Nombre Modulo";
                    SeguridadDgvAplicaciones.Columns[3].HeaderText = "Nombre Aplicacion";
                    SeguridadDgvAplicaciones.Columns[4].HeaderText = "Descripcion";
                    SeguridadDgvAplicaciones.Columns[5].HeaderText = "Activo";
                    SeguridadDgvAplicaciones.Columns[6].HeaderText = "Fecha Creacion";
                    SeguridadDgvAplicaciones.Columns[7].HeaderText = "Ultima Actualizacion";
                    SeguridadMetActualizarContador();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnEliminar_Click(Object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvAplicaciones.SelectedRows.Count > 0)
                {
                    var Confirmacion = MessageBox.Show(
                    "¿Estas seguro que deseas eliminar este registro?", "Confirmacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Confirmacion == DialogResult.Yes)
                    {
                        _ModeloMantenimientoApp.IdAplicacion = Convert.ToInt32(SeguridadDgvAplicaciones.CurrentRow.Cells[0].Value);
                        _ModeloMantenimientoApp.Estado = EstadoEntidad.Deleted;

                        string Resultado = _ModeloMantenimientoApp.SeguridadMetGrabarCambios();
                        MessageBox.Show(Resultado);
                        SeguridadMetCargarCombos();
                        SeguridadMetListaAplicaciones();
                        SeguridadMetReinicio();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccionar una fila para eliminar");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadBtnSalir_Click(Object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadMetCargarFila(int Indice)
        {
            SeguridadDgvAplicaciones.ClearSelection();
            SeguridadDgvAplicaciones.Rows[Indice].Selected = true;
            SeguridadDgvAplicaciones.CurrentCell = SeguridadDgvAplicaciones.Rows[Indice].Cells[0];

            SeguridadTxtIdAplicacion.Text = SeguridadDgvAplicaciones.Rows[Indice].Cells[0].Value.ToString();
            SeguridadCboIdModulo.SelectedValue = Convert.ToInt32(SeguridadDgvAplicaciones.Rows[Indice].Cells[1].Value);
            SeguridadTxtNombreAplicacion.Text = SeguridadDgvAplicaciones.Rows[Indice].Cells[3].Value.ToString();
            SeguridadTxtDescripcion.Text = SeguridadDgvAplicaciones.Rows[Indice].Cells[4].Value.ToString();
            SeguridadChkEstado.Checked= Convert.ToBoolean(SeguridadDgvAplicaciones.Rows[Indice].Cells[5].Value);
            _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;

        }

        private void SeguridadMetReinicio()
        {
            SeguridadTxtIdAplicacion.Text = string.Empty;
            SeguridadTxtNombreAplicacion.Text = string.Empty;
            SeguridadTxtDescripcion.Text = string.Empty;
            SeguridadChkEstado.Checked = false;
            if (SeguridadCboIdModulo.Items.Count > 0)
                SeguridadCboIdModulo.SelectedIndex = 0;
            _ModeloMantenimientoApp.Estado = EstadoEntidad.Added;

            SeguridadPnlFormulario.Enabled = false;
            SeguridadCboBuscar.Enabled = false;
        }

        private void SeguridadDgvAplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SeguridadDgvAplicaciones.SelectedRows.Count > 0)
            {
                SeguridadTxtIdAplicacion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[0].Value.ToString();
                SeguridadCboIdModulo.SelectedValue = Convert.ToInt32(SeguridadDgvAplicaciones.CurrentRow.Cells[1].Value);
                SeguridadTxtNombreAplicacion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[3].Value.ToString();
                SeguridadTxtDescripcion.Text = SeguridadDgvAplicaciones.CurrentRow.Cells[4].Value.ToString();
                SeguridadChkEstado.Checked = Convert.ToBoolean(SeguridadDgvAplicaciones.CurrentRow.Cells[5].Value);
                _ModeloMantenimientoApp.Estado = EstadoEntidad.Modified;
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadMetCargarCombos();
            SeguridadCboBuscar.SelectedIndex = 0;
            SeguridadMetListaAplicaciones();
            SeguridadMetReinicio();
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0)
            {
                SeguridadMetCargarFila(0);
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0 && SeguridadDgvAplicaciones.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvAplicaciones.CurrentCell.RowIndex;
                if (FilaActual > 0)
                {
                    SeguridadMetCargarFila(FilaActual - 1);
                    SeguridadMetActualizarContador();
                }
            }
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0 && SeguridadDgvAplicaciones.CurrentCell != null)
            {
                int FilaActual = SeguridadDgvAplicaciones.CurrentCell.RowIndex;
                if (FilaActual < SeguridadDgvAplicaciones.Rows.Count - 1)
                {
                    SeguridadMetCargarFila(FilaActual + 1);
                    SeguridadMetActualizarContador();
                }
            }
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAplicaciones.Rows.Count > 0)
            {
                SeguridadMetCargarFila(SeguridadDgvAplicaciones.Rows.Count - 1);
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnIngresar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
            SeguridadPnlFormulario.Enabled = true;
            SeguridadCboBuscar.Enabled = true;
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
        }

        private void SeguridadMetActualizarContador()
        {
            int Total = SeguridadDgvAplicaciones.Rows.Count;

            if (Total == 0)
            {
                SeguridadLblDatos.Text = "Mostrando 0 de 0 registros";
                return;
            }

            int FilaActual = (SeguridadDgvAplicaciones.CurrentCell != null)
                ? SeguridadDgvAplicaciones.CurrentCell.RowIndex + 1
                : 1;

            SeguridadLblDatos.Text = $"Mostrando {FilaActual} de {Total} registros";
        }

        private void SeguridadBtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteMantenimientoAplicacioncs reporte = new FrmReporteMantenimientoAplicacioncs();
            reporte.Show();
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "Aplicaciones_Seguridad.html");
        }
    }
}