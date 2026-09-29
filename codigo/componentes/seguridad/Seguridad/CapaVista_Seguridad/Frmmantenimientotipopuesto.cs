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
    public partial class FrmMantenimientoTipoPuesto : Form
    {
        private ClsModeloTipoPuesto _TipoPuesto = new ClsModeloTipoPuesto();
        private ClsPermisoAplicacion _MisPermisos;
        private bool _ModoAgregar = false;

        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 13;

        public FrmMantenimientoTipoPuesto()
        {
            InitializeComponent();
        }

        private void FrmMantenimientoTipoPuesto_Load(object sender, EventArgs e)
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

            SeguridadMetListarTipoPuesto();
            SeguridadMetHabilitarCampos(false);
            SeguridadMetActualizarContador();
        }

        private void SeguridadMetListarTipoPuesto()
        {
            try
            {
                SeguridadDgvTipoPuesto.DataSource = _TipoPuesto.SeguridadMetObtenerTodos();
                SeguridadMetConfigurarEncabezadosGrid();
                SeguridadMetActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadMetConfigurarEncabezadosGrid()
        {
            if (SeguridadDgvTipoPuesto.Columns["IdTipoPuesto"] != null)
                SeguridadDgvTipoPuesto.Columns["IdTipoPuesto"].HeaderText = "No.";

            if (SeguridadDgvTipoPuesto.Columns["NombreTipoPuesto"] != null)
                SeguridadDgvTipoPuesto.Columns["NombreTipoPuesto"].HeaderText = "Nombre";

            if (SeguridadDgvTipoPuesto.Columns["DescripcionTipoPuesto"] != null)
                SeguridadDgvTipoPuesto.Columns["DescripcionTipoPuesto"].HeaderText = "Descripción";

            if (SeguridadDgvTipoPuesto.Columns["IsActive"] != null)
                SeguridadDgvTipoPuesto.Columns["IsActive"].HeaderText = "Estado";

            if (SeguridadDgvTipoPuesto.Columns["CreatedAt"] != null)
                SeguridadDgvTipoPuesto.Columns["CreatedAt"].HeaderText = "Registrado";

            if (SeguridadDgvTipoPuesto.Columns["UpdatedAt"] != null)
                SeguridadDgvTipoPuesto.Columns["UpdatedAt"].HeaderText = "Última Modificación";
        }

        private void SeguridadMetActualizarContador()
        {
            int Total = SeguridadDgvTipoPuesto.Rows.Count;

            if (Total == 0)
            {
                LblSeguridadContadorTipoPuesto.Text = "Mostrando 0 de 0 registros";
                return;
            }

            int FilaActual = (SeguridadDgvTipoPuesto.CurrentCell != null)
                ? SeguridadDgvTipoPuesto.CurrentCell.RowIndex + 1
                : 1;

            LblSeguridadContadorTipoPuesto.Text = $"Mostrando {FilaActual} de {Total} registros";
        }

        private void SeguridadMetHabilitarCampos(bool habilitar)
        {
            SeguridadTxtNombre.Enabled = habilitar;
            SeguridadTxtDescripcion.Enabled = habilitar;
            SeguridadChkActivo.Enabled = habilitar;
        }

        private void SeguridadMetReinicio()
        {
            SeguridadTxtIdTipoPuesto.Clear();
            SeguridadTxtNombre.Clear();
            SeguridadTxtDescripcion.Clear();
            SeguridadChkActivo.Checked = true;
            _ModoAgregar = false;
        }

        private void SeguridadMetCargarFilaEnFormulario(int rowIndex)
        {
            var fila = SeguridadDgvTipoPuesto.Rows[rowIndex];

            _TipoPuesto.Estado = EstadoEntidad.Modified;
            _ModoAgregar = false;

            SeguridadTxtIdTipoPuesto.Text = fila.Cells["IdTipoPuesto"].Value.ToString();
            SeguridadTxtNombre.Text = fila.Cells["NombreTipoPuesto"].Value.ToString();
            SeguridadTxtDescripcion.Text = fila.Cells["DescripcionTipoPuesto"].Value?.ToString();
            SeguridadChkActivo.Checked = Convert.ToBoolean(fila.Cells["IsActive"].Value);

            SeguridadMetHabilitarCampos(true);
        }

        private void SeguridadMetSeleccionarFila(int indice)
        {
            if (indice < 0 || indice >= SeguridadDgvTipoPuesto.Rows.Count) return;

            SeguridadDgvTipoPuesto.ClearSelection();
            SeguridadDgvTipoPuesto.Rows[indice].Selected = true;
            SeguridadDgvTipoPuesto.CurrentCell = SeguridadDgvTipoPuesto.Rows[indice].Cells[0];
            SeguridadMetCargarFilaEnFormulario(indice);
            SeguridadMetActualizarContador();
        }

        private void SeguridadMetAsignarDatosAlModelo()
        {
            _TipoPuesto.NombreTipoPuesto = SeguridadTxtNombre.Text;
            _TipoPuesto.DescripcionTipoPuesto = SeguridadTxtDescripcion.Text;
            _TipoPuesto.IsActive = SeguridadChkActivo.Checked;
        }

        // ---------------------------- Botones ----------------------------

        private void SeguridadBtnAgregar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
            _TipoPuesto.Estado = EstadoEntidad.Added;
            _ModoAgregar = true;
            SeguridadMetHabilitarCampos(true);
            SeguridadTxtNombre.Focus();
        }

        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_ModoAgregar)
                {
                    MessageBox.Show("Presione Agregar para registrar un nuevo tipo de puesto");
                    return;
                }

                SeguridadMetAsignarDatosAlModelo();
                _TipoPuesto.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_TipoPuesto).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _TipoPuesto.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarTipoPuesto();
                    SeguridadMetReinicio();
                    SeguridadMetHabilitarCampos(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvTipoPuesto.SelectedRows.Count == 0
                    || string.IsNullOrWhiteSpace(SeguridadTxtIdTipoPuesto.Text))
                {
                    MessageBox.Show("Seleccione una fila del listado para modificar");
                    return;
                }

                _TipoPuesto.IdTipoPuesto = Convert.ToInt32(SeguridadTxtIdTipoPuesto.Text);
                SeguridadMetAsignarDatosAlModelo();
                _TipoPuesto.Estado = EstadoEntidad.Modified;

                bool Valido = new ClsValidacionDatos(_TipoPuesto).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _TipoPuesto.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarTipoPuesto();
                    SeguridadMetReinicio();
                    SeguridadMetHabilitarCampos(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvTipoPuesto.SelectedRows.Count > 0)
            {
                var Confirmar = MessageBox.Show("¿Desea eliminar el tipo de puesto seleccionado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Confirmar != DialogResult.Yes) return;

                _TipoPuesto.Estado = EstadoEntidad.Deleted;
                _TipoPuesto.IdTipoPuesto = Convert.ToInt32(SeguridadDgvTipoPuesto.CurrentRow.Cells["IdTipoPuesto"].Value);

                string Resultado = _TipoPuesto.SeguridadMetGrabarCambios();
                MessageBox.Show(Resultado);
                SeguridadMetListarTipoPuesto();
                SeguridadMetReinicio();
                SeguridadMetHabilitarCampos(false);
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void SeguridadBtnCancelar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
            SeguridadMetListarTipoPuesto();
            SeguridadMetHabilitarCampos(false);
        }

        private void SeguridadBtnLimpiar_Click(object sender, EventArgs e)
        {
            SeguridadTxtBuscar.Clear();
            SeguridadMetReinicio();
            SeguridadMetListarTipoPuesto();
            SeguridadMetHabilitarCampos(false);
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
            SeguridadMetListarTipoPuesto();
            SeguridadMetHabilitarCampos(false);
        }

        private void SeguridadBtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(SeguridadTxtBuscar.Text))
                {
                    MessageBox.Show("Ingrese el nombre del tipo de puesto a buscar");
                    return;
                }

                _TipoPuesto.SeguridadMetObtenerTodos();
                SeguridadDgvTipoPuesto.DataSource = _TipoPuesto.SeguridadMetBuscarPorNombre(SeguridadTxtBuscar.Text).ToList();
                SeguridadMetConfigurarEncabezadosGrid();
                SeguridadMetActualizarContador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            SeguridadMetSeleccionarFila(0);
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvTipoPuesto.CurrentCell != null)
                SeguridadMetSeleccionarFila(SeguridadDgvTipoPuesto.CurrentCell.RowIndex - 1);
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvTipoPuesto.CurrentCell != null)
                SeguridadMetSeleccionarFila(SeguridadDgvTipoPuesto.CurrentCell.RowIndex + 1);
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            SeguridadMetSeleccionarFila(SeguridadDgvTipoPuesto.Rows.Count - 1);
        }

        private void SeguridadDgvTipoPuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SeguridadMetCargarFilaEnFormulario(e.RowIndex);
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnImprimir_Click(object sender, EventArgs e)
        {
            // Pendiente: aquí se abre el reporte de Tipo de Puesto cuando exista
            MessageBox.Show("El reporte de Tipo de Puesto aún no está disponible.");
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "TipoPuesto_Seguridad.html");
        }

        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadPnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}