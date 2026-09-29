/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Samayoa y Oscar Morales
 * Carné : 9959-23-3424 y 9959-23-3070
 * Fecha : 24/09/2026
 * ==================================================================
 * Propósito :
 *  El FrmBitacora es el formulario de consulta de la bitácora
 *  del sistema: carga el historial completo a través de
 *  ClsModeloBitacora, lo muestra en el grid con encabezados y
 *  formato propios, permite filtrar por texto y abrir el reporte
 *  correspondiente.
 * Reglas especificas:
 *  Es una pantalla de solo lectura (el grid no permite agregar,
 *  eliminar ni editar filas); la búsqueda filtra sobre todos los
 *  campos visibles a la vez (usuario, acción, tabla, detalles,
 *  IP y fecha en varios formatos) y no distingue mayúsculas de
 *  minúsculas; y el acceso a los botones se restringe según los
 *  permisos del usuario para el módulo y la aplicación.
 * ===================================================================
*/

using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmBitacora : Form
    {
        private ClsModeloBitacora controladorBitacora = new ClsModeloBitacora();
        private List<ClsModeloBitacora> _listaBitacoraCompleta = new List<ClsModeloBitacora>();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 12;

        public FrmBitacora()
        {
            InitializeComponent();

            this.Load += FrmBitacora_Load;
            this.SeguridadBtnSalir.Click += new System.EventHandler(this.SeguridadBtnSalir_Click);
            this.SeguridadBtnReporte.Click += new System.EventHandler(this.SeguridadBtnReporte_Click);
            this.SeguridadBtnBuscar.Click += new System.EventHandler(this.SeguridadBtnBuscar_Click);
            this.SeguridadTxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SeguridadTxtBuscar_KeyDown);
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { SeguridadBtnReporte, TipoPermiso.Imprimir }
            };

            _MisPermisos = ClsSeguridadFormHelper.SeguridadMetInicializarSeguridad(
                this, ID_MODULO, ID_APLICACION, MapaBotones);

            if (!_MisPermisos.TieneAcceso)
                return;

            CargarBitacora();
        }

        private void CargarBitacora()
        {
            try
            {
                var lista = controladorBitacora.SeguridadMetObtenerTodas();
                _listaBitacoraCompleta = lista ?? new List<ClsModeloBitacora>();
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltro()
        {
            if (_listaBitacoraCompleta == null)
                return;

            string criterio = SeguridadTxtBuscar != null ? SeguridadTxtBuscar.Text.Trim() : string.Empty;

            List<ClsModeloBitacora> listaFiltrada;
            if (string.IsNullOrEmpty(criterio))
            {
                listaFiltrada = _listaBitacoraCompleta;
            }
            else
            {
                string criterioMin = criterio.ToLower();
                listaFiltrada = _listaBitacoraCompleta.Where(b =>
                    b.IdBitacora.ToString().Contains(criterioMin) ||
                    (b.IdUsuario.HasValue && b.IdUsuario.Value.ToString().Contains(criterioMin)) ||
                    (!string.IsNullOrEmpty(b.NombreUsuario) && b.NombreUsuario.ToLower().Contains(criterioMin)) ||
                    (!string.IsNullOrEmpty(b.AccionBitacora) && b.AccionBitacora.ToLower().Contains(criterioMin)) ||
                    (!string.IsNullOrEmpty(b.TablaBitacora) && b.TablaBitacora.ToLower().Contains(criterioMin)) ||
                    b.IdRegistroBitacora.ToString().Contains(criterioMin) ||
                    (!string.IsNullOrEmpty(b.DetallesBitacora) && b.DetallesBitacora.ToLower().Contains(criterioMin)) ||
                    (!string.IsNullOrEmpty(b.IpBitacora) && b.IpBitacora.ToLower().Contains(criterioMin)) ||
                    b.FechaHoraBitacora.ToString("yyyy-MM-dd HH:mm:ss").ToLower().Contains(criterioMin) ||
                    b.FechaHoraBitacora.ToString("dd/MM/yyyy HH:mm:ss").ToLower().Contains(criterioMin) ||
                    b.FechaHoraBitacora.ToString("yyyy-MM-dd").ToLower().Contains(criterioMin) ||
                    b.FechaHoraBitacora.ToString("dd/MM/yyyy").ToLower().Contains(criterioMin)
                ).ToList();
            }

            SeguridadDgvBitacora.DataSource = null;
            SeguridadDgvBitacora.DataSource = listaFiltrada;
            SeguridadMetConfigurarEncabezadosGrid();
        }

        private void SeguridadMetConfigurarEncabezadosGrid()
        {
            if (SeguridadDgvBitacora.Columns.Count == 0)
                return;

            if (SeguridadDgvBitacora.Columns["IdBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["IdBitacora"].HeaderText = "ID";
                SeguridadDgvBitacora.Columns["IdBitacora"].Width = 50;
                SeguridadDgvBitacora.Columns["IdBitacora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (SeguridadDgvBitacora.Columns["IdUsuario"] != null)
            {
                SeguridadDgvBitacora.Columns["IdUsuario"].Visible = false;
            }
            if (SeguridadDgvBitacora.Columns["NombreUsuario"] != null)
            {
                SeguridadDgvBitacora.Columns["NombreUsuario"].HeaderText = "Usuario";
                SeguridadDgvBitacora.Columns["NombreUsuario"].Width = 110;
                SeguridadDgvBitacora.Columns["NombreUsuario"].DisplayIndex = 1;
            }
            if (SeguridadDgvBitacora.Columns["AccionBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["AccionBitacora"].HeaderText = "Acción";
                SeguridadDgvBitacora.Columns["AccionBitacora"].Width = 100;
            }
            if (SeguridadDgvBitacora.Columns["TablaBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["TablaBitacora"].HeaderText = "Tabla Afectada";
                SeguridadDgvBitacora.Columns["TablaBitacora"].Width = 130;
            }
            if (SeguridadDgvBitacora.Columns["IdRegistroBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["IdRegistroBitacora"].HeaderText = "ID Registro";
                SeguridadDgvBitacora.Columns["IdRegistroBitacora"].Width = 90;
                SeguridadDgvBitacora.Columns["IdRegistroBitacora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (SeguridadDgvBitacora.Columns["DetallesBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["DetallesBitacora"].HeaderText = "Detalles";
                SeguridadDgvBitacora.Columns["DetallesBitacora"].Width = 180;
                SeguridadDgvBitacora.Columns["DetallesBitacora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (SeguridadDgvBitacora.Columns["IpBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["IpBitacora"].HeaderText = "Dirección IP";
                SeguridadDgvBitacora.Columns["IpBitacora"].Width = 110;
                SeguridadDgvBitacora.Columns["IpBitacora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (SeguridadDgvBitacora.Columns["FechaHoraBitacora"] != null)
            {
                SeguridadDgvBitacora.Columns["FechaHoraBitacora"].HeaderText = "Fecha y Hora";
                SeguridadDgvBitacora.Columns["FechaHoraBitacora"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                SeguridadDgvBitacora.Columns["FechaHoraBitacora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                SeguridadDgvBitacora.Columns["FechaHoraBitacora"].Width = 145;
            }

            SeguridadDgvBitacora.ReadOnly = true;
            SeguridadDgvBitacora.AllowUserToAddRows = false;
            SeguridadDgvBitacora.AllowUserToDeleteRows = false;
            SeguridadDgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SeguridadDgvBitacora.MultiSelect = false;
            SeguridadDgvBitacora.EnableHeadersVisualStyles = false;
            SeguridadDgvBitacora.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 109, 119);
            SeguridadDgvBitacora.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SeguridadDgvBitacora.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.5F, FontStyle.Bold);
            SeguridadDgvBitacora.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SeguridadDgvBitacora.ColumnHeadersHeight = 32;
            SeguridadDgvBitacora.RowHeadersVisible = false;
            SeguridadDgvBitacora.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void SeguridadBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguridadBtnBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void SeguridadTxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AplicarFiltro();
            }
        }

        private void SeguridadBtnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteBitacora reporte = new FrmReporteBitacora();
                reporte.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte de bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeguridadBtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/SeguridadAyudas/SeguridadAyudas.chm", "Bitacora_Seguridad.html");
        }
    }
}