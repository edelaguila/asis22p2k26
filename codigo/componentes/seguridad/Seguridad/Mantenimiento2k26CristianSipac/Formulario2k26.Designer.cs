namespace Mantenimiento2k26CristianSipac
{
    partial class Formulario2k26
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
            this.NavegadorExamen = new CapaVista_Navegador.Navegador();
            this.SuspendLayout();
            // 
            // NavegadorExamen
            // 
            this.NavegadorExamen.Location = new System.Drawing.Point(0, 119);
            this.NavegadorExamen.Name = "NavegadorExamen";
            this.NavegadorExamen.Size = new System.Drawing.Size(1438, 111);
            this.NavegadorExamen.TabIndex = 0;
            // 
            // Formulario2k26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 450);
            this.Controls.Add(this.NavegadorExamen);
            this.Name = "Formulario2k26";
            this.Text = "Formulario2k26";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador NavegadorExamen;
    }
}