namespace CapaVista_Consultas.UserControls
{
    partial class UcTablaCompleja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTablaCompleja));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTlpComplejas = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTlpPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasFlpPaginas = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnSiguiente = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasBtnAnterior = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasCboTablas = new CapaVista_Consultas.Components.ClsListaDesplegableConsultas();
            this.ConsultasLblTabla = new CapaVista_Consultas.Components.ClsEtiquetaConsultas();
            this.ConsultasDgvComplejas = new CapaVista_Consultas.Components.ClsTablaDatosConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasTlpComplejas.SuspendLayout();
            this.ConsultasTlpPaginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvComplejas)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.ColumnCount = 1;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTlpComplejas, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasDgvComplejas, 0, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(720, 448);
            this.ConsultasTlpPrincipal.TabIndex = 0;
            // 
            // ConsultasTlpComplejas
            // 
            this.ConsultasTlpComplejas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpComplejas.ColumnCount = 4;
            this.ConsultasTlpComplejas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpComplejas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.ConsultasTlpComplejas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpComplejas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpComplejas.Controls.Add(this.ConsultasTlpPaginacion, 0, 0);
            this.ConsultasTlpComplejas.Controls.Add(this.ConsultasCboTablas, 2, 1);
            this.ConsultasTlpComplejas.Controls.Add(this.ConsultasLblTabla, 1, 1);
            this.ConsultasTlpComplejas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpComplejas.Location = new System.Drawing.Point(3, 287);
            this.ConsultasTlpComplejas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpComplejas.Name = "ConsultasTlpComplejas";
            this.ConsultasTlpComplejas.RowCount = 2;
            this.ConsultasTlpComplejas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ConsultasTlpComplejas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ConsultasTlpComplejas.Size = new System.Drawing.Size(714, 157);
            this.ConsultasTlpComplejas.TabIndex = 2;
            // 
            // ConsultasTlpPaginacion
            // 
            this.ConsultasTlpPaginacion.ColumnCount = 3;
            this.ConsultasTlpComplejas.SetColumnSpan(this.ConsultasTlpPaginacion, 4);
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasFlpPaginas, 1, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnSiguiente, 2, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnAnterior, 0, 0);
            this.ConsultasTlpPaginacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPaginacion.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPaginacion.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPaginacion.Name = "ConsultasTlpPaginacion";
            this.ConsultasTlpPaginacion.RowCount = 1;
            this.ConsultasTlpPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPaginacion.Size = new System.Drawing.Size(714, 82);
            this.ConsultasTlpPaginacion.TabIndex = 2;
            // 
            // ConsultasFlpPaginas
            // 
            this.ConsultasFlpPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpPaginas.Location = new System.Drawing.Point(80, 0);
            this.ConsultasFlpPaginas.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasFlpPaginas.Name = "ConsultasFlpPaginas";
            this.ConsultasFlpPaginas.Size = new System.Drawing.Size(554, 82);
            this.ConsultasFlpPaginas.TabIndex = 2;
            // 
            // ConsultasBtnSiguiente
            // 
            this.ConsultasBtnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnSiguiente.BackgroundImage")));
            this.ConsultasBtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnSiguiente.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnSiguiente.Location = new System.Drawing.Point(634, 1);
            this.ConsultasBtnSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnSiguiente.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSiguiente.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSiguiente.Name = "ConsultasBtnSiguiente";
            this.ConsultasBtnSiguiente.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSiguiente.TabIndex = 3;
            this.ConsultasBtnSiguiente.UseVisualStyleBackColor = false;
            this.ConsultasBtnSiguiente.Click += new System.EventHandler(this.ConsultasMetBtnSiguienteClick);
            // 
            // ConsultasBtnAnterior
            // 
            this.ConsultasBtnAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnAnterior.BackgroundImage")));
            this.ConsultasBtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnAnterior.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnAnterior.Location = new System.Drawing.Point(0, 1);
            this.ConsultasBtnAnterior.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnAnterior.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAnterior.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAnterior.Name = "ConsultasBtnAnterior";
            this.ConsultasBtnAnterior.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAnterior.TabIndex = 4;
            this.ConsultasBtnAnterior.UseVisualStyleBackColor = false;
            this.ConsultasBtnAnterior.Click += new System.EventHandler(this.ConsultasMetBtnAnteriorClick);
            // 
            // ConsultasCboTablas
            // 
            this.ConsultasCboTablas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboTablas.BackColor = System.Drawing.Color.White;
            this.ConsultasCboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboTablas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboTablas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboTablas.FormattingEnabled = true;
            this.ConsultasCboTablas.Location = new System.Drawing.Point(254, 107);
            this.ConsultasCboTablas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboTablas.Name = "ConsultasCboTablas";
            this.ConsultasCboTablas.Size = new System.Drawing.Size(377, 31);
            this.ConsultasCboTablas.TabIndex = 3;
            // 
            // ConsultasLblTabla
            // 
            this.ConsultasLblTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasLblTabla.AutoSize = true;
            this.ConsultasLblTabla.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblTabla.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblTabla.Location = new System.Drawing.Point(83, 113);
            this.ConsultasLblTabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblTabla.Name = "ConsultasLblTabla";
            this.ConsultasLblTabla.Size = new System.Drawing.Size(165, 19);
            this.ConsultasLblTabla.TabIndex = 4;
            this.ConsultasLblTabla.Text = "Tabla Seleccionada";
            this.ConsultasLblTabla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConsultasDgvComplejas
            // 
            this.ConsultasDgvComplejas.AllowUserToAddRows = false;
            this.ConsultasDgvComplejas.AllowUserToDeleteRows = false;
            this.ConsultasDgvComplejas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvComplejas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvComplejas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvComplejas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvComplejas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultasDgvComplejas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ConsultasDgvComplejas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvComplejas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ConsultasDgvComplejas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultasDgvComplejas.DefaultCellStyle = dataGridViewCellStyle3;
            this.ConsultasDgvComplejas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvComplejas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsultasDgvComplejas.EnableHeadersVisualStyles = false;
            this.ConsultasDgvComplejas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasDgvComplejas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvComplejas.Location = new System.Drawing.Point(3, 4);
            this.ConsultasDgvComplejas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasDgvComplejas.MultiSelect = false;
            this.ConsultasDgvComplejas.Name = "ConsultasDgvComplejas";
            this.ConsultasDgvComplejas.ReadOnly = true;
            this.ConsultasDgvComplejas.RowHeadersVisible = false;
            this.ConsultasDgvComplejas.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvComplejas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ConsultasDgvComplejas.RowTemplate.Height = 28;
            this.ConsultasDgvComplejas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultasDgvComplejas.Size = new System.Drawing.Size(714, 275);
            this.ConsultasDgvComplejas.TabIndex = 3;
            // 
            // UcTablaCompleja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcTablaCompleja";
            this.Size = new System.Drawing.Size(720, 448);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpComplejas.ResumeLayout(false);
            this.ConsultasTlpComplejas.PerformLayout();
            this.ConsultasTlpPaginacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvComplejas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpComplejas;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPaginacion;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpPaginas;
        private Components.ClsListaDesplegableConsultas ConsultasCboTablas;
        private Components.ClsBotonConsultas ConsultasBtnSiguiente;
        private Components.ClsBotonConsultas ConsultasBtnAnterior;
        private Components.ClsEtiquetaConsultas ConsultasLblTabla;
        private Components.ClsTablaDatosConsultas ConsultasDgvComplejas;
    }
}
