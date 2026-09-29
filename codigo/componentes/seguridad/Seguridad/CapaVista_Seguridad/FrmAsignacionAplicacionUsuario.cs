using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

/*
 * ============================================================
 * Área         : Seguridad
 * Autor        : Evelyn Sofía Andrade Luna
 * Carné        : 9959-23-1224
 * Autor        : Guillermo Daniel Morales Mendizabal
 * Carné        : 0901-23-3329
 * Fecha        : 24/09/2026
 * ============================================================
 * Propósito    :
 *   Formulario principal del módulo de Asignación de
 *   Aplicación a Usuario. Permite asignar y quitar
 *   aplicaciones a usuarios por módulo, con validación
 *   de permisos de acceso. Incluye navegación entre
 *   registros, búsqueda por usuario, refresco de datos
 *   y acceso al reporte de asignaciones.
 * ============================================================
 */

namespace CapaVista_Seguridad
{
    public partial class FrmAsignacionAplicacionUsuario : Form
    {
        private ClsModeloAsigAppUsuario _AsigAppUsuario = new ClsModeloAsigAppUsuario();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 11;

        public FrmAsignacionAplicacionUsuario()
        {
            InitializeComponent();

            this.Load += FrmAsignacionAplicacionUsuario_Load;
            SeguridadBtnInsertar.Click += BtnSeguridadInsertar_Click;
            SeguridadBtnQuitar.Click += BtnSeguridadQuitar_Click;
            SeguridadBtnBuscar.Click += BtnSeguridadBuscar_Click;
            SeguridadBtnRefrescar.Click += SeguridadBtnRefrescar_Click;
            SeguridadBtnSalir.Click += BtnSeguridadSalir_Click;
            SeguridadBtnAyuda.Click += SeguridadBtnAyuda_Click;
            SeguridadBtnInicio.Click += SeguridadBtnInicio_Click;
            SeguridadBtnAnterior.Click += SeguridadBtnAnterior_Click;
            SeguridadBtnSiguiente.Click += SeguridadBtnSiguiente_Click;
            SeguridadBtnFin.Click += SeguridadBtnFin_Click;
        }

        private void FrmAsignacionAplicacionUsuario_Load(object sender, EventArgs e)
        {
            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { SeguridadBtnInsertar, TipoPermiso.Insertar },
                { SeguridadBtnQuitar, TipoPermiso.Eliminar }
            };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso)
                return;

