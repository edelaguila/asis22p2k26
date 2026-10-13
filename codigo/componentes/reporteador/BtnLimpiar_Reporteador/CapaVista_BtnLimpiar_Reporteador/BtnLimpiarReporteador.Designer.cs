namespace CapaVista_BtnLimpiar_Reporteador
{
    partial class ReporteadorUcLimpiar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool Disposing)
        {
            if (Disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(Disposing);
        }

        private void InitializeComponent()
        {
            this.ReporteadorBtnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReporteadorBtnLimpiar
            // 
            this.ReporteadorBtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.ReporteadorBtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReporteadorBtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReporteadorBtnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteadorBtnLimpiar.FlatAppearance.BorderSize = 0;
            this.ReporteadorBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteadorBtnLimpiar.Image = global::CapaVista_BtnLimpiar_Reporteador.Properties.Resources.btn_limpiarReporte;
            this.ReporteadorBtnLimpiar.Location = new System.Drawing.Point(0, 0);
            this.ReporteadorBtnLimpiar.Name = "ReporteadorBtnLimpiar";
            this.ReporteadorBtnLimpiar.Size = new System.Drawing.Size(56, 56);
            this.ReporteadorBtnLimpiar.TabIndex = 0;
            this.ReporteadorBtnLimpiar.UseVisualStyleBackColor = false;
            this.ReporteadorBtnLimpiar.Click += new System.EventHandler(this.ReporteadorMetLimpiarClick);
            // 
            // ReporteadorUcLimpiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ReporteadorBtnLimpiar);
            this.Name = "ReporteadorUcLimpiar";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Button ReporteadorBtnLimpiar;

        
    }
}
