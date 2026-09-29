namespace CapaVista_Consultas.Controles
{
    partial class ClsSeleccioneUnaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClsSeleccioneUnaConsulta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnConsultar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnNuevaConsulta = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnEliminar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasDgvConsultasReutilizables = new CapaVista_Consultas.Componentes.ClsTablaDatosConsultas();
            this.ConsultasColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasFlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasReutilizables)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasFlpBotones, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasDgvConsultasReutilizables, 0, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 1;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(641, 507);
            this.ConsultasTlpPrincipal.TabIndex = 0;
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnConsultar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnNuevaConsulta);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnEliminar);
            this.ConsultasFlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultasFlpBotones.Location = new System.Drawing.Point(551, 12);
            this.ConsultasFlpBotones.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.ConsultasFlpBotones.Name = "ConsultasFlpBotones";
            this.ConsultasFlpBotones.Size = new System.Drawing.Size(90, 240);
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
            this.ConsultasBtnConsultar.Click += new System.EventHandler(this.ConsultasMetBtnConsultarClick);
            // 
            // ConsultasBtnNuevaConsulta
            // 
            this.ConsultasBtnNuevaConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnNuevaConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnNuevaConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnNuevaConsulta.BackgroundImage")));
            this.ConsultasBtnNuevaConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnNuevaConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnNuevaConsulta.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnNuevaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnNuevaConsulta.Location = new System.Drawing.Point(0, 80);
            this.ConsultasBtnNuevaConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnNuevaConsulta.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnNuevaConsulta.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnNuevaConsulta.Name = "ConsultasBtnNuevaConsulta";
            this.ConsultasBtnNuevaConsulta.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnNuevaConsulta.TabIndex = 1;
            this.ConsultasBtnNuevaConsulta.UseVisualStyleBackColor = false;
            this.ConsultasBtnNuevaConsulta.Click += new System.EventHandler(this.ConsultasMetBtnIngresarClick);
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
            this.ConsultasBtnEliminar.Click += new System.EventHandler(this.ConsultasMetBtnEliminarClick);
            // 
            // ConsultasDgvConsultasReutilizables
            // 
            this.ConsultasDgvConsultasReutilizables.AllowUserToAddRows = false;
            this.ConsultasDgvConsultasReutilizables.AllowUserToDeleteRows = false;
            this.ConsultasDgvConsultasReutilizables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasReutilizables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvConsultasReutilizables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvConsultasReutilizables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvConsultasReutilizables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultasDgvConsultasReutilizables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ConsultasDgvConsultasReutilizables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasReutilizables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ConsultasDgvConsultasReutilizables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvConsultasReutilizables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultasColNombre});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultasDgvConsultasReutilizables.DefaultCellStyle = dataGridViewCellStyle3;
            this.ConsultasDgvConsultasReutilizables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvConsultasReutilizables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsultasDgvConsultasReutilizables.EnableHeadersVisualStyles = false;
            this.ConsultasDgvConsultasReutilizables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasDgvConsultasReutilizables.GridColor = System.Drawing.Color.LightGray;
            this.ConsultasDgvConsultasReutilizables.Location = new System.Drawing.Point(11, 12);
            this.ConsultasDgvConsultasReutilizables.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.ConsultasDgvConsultasReutilizables.MultiSelect = false;
            this.ConsultasDgvConsultasReutilizables.Name = "ConsultasDgvConsultasReutilizables";
            this.ConsultasDgvConsultasReutilizables.ReadOnly = true;
            this.ConsultasDgvConsultasReutilizables.RowHeadersVisible = false;
            this.ConsultasDgvConsultasReutilizables.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasReutilizables.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ConsultasDgvConsultasReutilizables.RowTemplate.Height = 28;
            this.ConsultasDgvConsultasReutilizables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultasDgvConsultasReutilizables.Size = new System.Drawing.Size(529, 483);
            this.ConsultasDgvConsultasReutilizables.TabIndex = 3;
            // 
            // ConsultasColNombre
            // 
            this.ConsultasColNombre.HeaderText = "Nombre";
            this.ConsultasColNombre.MinimumWidth = 6;
            this.ConsultasColNombre.Name = "ConsultasColNombre";
            this.ConsultasColNombre.ReadOnly = true;
            // 
            // UcSeleccioneUnaConsulta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcSeleccioneUnaConsulta";
            this.Size = new System.Drawing.Size(641, 507);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasReutilizables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
        private Componentes.ClsTablaDatosConsultas ConsultasDgvConsultasReutilizables;
        private Componentes.ClsBotonConsultas ConsultasBtnConsultar;
        private Componentes.ClsBotonConsultas ConsultasBtnNuevaConsulta;
        private Componentes.ClsBotonConsultas ConsultasBtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColNombre;
    }
}