            SeguridadMetCargarCombos();
            SeguridadMetListarAsigAppUsuario();
        }

        private void SeguridadMetCargarCombos()
        {
            try
            {
                SeguridadCboUsuario.DataSource = _AsigAppUsuario.SeguridadMetObtenerUsuarios();
                SeguridadCboUsuario.DisplayMember = "nombreUsuario";
                SeguridadCboUsuario.ValueMember = "idUsuario";

                SeguridadCboModulo.DataSource = _AsigAppUsuario.SeguridadMetObtenerModulos();
                SeguridadCboModulo.DisplayMember = "nombreModulo";
                SeguridadCboModulo.ValueMember = "idModulo";

                SeguridadCboAplicacion.DataSource = _AsigAppUsuario.SeguridadMetObtenerAplicaciones();
                SeguridadCboAplicacion.DisplayMember = "nombreAplicacion";
                SeguridadCboAplicacion.ValueMember = "idAplicacion";

                SeguridadCboUsuario.SelectedIndex = -1;
                SeguridadCboModulo.SelectedIndex = -1;
                SeguridadCboAplicacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadMetListarAsigAppUsuario()
        {
            try
            {
                var Lista = _AsigAppUsuario.SeguridadMetObtenerTodos();
                SeguridadMetCargarGrid(Lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadMetCargarGrid(IEnumerable<ClsModeloAsigAppUsuario> Lista)
        {
            SeguridadDgvAsignaciones.Rows.Clear();

            SeguridadDgvAsignaciones.Columns[0].HeaderCell.Style.BackColor = Color.Teal;
            SeguridadDgvAsignaciones.Columns[0].HeaderCell.Style.ForeColor = Color.White;

            DataTable Usuarios = SeguridadCboUsuario.DataSource as DataTable;
            DataTable Aplicaciones = SeguridadCboAplicacion.DataSource as DataTable;

            foreach (ClsModeloAsigAppUsuario Item in Lista)
            {
                string NombreUsuario = Item.IdUsuario.ToString();
                string NombreAplicacion = Item.IdAplicacion.ToString();

                if (Usuarios != null)
                {
                    DataRow[] FilaUsuario = Usuarios.Select("idUsuario = " + Item.IdUsuario);
                    if (FilaUsuario.Length > 0)
                        NombreUsuario = FilaUsuario[0]["nombreUsuario"].ToString();
                }

                if (Aplicaciones != null)
                {
                    DataRow[] FilaAplicacion = Aplicaciones.Select("idAplicacion = " + Item.IdAplicacion);
                    if (FilaAplicacion.Length > 0)
                        NombreAplicacion = FilaAplicacion[0]["nombreAplicacion"].ToString();
                }

                int Fila = SeguridadDgvAsignaciones.Rows.Add(
                    NombreUsuario,
                    NombreAplicacion,
                    "Sí"
                );

                SeguridadDgvAsignaciones.Rows[Fila].Tag = Item;
            }

            SeguridadMetActualizarContador();
        }

        private void BtnSeguridadInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadCboUsuario.SelectedIndex == -1 ||
                    SeguridadCboModulo.SelectedIndex == -1 ||
                    SeguridadCboAplicacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Usuario, Módulo y Aplicación");
                    return;
                }

                _AsigAppUsuario.IdUsuario = Convert.ToInt32(SeguridadCboUsuario.SelectedValue);
                _AsigAppUsuario.IdModulo = Convert.ToInt32(SeguridadCboModulo.SelectedValue);
                _AsigAppUsuario.IdAplicacion = Convert.ToInt32(SeguridadCboAplicacion.SelectedValue);

                _AsigAppUsuario.DerInsertarUsuarioModuloAplicacion = false;
                _AsigAppUsuario.DerEditarUsuarioModuloAplicacion = false;
                _AsigAppUsuario.DerEliminarUsuarioModuloAplicacion = false;
                _AsigAppUsuario.DerImprimirUsuarioModuloAplicacion = false;

                _AsigAppUsuario.Estado = EstadoEntidad.Added;

                bool Valido = new ClsValidacionDatos(_AsigAppUsuario).SeguridadMetValidar();

                if (Valido)
                {
                    string Resultado = _AsigAppUsuario.SeguridadMetGrabarCambios();
                    MessageBox.Show(Resultado);
                    SeguridadMetListarAsigAppUsuario();
                    SeguridadMetReinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadDgvAsignaciones.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila");
                    return;
                }

                ClsModeloAsigAppUsuario Asignacion =
                    SeguridadDgvAsignaciones.CurrentRow.Tag as ClsModeloAsigAppUsuario;

                if (Asignacion == null)
                    return;

                _AsigAppUsuario.IdUsuario = Asignacion.IdUsuario;
                _AsigAppUsuario.IdModulo = Asignacion.IdModulo;
                _AsigAppUsuario.IdAplicacion = Asignacion.IdAplicacion;
                _AsigAppUsuario.Estado = EstadoEntidad.Deleted;

                string Resultado = _AsigAppUsuario.SeguridadMetGrabarCambios();
                MessageBox.Show(Resultado);
                SeguridadMetListarAsigAppUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnSeguridadBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeguridadCboUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Usuario para buscar");
                    return;
                }

                int IdUsuario = Convert.ToInt32(SeguridadCboUsuario.SelectedValue);
                var Resultado = _AsigAppUsuario.SeguridadMetBuscarPorUsuario(IdUsuario);
                SeguridadMetCargarGrid(Resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            SeguridadMetReinicio();
            SeguridadMetListarAsigAppUsuario();
        }

        private void BtnSeguridadSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "AsigAplUsarios_Seguridad.html");
        }

        private void SeguridadBtnInicio_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAsignaciones.Rows.Count > 0)
            {
                SeguridadDgvAsignaciones.CurrentCell = SeguridadDgvAsignaciones.Rows[0].Cells[0];
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAsignaciones.CurrentRow != null && SeguridadDgvAsignaciones.CurrentRow.Index > 0)
            {
                int indice = SeguridadDgvAsignaciones.CurrentRow.Index - 1;
                SeguridadDgvAsignaciones.CurrentCell = SeguridadDgvAsignaciones.Rows[indice].Cells[0];
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAsignaciones.CurrentRow != null &&
                SeguridadDgvAsignaciones.CurrentRow.Index < SeguridadDgvAsignaciones.Rows.Count - 1)
            {
                int indice = SeguridadDgvAsignaciones.CurrentRow.Index + 1;
                SeguridadDgvAsignaciones.CurrentCell = SeguridadDgvAsignaciones.Rows[indice].Cells[0];
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadBtnFin_Click(object sender, EventArgs e)
        {
            if (SeguridadDgvAsignaciones.Rows.Count > 0)
            {
                int ultima = SeguridadDgvAsignaciones.Rows.Count - 1;
                SeguridadDgvAsignaciones.CurrentCell = SeguridadDgvAsignaciones.Rows[ultima].Cells[0];
                SeguridadMetActualizarContador();
            }
        }

        private void SeguridadMetActualizarContador()
        {
            int total = SeguridadDgvAsignaciones.Rows.Count;
            if (total == 0)
            {
                SeguridadLblContador.Text = "Mostrando 0 de 0 registros";
                return;
            }
            int actual = SeguridadDgvAsignaciones.CurrentRow != null
                ? SeguridadDgvAsignaciones.CurrentRow.Index + 1
                : 1;
            SeguridadLblContador.Text = $"Mostrando {actual} de {total} registros";
        }

        private void SeguridadMetReinicio()
        {
            SeguridadCboUsuario.SelectedIndex = -1;
            SeguridadCboModulo.SelectedIndex = -1;
            SeguridadCboAplicacion.SelectedIndex = -1;
        }


        private void SeguridadBtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteAsignacionAplicacionUsuario reporte = new FrmReporteAsignacionAplicacionUsuario();
            reporte.Show();
        }
    }
}