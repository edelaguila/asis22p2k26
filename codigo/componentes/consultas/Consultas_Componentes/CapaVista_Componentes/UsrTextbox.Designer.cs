namespace CapaVista_Componentes
{
    partial class UsrTextbox
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
            this.ConsultasTlpCampo = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTxtCampo = new CapaVista_Componentes.ClsCajaTextoConsultas();
            this.ConsultasLblError = new CapaVista_Componentes.ClsEtiquetaConsultas();
            this.ConsultasTlpCampo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpCampo
            // 
            this.ConsultasTlpCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTlpCampo.BackColor = System.Drawing.Color.Blue;
            this.ConsultasTlpCampo.ColumnCount = 1;
            this.ConsultasTlpCampo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpCampo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpCampo.Controls.Add(this.ConsultasTxtCampo, 0, 0);
            this.ConsultasTlpCampo.Location = new System.Drawing.Point(3, 3);
            this.ConsultasTlpCampo.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpCampo.MaximumSize = new System.Drawing.Size(1000, 30);
            this.ConsultasTlpCampo.MinimumSize = new System.Drawing.Size(10, 30);
            this.ConsultasTlpCampo.Name = "ConsultasTlpCampo";
            this.ConsultasTlpCampo.Padding = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpCampo.RowCount = 1;
            this.ConsultasTlpCampo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpCampo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ConsultasTlpCampo.Size = new System.Drawing.Size(366, 30);
            this.ConsultasTlpCampo.TabIndex = 2;
            // 
            // ConsultasTxtCampo
            // 
            this.ConsultasTxtCampo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTxtCampo.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtCampo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtCampo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtCampo.Location = new System.Drawing.Point(2, 2);
            this.ConsultasTxtCampo.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTxtCampo.MaxLength = 50;
            this.ConsultasTxtCampo.Name = "ConsultasTxtCampo";
            this.ConsultasTxtCampo.Size = new System.Drawing.Size(362, 30);
            this.ConsultasTxtCampo.TabIndex = 4;
            // 
            // ConsultasLblError
            // 
            this.ConsultasLblError.AutoSize = true;
            this.ConsultasLblError.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblError.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultasLblError.ForeColor = System.Drawing.Color.Red;
            this.ConsultasLblError.Location = new System.Drawing.Point(5, 44);
            this.ConsultasLblError.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLblError.Name = "ConsultasLblError";
            this.ConsultasLblError.Size = new System.Drawing.Size(36, 16);
            this.ConsultasLblError.TabIndex = 3;
            this.ConsultasLblError.Text = "Error";
            this.ConsultasLblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsrTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ConsultasLblError);
            this.Controls.Add(this.ConsultasTlpCampo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UsrTextbox";
            this.Size = new System.Drawing.Size(369, 80);
            this.ConsultasTlpCampo.ResumeLayout(false);
            this.ConsultasTlpCampo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpCampo;
        private CapaVista_Componentes.ClsEtiquetaConsultas ConsultasLblError;
        private ClsCajaTextoConsultas ConsultasTxtCampo;
    }
}
