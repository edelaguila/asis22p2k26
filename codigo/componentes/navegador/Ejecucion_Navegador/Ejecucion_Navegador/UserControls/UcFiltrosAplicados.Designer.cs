namespace CapaVista_Consultas.UserControls
{
    partial class UcFiltrosAplicados
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// ConsultasMetLimpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFiltrosAplicados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnConsultar = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasBtnGuardar = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasBtnEliminar = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasDgvConsultasFiltros = new CapaVista_Consultas.Components.ClsTablaDatosConsultas();
            this.ConsultasColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColOrdenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasFlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasFlpBotones, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasDgvConsultasFiltros, 0, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 1;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(682, 369);
            this.ConsultasTlpPrincipal.TabIndex = 1;
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnConsultar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnGuardar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnEliminar);
            this.ConsultasFlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultasFlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsultasFlpBotones.Location = new System.Drawing.Point(602, 0);
            this.ConsultasFlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasFlpBotones.Name = "ConsultasFlpBotones";
            this.ConsultasFlpBotones.Size = new System.Drawing.Size(80, 362);
            this.ConsultasFlpBotones.TabIndex = 2;
            // 
            // ConsultasBtnConsultar
            // 
            this.ConsultasBtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnConsultar.BackgroundImage")));
            this.ConsultasBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnConsultar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnConsultar.Location = new System.Drawing.Point(0, 0);
            this.ConsultasBtnConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnConsultar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.Name = "ConsultasBtnConsultar";
            this.ConsultasBtnConsultar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.TabIndex = 0;
            this.ConsultasBtnConsultar.UseVisualStyleBackColor = false;
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
            this.ConsultasBtnGuardar.Location = new System.Drawing.Point(0, 80);
            this.ConsultasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.Name = "ConsultasBtnGuardar";
            this.ConsultasBtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.TabIndex = 1;
            this.ConsultasBtnGuardar.UseVisualStyleBackColor = false;
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
            this.ConsultasBtnEliminar.Location = new System.Drawing.Point(0, 160);
            this.ConsultasBtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnEliminar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.Name = "ConsultasBtnEliminar";
            this.ConsultasBtnEliminar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.TabIndex = 2;
            this.ConsultasBtnEliminar.UseVisualStyleBackColor = false;
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
            this.ConsultasColTipo,
            this.ConsultasColCampo,
            this.ConsultasColOperador,
            this.ConsultasColValor,
            this.ConsultasColOrdenamiento});
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
            this.ConsultasDgvConsultasFiltros.Size = new System.Drawing.Size(596, 361);
            this.ConsultasDgvConsultasFiltros.TabIndex = 3;
            // 
            // ConsultasColTipo
            // 
            this.ConsultasColTipo.HeaderText = "Tipo";
            this.ConsultasColTipo.MinimumWidth = 6;
            this.ConsultasColTipo.Name = "ConsultasColTipo";
            this.ConsultasColTipo.ReadOnly = true;
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
            // UcFiltrosAplicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcFiltrosAplicados";
            this.Size = new System.Drawing.Size(682, 369);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
        private Components.ClsTablaDatosConsultas ConsultasDgvConsultasFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColOrdenamiento;
        private Components.ClsBotonConsultas ConsultasBtnConsultar;
        private Components.ClsBotonConsultas ConsultasBtnGuardar;
        private Components.ClsBotonConsultas ConsultasBtnEliminar;
    }
}
