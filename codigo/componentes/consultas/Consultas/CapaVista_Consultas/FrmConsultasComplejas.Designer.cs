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
            this.ConsultasGbxSeleccionConsulta = new CapaVista_Componentes.ClsGrupoConsultas();
            this.ConsultasUsrConsultasReutilizables = new CapaVista_Consultas.Controles.UsrSeleccioneUnaConsulta();
            this.ConsultasUsrTabla = new CapaVista_Consultas.Controles.UsrTabla();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnRefrescar = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnAyuda = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnInicio = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasBtnSalir = new CapaVista_Componentes.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxSeleccionConsulta.SuspendLayout();
            this.ConsultasFlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 3;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxSeleccionConsulta, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUsrTabla, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasFlpBotones, 2, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpPrincipal.MinimumSize = new System.Drawing.Size(1230, 700);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 4;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(1332, 703);
            this.ConsultasTlpPrincipal.TabIndex = 15;
            // 
            // ConsultasGbxSeleccionConsulta
            // 
            this.ConsultasGbxSeleccionConsulta.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxSeleccionConsulta.Controls.Add(this.ConsultasUsrConsultasReutilizables);
            this.ConsultasGbxSeleccionConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxSeleccionConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxSeleccionConsulta.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxSeleccionConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxSeleccionConsulta.Location = new System.Drawing.Point(5, 5);
            this.ConsultasGbxSeleccionConsulta.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasGbxSeleccionConsulta.Name = "ConsultasGbxSeleccionConsulta";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasGbxSeleccionConsulta, 3);
            this.ConsultasGbxSeleccionConsulta.Size = new System.Drawing.Size(390, 570);
            this.ConsultasGbxSeleccionConsulta.TabIndex = 21;
            this.ConsultasGbxSeleccionConsulta.TabStop = false;
            this.ConsultasGbxSeleccionConsulta.Text = "Seleccione una consulta";
            // 
            // ConsultasUsrConsultasReutilizables
            // 
            this.ConsultasUsrConsultasReutilizables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUsrConsultasReutilizables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUsrConsultasReutilizables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUsrConsultasReutilizables.Location = new System.Drawing.Point(3, 24);
            this.ConsultasUsrConsultasReutilizables.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUsrConsultasReutilizables.Name = "ConsultasUsrConsultasReutilizables";
            this.ConsultasUsrConsultasReutilizables.Query = null;
            this.ConsultasUsrConsultasReutilizables.Size = new System.Drawing.Size(384, 543);
            this.ConsultasUsrConsultasReutilizables.TabIndex = 0;
            this.ConsultasUsrConsultasReutilizables.Tabla = null;
            // 
            // ConsultasUsrTabla
            // 
            this.ConsultasUsrTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUsrTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUsrTabla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUsrTabla.Location = new System.Drawing.Point(405, 5);
            this.ConsultasUsrTabla.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasUsrTabla.Name = "ConsultasUsrTabla";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasUsrTabla, 4);
            this.ConsultasUsrTabla.Size = new System.Drawing.Size(832, 693);
            this.ConsultasUsrTabla.TabIndex = 22;
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnRefrescar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnAyuda);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnInicio);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnSalir);
            this.ConsultasFlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpBotones.Location = new System.Drawing.Point(1242, 5);
            this.ConsultasFlpBotones.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.ConsultasFlpBotones.Name = "ConsultasFlpBotones";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasFlpBotones, 3);
            this.ConsultasFlpBotones.Size = new System.Drawing.Size(85, 570);
            this.ConsultasFlpBotones.TabIndex = 23;
            // 
            // ConsultasBtnRefrescar
            // 
            this.ConsultasBtnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnRefrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnRefrescar.BackgroundImage")));
            this.ConsultasBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(0, 0);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.TabIndex = 19;
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = false;
            this.ConsultasBtnRefrescar.Click += new System.EventHandler(this.ConsultasMetBtnRefrescarClick);
            // 
            // ConsultasBtnAyuda
            // 
            this.ConsultasBtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnAyuda.BackgroundImage")));
            this.ConsultasBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnAyuda.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnAyuda.Location = new System.Drawing.Point(0, 80);
            this.ConsultasBtnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnAyuda.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.Name = "ConsultasBtnAyuda";
            this.ConsultasBtnAyuda.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnAyuda.TabIndex = 21;
            this.ConsultasBtnAyuda.UseVisualStyleBackColor = false;
            this.ConsultasBtnAyuda.Click += new System.EventHandler(this.ConsultasMetBtnAyudaClick);
            // 
            // ConsultasBtnInicio
            // 
            this.ConsultasBtnInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultasBtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnInicio.BackgroundImage")));
            this.ConsultasBtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnInicio.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnInicio.Location = new System.Drawing.Point(0, 160);
            this.ConsultasBtnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnInicio.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnInicio.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnInicio.Name = "ConsultasBtnInicio";
            this.ConsultasBtnInicio.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnInicio.TabIndex = 20;
            this.ConsultasBtnInicio.UseVisualStyleBackColor = false;
            this.ConsultasBtnInicio.Click += new System.EventHandler(this.ConsultasMetBtnInicioClick);
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
            this.ConsultasBtnSalir.Location = new System.Drawing.Point(0, 240);
            this.ConsultasBtnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnSalir.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.Name = "ConsultasBtnSalir";
            this.ConsultasBtnSalir.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnSalir.TabIndex = 17;
            this.ConsultasBtnSalir.UseVisualStyleBackColor = false;
            this.ConsultasBtnSalir.Click += new System.EventHandler(this.ConsultasMetBtnSalirClick);
            // 
            // FrmConsultasComplejas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1350, 750);
            this.Name = "FrmConsultasComplejas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4002 – ConsultasComplejas";
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxSeleccionConsulta.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnSalir;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnRefrescar;
        private CapaVista_Componentes.ClsGrupoConsultas ConsultasGbxSeleccionConsulta;
        private Controles.UsrSeleccioneUnaConsulta ConsultasUsrConsultasReutilizables;
        private Controles.UsrTabla ConsultasUsrTabla;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnInicio;
        private CapaVista_Componentes.ClsBotonConsultas ConsultasBtnAyuda;
    }
}