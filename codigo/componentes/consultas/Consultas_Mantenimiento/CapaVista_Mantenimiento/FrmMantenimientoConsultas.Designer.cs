namespace CapaVista_Consultas
{
    partial class FrmMantenimientoConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnEliminar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnRefrescar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnAyuda = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasDgvConsultasFiltros = new CapaVista_Componentes.ClsTablaDatosConsultas();
            this.ConsultasColCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColOrdenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColConector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasGbxCondicionesLogicas = new CapaVista_Componentes.ClsGrupoConsultas();
            this.ConsultasTlpCondicionesLogicas = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnIngresar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasLblOrdenamiento = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasTlpOrdenamiento = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasRdoDescendente = new CapaVista_Componentes.ClsBotonRadioConsultas();
            this.ConsultasRdoAscendente = new CapaVista_Componentes.ClsBotonRadioConsultas();
            this.ConsultasLblCampo = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboOperadorCampo = new CapaVista_Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblOperador = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboOperador = new CapaVista_Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblValor = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasLblConector = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboConector = new CapaVista_Componentes.ClsListaComboBoxConsultas();
            this.ConsultasUsrValor = new CapaVista_Componentes.UsrTextbox();
            this.ConsultasGbxGuardarConsultas = new CapaVista_Componentes.ClsGrupoConsultas();
            this.ConsultasTlpGuardarConsulta = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasLblNombre = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasBtnGuardar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasTxtNombre = new CapaVista_Componentes.ClsCajaTextoConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasTlpFiltros.SuspendLayout();
            this.ConsultasFlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).BeginInit();
            this.ConsultasGbxCondicionesLogicas.SuspendLayout();
            this.ConsultasTlpCondicionesLogicas.SuspendLayout();
            this.ConsultasTlpOrdenamiento.SuspendLayout();
            this.ConsultasGbxGuardarConsultas.SuspendLayout();
            this.ConsultasTlpGuardarConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTlpFiltros, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxCondicionesLogicas, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxGuardarConsultas, 0, 1);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 3;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(1144, 522);
            this.ConsultasTlpPrincipal.TabIndex = 16;
            // 
            // ConsultasTlpFiltros
            // 
            this.ConsultasTlpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpFiltros.ColumnCount = 2;
            this.ConsultasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpFiltros.Controls.Add(this.ConsultasFlpBotones, 1, 0);
            this.ConsultasTlpFiltros.Controls.Add(this.ConsultasDgvConsultasFiltros, 0, 0);
            this.ConsultasTlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpFiltros.Location = new System.Drawing.Point(483, 4);
            this.ConsultasTlpFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpFiltros.Name = "ConsultasTlpFiltros";
            this.ConsultasTlpFiltros.RowCount = 1;
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasTlpFiltros, 2);
            this.ConsultasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpFiltros.Size = new System.Drawing.Size(658, 492);
            this.ConsultasTlpFiltros.TabIndex = 19;
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnEliminar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnRefrescar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnAyuda);
            this.ConsultasFlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultasFlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsultasFlpBotones.Location = new System.Drawing.Point(578, 0);
            this.ConsultasFlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasFlpBotones.Name = "ConsultasFlpBotones";
            this.ConsultasFlpBotones.Size = new System.Drawing.Size(80, 362);
            this.ConsultasFlpBotones.TabIndex = 2;
            // 
            // ConsultasBtnEliminar
            // 
            this.ConsultasBtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnEliminar.BackgroundImage")));
            this.ConsultasBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnEliminar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnEliminar.Location = new System.Drawing.Point(0, 0);
            this.ConsultasBtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnEliminar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.Name = "ConsultasBtnEliminar";
            this.ConsultasBtnEliminar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.TabIndex = 2;
            this.ConsultasBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // ConsultasBtnRefrescar
            // 
            this.ConsultasBtnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnRefrescar.BackgroundImage")));
            this.ConsultasBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(0, 80);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.TabIndex = 4;
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = false;
            this.ConsultasBtnRefrescar.Click += new System.EventHandler(this.ConsultasMetBtnRefrescarClick);
            // 
            // ConsultasBtnAyuda
            // 
            this.ConsultasBtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnAyuda.BackgroundImage")));
            this.ConsultasBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnAyuda.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnAyuda.Location = new System.Drawing.Point(0, 160);
            this.ConsultasBtnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnAyuda.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.Name = "ConsultasBtnAyuda";
            this.ConsultasBtnAyuda.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.TabIndex = 3;
            this.ConsultasBtnAyuda.UseVisualStyleBackColor = false;
            this.ConsultasBtnAyuda.Click += new System.EventHandler(this.ConsultasMetBtnAyudaClick);
            // 
            // ConsultasDgvConsultasFiltros
            // 
            this.ConsultasDgvConsultasFiltros.AllowUserToAddRows = false;
            this.ConsultasDgvConsultasFiltros.AllowUserToDeleteRows = false;
            this.ConsultasDgvConsultasFiltros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasFiltros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvConsultasFiltros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvConsultasFiltros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvConsultasFiltros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultasDgvConsultasFiltros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ConsultasDgvConsultasFiltros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasFiltros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ConsultasDgvConsultasFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvConsultasFiltros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultasColCampo,
            this.ConsultasColOperador,
            this.ConsultasColValor,
            this.ConsultasColOrdenamiento,
            this.ConsultasColConector});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultasDgvConsultasFiltros.DefaultCellStyle = dataGridViewCellStyle3;
            this.ConsultasDgvConsultasFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvConsultasFiltros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsultasDgvConsultasFiltros.EnableHeadersVisualStyles = false;
            this.ConsultasDgvConsultasFiltros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasDgvConsultasFiltros.GridColor = System.Drawing.Color.LightGray;
            this.ConsultasDgvConsultasFiltros.Location = new System.Drawing.Point(3, 4);
            this.ConsultasDgvConsultasFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasDgvConsultasFiltros.MultiSelect = false;
            this.ConsultasDgvConsultasFiltros.Name = "ConsultasDgvConsultasFiltros";
            this.ConsultasDgvConsultasFiltros.ReadOnly = true;
            this.ConsultasDgvConsultasFiltros.RowHeadersVisible = false;
            this.ConsultasDgvConsultasFiltros.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasFiltros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ConsultasDgvConsultasFiltros.RowTemplate.Height = 28;
            this.ConsultasDgvConsultasFiltros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultasDgvConsultasFiltros.Size = new System.Drawing.Size(572, 484);
            this.ConsultasDgvConsultasFiltros.TabIndex = 3;
            // 
            // ConsultasColCampo
            // 
            this.ConsultasColCampo.HeaderText = "Campo";
            this.ConsultasColCampo.MinimumWidth = 6;
            this.ConsultasColCampo.Name = "ConsultasColCampo";
            this.ConsultasColCampo.ReadOnly = true;
            // 
            // ConsultasColOperador
            // 
            this.ConsultasColOperador.HeaderText = "Operador";
            this.ConsultasColOperador.MinimumWidth = 6;
            this.ConsultasColOperador.Name = "ConsultasColOperador";
            this.ConsultasColOperador.ReadOnly = true;
            // 
            // ConsultasColValor
            // 
            this.ConsultasColValor.HeaderText = "Valor";
            this.ConsultasColValor.MinimumWidth = 6;
            this.ConsultasColValor.Name = "ConsultasColValor";
            this.ConsultasColValor.ReadOnly = true;
            // 
            // ConsultasColOrdenamiento
            // 
            this.ConsultasColOrdenamiento.HeaderText = "Ordenamiento";
            this.ConsultasColOrdenamiento.MinimumWidth = 6;
            this.ConsultasColOrdenamiento.Name = "ConsultasColOrdenamiento";
            this.ConsultasColOrdenamiento.ReadOnly = true;
            // 
            // ConsultasColConector
            // 
            this.ConsultasColConector.HeaderText = "Conector";
            this.ConsultasColConector.MinimumWidth = 6;
            this.ConsultasColConector.Name = "ConsultasColConector";
            this.ConsultasColConector.ReadOnly = true;
            // 
            // ConsultasGbxCondicionesLogicas
            // 
            this.ConsultasGbxCondicionesLogicas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxCondicionesLogicas.Controls.Add(this.ConsultasTlpCondicionesLogicas);
            this.ConsultasGbxCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxCondicionesLogicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxCondicionesLogicas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxCondicionesLogicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxCondicionesLogicas.Location = new System.Drawing.Point(3, 3);
            this.ConsultasGbxCondicionesLogicas.Name = "ConsultasGbxCondicionesLogicas";
            this.ConsultasGbxCondicionesLogicas.Size = new System.Drawing.Size(474, 314);
            this.ConsultasGbxCondicionesLogicas.TabIndex = 16;
            this.ConsultasGbxCondicionesLogicas.TabStop = false;
            this.ConsultasGbxCondicionesLogicas.Text = "Agregar Condición";
            // 
            // ConsultasTlpCondicionesLogicas
            // 
            this.ConsultasTlpCondicionesLogicas.ColumnCount = 2;
            this.ConsultasTlpCondicionesLogicas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.ConsultasTlpCondicionesLogicas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasBtnIngresar, 1, 5);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblOrdenamiento, 0, 3);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasTlpOrdenamiento, 1, 3);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblCampo, 0, 0);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasCboOperadorCampo, 1, 0);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblOperador, 0, 1);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasCboOperador, 1, 1);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblValor, 0, 2);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblConector, 0, 4);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasCboConector, 1, 4);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasUsrValor, 1, 2);
            this.ConsultasTlpCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpCondicionesLogicas.Location = new System.Drawing.Point(3, 24);
            this.ConsultasTlpCondicionesLogicas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpCondicionesLogicas.Name = "ConsultasTlpCondicionesLogicas";
            this.ConsultasTlpCondicionesLogicas.RowCount = 6;
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.ConsultasTlpCondicionesLogicas.Size = new System.Drawing.Size(468, 287);
            this.ConsultasTlpCondicionesLogicas.TabIndex = 2;
            // 
            // ConsultasBtnIngresar
            // 
            this.ConsultasBtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnIngresar.BackgroundImage")));
            this.ConsultasBtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnIngresar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnIngresar.Location = new System.Drawing.Point(262, 199);
            this.ConsultasBtnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnIngresar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.Name = "ConsultasBtnIngresar";
            this.ConsultasBtnIngresar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.TabIndex = 9;
            this.ConsultasBtnIngresar.UseVisualStyleBackColor = false;
            // 
            // ConsultasLblOrdenamiento
            // 
            this.ConsultasLblOrdenamiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblOrdenamiento.AutoSize = true;
            this.ConsultasLblOrdenamiento.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOrdenamiento.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOrdenamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOrdenamiento.Location = new System.Drawing.Point(24, 133);
            this.ConsultasLblOrdenamiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOrdenamiento.Name = "ConsultasLblOrdenamiento";
            this.ConsultasLblOrdenamiento.Size = new System.Drawing.Size(110, 19);
            this.ConsultasLblOrdenamiento.TabIndex = 10;
            this.ConsultasLblOrdenamiento.Text = "Ordenamiento";
            this.ConsultasLblOrdenamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasTlpOrdenamiento
            // 
            this.ConsultasTlpOrdenamiento.ColumnCount = 2;
            this.ConsultasTlpOrdenamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.ConsultasTlpOrdenamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.ConsultasTlpOrdenamiento.Controls.Add(this.ConsultasRdoDescendente, 1, 0);
            this.ConsultasTlpOrdenamiento.Controls.Add(this.ConsultasRdoAscendente, 0, 0);
            this.ConsultasTlpOrdenamiento.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConsultasTlpOrdenamiento.Location = new System.Drawing.Point(137, 126);
            this.ConsultasTlpOrdenamiento.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpOrdenamiento.Name = "ConsultasTlpOrdenamiento";
            this.ConsultasTlpOrdenamiento.RowCount = 1;
            this.ConsultasTlpOrdenamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpOrdenamiento.Size = new System.Drawing.Size(169, 33);
            this.ConsultasTlpOrdenamiento.TabIndex = 8;
            // 
            // ConsultasRdoDescendente
            // 
            this.ConsultasRdoDescendente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultasRdoDescendente.AutoSize = true;
            this.ConsultasRdoDescendente.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasRdoDescendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasRdoDescendente.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasRdoDescendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasRdoDescendente.Location = new System.Drawing.Point(79, 7);
            this.ConsultasRdoDescendente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 4);
            this.ConsultasRdoDescendente.Name = "ConsultasRdoDescendente";
            this.ConsultasRdoDescendente.Size = new System.Drawing.Size(69, 22);
            this.ConsultasRdoDescendente.TabIndex = 2;
            this.ConsultasRdoDescendente.TabStop = true;
            this.ConsultasRdoDescendente.Text = "DESC";
            this.ConsultasRdoDescendente.UseVisualStyleBackColor = true;
            // 
            // ConsultasRdoAscendente
            // 
            this.ConsultasRdoAscendente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasRdoAscendente.AutoSize = true;
            this.ConsultasRdoAscendente.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasRdoAscendente.Checked = true;
            this.ConsultasRdoAscendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasRdoAscendente.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasRdoAscendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasRdoAscendente.Location = new System.Drawing.Point(13, 7);
            this.ConsultasRdoAscendente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 4);
            this.ConsultasRdoAscendente.Name = "ConsultasRdoAscendente";
            this.ConsultasRdoAscendente.Size = new System.Drawing.Size(60, 22);
            this.ConsultasRdoAscendente.TabIndex = 1;
            this.ConsultasRdoAscendente.TabStop = true;
            this.ConsultasRdoAscendente.Text = "ASC";
            this.ConsultasRdoAscendente.UseVisualStyleBackColor = true;
            // 
            // ConsultasLblCampo
            // 
            this.ConsultasLblCampo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblCampo.AutoSize = true;
            this.ConsultasLblCampo.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblCampo.CampoObligatorio = true;
            this.ConsultasLblCampo.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblCampo.Location = new System.Drawing.Point(57, 7);
            this.ConsultasLblCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblCampo.Name = "ConsultasLblCampo";
            this.ConsultasLblCampo.Size = new System.Drawing.Size(77, 19);
            this.ConsultasLblCampo.TabIndex = 11;
            this.ConsultasLblCampo.Text = "Campo";
            this.ConsultasLblCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasCboOperadorCampo
            // 
            this.ConsultasCboOperadorCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboOperadorCampo.BackColor = System.Drawing.Color.White;
            this.ConsultasCboOperadorCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboOperadorCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboOperadorCampo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboOperadorCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboOperadorCampo.FormattingEnabled = true;
            this.ConsultasCboOperadorCampo.Location = new System.Drawing.Point(140, 4);
            this.ConsultasCboOperadorCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperadorCampo.Name = "ConsultasCboOperadorCampo";
            this.ConsultasCboOperadorCampo.Size = new System.Drawing.Size(325, 31);
            this.ConsultasCboOperadorCampo.TabIndex = 17;
            // 
            // ConsultasLblOperador
            // 
            this.ConsultasLblOperador.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblOperador.AutoSize = true;
            this.ConsultasLblOperador.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOperador.CampoObligatorio = true;
            this.ConsultasLblOperador.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOperador.Location = new System.Drawing.Point(40, 40);
            this.ConsultasLblOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOperador.Name = "ConsultasLblOperador";
            this.ConsultasLblOperador.Size = new System.Drawing.Size(94, 19);
            this.ConsultasLblOperador.TabIndex = 12;
            this.ConsultasLblOperador.Text = "Operador";
            this.ConsultasLblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasCboOperador
            // 
            this.ConsultasCboOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboOperador.BackColor = System.Drawing.Color.White;
            this.ConsultasCboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboOperador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboOperador.FormattingEnabled = true;
            this.ConsultasCboOperador.Location = new System.Drawing.Point(140, 37);
            this.ConsultasCboOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(325, 31);
            this.ConsultasCboOperador.TabIndex = 18;
            // 
            // ConsultasLblValor
            // 
            this.ConsultasLblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasLblValor.AutoSize = true;
            this.ConsultasLblValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblValor.CampoObligatorio = true;
            this.ConsultasLblValor.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblValor.Location = new System.Drawing.Point(70, 70);
            this.ConsultasLblValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblValor.Name = "ConsultasLblValor";
            this.ConsultasLblValor.Size = new System.Drawing.Size(64, 19);
            this.ConsultasLblValor.TabIndex = 13;
            this.ConsultasLblValor.Text = "Valor";
            this.ConsultasLblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasLblConector
            // 
            this.ConsultasLblConector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblConector.AutoSize = true;
            this.ConsultasLblConector.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblConector.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblConector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblConector.Location = new System.Drawing.Point(62, 166);
            this.ConsultasLblConector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblConector.Name = "ConsultasLblConector";
            this.ConsultasLblConector.Size = new System.Drawing.Size(72, 19);
            this.ConsultasLblConector.TabIndex = 19;
            this.ConsultasLblConector.Text = "Conector";
            this.ConsultasLblConector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasCboConector
            // 
            this.ConsultasCboConector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboConector.BackColor = System.Drawing.Color.White;
            this.ConsultasCboConector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboConector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboConector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboConector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboConector.FormattingEnabled = true;
            this.ConsultasCboConector.Location = new System.Drawing.Point(140, 163);
            this.ConsultasCboConector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboConector.Name = "ConsultasCboConector";
            this.ConsultasCboConector.Size = new System.Drawing.Size(325, 31);
            this.ConsultasCboConector.TabIndex = 20;
            // 
            // ConsultasUsrValor
            // 
            this.ConsultasUsrValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasUsrValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUsrValor.Location = new System.Drawing.Point(137, 66);
            this.ConsultasUsrValor.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUsrValor.Name = "ConsultasUsrValor";
            this.ConsultasUsrValor.Size = new System.Drawing.Size(331, 35);
            this.ConsultasUsrValor.TabIndex = 21;
            // 
            // ConsultasGbxGuardarConsultas
            // 
            this.ConsultasGbxGuardarConsultas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxGuardarConsultas.Controls.Add(this.ConsultasTlpGuardarConsulta);
            this.ConsultasGbxGuardarConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxGuardarConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxGuardarConsultas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxGuardarConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxGuardarConsultas.Location = new System.Drawing.Point(3, 323);
            this.ConsultasGbxGuardarConsultas.Name = "ConsultasGbxGuardarConsultas";
            this.ConsultasGbxGuardarConsultas.Size = new System.Drawing.Size(474, 174);
            this.ConsultasGbxGuardarConsultas.TabIndex = 18;
            this.ConsultasGbxGuardarConsultas.TabStop = false;
            this.ConsultasGbxGuardarConsultas.Text = "Guardar Consulta";
            // 
            // ConsultasTlpGuardarConsulta
            // 
            this.ConsultasTlpGuardarConsulta.ColumnCount = 2;
            this.ConsultasTlpGuardarConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.ConsultasTlpGuardarConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpGuardarConsulta.Controls.Add(this.ConsultasLblNombre, 0, 0);
            this.ConsultasTlpGuardarConsulta.Controls.Add(this.ConsultasBtnGuardar, 1, 1);
            this.ConsultasTlpGuardarConsulta.Controls.Add(this.ConsultasTxtNombre, 1, 0);
            this.ConsultasTlpGuardarConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpGuardarConsulta.Location = new System.Drawing.Point(3, 24);
            this.ConsultasTlpGuardarConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpGuardarConsulta.Name = "ConsultasTlpGuardarConsulta";
            this.ConsultasTlpGuardarConsulta.RowCount = 2;
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpGuardarConsulta.Size = new System.Drawing.Size(468, 147);
            this.ConsultasTlpGuardarConsulta.TabIndex = 2;
            // 
            // ConsultasLblNombre
            // 
            this.ConsultasLblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblNombre.AutoSize = true;
            this.ConsultasLblNombre.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblNombre.CampoObligatorio = true;
            this.ConsultasLblNombre.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblNombre.Location = new System.Drawing.Point(50, 17);
            this.ConsultasLblNombre.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLblNombre.Name = "ConsultasLblNombre";
            this.ConsultasLblNombre.Size = new System.Drawing.Size(84, 19);
            this.ConsultasLblNombre.TabIndex = 3;
            this.ConsultasLblNombre.Text = "Nombre";
            this.ConsultasLblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasBtnGuardar
            // 
            this.ConsultasBtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnGuardar.BackgroundImage")));
            this.ConsultasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnGuardar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnGuardar.Location = new System.Drawing.Point(262, 60);
            this.ConsultasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.Name = "ConsultasBtnGuardar";
            this.ConsultasBtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.TabIndex = 2;
            this.ConsultasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // ConsultasTxtNombre
            // 
            this.ConsultasTxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTxtNombre.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtNombre.Location = new System.Drawing.Point(140, 11);
            this.ConsultasTxtNombre.MaxLength = 50;
            this.ConsultasTxtNombre.Name = "ConsultasTxtNombre";
            this.ConsultasTxtNombre.Size = new System.Drawing.Size(325, 30);
            this.ConsultasTxtNombre.TabIndex = 0;
            // 
            // FrmMantenimientoConsultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1144, 522);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientoConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4003 – MantenimientoConsultas";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpFiltros.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).EndInit();
            this.ConsultasGbxCondicionesLogicas.ResumeLayout(false);
            this.ConsultasTlpCondicionesLogicas.ResumeLayout(false);
            this.ConsultasTlpCondicionesLogicas.PerformLayout();
            this.ConsultasTlpOrdenamiento.ResumeLayout(false);
            this.ConsultasTlpOrdenamiento.PerformLayout();
            this.ConsultasGbxGuardarConsultas.ResumeLayout(false);
            this.ConsultasTlpGuardarConsulta.ResumeLayout(false);
            this.ConsultasTlpGuardarConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private CapaVista_Componentes.ClsGrupoConsultas ConsultasGbxCondicionesLogicas;
        private CapaVista_Componentes.ClsGrupoConsultas ConsultasGbxGuardarConsultas;
        private CapaVista_Componentes.ClsCajaTextoConsultas ConsultasTxtNombre;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnGuardar;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblNombre;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpGuardarConsulta;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpCondicionesLogicas;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnIngresar;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblOrdenamiento;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpOrdenamiento;
        private CapaVista_Componentes.ClsBotonRadioConsultas ConsultasRdoDescendente;
        private CapaVista_Componentes.ClsBotonRadioConsultas ConsultasRdoAscendente;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblCampo;
        private CapaVista_Componentes.ClsListaComboBoxConsultas ConsultasCboOperadorCampo;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblOperador;
        private CapaVista_Componentes.ClsListaComboBoxConsultas ConsultasCboOperador;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblValor;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblConector;
        private CapaVista_Componentes.ClsListaComboBoxConsultas ConsultasCboConector;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpFiltros;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnEliminar;
        private CapaVista_Componentes.ClsTablaDatosConsultas ConsultasDgvConsultasFiltros;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnAyuda;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColOrdenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColConector;
        private CapaVista_Componentes.UsrTextbox ConsultasUsrValor;
    }
}