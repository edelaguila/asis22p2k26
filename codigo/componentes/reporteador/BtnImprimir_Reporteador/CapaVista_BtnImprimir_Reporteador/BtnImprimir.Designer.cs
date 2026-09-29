namespace CapaVista_BtnImprimir_Reporteador
{
    partial class ReporteadorUcImprimir
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

        private void InitializeComponent()
        {
            this.ReporteadorBtnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReporteadorBtnImprimir
            // 
            this.ReporteadorBtnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.ReporteadorBtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReporteadorBtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReporteadorBtnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteadorBtnImprimir.FlatAppearance.BorderSize = 0;
            this.ReporteadorBtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteadorBtnImprimir.Image = global::CapaVista_BtnImprimir_Reporteador.Properties.Resources.btn_imprimir;
            this.ReporteadorBtnImprimir.Location = new System.Drawing.Point(0, 0);
            this.ReporteadorBtnImprimir.Name = "ReporteadorBtnImprimir";
            this.ReporteadorBtnImprimir.Size = new System.Drawing.Size(56, 56);
            this.ReporteadorBtnImprimir.TabIndex = 0;
            this.ReporteadorBtnImprimir.UseVisualStyleBackColor = false;
            // 
            // ReporteadorUcImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ReporteadorBtnImprimir);
            this.Name = "ReporteadorUcImprimir";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ReporteadorBtnImprimir;
    }
}