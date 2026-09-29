namespace CapaVista_Consultas
{
    partial class FrmConsultasComplejas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasComplejas));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasUcTablaCompleja = new CapaVista_Consultas.UserControls.UcTablaCompleja();
            this.ConsultasBtnSalir = new CapaVista_Consultas.Components.ClsBotonConsultas();
            this.ConsultasGbxReutilizables = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.ConsultasUcConsultasReutilizables = new CapaVista_Consultas.UserControls.UcConsultasReutilizables();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxReutilizables.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcTablaCompleja, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasBtnSalir, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxReutilizables, 0, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(1122, 827);
            this.ConsultasTlpPrincipal.TabIndex = 15;
            // 
            // ConsultasUcTablaCompleja
            // 
            this.ConsultasUcTablaCompleja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.SetColumnSpan(this.ConsultasUcTablaCompleja, 2);
            this.ConsultasUcTablaCompleja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcTablaCompleja.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcTablaCompleja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcTablaCompleja.Location = new System.Drawing.Point(14, 308);
            this.ConsultasUcTablaCompleja.Margin = new System.Windows.Forms.Padding(14);
            this.ConsultasUcTablaCompleja.Name = "ConsultasUcTablaCompleja";
            this.ConsultasUcTablaCompleja.Size = new System.Drawing.Size(1094, 505);
            this.ConsultasUcTablaCompleja.TabIndex = 16;
            // 
            // ConsultasBtnSalir
            // 
            this.ConsultasBtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnSalir.BackgroundImage")));
            this.ConsultasBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnSalir.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnSalir.Location = new System.Drawing.Point(1037, 6);
            this.ConsultasBtnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.ConsultasBtnSalir.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.Name = "ConsultasBtnSalir";
            this.ConsultasBtnSalir.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.TabIndex = 17;
            this.ConsultasBtnSalir.UseVisualStyleBackColor = false;
            this.ConsultasBtnSalir.Click += new System.EventHandler(this.ConsultasMetBtnSalir);
            // 
            // ConsultasGbxReutilizables
            // 
            this.ConsultasGbxReutilizables.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxReutilizables.Controls.Add(this.ConsultasUcConsultasReutilizables);
            this.ConsultasGbxReutilizables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxReutilizables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxReutilizables.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxReutilizables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxReutilizables.Location = new System.Drawing.Point(6, 6);
            this.ConsultasGbxReutilizables.Margin = new System.Windows.Forms.Padding(6);
            this.ConsultasGbxReutilizables.Name = "ConsultasGbxReutilizables";
            this.ConsultasGbxReutilizables.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasGbxReutilizables.Size = new System.Drawing.Size(1019, 282);
            this.ConsultasGbxReutilizables.TabIndex = 18;
            this.ConsultasGbxReutilizables.TabStop = false;
            this.ConsultasGbxReutilizables.Text = "Elegir una Consulta";
            // 
            // ConsultasUcConsultasReutilizables
            // 
            this.ConsultasUcConsultasReutilizables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcConsultasReutilizables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcConsultasReutilizables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcConsultasReutilizables.Location = new System.Drawing.Point(3, 25);
            this.ConsultasUcConsultasReutilizables.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUcConsultasReutilizables.Name = "ConsultasUcConsultasReutilizables";
            this.ConsultasUcConsultasReutilizables.Size = new System.Drawing.Size(1013, 253);
            this.ConsultasUcConsultasReutilizables.TabIndex = 0;
            // 
            // FrmConsultasComplejas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1122, 827);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1140, 874);
            this.Name = "FrmConsultasComplejas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4002 – ConsultasComplejas";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxReutilizables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private UserControls.UcTablaCompleja ConsultasUcTablaCompleja;
        private Components.ClsBotonConsultas ConsultasBtnSalir;
        private Components.ClsGrupoConsultas ConsultasGbxReutilizables;
        private UserControls.UcConsultasReutilizables ConsultasUcConsultasReutilizables;
    }
}