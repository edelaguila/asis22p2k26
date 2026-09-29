namespace CapaVista_Reporteador
{
    partial class FrmReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.ReporteadorPbLogo = new System.Windows.Forms.PictureBox();
            this.ReporteadorPbFooter = new System.Windows.Forms.PictureBox();
            this.ReporteadorPbBanner = new System.Windows.Forms.PictureBox();
            this.ReporteadorLblRutaReporte = new System.Windows.Forms.Label();
            this.ReporteadorLblNombreReporte = new System.Windows.Forms.Label();
            this.ReporteadorLblDatosBuscarReporte = new System.Windows.Forms.Label();
            this.ReporteadorTxtRutaReporte = new System.Windows.Forms.TextBox();
            this.ReporteadorTxtNombreReporte = new System.Windows.Forms.TextBox();
            this.ReporteadorDgvReportes = new System.Windows.Forms.DataGridView();
            this.ReporteadorChkNombreReporte = new System.Windows.Forms.CheckBox();
            this.ReporteadorChkFechaReporte = new System.Windows.Forms.CheckBox();
            this.ReporteadorTxtNombreReporte2 = new System.Windows.Forms.TextBox();
            this.ReporteadorDtpFechaReporte = new System.Windows.Forms.DateTimePicker();
            this.ReporteadorPnlFiltroBuscarReporte = new System.Windows.Forms.Panel();
            this.BtnRuta = new CapaVista_BtnRuta.BtnRuta();
            this.BtnGuardar = new CapaVista_BtnGuardar.BtnGuardar();
            this.BtnImprimir = new CapaVista_BtnImprimir.BtnImprimir();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorPbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorPbFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorPbBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorDgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteadorPbLogo
            // 
            this.ReporteadorPbLogo.Image = global::CapaVista_Reportedor.Properties.Resources.img_mascota;
            this.ReporteadorPbLogo.Location = new System.Drawing.Point(680, 261);
            this.ReporteadorPbLogo.Name = "ReporteadorPbLogo";
            this.ReporteadorPbLogo.Size = new System.Drawing.Size(195, 210);
            this.ReporteadorPbLogo.TabIndex = 2;
            this.ReporteadorPbLogo.TabStop = false;
            // 
            // ReporteadorPbFooter
            // 
            this.ReporteadorPbFooter.Image = global::CapaVista_Reportedor.Properties.Resources.Footer_reporteador;
            this.ReporteadorPbFooter.Location = new System.Drawing.Point(-6, 555);
            this.ReporteadorPbFooter.Name = "ReporteadorPbFooter";
            this.ReporteadorPbFooter.Size = new System.Drawing.Size(890, 110);
            this.ReporteadorPbFooter.TabIndex = 1;
            this.ReporteadorPbFooter.TabStop = false;
            // 
            // ReporteadorPbBanner
            // 
            this.ReporteadorPbBanner.Image = global::CapaVista_Reportedor.Properties.Resources.banner_Reporteador;
            this.ReporteadorPbBanner.Location = new System.Drawing.Point(-6, -3);
            this.ReporteadorPbBanner.Name = "ReporteadorPbBanner";
            this.ReporteadorPbBanner.Size = new System.Drawing.Size(890, 110);
            this.ReporteadorPbBanner.TabIndex = 0;
            this.ReporteadorPbBanner.TabStop = false;
            // 
            // ReporteadorLblRutaReporte
            // 
            this.ReporteadorLblRutaReporte.AutoSize = true;
            this.ReporteadorLblRutaReporte.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorLblRutaReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ReporteadorLblRutaReporte.Location = new System.Drawing.Point(28, 125);
            this.ReporteadorLblRutaReporte.Name = "ReporteadorLblRutaReporte";
            this.ReporteadorLblRutaReporte.Size = new System.Drawing.Size(151, 21);
            this.ReporteadorLblRutaReporte.TabIndex = 3;
            this.ReporteadorLblRutaReporte.Text = "Ruta del reporte: *";
            // 
            // ReporteadorLblNombreReporte
            // 
            this.ReporteadorLblNombreReporte.AutoSize = true;
            this.ReporteadorLblNombreReporte.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorLblNombreReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ReporteadorLblNombreReporte.Location = new System.Drawing.Point(28, 186);
            this.ReporteadorLblNombreReporte.Name = "ReporteadorLblNombreReporte";
            this.ReporteadorLblNombreReporte.Size = new System.Drawing.Size(174, 21);
            this.ReporteadorLblNombreReporte.TabIndex = 4;
            this.ReporteadorLblNombreReporte.Text = "Nombre del reporte: *";
            // 
            // ReporteadorLblDatosBuscarReporte
            // 
            this.ReporteadorLblDatosBuscarReporte.AutoSize = true;
            this.ReporteadorLblDatosBuscarReporte.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorLblDatosBuscarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ReporteadorLblDatosBuscarReporte.Location = new System.Drawing.Point(28, 286);
            this.ReporteadorLblDatosBuscarReporte.Name = "ReporteadorLblDatosBuscarReporte";
            this.ReporteadorLblDatosBuscarReporte.Size = new System.Drawing.Size(211, 21);
            this.ReporteadorLblDatosBuscarReporte.TabIndex = 5;
            this.ReporteadorLblDatosBuscarReporte.Text = "Datos para buscar reporte:";
            // 
            // ReporteadorTxtRutaReporte
            // 
            this.ReporteadorTxtRutaReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteadorTxtRutaReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorTxtRutaReporte.Location = new System.Drawing.Point(219, 113);
            this.ReporteadorTxtRutaReporte.Name = "ReporteadorTxtRutaReporte";
            this.ReporteadorTxtRutaReporte.Size = new System.Drawing.Size(480, 33);
            this.ReporteadorTxtRutaReporte.TabIndex = 6;
            // 
            // ReporteadorTxtNombreReporte
            // 
            this.ReporteadorTxtNombreReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteadorTxtNombreReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorTxtNombreReporte.Location = new System.Drawing.Point(219, 174);
            this.ReporteadorTxtNombreReporte.Name = "ReporteadorTxtNombreReporte";
            this.ReporteadorTxtNombreReporte.Size = new System.Drawing.Size(480, 33);
            this.ReporteadorTxtNombreReporte.TabIndex = 7;
            // 
            // ReporteadorDgvReportes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReporteadorDgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReporteadorDgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReporteadorDgvReportes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.ReporteadorDgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReporteadorDgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReporteadorDgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReporteadorDgvReportes.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReporteadorDgvReportes.EnableHeadersVisualStyles = false;
            this.ReporteadorDgvReportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(63)))));
            this.ReporteadorDgvReportes.Location = new System.Drawing.Point(32, 405);
            this.ReporteadorDgvReportes.Name = "ReporteadorDgvReportes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReporteadorDgvReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ReporteadorDgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ReporteadorDgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReporteadorDgvReportes.Size = new System.Drawing.Size(654, 144);
            this.ReporteadorDgvReportes.TabIndex = 8;
            // 
            // ReporteadorChkNombreReporte
            // 
            this.ReporteadorChkNombreReporte.AutoSize = true;
            this.ReporteadorChkNombreReporte.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorChkNombreReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ReporteadorChkNombreReporte.Location = new System.Drawing.Point(32, 321);
            this.ReporteadorChkNombreReporte.Name = "ReporteadorChkNombreReporte";
            this.ReporteadorChkNombreReporte.Size = new System.Drawing.Size(181, 27);
            this.ReporteadorChkNombreReporte.TabIndex = 9;
            this.ReporteadorChkNombreReporte.Text = "Nombre del reporte";
            this.ReporteadorChkNombreReporte.UseVisualStyleBackColor = true;
            // 
            // ReporteadorChkFechaReporte
            // 
            this.ReporteadorChkFechaReporte.AutoSize = true;
            this.ReporteadorChkFechaReporte.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorChkFechaReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ReporteadorChkFechaReporte.Location = new System.Drawing.Point(283, 321);
            this.ReporteadorChkFechaReporte.Name = "ReporteadorChkFechaReporte";
            this.ReporteadorChkFechaReporte.Size = new System.Drawing.Size(162, 27);
            this.ReporteadorChkFechaReporte.TabIndex = 10;
            this.ReporteadorChkFechaReporte.Text = "Fecha del reporte";
            this.ReporteadorChkFechaReporte.UseVisualStyleBackColor = true;
            // 
            // ReporteadorTxtNombreReporte2
            // 
            this.ReporteadorTxtNombreReporte2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteadorTxtNombreReporte2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteadorTxtNombreReporte2.Location = new System.Drawing.Point(32, 354);
            this.ReporteadorTxtNombreReporte2.Name = "ReporteadorTxtNombreReporte2";
            this.ReporteadorTxtNombreReporte2.Size = new System.Drawing.Size(214, 33);
            this.ReporteadorTxtNombreReporte2.TabIndex = 11;
            // 
            // ReporteadorDtpFechaReporte
            // 
            this.ReporteadorDtpFechaReporte.CalendarFont = new System.Drawing.Font("Segoe UI", 12F);
            this.ReporteadorDtpFechaReporte.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ReporteadorDtpFechaReporte.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.ReporteadorDtpFechaReporte.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(118)))), ((int)(((byte)(63)))));
            this.ReporteadorDtpFechaReporte.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.ReporteadorDtpFechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReporteadorDtpFechaReporte.Location = new System.Drawing.Point(283, 353);
            this.ReporteadorDtpFechaReporte.MaxDate = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            this.ReporteadorDtpFechaReporte.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.ReporteadorDtpFechaReporte.Name = "ReporteadorDtpFechaReporte";
            this.ReporteadorDtpFechaReporte.Size = new System.Drawing.Size(162, 31);
            this.ReporteadorDtpFechaReporte.TabIndex = 12;
            // 
            // ReporteadorPnlFiltroBuscarReporte
            // 
            this.ReporteadorPnlFiltroBuscarReporte.Location = new System.Drawing.Point(12, 311);
            this.ReporteadorPnlFiltroBuscarReporte.Name = "ReporteadorPnlFiltroBuscarReporte";
            this.ReporteadorPnlFiltroBuscarReporte.Size = new System.Drawing.Size(462, 88);
            this.ReporteadorPnlFiltroBuscarReporte.TabIndex = 13;
            // 
            // BtnRuta
            // 
            this.BtnRuta.CampoTextoRuta = null;
            this.BtnRuta.Location = new System.Drawing.Point(718, 101);
            this.BtnRuta.Name = "BtnRuta";
            this.BtnRuta.Size = new System.Drawing.Size(56, 56);
            this.BtnRuta.TabIndex = 14;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(83, 227);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(56, 56);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.TxtNombreReporte = null;
            this.BtnGuardar.TxtRutaReporte = null;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(150, 227);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.RutaReporte = null;
            this.BtnImprimir.Size = new System.Drawing.Size(56, 56);
            this.BtnImprimir.TabIndex = 16;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(874, 661);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnRuta);
            this.Controls.Add(this.ReporteadorDtpFechaReporte);
            this.Controls.Add(this.ReporteadorTxtNombreReporte2);
            this.Controls.Add(this.ReporteadorChkFechaReporte);
            this.Controls.Add(this.ReporteadorChkNombreReporte);
            this.Controls.Add(this.ReporteadorDgvReportes);
            this.Controls.Add(this.ReporteadorTxtNombreReporte);
            this.Controls.Add(this.ReporteadorTxtRutaReporte);
            this.Controls.Add(this.ReporteadorLblDatosBuscarReporte);
            this.Controls.Add(this.ReporteadorLblNombreReporte);
            this.Controls.Add(this.ReporteadorLblRutaReporte);
            this.Controls.Add(this.ReporteadorPbLogo);
            this.Controls.Add(this.ReporteadorPbFooter);
            this.Controls.Add(this.ReporteadorPbBanner);
            this.Controls.Add(this.ReporteadorPnlFiltroBuscarReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(890, 700);
            this.MinimumSize = new System.Drawing.Size(890, 700);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3001 - ListaReportes";
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorPbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorPbFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorPbBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteadorDgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ReporteadorPbBanner;
        private System.Windows.Forms.PictureBox ReporteadorPbFooter;
        private System.Windows.Forms.PictureBox ReporteadorPbLogo;
        private System.Windows.Forms.Label ReporteadorLblRutaReporte;
        private System.Windows.Forms.Label ReporteadorLblNombreReporte;
        private System.Windows.Forms.Label ReporteadorLblDatosBuscarReporte;
        private System.Windows.Forms.TextBox ReporteadorTxtRutaReporte;
        private System.Windows.Forms.TextBox ReporteadorTxtNombreReporte;
        private System.Windows.Forms.DataGridView ReporteadorDgvReportes;
        private System.Windows.Forms.CheckBox ReporteadorChkNombreReporte;
        private System.Windows.Forms.CheckBox ReporteadorChkFechaReporte;
        private System.Windows.Forms.TextBox ReporteadorTxtNombreReporte2;
        private System.Windows.Forms.DateTimePicker ReporteadorDtpFechaReporte;
        private System.Windows.Forms.Panel ReporteadorPnlFiltroBuscarReporte;
        private CapaVista_BtnRuta.BtnRuta BtnRuta;
        private CapaVista_BtnGuardar.BtnGuardar BtnGuardar;
        private CapaVista_BtnImprimir.BtnImprimir BtnImprimir;
    }
}