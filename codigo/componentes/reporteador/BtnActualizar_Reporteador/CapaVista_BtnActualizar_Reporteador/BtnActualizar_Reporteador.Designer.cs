namespace CapaVista_BtnActualizar
{
    partial class ReporteadorUcActualizar
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
            this.ReporteadorBtnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReporteadorBtnActualizar
            // 
            this.ReporteadorBtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.ReporteadorBtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReporteadorBtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReporteadorBtnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteadorBtnActualizar.FlatAppearance.BorderSize = 0;
            this.ReporteadorBtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReporteadorBtnActualizar.ForeColor = System.Drawing.Color.Transparent;
            this.ReporteadorBtnActualizar.Image = global::CapaVista_BtnActualizar_Reporteador.Properties.Resources.btn_refrescar;
            this.ReporteadorBtnActualizar.Location = new System.Drawing.Point(0, 0);
            this.ReporteadorBtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.ReporteadorBtnActualizar.Name = "ReporteadorBtnActualizar";
            this.ReporteadorBtnActualizar.Size = new System.Drawing.Size(56, 56);
            this.ReporteadorBtnActualizar.TabIndex = 0;
            this.ReporteadorBtnActualizar.UseVisualStyleBackColor = false;
            this.ReporteadorBtnActualizar.Click += new System.EventHandler(this.ReporteadorBtnActualizar_Click);
            // 
            // ReporteadorUcActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ReporteadorBtnActualizar);
            this.Name = "ReporteadorUcActualizar";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ReporteadorBtnActualizar;
    }
}
