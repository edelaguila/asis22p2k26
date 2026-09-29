using CapaControlador_Seguridad.Objetos_de_valor;
using CapaControlador_Seguridad;
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
    public partial class FrmAsignacionAppPerf : Form
    {
        private ClsModeloAsigAppPerf _AsigAppPerf = new ClsModeloAsigAppPerf();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 10;

        public FrmAsignacionAppPerf()
        {   
            InitializeComponent();
        }

        private void FrmAsignacionAppPerf_Load(object sender, EventArgs e)
        {
            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { BtnSeguridadAgregar,   TipoPermiso.Insertar },
                { BtnSeguridadModificar, TipoPermiso.Editar   },
                { BtnSeguridadQuitar,    TipoPermiso.Eliminar }
            };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
             this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso)
            return;

            SeguridadMetCargarCombos();
            SeguridadMetConfigurarColumnas();
            SeguridadMetListarAsigAppPerf();
        }

        private void SeguridadMetConfigurarColumnas()
        {
            DgvSeguridadListaUsuarios.AutoGenerateColumns = false;
            DgvSeguridadListaUsuarios.Columns.Clear();

            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdRol",
                Name = "IdRol",
                Visible = false
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdModulo",
                Name = "IdModulo",
                Visible = false
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdAplicacion",
                Name = "IdAplicacion",
                Visible = false
            });

            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreRol",
                HeaderText = "Perfil",
                Name = "NombreRol"
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreModulo",
                HeaderText = "Módulo",
                Name = "NombreModulo"
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreAplicacion",
                HeaderText = "Aplicación",
                Name = "NombreAplicacion"
            });

            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "DerInsertarRolModuloAplicacion",
                HeaderText = "Insertar",
                Name = "DerInsertar"
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "DerEditarRolModuloAplicacion",
                HeaderText = "Editar",
                Name = "DerEditar"
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "DerEliminarRolModuloAplicacion",
                HeaderText = "Eliminar",
                Name = "DerEliminar"
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "DerImprimirRolModuloAplicacion",
                HeaderText = "Imprimir",
                Name = "DerImprimir"
            });

            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Fecha de creación",
                Name = "CreatedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            DgvSeguridadListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedAt",
                HeaderText = "Última actualización",
                Name = "UpdatedAt",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                CboSeguridadPerfiles.DataSource = _AsigAppPerf.SeguridadMetObtenerRoles();
                CboSeguridadPerfiles.DisplayMember = "NombreRol";
                CboSeguridadPerfiles.ValueMember = "IdRol";

                CboSeguridadModulos.DataSource = _AsigAppPerf.SeguridadMetObtenerModulos();
                CboSeguridadModulos.DisplayMember = "NombreModulo";
                CboSeguridadModulos.ValueMember = "IdModulo";

                CboSeguridadAplicaciones.DataSource = _AsigAppPerf.SeguridadMetObtenerAplicaciones();
                CboSeguridadAplicaciones.DisplayMember = "NombreAplicacion";
                CboSeguridadAplicaciones.ValueMember = "IdAplicacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadMetListarAsigAppPerf()
        {
            try
            {
                DgvSeguridadListaUsuarios.DataSource = _AsigAppPerf.SeguridadMetObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un Perfil, Módulo y Aplicación, marque los permisos deseados y presione Agregar.");
        }

        private void BtnSeguridadAgregar_Click(object sender, EventArgs e)
        {
            CboSeguridadPerfiles.SelectedIndex = -1;
            CboSeguridadModulos.SelectedIndex = -1;
            CboSeguridadAplicaciones.SelectedIndex = -1;

            chkSeguridadInsertar.Checked = false;
            chkSeguridadEditar.Checked = false;
            chkSeguridadeliminar.Checked = false;
            chkSeguridadImprimir.Checked = false;

            _AsigAppPerf.Estado = EstadoEntidad.Added;

            CboSeguridadPerfiles.Enabled = true;
            CboSeguridadModulos.Enabled = true;
            CboSeguridadAplicaciones.Enabled = true;
        }

        private void BtnSeguridadBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtSeguridadFiltro.Text))
                {
                    MessageBox.Show("Ingrese un ID de Rol para filtrar");
                    return;
                }

                int IdRol = Convert.ToInt32(TxtSeguridadFiltro.Text);
                DgvSeguridadListaUsuarios.DataSource = _AsigAppPerf.SeguridadMetBuscarPorRol(IdRol);
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID de Rol debe ser un número");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadQuitar_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.SelectedRows.Count > 0)
            {
                _AsigAppPerf.Estado = EstadoEntidad.Deleted;
                _AsigAppPerf.IdRol = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells["IdRol"].Value);
                _AsigAppPerf.IdModulo = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells["IdModulo"].Value);
                _AsigAppPerf.IdAplicacion = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells["IdAplicacion"].Value);

                string Resultado = _AsigAppPerf.SeguridadMetGrabarCambios();
                MessageBox.Show(Resultado);
                SeguridadMetListarAsigAppPerf();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void BtnSeguridadSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvSeguridadListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSeguridadListaUsuarios.SelectedRows.Count > 0)
            {
                _AsigAppPerf.Estado = EstadoEntidad.Modified;
                CboSeguridadPerfiles.SelectedValue = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells["IdRol"].Value);
                CboSeguridadModulos.SelectedValue = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells["IdModulo"].Value);
                CboSeguridadAplicaciones.SelectedValue = Convert.ToInt32(DgvSeguridadListaUsuarios.CurrentRow.Cells["IdAplicacion"].Value);
                chkSeguridadInsertar.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells["DerInsertar"].Value);
                chkSeguridadEditar.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells["DerEditar"].Value);
                chkSeguridadeliminar.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells["DerEliminar"].Value);
                chkSeguridadImprimir.Checked = Convert.ToBoolean(DgvSeguridadListaUsuarios.CurrentRow.Cells["DerImprimir"].Value);
            }
        }

        private void SeguridadMetReinicio()
        {
            chkSeguridadInsertar.Checked = false;
            chkSeguridadEditar.Checked = false;
            chkSeguridadeliminar.Checked = false;
            chkSeguridadImprimir.Checked = false;
        }

        private void BtnSeguridadModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvSeguridadListaUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para modificar");
                    return;
                }

                _AsigAppPerf.IdRol = Convert.ToInt32(CboSeguridadPerfiles.SelectedValue);
                _AsigAppPerf.IdModulo = Convert.ToInt32(CboSeguridadModulos.SelectedValue);
                _AsigAppPerf.IdAplicacion = Convert.ToInt32(CboSeguridadAplicaciones.SelectedValue);
                _AsigAppPerf.DerInsertarRolModuloAplicacion = chkSeguridadInsertar.Checked;
                _AsigAppPerf.DerEditarRolModuloAplicacion = chkSeguridadEditar.Checked;
                _AsigAppPerf.DerEliminarRolModuloAplicacion = chkSeguridadeliminar.Checked;
                _AsigAppPerf.DerImprimirRolModuloAplicacion = chkSeguridadImprimir.Checked;
                _AsigAppPerf.Estado = EstadoEntidad.Modified;

                bool Valido = new ClsValidacionDatos(_AsigAppPerf).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _AsigAppPerf.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarAsigAppPerf();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                _AsigAppPerf.IdRol = Convert.ToInt32(CboSeguridadPerfiles.SelectedValue);
                _AsigAppPerf.IdModulo = Convert.ToInt32(CboSeguridadModulos.SelectedValue);
                _AsigAppPerf.IdAplicacion = Convert.ToInt32(CboSeguridadAplicaciones.SelectedValue);
                _AsigAppPerf.DerInsertarRolModuloAplicacion = chkSeguridadInsertar.Checked;
                _AsigAppPerf.DerEditarRolModuloAplicacion = chkSeguridadEditar.Checked;
                _AsigAppPerf.DerEliminarRolModuloAplicacion = chkSeguridadeliminar.Checked;
                _AsigAppPerf.DerImprimirRolModuloAplicacion = chkSeguridadImprimir.Checked;
                _AsigAppPerf.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_AsigAppPerf).SeguridadMetValidar();
                if (Valido)
                {
                    string Resultado = _AsigAppPerf.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarAsigAppPerf();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadActualizar_Click(object sender, EventArgs e)
        {
            TxtSeguridadFiltro.Clear();
            SeguridadMetListarAsigAppPerf();
        }

        private void BtnSeguridadInicio_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0)
            {
                DgvSeguridadListaUsuarios.ClearSelection();
                DgvSeguridadListaUsuarios.Rows[0].Selected = true;
                DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[0].Cells[0];
            }
        }

        private void BtnSeguridadAnterior_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0 && DgvSeguridadListaUsuarios.CurrentCell != null)
            {
                int FilaActual = DgvSeguridadListaUsuarios.CurrentCell.RowIndex;
                if (FilaActual > 0)
                {
                    DgvSeguridadListaUsuarios.ClearSelection();
                    DgvSeguridadListaUsuarios.Rows[FilaActual - 1].Selected = true;
                    DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[FilaActual - 1].Cells[0];
                }
            }
        }

        private void BtnSeguridadSiguiente_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0 && DgvSeguridadListaUsuarios.CurrentCell != null)
            {
                int FilaActual = DgvSeguridadListaUsuarios.CurrentCell.RowIndex;
                if (FilaActual < DgvSeguridadListaUsuarios.Rows.Count - 1)
                {
                    DgvSeguridadListaUsuarios.ClearSelection();
                    DgvSeguridadListaUsuarios.Rows[FilaActual + 1].Selected = true;
                    DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[FilaActual + 1].Cells[0];
                }
            }
        }

        private void BtnSeguridadFin_Click(object sender, EventArgs e)
        {
            if (DgvSeguridadListaUsuarios.Rows.Count > 0)
            {
                int UltimaFila = DgvSeguridadListaUsuarios.Rows.Count - 1;
                DgvSeguridadListaUsuarios.ClearSelection();
                DgvSeguridadListaUsuarios.Rows[UltimaFila].Selected = true;
                DgvSeguridadListaUsuarios.CurrentCell = DgvSeguridadListaUsuarios.Rows[UltimaFila].Cells[0];
            }
        }
    }
}