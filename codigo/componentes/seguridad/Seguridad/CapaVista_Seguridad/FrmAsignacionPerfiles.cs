using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista_Seguridad.frmReportes;


 /* ============================================================
 * Área : Seguridad
 * Autor : Daniella Jurado
 * Carné : 0901-23-3679
 * Fecha : 23/09/2026
 * ============================================================
 * Propósito :
 * Esta ventana permite administrar los perfiles asignados a los
 * usuarios del sistema. Cuenta con una sección para consultar los
 * perfiles que ya tiene asignado un usuario y otra para agregar
 * nuevas asignaciones, permitiendo seleccionar usuarios y perfiles,
 * revisar las asignaciones pendientes y quitarlas antes de guardarlas.
 * También permite eliminar perfiles ya asignados, navegar entre los
 * registros de las tablas, consultar la ayuda y generar el reporte
 * de las asignaciones. Además, controla los permisos de los botones
 * según el usuario que tenga acceso al módulo.
 * ============================================================
 */

namespace CapaVista_Seguridad
{
    public partial class FrmAsignacionPerfiles : Form
    {
        private DataGridView TablaActiva;
        private FrmReporteAsignacionPerfiles reporteAsignacionPerfiles;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 9;

        private readonly ClsModeloAsignacionPerfiles _ControladorAsignacion = new ClsModeloAsignacionPerfiles();
        private ClsPermisoAplicacion _MisPermisos;

        public FrmAsignacionPerfiles()
        {
            InitializeComponent();

            dataGridViewPerfilesUsuario.Enter += (s, e) => TablaActiva = dataGridViewPerfilesUsuario;
            dataGridViewAsignacion.Enter += (s, e) => TablaActiva = dataGridViewAsignacion;

            SeguridadMetConfigurarColumnasConsulta();
            SeguridadMetConfigurarColumnasAsignacion();
            CargarCombos();

            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { buttonAgregar, TipoPermiso.Insertar },
                { buttonAsignar, TipoPermiso.Insertar }
            };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (dataGridViewPerfilesUsuario.Columns.Contains("ColQuitarConsulta"))
                dataGridViewPerfilesUsuario.Columns["ColQuitarConsulta"].Visible =
                    _MisPermisos != null && _MisPermisos.PuedeEliminar;

            comboBoxUsuariosConsulta.SelectedIndexChanged += comboBoxUsuariosConsulta_SelectedIndexChanged;
            buttonCancelarConsulta.Click += buttonCancelarConsulta_Click;
            buttonAgregar.Click += buttonAgregar_Click;
            buttonAsignar.Click += buttonAsignar_Click;
            buttonCancelarAsignacion.Click += buttonCancelarAsignacion_Click;
            dataGridViewPerfilesUsuario.CellClick += dataGridViewPerfilesUsuario_CellClick;
            dataGridViewAsignacion.CellClick += dataGridViewAsignacion_CellClick;
        }

