namespace CapaVista_Consultas.UserControls
{
    partial class UcAgruparOrdenar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAgruparOrdenar));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnRefrescar = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasTxtValor = new CapaVista_Consultas.Components.ClsCajaTextoConsultas();
            this.ConsultasCboOperador = new CapaVista_Consultas.Components.ClsListaDesplegableConsultas();
            this.ConsultasTlpOrdenamiento = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasRdoDescendente = new CapaVista_Consultas.Components.ClsBotonRadioConsultas();
            this.ConsultasRdoAscendente = new CapaVista_Consultas.Components.ClsBotonRadioConsultas();
            this.ConsultasLblOrdenamiento = new CapaVista_Consultas.Components.ClsEtiquetaConsultas();
            this.ConsultasLblCampo = new CapaVista_Consultas.Components.ClsEtiquetaConsultas();
            this.ConsultasLblOperador = new CapaVista_Consultas.Components.ClsEtiquetaConsultas();
            this.ConsultasLblValor = new CapaVista_Consultas.Components.ClsEtiquetaConsultas();
            this.ConsultasBtnIngresar = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasCboCampo = new CapaVista_Consultas.Components.ClsListaDesplegableConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasTlpOrdenamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.ConsultasTlpPrincipal.ColumnCount = 6;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33345F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33345F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3331F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnRefrescar, 5, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTxtValor, 3, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasCboOperador, 2, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTlpOrdenamiento, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblOrdenamiento, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblCampo, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblOperador, 2, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasLblValor, 3, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnIngresar, 4, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasCboCampo, 1, 1);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 3;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(775, 128);
            this.ConsultasTlpPrincipal.TabIndex = 0;
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
            // ConsultasTxtValor
            // 
            this.ConsultasTxtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTxtValor.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtValor.Location = new System.Drawing.Point(449, 39);
            this.ConsultasTxtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTxtValor.Name = "ConsultasTxtValor";
            this.ConsultasTxtValor.Size = new System.Drawing.Size(141, 30);
            this.ConsultasTxtValor.TabIndex = 22;
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
            this.ConsultasCboOperador.Location = new System.Drawing.Point(301, 39);
            this.ConsultasCboOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(142, 31);
            this.ConsultasCboOperador.TabIndex = 21;
            // 
            // ConsultasTlpOrdenamiento
            // 
            this.ConsultasTlpOrdenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTlpOrdenamiento.ColumnCount = 2;
            this.ConsultasTlpOrdenamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConsultasTlpOrdenamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ConsultasTlpOrdenamiento.Controls.Add(this.ConsultasRdoDescendente, 1, 0);
            this.ConsultasTlpOrdenamiento.Controls.Add(this.ConsultasRdoAscendente, 0, 0);
            this.ConsultasTlpOrdenamiento.Location = new System.Drawing.Point(0, 35);
            this.ConsultasTlpOrdenamiento.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpOrdenamiento.Name = "ConsultasTlpOrdenamiento";
            this.ConsultasTlpOrdenamiento.RowCount = 1;
            this.ConsultasTlpOrdenamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpOrdenamiento.Size = new System.Drawing.Size(150, 40);
            this.ConsultasTlpOrdenamiento.TabIndex = 19;
            // 
            // ConsultasRdoDescendente
            // 
            this.ConsultasRdoDescendente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultasRdoDescendente.AutoSize = true;
            this.ConsultasRdoDescendente.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasRdoDescendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasRdoDescendente.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasRdoDescendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasRdoDescendente.Location = new System.Drawing.Point(78, 10);
            this.ConsultasRdoDescendente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 4);
            this.ConsultasRdoDescendente.Name = "ConsultasRdoDescendente";
            this.ConsultasRdoDescendente.Size = new System.Drawing.Size(69, 23);
            this.ConsultasRdoDescendente.TabIndex = 1;
            this.ConsultasRdoDescendente.TabStop = true;
            this.ConsultasRdoDescendente.Text = "DESC";
            this.ConsultasRdoDescendente.UseVisualStyleBackColor = true;
            // 
            // ConsultasRdoAscendente
            // 
            this.ConsultasRdoAscendente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasRdoAscendente.AutoSize = true;
            this.ConsultasRdoAscendente.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasRdoAscendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasRdoAscendente.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasRdoAscendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasRdoAscendente.Location = new System.Drawing.Point(12, 10);
            this.ConsultasRdoAscendente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 4);
            this.ConsultasRdoAscendente.Name = "ConsultasRdoAscendente";
            this.ConsultasRdoAscendente.Size = new System.Drawing.Size(60, 23);
            this.ConsultasRdoAscendente.TabIndex = 2;
            this.ConsultasRdoAscendente.TabStop = true;
            this.ConsultasRdoAscendente.Text = "ASC";
            this.ConsultasRdoAscendente.UseVisualStyleBackColor = true;
            // 
            // ConsultasLblOrdenamiento
            // 
            this.ConsultasLblOrdenamiento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblOrdenamiento.AutoSize = true;
            this.ConsultasLblOrdenamiento.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOrdenamiento.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOrdenamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOrdenamiento.Location = new System.Drawing.Point(20, 12);
            this.ConsultasLblOrdenamiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOrdenamiento.Name = "ConsultasLblOrdenamiento";
            this.ConsultasLblOrdenamiento.Size = new System.Drawing.Size(110, 19);
            this.ConsultasLblOrdenamiento.TabIndex = 18;
            this.ConsultasLblOrdenamiento.Text = "Ordenamiento";
            this.ConsultasLblOrdenamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasLblCampo
            // 
            this.ConsultasLblCampo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblCampo.AutoSize = true;
            this.ConsultasLblCampo.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblCampo.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblCampo.Location = new System.Drawing.Point(194, 12);
            this.ConsultasLblCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblCampo.Name = "ConsultasLblCampo";
            this.ConsultasLblCampo.Size = new System.Drawing.Size(59, 19);
            this.ConsultasLblCampo.TabIndex = 17;
            this.ConsultasLblCampo.Text = "Campo";
            this.ConsultasLblCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasLblOperador
            // 
            this.ConsultasLblOperador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblOperador.AutoSize = true;
            this.ConsultasLblOperador.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOperador.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOperador.Location = new System.Drawing.Point(334, 12);
            this.ConsultasLblOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOperador.Name = "ConsultasLblOperador";
            this.ConsultasLblOperador.Size = new System.Drawing.Size(76, 19);
            this.ConsultasLblOperador.TabIndex = 16;
            this.ConsultasLblOperador.Text = "Operador";
            this.ConsultasLblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasLblValor
            // 
            this.ConsultasLblValor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsultasLblValor.AutoSize = true;
            this.ConsultasLblValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblValor.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblValor.Location = new System.Drawing.Point(496, 12);
            this.ConsultasLblValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblValor.Name = "ConsultasLblValor";
            this.ConsultasLblValor.Size = new System.Drawing.Size(46, 19);
            this.ConsultasLblValor.TabIndex = 15;
            this.ConsultasLblValor.Text = "Valor";
            this.ConsultasLblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ConsultasBtnIngresar.Location = new System.Drawing.Point(598, 10);
            this.ConsultasBtnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnIngresar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.Name = "ConsultasBtnIngresar";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasBtnIngresar, 2);
            this.ConsultasBtnIngresar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.TabIndex = 14;
            this.ConsultasBtnIngresar.UseVisualStyleBackColor = false;
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
            this.ConsultasCboCampo.Location = new System.Drawing.Point(153, 39);
            this.ConsultasCboCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboCampo.Name = "ConsultasCboCampo";
            this.ConsultasCboCampo.Size = new System.Drawing.Size(142, 31);
            this.ConsultasCboCampo.TabIndex = 20;
            // 
            // UcAgruparOrdenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcAgruparOrdenar";
            this.Size = new System.Drawing.Size(775, 128);
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpPrincipal.PerformLayout();
            this.ConsultasTlpOrdenamiento.ResumeLayout(false);
            this.ConsultasTlpOrdenamiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Components.ClsBotonConsultas ConsultasBtnIngresar;
        private Components.ClsEtiquetaConsultas ConsultasLblOrdenamiento;
        private Components.ClsEtiquetaConsultas ConsultasLblCampo;
        private Components.ClsEtiquetaConsultas ConsultasLblOperador;
        private Components.ClsEtiquetaConsultas ConsultasLblValor;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpOrdenamiento;
        private Components.ClsBotonRadioConsultas ConsultasRdoDescendente;
        private Components.ClsBotonRadioConsultas ConsultasRdoAscendente;
        private Components.ClsListaDesplegableConsultas ConsultasCboCampo;
        private Components.ClsListaDesplegableConsultas ConsultasCboOperador;
        private Components.ClsCajaTextoConsultas ConsultasTxtValor;
        private Components.ClsBotonConsultas ConsultasBtnRefrescar;
    }
}
