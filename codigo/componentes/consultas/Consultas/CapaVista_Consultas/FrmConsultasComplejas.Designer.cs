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
            this.ConsultasGbxSeleccionTabla = new CapaVista_Consultas.Componentes.ClsGrupoConsultas();
            this.ConsultasCboSeleccionTabla = new CapaVista_Consultas.Componentes.ClsListaComboBoxConsultas();
            this.ConsultasGbxSeleccionConsulta = new CapaVista_Consultas.Componentes.ClsGrupoConsultas();
            this.ConsultasUcConsultasReutilizables = new CapaVista_Consultas.Controles.ClsSeleccioneUnaConsulta();
            this.ConsultasUcTabla = new CapaVista_Consultas.Controles.ClsTabla();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnRefrescar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnSalir = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnInicio = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxSeleccionTabla.SuspendLayout();
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
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxSeleccionTabla, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxSeleccionConsulta, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcTabla, 1, 0);
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
            // ConsultasGbxSeleccionTabla
            // 
            this.ConsultasGbxSeleccionTabla.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxSeleccionTabla.Controls.Add(this.ConsultasCboSeleccionTabla);
            this.ConsultasGbxSeleccionTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxSeleccionTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxSeleccionTabla.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxSeleccionTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxSeleccionTabla.Location = new System.Drawing.Point(5, 5);
            this.ConsultasGbxSeleccionTabla.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasGbxSeleccionTabla.Name = "ConsultasGbxSeleccionTabla";
            this.ConsultasGbxSeleccionTabla.Size = new System.Drawing.Size(390, 80);
            this.ConsultasGbxSeleccionTabla.TabIndex = 20;
            this.ConsultasGbxSeleccionTabla.TabStop = false;
            this.ConsultasGbxSeleccionTabla.Text = "Seleccione una tabla";
            // 
            // ConsultasCboSeleccionTabla
            // 
            this.ConsultasCboSeleccionTabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasCboSeleccionTabla.BackColor = System.Drawing.Color.White;
            this.ConsultasCboSeleccionTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboSeleccionTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboSeleccionTabla.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboSeleccionTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboSeleccionTabla.FormattingEnabled = true;
            this.ConsultasCboSeleccionTabla.Location = new System.Drawing.Point(18, 33);
            this.ConsultasCboSeleccionTabla.Name = "ConsultasCboSeleccionTabla";
            this.ConsultasCboSeleccionTabla.Size = new System.Drawing.Size(356, 31);
            this.ConsultasCboSeleccionTabla.TabIndex = 0;
            // 
            // ConsultasGbxSeleccionConsulta
            // 
            this.ConsultasGbxSeleccionConsulta.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxSeleccionConsulta.Controls.Add(this.ConsultasUcConsultasReutilizables);
            this.ConsultasGbxSeleccionConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxSeleccionConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxSeleccionConsulta.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxSeleccionConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxSeleccionConsulta.Location = new System.Drawing.Point(5, 95);
            this.ConsultasGbxSeleccionConsulta.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasGbxSeleccionConsulta.Name = "ConsultasGbxSeleccionConsulta";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasGbxSeleccionConsulta, 2);
            this.ConsultasGbxSeleccionConsulta.Size = new System.Drawing.Size(390, 480);
            this.ConsultasGbxSeleccionConsulta.TabIndex = 21;
            this.ConsultasGbxSeleccionConsulta.TabStop = false;
            this.ConsultasGbxSeleccionConsulta.Text = "Seleccione una consulta";
            // 
            // ConsultasUcConsultasReutilizables
            // 
            this.ConsultasUcConsultasReutilizables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcConsultasReutilizables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcConsultasReutilizables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcConsultasReutilizables.Location = new System.Drawing.Point(3, 24);
            this.ConsultasUcConsultasReutilizables.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUcConsultasReutilizables.Name = "ConsultasUcConsultasReutilizables";
            this.ConsultasUcConsultasReutilizables.Query = null;
            this.ConsultasUcConsultasReutilizables.Size = new System.Drawing.Size(384, 453);
            this.ConsultasUcConsultasReutilizables.TabIndex = 0;
            this.ConsultasUcConsultasReutilizables.Tabla = null;
            // 
            // ConsultasUcTabla
            // 
            this.ConsultasUcTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcTabla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcTabla.Location = new System.Drawing.Point(405, 5);
            this.ConsultasUcTabla.Margin = new System.Windows.Forms.Padding(5);
            this.ConsultasUcTabla.Name = "ConsultasUcTabla";
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasUcTabla, 4);
            this.ConsultasUcTabla.Size = new System.Drawing.Size(832, 693);
            this.ConsultasUcTabla.TabIndex = 22;
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnRefrescar);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnSalir);
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnInicio);
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
            this.ConsultasBtnSalir.TabIndex = 17;
            this.ConsultasBtnSalir.UseVisualStyleBackColor = false;
            this.ConsultasBtnSalir.Click += new System.EventHandler(this.ConsultasMetBtnSalirClick);
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
            this.ConsultasGbxSeleccionTabla.ResumeLayout(false);
            this.ConsultasGbxSeleccionConsulta.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Componentes.ClsBotonConsultas ConsultasBtnSalir;
        private Componentes.ClsBotonConsultas ConsultasBtnRefrescar;
        private Componentes.ClsGrupoConsultas ConsultasGbxSeleccionTabla;
        private Componentes.ClsGrupoConsultas ConsultasGbxSeleccionConsulta;
        private Controles.ClsSeleccioneUnaConsulta ConsultasUcConsultasReutilizables;
        private Controles.ClsTabla ConsultasUcTabla;
        private Componentes.ClsListaComboBoxConsultas ConsultasCboSeleccionTabla;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
        private Componentes.ClsBotonConsultas ConsultasBtnInicio;
    }
}