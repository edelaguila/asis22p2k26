namespace CapaVista_BtnImprimir
{
    partial class BtnImprimir
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAccionImprimir =
                new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.btnAccionImprimir.BackColor =
                System.Drawing.Color.Transparent;

            this.btnAccionImprimir.BackgroundImageLayout =
                System.Windows.Forms.ImageLayout.Center;

            this.btnAccionImprimir.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnAccionImprimir.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.btnAccionImprimir.FlatAppearance.BorderSize = 0;

            this.btnAccionImprimir.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAccionImprimir.Image =
                global::CapaVista_BtnImprimir
                .Properties.Resources.btn_imprimir;

            this.btnAccionImprimir.Location =
                new System.Drawing.Point(0, 0);

            this.btnAccionImprimir.Name =
                "btnAccionImprimir";

            this.btnAccionImprimir.Size =
                new System.Drawing.Size(56, 56);

            this.btnAccionImprimir.TabIndex = 0;

            this.btnAccionImprimir.UseVisualStyleBackColor =
                false;

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.Controls.Add(this.btnAccionImprimir);

            this.Name = "BtnImprimir";

            this.Size =
                new System.Drawing.Size(56, 56);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAccionImprimir;
    }
}