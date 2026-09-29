namespace CapaVista_BtnGuardar
{
    partial class BtnGuardar
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
            this.btnAccionGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccionGuardar
            // 
            this.btnAccionGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnAccionGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccionGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccionGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccionGuardar.FlatAppearance.BorderSize = 0;
            this.btnAccionGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccionGuardar.Image = global::CapaVista_BtnGuardar.Properties.Resources.btn_guardar;
            this.btnAccionGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnAccionGuardar.Name = "btnAccionGuardar";
            this.btnAccionGuardar.Size = new System.Drawing.Size(56, 56);
            this.btnAccionGuardar.TabIndex = 0;
            this.btnAccionGuardar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAccionGuardar);
            this.Name = "BtnGuardar";
            this.Size = new System.Drawing.Size(56, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccionGuardar;
    }
}