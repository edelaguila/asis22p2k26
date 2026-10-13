namespace Ejecucion_Consultas
{
    partial class FrmEjecucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjecucion));
            this.ConsultasTxtId = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasBtnConsultar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasLblId = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.SuspendLayout();
            // 
            // ConsultasTxtId
            // 
            this.ConsultasTxtId.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtId.Enabled = false;
            this.ConsultasTxtId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtId.Location = new System.Drawing.Point(226, 212);
            this.ConsultasTxtId.Name = "ConsultasTxtId";
            this.ConsultasTxtId.Size = new System.Drawing.Size(200, 30);
            this.ConsultasTxtId.TabIndex = 0;
            // 
            // ConsultasBtnConsultar
            // 
            this.ConsultasBtnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnConsultar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnConsultar.Image")));
            this.ConsultasBtnConsultar.Location = new System.Drawing.Point(462, 186);
            this.ConsultasBtnConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnConsultar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.Name = "ConsultasBtnConsultar";
            this.ConsultasBtnConsultar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnConsultar.TabIndex = 1;
            this.ConsultasBtnConsultar.UseVisualStyleBackColor = false;
            this.ConsultasBtnConsultar.Click += new System.EventHandler(this.ConsultasMetBtnConsultarClick);
            // 
            // ConsultasLblId
            // 
            this.ConsultasLblId.AutoSize = true;
            this.ConsultasLblId.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblId.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblId.Location = new System.Drawing.Point(98, 216);
            this.ConsultasLblId.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLblId.Name = "ConsultasLblId";
            this.ConsultasLblId.Size = new System.Drawing.Size(122, 19);
            this.ConsultasLblId.TabIndex = 2;
            this.ConsultasLblId.Text = "ID Seleccionado";
            this.ConsultasLblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConsultasLblId);
            this.Controls.Add(this.ConsultasBtnConsultar);
            this.Controls.Add(this.ConsultasTxtId);
            this.Name = "FrmEjecucion";
            this.Text = "4004 - EjecucionComplejas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVista_Consultas.Componentes.ClsCajaTextoConsultas ConsultasTxtId;
        private CapaVista_Consultas.Componentes.ClsBotonConsultas ConsultasBtnConsultar;
        private CapaVista_Consultas.Componentes.ClsEtiquetaConsultas ConsultasLblId;
    }
}