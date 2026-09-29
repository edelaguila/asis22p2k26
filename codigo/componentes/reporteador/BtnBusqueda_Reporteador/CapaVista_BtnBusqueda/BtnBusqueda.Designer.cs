namespace CapaVista_BtnBusqueda
{
    partial class ReporteadorUcBusqueda
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">
        /// true si los recursos administrados se deben desechar;
        /// false en caso contrario.
        /// </param>
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
        /// Método necesario para admitir el Diseñador.
        /// No se puede modificar el contenido de este método
        /// con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReporteadorBtnBusqueda =
                new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // ReporteadorBtnBusqueda
            // 
            this.ReporteadorBtnBusqueda.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.ReporteadorBtnBusqueda.FlatAppearance.BorderSize =
                0;

            this.ReporteadorBtnBusqueda.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.ReporteadorBtnBusqueda.Image =
                global::CapaVista_BtnBusqueda
                .Properties.Resources.btn_aplicarFiltro;

            this.ReporteadorBtnBusqueda.Location =
                new System.Drawing.Point(0, 0);

            this.ReporteadorBtnBusqueda.Name =
                "ReporteadorBtnBusqueda";

            this.ReporteadorBtnBusqueda.Size =
                new System.Drawing.Size(56, 56);

            this.ReporteadorBtnBusqueda.TabIndex =
                0;

            this.ReporteadorBtnBusqueda.UseVisualStyleBackColor =
                true;

            // 
            // BtnBusqueda
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.Transparent;

            this.Controls.Add(
                this.ReporteadorBtnBusqueda);

            this.Name =
                "BtnBusqueda";

            this.Size =
                new System.Drawing.Size(56, 56);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button
            ReporteadorBtnBusqueda;
    }
}