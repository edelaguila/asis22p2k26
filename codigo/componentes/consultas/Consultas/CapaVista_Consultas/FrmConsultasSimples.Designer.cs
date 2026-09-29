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
            this.ConsultasUsrTablaSimple = new CapaVista_Consultas.Controles.UsrTabla();
            this.ConsultasGbxAgregarFiltro = new CapaVista_Componentes.ClsGrupoConsultas();
            this.ConsultasUsrAgregarFiltro = new CapaVista_Consultas.Controles.UsrAgregarFiltro();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnComplejas = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnSalir = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxAgregarFiltro.SuspendLayout();
            this.ConsultasFlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUsrTablaSimple, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxAgregarFiltro, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasFlpBotones, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 2;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(982, 678);
            this.ConsultasTlpPrincipal.TabIndex = 19;
            // 
            // ConsultasUsrTablaSimple
            // 
            this.ConsultasUsrTablaSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpPrincipal.SetColumnSpan(this.ConsultasUsrTablaSimple, 2);
            this.ConsultasUsrTablaSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUsrTablaSimple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUsrTablaSimple.Location = new System.Drawing.Point(5, 170);
            this.ConsultasUsrTablaSimple.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasUsrTablaSimple.Name = "ConsultasUsrTablaSimple";
            this.ConsultasUsrTablaSimple.Size = new System.Drawing.Size(972, 503);
            this.ConsultasUsrTablaSimple.TabIndex = 18;
            // 
            // ConsultasGbxAgregarFiltro
            // 
            this.ConsultasGbxAgregarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxAgregarFiltro.Controls.Add(this.ConsultasUsrAgregarFiltro);
            this.ConsultasGbxAgregarFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxAgregarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxAgregarFiltro.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxAgregarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxAgregarFiltro.Location = new System.Drawing.Point(10, 5);
            this.ConsultasGbxAgregarFiltro.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.ConsultasGbxAgregarFiltro.Name = "ConsultasGbxAgregarFiltro";
            this.ConsultasGbxAgregarFiltro.Padding = new System.Windows.Forms.Padding(0);
            this.ConsultasGbxAgregarFiltro.Size = new System.Drawing.Size(876, 155);
            this.ConsultasGbxAgregarFiltro.TabIndex = 19;
            this.ConsultasGbxAgregarFiltro.TabStop = false;
            this.ConsultasGbxAgregarFiltro.Text = "Agregar Filtro";
            // 
            // ConsultasUsrAgregarFiltro
            // 
            this.ConsultasUsrAgregarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUsrAgregarFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUsrAgregarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUsrAgregarFiltro.Location = new System.Drawing.Point(0, 21);
            this.ConsultasUsrAgregarFiltro.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasUsrAgregarFiltro.Name = "ConsultasUsrAgregarFiltro";
            this.ConsultasUsrAgregarFiltro.Size = new System.Drawing.Size(876, 134);
            this.ConsultasUsrAgregarFiltro.TabIndex = 0;
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnComplejas);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnSalir);
            this.ConsultasFlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpBotones.Location = new System.Drawing.Point(896, 5);
            this.ConsultasFlpBotones.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasFlpBotones.Name = "ConsultasFlpBotones";
            this.ConsultasFlpBotones.Size = new System.Drawing.Size(81, 155);
            this.ConsultasFlpBotones.TabIndex = 23;
            // 
            // ConsultasBtnComplejas
            // 
            this.ConsultasBtnComplejas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnComplejas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnComplejas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnComplejas.BackgroundImage")));
            this.ConsultasBtnComplejas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnComplejas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnComplejas.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnComplejas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnComplejas.Location = new System.Drawing.Point(0, 0);
            this.ConsultasBtnComplejas.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnComplejas.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.Name = "ConsultasBtnComplejas";
            this.ConsultasBtnComplejas.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnComplejas.TabIndex = 21;
            this.ConsultasBtnComplejas.UseVisualStyleBackColor = false;
            this.ConsultasBtnComplejas.Click += new System.EventHandler(this.ConsultasMetBtnComplejasClick);
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
            this.ConsultasBtnSalir.Location = new System.Drawing.Point(0, 80);
            this.ConsultasBtnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnSalir.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.Name = "ConsultasBtnSalir";
            this.ConsultasBtnSalir.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.TabIndex = 22;
            this.ConsultasBtnSalir.UseVisualStyleBackColor = false;
            this.ConsultasBtnSalir.Click += new System.EventHandler(this.ConsultasMetBtnSalirClick);
            // 
            // FrmConsultasSimples
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(982, 678);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 725);
            this.Name = "FrmConsultasSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4001 - ConsultasSimples";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxAgregarFiltro.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private CapaVista_Componentes.ClsGrupoConsultas ConsultasGbxAgregarFiltro;
        private Controles.UsrAgregarFiltro ConsultasUsrAgregarFiltro;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnComplejas;
        private Controles.UsrTabla ConsultasUsrTablaSimple;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnSalir;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
    }
}