namespace CapaVista_BtnRuta
{
    partial class BtnRuta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRutaReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRutaReporte
            // 
            this.BtnRutaReporte.BackColor = System.Drawing.Color.Transparent;
            this.BtnRutaReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRutaReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRutaReporte.FlatAppearance.BorderSize = 0;
            this.BtnRutaReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRutaReporte.ForeColor = System.Drawing.Color.Transparent;
            this.BtnRutaReporte.Image = global::CapaVista_BtnRuta.Properties.Resources.btn_rutaReporte;
            this.BtnRutaReporte.Location = new System.Drawing.Point(0, 0);
            this.BtnRutaReporte.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRutaReporte.Name = "BtnRutaReporte";
            this.BtnRutaReporte.Size = new System.Drawing.Size(56, 56);
            this.BtnRutaReporte.TabIndex = 0;
            this.BtnRutaReporte.UseVisualStyleBackColor = false;
            this.BtnRutaReporte.Click += new System.EventHandler(this.BtnRutaReporte_Click);
            // 
            // BtnRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRutaReporte);
            this.Name = "BtnRuta";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRutaReporte;
    }
}