namespace CapaVista_Seguridad
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.SeguridadPgbCarga = new System.Windows.Forms.ProgressBar();
            this._TimerCarga = new System.Windows.Forms.Timer(this.components);
            this.SeguridadLblTitulo = new System.Windows.Forms.Label();
            this.SeguridadLblMensaje = new System.Windows.Forms.Label();
            this.SeguridadLblPorcentaje = new System.Windows.Forms.Label();
            this.SeguridadPbLogo = new System.Windows.Forms.PictureBox();
            this.SeguridadPbMascota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // SeguridadPgbCarga
            // 
            this.SeguridadPgbCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.SeguridadPgbCarga.Location = new System.Drawing.Point(163, 296);
            this.SeguridadPgbCarga.Name = "SeguridadPgbCarga";
            this.SeguridadPgbCarga.Size = new System.Drawing.Size(476, 25);
            this.SeguridadPgbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SeguridadPgbCarga.TabIndex = 2;
            // 
            // _TimerCarga
            // 
            this._TimerCarga.Interval = 35;
            this._TimerCarga.Tick += new System.EventHandler(this._TimerCarga_Tick);
            // 
            // SeguridadLblTitulo
            // 
            this.SeguridadLblTitulo.AutoSize = true;
            this.SeguridadLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadLblTitulo.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.SeguridadLblTitulo.Location = new System.Drawing.Point(327, 205);
            this.SeguridadLblTitulo.Name = "SeguridadLblTitulo";
            this.SeguridadLblTitulo.Size = new System.Drawing.Size(162, 27);
            this.SeguridadLblTitulo.TabIndex = 3;
            this.SeguridadLblTitulo.Text = "CARGANDO";
            // 
            // SeguridadLblMensaje
            // 
            this.SeguridadLblMensaje.AutoSize = true;
            this.SeguridadLblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadLblMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblMensaje.Location = new System.Drawing.Point(148, 240);
            this.SeguridadLblMensaje.Name = "SeguridadLblMensaje";
            this.SeguridadLblMensaje.Size = new System.Drawing.Size(512, 19);
            this.SeguridadLblMensaje.TabIndex = 5;
            this.SeguridadLblMensaje.Text = "Por favor espere mientras preparamos la mejor experiencia para usted.";
            // 
            // SeguridadLblPorcentaje
            // 
            this.SeguridadLblPorcentaje.AutoSize = true;
            this.SeguridadLblPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadLblPorcentaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblPorcentaje.Location = new System.Drawing.Point(389, 326);
            this.SeguridadLblPorcentaje.Name = "SeguridadLblPorcentaje";
            this.SeguridadLblPorcentaje.Size = new System.Drawing.Size(28, 19);
            this.SeguridadLblPorcentaje.TabIndex = 6;
            this.SeguridadLblPorcentaje.Text = "%";
            this.SeguridadLblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SeguridadPbLogo
            // 
            this.SeguridadPbLogo.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadPbLogo.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.logo;
            this.SeguridadPbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadPbLogo.Location = new System.Drawing.Point(273, 73);
            this.SeguridadPbLogo.Name = "SeguridadPbLogo";
            this.SeguridadPbLogo.Size = new System.Drawing.Size(130, 126);
            this.SeguridadPbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeguridadPbLogo.TabIndex = 4;
            this.SeguridadPbLogo.TabStop = false;
            // 
            // SeguridadPbMascota
            // 
            this.SeguridadPbMascota.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadPbMascota.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources._8;
            this.SeguridadPbMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadPbMascota.Location = new System.Drawing.Point(406, 52);
            this.SeguridadPbMascota.Name = "SeguridadPbMascota";
            this.SeguridadPbMascota.Size = new System.Drawing.Size(117, 147);
            this.SeguridadPbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeguridadPbMascota.TabIndex = 0;
            this.SeguridadPbMascota.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeguridadLblPorcentaje);
            this.Controls.Add(this.SeguridadLblMensaje);
            this.Controls.Add(this.SeguridadPbLogo);
            this.Controls.Add(this.SeguridadLblTitulo);
            this.Controls.Add(this.SeguridadPgbCarga);
            this.Controls.Add(this.SeguridadPbMascota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2001 - Splash";
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SeguridadPbMascota;
        private System.Windows.Forms.ProgressBar SeguridadPgbCarga;
        private System.Windows.Forms.Timer _TimerCarga;
        private System.Windows.Forms.Label SeguridadLblTitulo;
        private System.Windows.Forms.PictureBox SeguridadPbLogo;
        private System.Windows.Forms.Label SeguridadLblMensaje;
        private System.Windows.Forms.Label SeguridadLblPorcentaje;
    }
}