        private GraphicsPath SeguridadMetObtenerRectanguloRedondeado(Rectangle Limites, int Radio)
        {
            GraphicsPath RutaGrafica = new GraphicsPath();
            int Diametro = Radio * 2;
            RutaGrafica.AddArc(Limites.X, Limites.Y, Diametro, Diametro, 180, 90);
            RutaGrafica.AddArc(Limites.Right - Diametro, Limites.Y, Diametro, Diametro, 270, 90);
            RutaGrafica.AddArc(Limites.Right - Diametro, Limites.Bottom - Diametro, Diametro, Diametro, 0, 90);
            RutaGrafica.AddArc(Limites.X, Limites.Bottom - Diametro, Diametro, Diametro, 90, 90);
            RutaGrafica.CloseFigure();
            return RutaGrafica;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            panelHeader.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelHeader.ClientRectangle, 18));
        }

        private void panelConsulta_Paint(object sender, PaintEventArgs e)
        {
            panelConsulta.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelConsulta.ClientRectangle, 18));
        }

        private void panelAsignacion_Paint(object sender, PaintEventArgs e)
        {
            panelAsignacion.Region = new Region(SeguridadMetObtenerRectanguloRedondeado(panelAsignacion.ClientRectangle, 18));
        }


        #region Configuración de columnas (mismo patrón que FrmAsignacionAppPerf: columnas ocultas para los Id)

        private void SeguridadMetConfigurarColumnasConsulta()
        {
            dataGridViewPerfilesUsuario.AutoGenerateColumns = false;
            dataGridViewPerfilesUsuario.Columns.Clear();
            dataGridViewPerfilesUsuario.AllowUserToAddRows = false;
            dataGridViewPerfilesUsuario.ReadOnly = true;
            dataGridViewPerfilesUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewPerfilesUsuario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColIdRolConsulta",
                Visible = false
            });
            dataGridViewPerfilesUsuario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColNombreRolConsulta",
                HeaderText = "Perfil",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewPerfilesUsuario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColFechaConsulta",
                HeaderText = "Fecha de Asignación",
                Width = 150
            });
            dataGridViewPerfilesUsuario.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "ColQuitarConsulta",
                HeaderText = "Accion",
                Text = "Quitar",
                UseColumnTextForButtonValue = true,
                Width = 90
            });
        }

        private void SeguridadMetConfigurarColumnasAsignacion()
        {
            dataGridViewAsignacion.AutoGenerateColumns = false;
            dataGridViewAsignacion.Columns.Clear();
            dataGridViewAsignacion.AllowUserToAddRows = false;
            dataGridViewAsignacion.ReadOnly = true;
            dataGridViewAsignacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewAsignacion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColIdUsuarioPend",
                Visible = false
            });
            dataGridViewAsignacion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColIdRolPend",
                Visible = false
            });
            dataGridViewAsignacion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColNombreUsuarioPend",
                HeaderText = "Usuario",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewAsignacion.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ColNombreRolPend",
                HeaderText = "Perfil",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewAsignacion.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "ColQuitarPend",
                HeaderText = "Accion",
                Text = "Quitar",
                UseColumnTextForButtonValue = true,
                Width = 90
            });
        }

        #endregion

        #region Carga de combos

        private void CargarCombos()
        {
            try
            {
                DataTable dtUsuariosConsulta = _ControladorAsignacion.SeguridadMetObtenerUsuarios();
                comboBoxUsuariosConsulta.DataSource = dtUsuariosConsulta;
                comboBoxUsuariosConsulta.DisplayMember = "nombreUsuario";
                comboBoxUsuariosConsulta.ValueMember = "idUsuario";
                comboBoxUsuariosConsulta.SelectedIndex = -1;

                DataTable dtUsuariosAsignacion = _ControladorAsignacion.SeguridadMetObtenerUsuarios();
                comboBoxUsuariosAsignacion.DataSource = dtUsuariosAsignacion;
                comboBoxUsuariosAsignacion.DisplayMember = "nombreUsuario";
                comboBoxUsuariosAsignacion.ValueMember = "idUsuario";
                comboBoxUsuariosAsignacion.SelectedIndex = -1;

                DataTable dtRoles = _ControladorAsignacion.SeguridadMetObtenerRoles();
                comboBoxPerfilesAsignacion.DataSource = dtRoles;
                comboBoxPerfilesAsignacion.DisplayMember = "nombreRol";
                comboBoxPerfilesAsignacion.ValueMember = "idRol";
                comboBoxPerfilesAsignacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Panel Consulta (perfiles ya asignados a un usuario)

        private void comboBoxUsuariosConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewPerfilesUsuario.Rows.Clear();

            if (comboBoxUsuariosConsulta.SelectedValue == null ||
                !(comboBoxUsuariosConsulta.SelectedValue is int))
                return;

            int idUsuarioSeleccionado = (int)comboBoxUsuariosConsulta.SelectedValue;

            try
            {
                _ControladorAsignacion.SeguridadMetObtenerTodos();
                var Asignados = _ControladorAsignacion.SeguridadMetBuscarPorUsuario(idUsuarioSeleccionado).ToList();

                foreach (var Item in Asignados)
                {
                    dataGridViewPerfilesUsuario.Rows.Add(
                        Item.IdRol,
                        Item.NombreRol,
                        Item.FechaAsignacionUsuarioRol.ToString("dd/MM/yyyy"),
                        "Quitar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los perfiles del usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPerfilesUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridViewPerfilesUsuario.Columns[e.ColumnIndex].Name != "ColQuitarConsulta") return;
            if (!(_MisPermisos != null && _MisPermisos.PuedeEliminar)) return;

            var Fila = dataGridViewPerfilesUsuario.Rows[e.RowIndex];
            int idUsuario = (int)comboBoxUsuariosConsulta.SelectedValue;
            int idRol = Convert.ToInt32(Fila.Cells["ColIdRolConsulta"].Value);
            string nombreRol = Fila.Cells["ColNombreRolConsulta"].Value.ToString();

            DialogResult Respuesta = MessageBox.Show(
                "¿Quitar el perfil \"" + nombreRol + "\" a este usuario?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Respuesta != DialogResult.Yes) return;

            _ControladorAsignacion.IdUsuario = idUsuario;
            _ControladorAsignacion.IdRol = idRol;
            _ControladorAsignacion.Estado = EstadoEntidad.Deleted;

            string Resultado = _ControladorAsignacion.SeguridadMetGrabarCambios();
            MessageBox.Show(Resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxUsuariosConsulta_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void buttonCancelarConsulta_Click(object sender, EventArgs e)
        {
            comboBoxUsuariosConsulta.SelectedIndex = -1;
            dataGridViewPerfilesUsuario.Rows.Clear();
        }

        #endregion

        #region Panel Asignación (agregar nuevos perfiles a un usuario)

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuariosAsignacion.SelectedValue == null || !(comboBoxUsuariosAsignacion.SelectedValue is int) ||
                comboBoxPerfilesAsignacion.SelectedValue == null || !(comboBoxPerfilesAsignacion.SelectedValue is int))
            {
                MessageBox.Show("Debe seleccionar un Usuario y un Perfil antes de agregar.",
                    "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = (int)comboBoxUsuariosAsignacion.SelectedValue;
            int idRol = (int)comboBoxPerfilesAsignacion.SelectedValue;
            string nombreUsuario = ((DataRowView)comboBoxUsuariosAsignacion.SelectedItem)["nombreUsuario"].ToString();
            string nombreRol = ((DataRowView)comboBoxPerfilesAsignacion.SelectedItem)["nombreRol"].ToString();

            foreach (DataGridViewRow Fila in dataGridViewAsignacion.Rows)
            {
                int idUsuarioFila = Convert.ToInt32(Fila.Cells["ColIdUsuarioPend"].Value);
                int idRolFila = Convert.ToInt32(Fila.Cells["ColIdRolPend"].Value);
                if (idUsuarioFila == idUsuario && idRolFila == idRol)
                {
                    MessageBox.Show("Ese perfil ya está en la lista de asignación pendiente.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dataGridViewAsignacion.Rows.Add(idUsuario, idRol, nombreUsuario, nombreRol, "Quitar");
        }

        private void dataGridViewAsignacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridViewAsignacion.Columns[e.ColumnIndex].Name != "ColQuitarPend") return;

            dataGridViewAsignacion.Rows.RemoveAt(e.RowIndex);
        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAsignacion.Rows.Count == 0)
            {
                MessageBox.Show("No hay perfiles pendientes por asignar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var Errores = new StringBuilder();
            int Exitosos = 0;
            int Total = dataGridViewAsignacion.Rows.Count;

            foreach (DataGridViewRow Fila in dataGridViewAsignacion.Rows)
            {
                int idUsuario = Convert.ToInt32(Fila.Cells["ColIdUsuarioPend"].Value);
                int idRol = Convert.ToInt32(Fila.Cells["ColIdRolPend"].Value);
                string nombreUsuario = Fila.Cells["ColNombreUsuarioPend"].Value.ToString();
                string nombreRol = Fila.Cells["ColNombreRolPend"].Value.ToString();

                _ControladorAsignacion.IdUsuario = idUsuario;
                _ControladorAsignacion.IdRol = idRol;
                _ControladorAsignacion.FechaAsignacionUsuarioRol = DateTime.Now;
                _ControladorAsignacion.Estado = EstadoEntidad.Added;

                string Resultado = _ControladorAsignacion.SeguridadMetGrabarCambios();
                if (Resultado == "Grabacion exitosa")
                    Exitosos++;
                else
                    Errores.AppendLine(nombreUsuario + " → " + nombreRol + ": " + Resultado);
            }

            string Mensaje = Exitosos + " de " + Total + " asignaciones guardadas correctamente.";
            if (Errores.Length > 0)
                Mensaje += Environment.NewLine + Environment.NewLine + "Errores:" + Environment.NewLine + Errores.ToString();

            MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK,
                Errores.Length > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

            dataGridViewAsignacion.Rows.Clear();
            comboBoxUsuariosAsignacion.SelectedIndex = -1;
            comboBoxPerfilesAsignacion.SelectedIndex = -1;

            comboBoxUsuariosConsulta_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void buttonCancelarAsignacion_Click(object sender, EventArgs e)
        {
            dataGridViewAsignacion.Rows.Clear();
            comboBoxUsuariosAsignacion.SelectedIndex = -1;
            comboBoxPerfilesAsignacion.SelectedIndex = -1;
        }

        #endregion

        private DataGridView ObtenerDataGridViewActivo()
        {
            if (TablaActiva != null)
                return TablaActiva;

            if (dataGridViewPerfilesUsuario.Rows.Count > 0)
                return dataGridViewPerfilesUsuario;

            return dataGridViewAsignacion;
        }

        private int ObtenerPrimeraColumnaVisible(DataGridView Tabla)
        {
            for (int i = 0; i < Tabla.Columns.Count; i++)
            {
                if (Tabla.Columns[i].Visible)
                {
                    return i;
                }
            }

            return -1;
        }

        private void BtnSeguridadInicio_Click(object sender, EventArgs e)
        {
            DataGridView Tabla = ObtenerDataGridViewActivo();

            if (Tabla.Rows.Count > 0)
            {
                int ColumnaVisible = ObtenerPrimeraColumnaVisible(Tabla);

                if (ColumnaVisible >= 0)
                {
                    Tabla.ClearSelection();
                    Tabla.Rows[0].Selected = true;
                    Tabla.CurrentCell = Tabla.Rows[0].Cells[ColumnaVisible];
                    Tabla.Focus();
                }
            }
        }

        private void BtnSeguridadAnterior_Click(object sender, EventArgs e)
        {
            DataGridView Tabla = ObtenerDataGridViewActivo();

            if (Tabla.Rows.Count > 0 && Tabla.CurrentCell != null)
            {
                int FilaActual = Tabla.CurrentCell.RowIndex;

                if (FilaActual > 0)
                {
                    int ColumnaVisible = ObtenerPrimeraColumnaVisible(Tabla);

                    if (ColumnaVisible >= 0)
                    {
                        Tabla.ClearSelection();
                        Tabla.Rows[FilaActual - 1].Selected = true;
                        Tabla.CurrentCell =
                            Tabla.Rows[FilaActual - 1].Cells[ColumnaVisible];
                        Tabla.Focus();
                    }
                }
            }
        }

        private void BtnSeguridadSiguiente_Click(object sender, EventArgs e)
        {
            DataGridView Tabla = ObtenerDataGridViewActivo();

            if (Tabla.Rows.Count > 0 && Tabla.CurrentCell != null)
            {
                int FilaActual = Tabla.CurrentCell.RowIndex;

                if (FilaActual < Tabla.Rows.Count - 1)
                {
                    int ColumnaVisible = ObtenerPrimeraColumnaVisible(Tabla);

                    if (ColumnaVisible >= 0)
                    {
                        Tabla.ClearSelection();
                        Tabla.Rows[FilaActual + 1].Selected = true;
                        Tabla.CurrentCell =
                            Tabla.Rows[FilaActual + 1].Cells[ColumnaVisible];
                        Tabla.Focus();
                    }
                }
            }
        }

        private void BtnSeguridadFin_Click(object sender, EventArgs e)
        {
            DataGridView Tabla = ObtenerDataGridViewActivo();

            if (Tabla.Rows.Count > 0)
            {
                int UltimaFila = Tabla.Rows.Count - 1;
                int ColumnaVisible = ObtenerPrimeraColumnaVisible(Tabla);

                if (ColumnaVisible >= 0)
                {
                    Tabla.ClearSelection();
                    Tabla.Rows[UltimaFila].Selected = true;
                    Tabla.CurrentCell =
                        Tabla.Rows[UltimaFila].Cells[ColumnaVisible];
                    Tabla.Focus();
                }
            }
        }

        private void BtnSeguridadSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSeguridadAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "AsigPerfiles_Seguridad.html");
        }

        private void BtnSeguridadReporte_Click(object sender, EventArgs e)
        {
            if (reporteAsignacionPerfiles == null ||
                reporteAsignacionPerfiles.IsDisposed)
            {
                reporteAsignacionPerfiles =
                    new FrmReporteAsignacionPerfiles();

                reporteAsignacionPerfiles.FormClosed +=
                    (s, args) => reporteAsignacionPerfiles = null;

                reporteAsignacionPerfiles.Show();
            }
            else
            {
                reporteAsignacionPerfiles.BringToFront();
                reporteAsignacionPerfiles.Activate();
            }
        }
    }
    }

