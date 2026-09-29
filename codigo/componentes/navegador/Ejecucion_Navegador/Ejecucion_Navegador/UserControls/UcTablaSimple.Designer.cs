namespace CapaVista_Consultas.UserControls
{
    partial class UcTablaSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTablaSimple));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTlpPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasFlpPaginas = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnAnterior = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasBtnSiguiente = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasDgvSimples = new CapaVista_Consultas.Components.ClsTablaDatosConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasTlpPaginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvSimples)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 1;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTlpPaginacion, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasDgvSimples, 0, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(871, 480);
            this.ConsultasTlpPrincipal.TabIndex = 0;
            // 
            // ConsultasTlpPaginacion
            // 
            this.ConsultasTlpPaginacion.ColumnCount = 3;
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasFlpPaginas, 1, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnAnterior, 0, 0);
            this.ConsultasTlpPaginacion.Controls.Add(this.ConsultasBtnSiguiente, 2, 0);
            this.ConsultasTlpPaginacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPaginacion.Location = new System.Drawing.Point(0, 398);
            this.ConsultasTlpPaginacion.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPaginacion.Name = "ConsultasTlpPaginacion";
            this.ConsultasTlpPaginacion.RowCount = 1;
            this.ConsultasTlpPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPaginacion.Size = new System.Drawing.Size(871, 82);
            this.ConsultasTlpPaginacion.TabIndex = 3;
            // 
            // ConsultasFlpPaginas
            // 
            this.ConsultasFlpPaginas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpPaginas.Location = new System.Drawing.Point(83, 4);
            this.ConsultasFlpPaginas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasFlpPaginas.Name = "ConsultasFlpPaginas";
            this.ConsultasFlpPaginas.Size = new System.Drawing.Size(705, 74);
            this.ConsultasFlpPaginas.TabIndex = 2;
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
            this.ConsultasBtnAnterior.Name = "ConsultasBtnAnterior";
            this.ConsultasBtnAnterior.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAnterior.TabIndex = 3;
            this.ConsultasBtnAnterior.UseVisualStyleBackColor = false;
            this.ConsultasBtnAnterior.Click += new System.EventHandler(this.ConsultasMetBtnAnteriorClick);
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
            this.ConsultasBtnSiguiente.Location = new System.Drawing.Point(791, 1);
            this.ConsultasBtnSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnSiguiente.Name = "ConsultasBtnSiguiente";
            this.ConsultasBtnSiguiente.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSiguiente.TabIndex = 4;
            this.ConsultasBtnSiguiente.UseVisualStyleBackColor = false;
            this.ConsultasBtnSiguiente.Click += new System.EventHandler(this.ConsultasMetBtnSiguiente);
            // 
            // ConsultasDgvSimples
            // 
            this.ConsultasDgvSimples.AllowUserToAddRows = false;
            this.ConsultasDgvSimples.AllowUserToDeleteRows = false;
            this.ConsultasDgvSimples.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvSimples.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvSimples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvSimples.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvSimples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultasDgvSimples.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ConsultasDgvSimples.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvSimples.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ConsultasDgvSimples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultasDgvSimples.DefaultCellStyle = dataGridViewCellStyle3;
            this.ConsultasDgvSimples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvSimples.EnableHeadersVisualStyles = false;
            this.ConsultasDgvSimples.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasDgvSimples.GridColor = System.Drawing.Color.LightGray;
            this.ConsultasDgvSimples.Location = new System.Drawing.Point(3, 4);
            this.ConsultasDgvSimples.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasDgvSimples.MultiSelect = false;
            this.ConsultasDgvSimples.Name = "ConsultasDgvSimples";
            this.ConsultasDgvSimples.RowHeadersVisible = false;
            this.ConsultasDgvSimples.RowHeadersWidth = 51;
            this.ConsultasDgvSimples.RowTemplate.Height = 28;
            this.ConsultasDgvSimples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultasDgvSimples.Size = new System.Drawing.Size(865, 390);
            this.ConsultasDgvSimples.TabIndex = 4;
            // 
            // UcTablaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TablaSimple";
            this.Size = new System.Drawing.Size(871, 480);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpPaginacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvSimples)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPaginacion;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpPaginas;
        private Components.ClsBotonConsultas ConsultasBtnAnterior;
        private Components.ClsBotonConsultas ConsultasBtnSiguiente;
        private Components.ClsTablaDatosConsultas ConsultasDgvSimples;
    }
}
