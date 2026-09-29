/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Omar Gomez y Andre de jesus Gonales
 * Carné : 9959-23-10733 y 9959-23-3117
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  Propósito :
 *  El FrmMantenimientoUsuarios es el formulario donde se
 *  gestiona los usuarios del sistema: puede agregar, modificar,
 *  eliminar, consultar por nombre y navegar entre los registros
 *  listados en el grid, controlando el acceso según los permisos
 *  asignados al usuario.
 * ===================================================================
*/
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmMantenimientoUsuarios : Form
    {
        private ClsModeloUsuario _Usuario = new ClsModeloUsuario();
        private ClsPermisoAplicacion _MisPermisos;
        private BindingSource _BindingSource = new BindingSource();
        private List<ClsModeloUsuario> _ListaUsuarios = new List<ClsModeloUsuario>();

        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 5;

        public FrmMantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                var MapaBotones = new Dictionary<Control, TipoPermiso>
                {
                    { SeguridadBtnGuardar,   TipoPermiso.Insertar },
                    { SeguridadBtnModificar, TipoPermiso.Editar },
                    { SeguridadBtnReporte,   TipoPermiso.Imprimir },
                    { SeguridadBtnLimpiar,   TipoPermiso.Eliminar }
                };

                _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                    this, ID_MODULO, ID_APLICACION, MapaBotones);

                if (!_MisPermisos.TieneAcceso)
                    return;

                SeguridadMetConfigurarColumnasUsuarios();
                SeguridadDgvUsuarios.DataSource = _BindingSource;
                SeguridadMetListarUsuarios();
                SeguridadMetCargarCombos();

                _BindingSource.CurrentChanged += SeguridadBsCurrentChanged;
                SeguridadBtnRefrescar.Click   += SeguridadBtnRefrescar_Click;
                SeguridadBtnConsultar.Click   += SeguridadBtnConsultar_Click;
                SeguridadBtnInicio.Click      += SeguridadBtnInicio_Click;
                SeguridadBtnAnterior.Click    += SeguridadBtnAnterior_Click;
                SeguridadBtnSiguiente.Click   += SeguridadBtnSiguiente_Click;
                SeguridadBtnFin.Click         += SeguridadBtnFin_Click;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                SeguridadCboEmpleado.DataSource = _Usuario.SeguridadMetObtenerEmpleados();
                SeguridadCboEmpleado.DisplayMember = "NombresEmpleado";
                SeguridadCboEmpleado.ValueMember = "IdEmpleado";
                SeguridadCboEmpleado.SelectedIndex = -1;
                SeguridadCboEmpleado.SelectedIndexChanged += CboEmpleado_SelectedIndexChanged;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void CboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeguridadCboEmpleado.SelectedValue != null)
                SeguridadTxtIdEmpleado.Text = SeguridadCboEmpleado.SelectedValue.ToString();
        }

        private void SeguridadMetListarUsuarios()
        {
            try
            {
                _ListaUsuarios = _Usuario.SeguridadMetObtenerTodos();
                _BindingSource.DataSource = _ListaUsuarios;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void SeguridadMetFiltrarUsuarios(string Nombre)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                _BindingSource.DataSource = _ListaUsuarios;
            }
            else
            {
                _BindingSource.DataSource = _ListaUsuarios
                    .Where(u => u.NombreUsuario != null &&
                                u.NombreUsuario.IndexOf(Nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }
        }

        private void SeguridadMetConfigurarColumnasUsuarios()
        {
            SeguridadDgvUsuarios.AutoGenerateColumns = false;
            SeguridadDgvUsuarios.Columns.Clear();

            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdUsuario", DataPropertyName = "IdUsuario",
                HeaderText = "ID", Width = 50
            });
            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdEmpleado", DataPropertyName = "IdEmpleado",
                HeaderText = "ID Empleado", Width = 90
            });
            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombreUsuario", DataPropertyName = "NombreUsuario",
                HeaderText = "Usuario", Width = 160
            });
            SeguridadDgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUltimoAcceso", DataPropertyName = "UltimoAccesoUsuario",
                HeaderText = "Último acceso", Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            SeguridadDgvUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colIsActive", DataPropertyName = "IsActive",
                HeaderText = "Estado", Width = 60
            });
        }

        private void SeguridadBsCurrentChanged(object sender, EventArgs e)
        {
            if (_BindingSource.Current is ClsModeloUsuario Usuario)
            {
                SeguridadTxtIdEmpleado.Text          = Usuario.IdEmpleado.ToString();
                SeguridadTxtUsuario.Text             = Usuario.NombreUsuario;
                SeguridadTxtContrasena.Text          = string.Empty;
                SeguridadTxtConfirmarContrasena.Text = string.Empty;
                SeguridadChkActivo.Checked           = Convert.ToBoolean(Usuario.IsActive);

                if (SeguridadCboEmpleado.DataSource != null)
                    SeguridadCboEmpleado.SelectedValue = Usuario.IdEmpleado;
            }
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadTxtConsultar.Clear();
            SeguridadMetListarUsuarios();
        }

        private void SeguridadBtnConsultar_Click(object sender, EventArgs e)
        {
            SeguridadMetFiltrarUsuarios(SeguridadTxtConsultar.Text.Trim());
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (_BindingSource.Count > 0)
                _BindingSource.MoveFirst();
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (_BindingSource.Position > 0)
                _BindingSource.MovePrevious();
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (_BindingSource.Position < _BindingSource.Count - 1)
                _BindingSource.MoveNext();
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (_BindingSource.Count > 0)
                _BindingSource.MoveLast();
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
                if (string.IsNullOrWhiteSpace(SeguridadTxtIdEmpleado.Text))
                {
                    MessageBox.Show("Seleccione un empleado del listado.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _Usuario.IdEmpleado                 = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                _Usuario.NombreUsuario              = SeguridadTxtUsuario.Text;
                _Usuario.ContrasenaUsuario          = SeguridadTxtContrasena.Text;
                _Usuario.ConfirmarContrasenaUsuario = SeguridadTxtConfirmarContrasena.Text;
                _Usuario.UltimoAccesoUsuario        = DateTime.Now;
                _Usuario.IsActive                   = SeguridadChkActivo.Checked ? 1 : 0;
                _Usuario.Estado                     = EstadoEntidad.Added;

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

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeEditar)
            {
                MessageBox.Show("No tienes permiso para modificar usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (SeguridadDgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para modificar.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(SeguridadTxtIdEmpleado.Text))
                {
                    MessageBox.Show("Haga clic sobre una fila del listado para cargar los datos.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _Usuario.IdUsuario                  = Convert.ToInt32(SeguridadDgvUsuarios.CurrentRow.Cells[0].Value);
                _Usuario.IdEmpleado                 = Convert.ToInt32(SeguridadTxtIdEmpleado.Text);
                _Usuario.NombreUsuario              = SeguridadTxtUsuario.Text;
                _Usuario.ContrasenaUsuario          = SeguridadTxtContrasena.Text;
                _Usuario.ConfirmarContrasenaUsuario = SeguridadTxtConfirmarContrasena.Text;
                _Usuario.UltimoAccesoUsuario        = DateTime.Now;
                _Usuario.IsActive                   = SeguridadChkActivo.Checked ? 1 : 0;
                _Usuario.Estado                     = EstadoEntidad.Modified;

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

        private void SeguridadDgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void SeguridadChkMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            char Caracter = SeguridadChkMostrarContra.Checked ? '\0' : '*';
            SeguridadTxtContrasena.PasswordChar          = Caracter;
            SeguridadTxtConfirmarContrasena.PasswordChar = Caracter;
        }

        private void SeguridadBtnLimpiar_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeEliminar)
            {
                MessageBox.Show("No tienes permiso para eliminar usuarios.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (SeguridadDgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila del listado para eliminar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult Confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el usuario seleccionado?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Confirmacion == DialogResult.Yes)
                {
                    _Usuario.IdUsuario = Convert.ToInt32(SeguridadDgvUsuarios.CurrentRow.Cells[0].Value);
                    _Usuario.Estado    = EstadoEntidad.Deleted;

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

        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadBtnReporte_Click(object sender, EventArgs e)
        {
            if (!_MisPermisos.PuedeImprimir)
            {
                MessageBox.Show("No tienes permiso para generar reportes.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmReporteMantenimientoUsuario reporte = new FrmReporteMantenimientoUsuario();
            reporte.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "Usuarios_Seguridad.html");
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            SeguridadTxtIdEmpleado.Clear();
            SeguridadTxtUsuario.Clear();
            SeguridadTxtContrasena.Clear();
            SeguridadCboEmpleado.SelectedIndex = -1;
            SeguridadChkActivo.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
