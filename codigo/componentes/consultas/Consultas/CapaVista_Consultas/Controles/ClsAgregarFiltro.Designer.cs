namespace CapaVista_Consultas.Controles
{
    partial class ClsAgregarFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClsAgregarFiltro));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasLblCampo = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboCampo = new CapaVista_Consultas.Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblOperador = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboOperador = new CapaVista_Consultas.Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblValor = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasTxtValor = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasBtnBuscar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnRefrescar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.ConsultasTlpPrincipal.ColumnCount = 5;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblCampo, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasCboCampo, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblOperador, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasCboOperador, 1, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblValor, 2, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTxtValor, 2, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnBuscar, 3, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnRefrescar, 4, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(775, 100);
            this.ConsultasTlpPrincipal.TabIndex = 0;
            // 
            // ConsultasLblCampo
            // 
            this.ConsultasLblCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblCampo.AutoSize = true;
            this.ConsultasLblCampo.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblCampo.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblCampo.Location = new System.Drawing.Point(69, 12);
            this.ConsultasLblCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblCampo.Name = "ConsultasLblCampo";
            this.ConsultasLblCampo.Size = new System.Drawing.Size(59, 19);
            this.ConsultasLblCampo.TabIndex = 17;
            this.ConsultasLblCampo.Text = "Campo";
            this.ConsultasLblCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ConsultasCboCampo.Location = new System.Drawing.Point(3, 39);
            this.ConsultasCboCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboCampo.Name = "ConsultasCboCampo";
            this.ConsultasCboCampo.Size = new System.Drawing.Size(192, 31);
            this.ConsultasCboCampo.TabIndex = 20;
            // 
            // ConsultasLblOperador
            // 
            this.ConsultasLblOperador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblOperador.AutoSize = true;
            this.ConsultasLblOperador.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOperador.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOperador.Location = new System.Drawing.Point(259, 12);
            this.ConsultasLblOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOperador.Name = "ConsultasLblOperador";
            this.ConsultasLblOperador.Size = new System.Drawing.Size(76, 19);
            this.ConsultasLblOperador.TabIndex = 16;
            this.ConsultasLblOperador.Text = "Operador";
            this.ConsultasLblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ConsultasCboOperador.Location = new System.Drawing.Point(201, 39);
            this.ConsultasCboOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(192, 31);
            this.ConsultasCboOperador.TabIndex = 21;
            // 
            // ConsultasLblValor
            // 
            this.ConsultasLblValor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblValor.AutoSize = true;
            this.ConsultasLblValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblValor.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblValor.Location = new System.Drawing.Point(472, 12);
            this.ConsultasLblValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblValor.Name = "ConsultasLblValor";
            this.ConsultasLblValor.Size = new System.Drawing.Size(46, 19);
            this.ConsultasLblValor.TabIndex = 15;
            this.ConsultasLblValor.Text = "Valor";
            this.ConsultasLblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasTxtValor
            // 
            this.ConsultasTxtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTxtValor.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtValor.Location = new System.Drawing.Point(399, 39);
            this.ConsultasTxtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTxtValor.Name = "ConsultasTxtValor";
            this.ConsultasTxtValor.Size = new System.Drawing.Size(192, 30);
            this.ConsultasTxtValor.TabIndex = 22;
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
            this.ConsultasBtnBuscar.Location = new System.Drawing.Point(599, 10);
            this.ConsultasBtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnBuscar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnBuscar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnBuscar.Name = "ConsultasBtnBuscar";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasBtnBuscar, 2);
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
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(689, 10);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasBtnRefrescar, 2);
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.TabIndex = 23;
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = false;
            // 
            // UcAgregarFiltro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcAgregarFiltro";
            this.Size = new System.Drawing.Size(775, 100);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Componentes.ClsBotonConsultas ConsultasBtnBuscar;
        private Componentes.ClsEtiquetaConsultas ConsultasLblCampo;
        private Componentes.ClsEtiquetaConsultas ConsultasLblOperador;
        private Componentes.ClsEtiquetaConsultas ConsultasLblValor;
        private Componentes.ClsListaComboBoxConsultas ConsultasCboCampo;
        private Componentes.ClsListaComboBoxConsultas ConsultasCboOperador;
        private Componentes.ClsCajaTextoConsultas ConsultasTxtValor;
        private Componentes.ClsBotonConsultas ConsultasBtnRefrescar;
    }
}
