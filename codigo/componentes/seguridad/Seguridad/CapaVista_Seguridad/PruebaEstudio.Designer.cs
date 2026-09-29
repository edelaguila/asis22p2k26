namespace CapaVista_Seguridad
{
    partial class PruebaEstudio
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
            this.navegador2 = new CapaVista_Navegador.Navegador();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador2
            // 
            this.navegador2.Location = new System.Drawing.Point(3, 33);
            this.navegador2.Name = "navegador2";
            this.navegador2.Size = new System.Drawing.Size(1438, 111);
            this.navegador2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1308, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PruebaEstudio
            // 
            this.ClientSize = new System.Drawing.Size(1450, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.navegador2);
            this.Name = "PruebaEstudio";
            this.Load += new System.EventHandler(this.PruebaEstudio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private CapaVista_Navegador.Navegador navegador2;
        private System.Windows.Forms.Button button1;
    }
}