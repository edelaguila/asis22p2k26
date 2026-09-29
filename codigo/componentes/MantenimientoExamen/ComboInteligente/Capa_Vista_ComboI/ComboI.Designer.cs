namespace Capa_Vista_ComboI
{
    partial class ComboI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPrueba = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboPrueba
            // 
            this.cboPrueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPrueba.FormattingEnabled = true;
            this.cboPrueba.Location = new System.Drawing.Point(0, 0);
            this.cboPrueba.Name = "cboPrueba";
            this.cboPrueba.Size = new System.Drawing.Size(599, 24);
            this.cboPrueba.TabIndex = 0;
            // 
            // ComboI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboPrueba);
            this.Name = "ComboI";
            this.Size = new System.Drawing.Size(599, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPrueba;
    }
}
