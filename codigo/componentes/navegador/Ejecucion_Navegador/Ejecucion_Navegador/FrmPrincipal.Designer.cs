namespace CapaVista_Navegador
{
    partial class FrmPrincipal
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.SuspendLayout();
            //
            // navegador1
            //
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            //
            // FrmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1480, 653);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmPrincipal";
            this.Text = "1001 – Crud";
            this.ResumeLayout(false);

        }

        #endregion

        private Navegador navegador1;
    }
}
