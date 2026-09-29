namespace CapaVista_BtnBusqueda
{
    partial class BtnBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BtnBusqueda));
            this.btnAccionBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccionBusqueda
            // 
            this.btnAccionBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnAccionBusqueda.Image")));
            this.btnAccionBusqueda.Location = new System.Drawing.Point(0, 0);
            this.btnAccionBusqueda.Name = "btnAccionBusqueda";
            this.btnAccionBusqueda.Size = new System.Drawing.Size(75, 69);
            this.btnAccionBusqueda.TabIndex = 0;
            this.btnAccionBusqueda.UseVisualStyleBackColor = true;
            // 
            // BtnBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAccionBusqueda);
            this.Name = "BtnBusqueda";
            this.Size = new System.Drawing.Size(73, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccionBusqueda;
    }
}
