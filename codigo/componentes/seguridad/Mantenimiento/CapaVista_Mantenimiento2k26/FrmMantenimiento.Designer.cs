namespace CapaVista_Mantenimiento2k26
{
    partial class FrmMantenimiento
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
            this.tbl_paciente = new System.Windows.Forms.DataGridView();
            this.nombrePaci = new System.Windows.Forms.TextBox();
            this.apellidoPaci = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generoPaci = new System.Windows.Forms.TextBox();
            this.direccionPaci = new System.Windows.Forms.TextBox();
            this.telefonoPaci = new System.Windows.Forms.TextBox();
            this.estadoPaci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.navegador1 = new CapaVista_Navegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_paciente
            // 
            this.tbl_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_paciente.Location = new System.Drawing.Point(29, 320);
            this.tbl_paciente.Name = "tbl_paciente";
            this.tbl_paciente.RowHeadersWidth = 51;
            this.tbl_paciente.RowTemplate.Height = 24;
            this.tbl_paciente.Size = new System.Drawing.Size(1422, 228);
            this.tbl_paciente.TabIndex = 0;
            // 
            // nombrePaci
            // 
            this.nombrePaci.Location = new System.Drawing.Point(29, 73);
            this.nombrePaci.Name = "nombrePaci";
            this.nombrePaci.Size = new System.Drawing.Size(224, 22);
            this.nombrePaci.TabIndex = 1;
            // 
            // apellidoPaci
            // 
            this.apellidoPaci.Location = new System.Drawing.Point(29, 156);
            this.apellidoPaci.Name = "apellidoPaci";
            this.apellidoPaci.Size = new System.Drawing.Size(224, 22);
            this.apellidoPaci.TabIndex = 2;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(29, 134);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(63, 16);
            this.Apellido.TabIndex = 3;
            this.Apellido.Text = "Apellido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // generoPaci
            // 
            this.generoPaci.Location = new System.Drawing.Point(299, 73);
            this.generoPaci.Name = "generoPaci";
            this.generoPaci.Size = new System.Drawing.Size(224, 22);
            this.generoPaci.TabIndex = 5;
            // 
            // direccionPaci
            // 
            this.direccionPaci.Location = new System.Drawing.Point(299, 156);
            this.direccionPaci.Name = "direccionPaci";
            this.direccionPaci.Size = new System.Drawing.Size(224, 22);
            this.direccionPaci.TabIndex = 6;
            // 
            // telefonoPaci
            // 
            this.telefonoPaci.Location = new System.Drawing.Point(564, 73);
            this.telefonoPaci.Name = "telefonoPaci";
            this.telefonoPaci.Size = new System.Drawing.Size(224, 22);
            this.telefonoPaci.TabIndex = 7;
            // 
            // estadoPaci
            // 
            this.estadoPaci.Location = new System.Drawing.Point(564, 156);
            this.estadoPaci.Name = "estadoPaci";
            this.estadoPaci.Size = new System.Drawing.Size(224, 22);
            this.estadoPaci.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Genero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dirección: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado: ";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(26, 203);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 13;
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 560);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.estadoPaci);
            this.Controls.Add(this.telefonoPaci);
            this.Controls.Add(this.direccionPaci);
            this.Controls.Add(this.generoPaci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.apellidoPaci);
            this.Controls.Add(this.nombrePaci);
            this.Controls.Add(this.tbl_paciente);
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_paciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbl_paciente;
        private System.Windows.Forms.TextBox nombrePaci;
        private System.Windows.Forms.TextBox apellidoPaci;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox generoPaci;
        private System.Windows.Forms.TextBox direccionPaci;
        private System.Windows.Forms.TextBox telefonoPaci;
        private System.Windows.Forms.TextBox estadoPaci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CapaVista_Navegador.Navegador navegador1;
    }
}