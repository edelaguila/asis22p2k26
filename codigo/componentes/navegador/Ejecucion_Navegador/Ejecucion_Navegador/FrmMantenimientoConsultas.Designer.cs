namespace CapaVista_Consultas
{
    partial class FrmMantenimientoConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoConsultas));
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasGbxCondicionesLogicas = new CapaVista_Consultas.Components.ClsGrupoConsultas();
            this.ConsultasUcCondicionesOrdenamientoAgrupacion = new CapaVista_Consultas.UserControls.UcCondicionesOrdenamientoAgrupacion();
            this.ConsultasUcFiltrosAplicados = new CapaVista_Consultas.UserControls.UcFiltrosAplicados();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasGbxCondicionesLogicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxCondicionesLogicas, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasUcFiltrosAplicados, 1, 0);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 1;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(981, 292);
            this.ConsultasTlpPrincipal.TabIndex = 16;
            // 
            // ConsultasGbxCondicionesLogicas
            // 
            this.ConsultasGbxCondicionesLogicas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxCondicionesLogicas.Controls.Add(this.ConsultasUcCondicionesOrdenamientoAgrupacion);
            this.ConsultasGbxCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxCondicionesLogicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxCondicionesLogicas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxCondicionesLogicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxCondicionesLogicas.Location = new System.Drawing.Point(3, 3);
            this.ConsultasGbxCondicionesLogicas.Name = "ConsultasGbxCondicionesLogicas";
            this.ConsultasGbxCondicionesLogicas.Size = new System.Drawing.Size(386, 286);
            this.ConsultasGbxCondicionesLogicas.TabIndex = 16;
            this.ConsultasGbxCondicionesLogicas.TabStop = false;
            this.ConsultasGbxCondicionesLogicas.Text = "Agregar Condición";
            // 
            // ConsultasUcCondicionesOrdenamientoAgrupacion
            // 
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.Location = new System.Drawing.Point(3, 24);
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.Name = "ConsultasUcCondicionesOrdenamientoAgrupacion";
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.Size = new System.Drawing.Size(380, 259);
            this.ConsultasUcCondicionesOrdenamientoAgrupacion.TabIndex = 1;
            // 
            // ConsultasUcFiltrosAplicados
            // 
            this.ConsultasUcFiltrosAplicados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasUcFiltrosAplicados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasUcFiltrosAplicados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasUcFiltrosAplicados.Location = new System.Drawing.Point(392, 0);
            this.ConsultasUcFiltrosAplicados.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasUcFiltrosAplicados.Name = "ConsultasUcFiltrosAplicados";
            this.ConsultasUcFiltrosAplicados.Size = new System.Drawing.Size(589, 292);
            this.ConsultasUcFiltrosAplicados.TabIndex = 17;
            // 
            // FrmMantenimientoConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(981, 292);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientoConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4003 – MantenimientoConsultas";
            this.TopMost = true;
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasGbxCondicionesLogicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Components.ClsGrupoConsultas ConsultasGbxCondicionesLogicas;
        private UserControls.UcCondicionesOrdenamientoAgrupacion ConsultasUcCondicionesOrdenamientoAgrupacion;
        private UserControls.UcFiltrosAplicados ConsultasUcFiltrosAplicados;
    }
}