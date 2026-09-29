using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.Ayudas;
using CapaControlador_Seguridad;
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
    public partial class FrmBitacora : Form
    {
        ClsModeloBitacora controladorBitacora = new ClsModeloBitacora();

        private ClsPermisoAplicacion _MisPermisos;
        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 12;
        public FrmBitacora()
        {
            InitializeComponent();

            this.Load += FrmBitacora_Load;
            this.btnVerBitacora.Click += new System.EventHandler(this.btnVerBitacora_Click);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            var MapaBotones = new Dictionary<Control, TipoPermiso>
            {
                { btnVerBitacora, TipoPermiso.Imprimir }
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
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAccion_Click(object sender, EventArgs e)
        {
            FrmAsignacionPerfiles Formulario = new FrmAsignacionPerfiles();
            Formulario.Show();
        }

        private void btnVerBitacora_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}