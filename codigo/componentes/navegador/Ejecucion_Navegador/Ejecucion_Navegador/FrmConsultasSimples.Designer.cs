namespace CapaVista_Consultas
{
    partial class FrmConsultasSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasSimples));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasUcTablaSimple = new CapaVista_Consultas.UserControls.UcTablaSimple();
            this.ConsultasGbxAgregarFiltro = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.ConsultasUcAgruparOrdenar = new CapaVista_Consultas.UserControls.UcAgruparOrdenar();
            this.ConsultasBtnComplejas = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxAgregarFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcTablaSimple, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxAgregarFiltro, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnComplejas, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(1096, 653);
            this.ConsultasTlpPrincipal.TabIndex = 19;
            // 
            // ConsultasUcTablaSimple
            // 
            this.ConsultasUcTablaSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.SetColumnSpan(this.ConsultasUcTablaSimple, 2);
            this.ConsultasUcTablaSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcTablaSimple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcTablaSimple.Location = new System.Drawing.Point(2, 145);
            this.ConsultasUcTablaSimple.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ConsultasUcTablaSimple.Name = "ConsultasUcTablaSimple";
            this.ConsultasUcTablaSimple.Size = new System.Drawing.Size(1092, 504);
            this.ConsultasUcTablaSimple.TabIndex = 18;
            // 
            // ConsultasGbxAgregarFiltro
            // 
            this.ConsultasGbxAgregarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxAgregarFiltro.Controls.Add(this.ConsultasUcAgruparOrdenar);
            this.ConsultasGbxAgregarFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxAgregarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxAgregarFiltro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxAgregarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxAgregarFiltro.Location = new System.Drawing.Point(3, 4);
            this.ConsultasGbxAgregarFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasGbxAgregarFiltro.Name = "ConsultasGbxAgregarFiltro";
            this.ConsultasGbxAgregarFiltro.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasGbxAgregarFiltro.Size = new System.Drawing.Size(999, 133);
            this.ConsultasGbxAgregarFiltro.TabIndex = 19;
            this.ConsultasGbxAgregarFiltro.TabStop = false;
            this.ConsultasGbxAgregarFiltro.Text = "Agregar Filtro";
            // 
            // ConsultasUcAgruparOrdenar
            // 
            this.ConsultasUcAgruparOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcAgruparOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcAgruparOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcAgruparOrdenar.Location = new System.Drawing.Point(3, 25);
            this.ConsultasUcAgruparOrdenar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUcAgruparOrdenar.Name = "ConsultasUcAgruparOrdenar";
            this.ConsultasUcAgruparOrdenar.Size = new System.Drawing.Size(993, 104);
            this.ConsultasUcAgruparOrdenar.TabIndex = 0;
            // 
            // ConsultasBtnComplejas
            // 
            this.ConsultasBtnComplejas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnComplejas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnComplejas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnComplejas.BackgroundImage")));
            this.ConsultasBtnComplejas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnComplejas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnComplejas.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnComplejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnComplejas.Location = new System.Drawing.Point(1010, 0);
            this.ConsultasBtnComplejas.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnComplejas.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.Name = "ConsultasBtnComplejas";
            this.ConsultasBtnComplejas.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.TabIndex = 20;
            this.ConsultasBtnComplejas.UseVisualStyleBackColor = false;
            this.ConsultasBtnComplejas.Click += new System.EventHandler(this.ConsultasMetBtnComplejas);
            // 
            // FrmConsultasSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1096, 653);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmConsultasSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4001 - ConsultasSimples";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxAgregarFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.UcTablaSimple ConsultasUcTablaSimple;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Components.ClsGrupoConsultas ConsultasGbxAgregarFiltro;
        private UserControls.UcAgruparOrdenar ConsultasUcAgruparOrdenar;
        private Components.ClsBotonConsultas ConsultasBtnComplejas;
    }
}