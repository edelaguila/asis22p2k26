namespace CapaVista_Mantenimiento2k26
{
    partial class FrmDepartamento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Mantenimiento2k26BtnReporte = new System.Windows.Forms.Button();
            this.Mantenimiento2k26RvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Mantenimiento2k26Navegador = new CapaVista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // Mantenimiento2k26BtnReporte
            // 
            this.Mantenimiento2k26BtnReporte.BackColor = System.Drawing.Color.FromArgb(131, 197, 190);
            this.Mantenimiento2k26BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mantenimiento2k26BtnReporte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Mantenimiento2k26BtnReporte.ForeColor = System.Drawing.Color.FromArgb(0, 109, 119);
            this.Mantenimiento2k26BtnReporte.Location = new System.Drawing.Point(12, 12);
            this.Mantenimiento2k26BtnReporte.Name = "Mantenimiento2k26BtnReporte";
            this.Mantenimiento2k26BtnReporte.Size = new System.Drawing.Size(170, 38);
            this.Mantenimiento2k26BtnReporte.TabIndex = 1;
            this.Mantenimiento2k26BtnReporte.Text = "Reporte";
            this.Mantenimiento2k26BtnReporte.UseVisualStyleBackColor = false;
            this.Mantenimiento2k26BtnReporte.Click += new System.EventHandler(this.Mantenimiento2k26BtnReporte_Click);
            // 
            // Mantenimiento2k26RvReporte
            // 
            this.Mantenimiento2k26RvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mantenimiento2k26RvReporte.Location = new System.Drawing.Point(12, 180);
            this.Mantenimiento2k26RvReporte.Name = "Mantenimiento2k26RvReporte";
            this.Mantenimiento2k26RvReporte.Size = new System.Drawing.Size(1426, 500);
            this.Mantenimiento2k26RvReporte.TabIndex = 2;
            this.Mantenimiento2k26RvReporte.Visible = false;
            this.Mantenimiento2k26RvReporte.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // Mantenimiento2k26Navegador
            // 
            this.Mantenimiento2k26Navegador.Location = new System.Drawing.Point(2, 60);
            this.Mantenimiento2k26Navegador.Name = "Mantenimiento2k26Navegador";
            this.Mantenimiento2k26Navegador.Size = new System.Drawing.Size(1438, 111);
            this.Mantenimiento2k26Navegador.TabIndex = 0;
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(250, 247, 242);
            this.ClientSize = new System.Drawing.Size(1450, 700);
            this.Controls.Add(this.Mantenimiento2k26RvReporte);
            this.Controls.Add(this.Mantenimiento2k26BtnReporte);
            this.Controls.Add(this.Mantenimiento2k26Navegador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2016 – MantenimientoDepartamentos";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador Mantenimiento2k26Navegador;
        private System.Windows.Forms.Button Mantenimiento2k26BtnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer Mantenimiento2k26RvReporte;
    }
}
