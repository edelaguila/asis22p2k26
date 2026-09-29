namespace CapaVista_Consultas.Controles
{
    partial class UsrAgregarFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrAgregarFiltro));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasLblCampo = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasLblOperador = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboCampo = new CapaVista_Componentes.ClsListaComboBoxConsultas();
            this.ConsultasCboOperador = new CapaVista_Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblValor = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasUsrValor = new CapaVista_Componentes.UsrTextbox();
            this.ConsultasBtnBuscar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnRefrescar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnAyuda = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.ConsultasTlpPrincipal.ColumnCount = 5;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblCampo, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblOperador, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasCboCampo, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasCboOperador, 1, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblValor, 0, 2);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUsrValor, 1, 2);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnBuscar, 2, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnRefrescar, 3, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnAyuda, 4, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 5;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(708, 142);
            this.ConsultasTlpPrincipal.TabIndex = 0;
            // 
            // ConsultasLblCampo
            // 
            this.ConsultasLblCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasLblCampo.AutoSize = true;
            this.ConsultasLblCampo.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblCampo.CampoObligatorio = true;
            this.ConsultasLblCampo.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblCampo.Location = new System.Drawing.Point(20, 4);
            this.ConsultasLblCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblCampo.Name = "ConsultasLblCampo";
            this.ConsultasLblCampo.Size = new System.Drawing.Size(92, 19);
            this.ConsultasLblCampo.TabIndex = 17;
            this.ConsultasLblCampo.Text = "Campo   ";
            this.ConsultasLblCampo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConsultasLblOperador
            // 
            this.ConsultasLblOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasLblOperador.AutoSize = true;
            this.ConsultasLblOperador.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOperador.CampoObligatorio = true;
            this.ConsultasLblOperador.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOperador.Location = new System.Drawing.Point(3, 44);
            this.ConsultasLblOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOperador.Name = "ConsultasLblOperador";
            this.ConsultasLblOperador.Size = new System.Drawing.Size(109, 19);
            this.ConsultasLblOperador.TabIndex = 16;
            this.ConsultasLblOperador.Text = "Operador   ";
            this.ConsultasLblOperador.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConsultasCboCampo
            // 
            this.ConsultasCboCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboCampo.BackColor = System.Drawing.Color.White;
            this.ConsultasCboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboCampo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboCampo.FormattingEnabled = true;
            this.ConsultasCboCampo.Location = new System.Drawing.Point(118, 4);
            this.ConsultasCboCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboCampo.Name = "ConsultasCboCampo";
            this.ConsultasCboCampo.Size = new System.Drawing.Size(317, 31);
            this.ConsultasCboCampo.TabIndex = 20;
            // 
            // ConsultasCboOperador
            // 
            this.ConsultasCboOperador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboOperador.BackColor = System.Drawing.Color.White;
            this.ConsultasCboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboOperador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboOperador.FormattingEnabled = true;
            this.ConsultasCboOperador.Location = new System.Drawing.Point(118, 44);
            this.ConsultasCboOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(317, 31);
            this.ConsultasCboOperador.TabIndex = 21;
            // 
            // ConsultasLblValor
            // 
            this.ConsultasLblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasLblValor.AutoSize = true;
            this.ConsultasLblValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblValor.CampoObligatorio = true;
            this.ConsultasLblValor.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblValor.Location = new System.Drawing.Point(33, 84);
            this.ConsultasLblValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblValor.Name = "ConsultasLblValor";
            this.ConsultasLblValor.Size = new System.Drawing.Size(79, 19);
            this.ConsultasLblValor.TabIndex = 15;
            this.ConsultasLblValor.Text = "Valor   ";
            this.ConsultasLblValor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConsultasUsrValor
            // 
            this.ConsultasUsrValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasUsrValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasUsrValor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUsrValor.Location = new System.Drawing.Point(115, 80);
            this.ConsultasUsrValor.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUsrValor.Name = "ConsultasUsrValor";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasUsrValor, 2);
            this.ConsultasUsrValor.Size = new System.Drawing.Size(323, 37);
            this.ConsultasUsrValor.TabIndex = 26;
            // 
            // ConsultasBtnBuscar
            // 
            this.ConsultasBtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnBuscar.BackgroundImage")));
            this.ConsultasBtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnBuscar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnBuscar.Location = new System.Drawing.Point(443, 20);
            this.ConsultasBtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnBuscar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnBuscar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnBuscar.Name = "ConsultasBtnBuscar";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasBtnBuscar, 3);
            this.ConsultasBtnBuscar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnBuscar.TabIndex = 14;
            this.ConsultasBtnBuscar.UseVisualStyleBackColor = false;
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
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(533, 20);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasBtnRefrescar, 3);
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.TabIndex = 23;
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = false;
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
            this.ConsultasBtnAyuda.Location = new System.Drawing.Point(623, 20);
            this.ConsultasBtnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnAyuda.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.Name = "ConsultasBtnAyuda";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasBtnAyuda, 3);
            this.ConsultasBtnAyuda.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.TabIndex = 24;
            this.ConsultasBtnAyuda.UseVisualStyleBackColor = false;
            this.ConsultasBtnAyuda.Click += new System.EventHandler(this.ConsultasMetBtnAyudaClick);
            // 
            // UsrAgregarFiltro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UsrAgregarFiltro";
            this.Size = new System.Drawing.Size(708, 142);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnBuscar;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblCampo;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblOperador;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblValor;
        private CapaVista_Componentes.ClsListaComboBoxConsultas ConsultasCboCampo;
        private CapaVista_Componentes.ClsListaComboBoxConsultas ConsultasCboOperador;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnRefrescar;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnAyuda;
        private CapaVista_Componentes.UsrTextbox ConsultasUsrValor;
    }
}
