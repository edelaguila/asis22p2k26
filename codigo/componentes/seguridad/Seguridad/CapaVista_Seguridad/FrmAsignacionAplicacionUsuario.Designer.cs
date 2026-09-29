namespace CapaVista_Seguridad
{
    partial class FrmAsignacionAplicacionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionAplicacionUsuario));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.SeguridadGbxDatos = new System.Windows.Forms.GroupBox();
            this.SeguridadCboAplicacion = new System.Windows.Forms.ComboBox();
            this.SeguridadCboModulo = new System.Windows.Forms.ComboBox();
            this.SeguridadCboUsuario = new System.Windows.Forms.ComboBox();
            this.SeguridadLblUsuario = new System.Windows.Forms.Label();
            this.SeguridadLblModulo = new System.Windows.Forms.Label();
            this.SeguridadLblAplicacion = new System.Windows.Forms.Label();
            this.colIngresar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeguridadDgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.SeguridadGbxAsignaciones = new System.Windows.Forms.GroupBox();
            this.SeguridadBtnInsertar = new System.Windows.Forms.Button();
            this.SeguridadBtnSalir = new System.Windows.Forms.Button();
            this.SeguridadBtnQuitar = new System.Windows.Forms.Button();
            this.SeguridadBtnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SeguridadPnlEncabezado = new System.Windows.Forms.Panel();
            this.SeguridadBtnAyuda = new System.Windows.Forms.Button();
            this.SeguridadPbMascota = new System.Windows.Forms.PictureBox();
            this.SeguridadLblDescripcion = new System.Windows.Forms.Label();
            this.SeguridadLblTitulo = new System.Windows.Forms.Label();
            this.SeguridadPbIconoAsignacion = new System.Windows.Forms.PictureBox();
            this.SeguridadGbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvAsignaciones)).BeginInit();
            this.SeguridadGbxAsignaciones.SuspendLayout();
            this.SeguridadPnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbIconoAsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(786, -55);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(75, 23);
            this.btnAyuda.TabIndex = 21;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // SeguridadGbxDatos
            // 
            this.SeguridadGbxDatos.Controls.Add(this.SeguridadCboAplicacion);
            this.SeguridadGbxDatos.Controls.Add(this.SeguridadCboModulo);
            this.SeguridadGbxDatos.Controls.Add(this.SeguridadCboUsuario);
            this.SeguridadGbxDatos.Controls.Add(this.SeguridadLblUsuario);
            this.SeguridadGbxDatos.Controls.Add(this.SeguridadLblModulo);
            this.SeguridadGbxDatos.Controls.Add(this.SeguridadLblAplicacion);
            this.SeguridadGbxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadGbxDatos.Location = new System.Drawing.Point(12, 190);
            this.SeguridadGbxDatos.Name = "SeguridadGbxDatos";
            this.SeguridadGbxDatos.Size = new System.Drawing.Size(943, 115);
            this.SeguridadGbxDatos.TabIndex = 19;
            this.SeguridadGbxDatos.TabStop = false;
            this.SeguridadGbxDatos.Text = "Datos";
            // 
            // SeguridadCboAplicacion
            // 
            this.SeguridadCboAplicacion.DropDownWidth = 180;
            this.SeguridadCboAplicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadCboAplicacion.FormattingEnabled = true;
            this.SeguridadCboAplicacion.Location = new System.Drawing.Point(385, 66);
            this.SeguridadCboAplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadCboAplicacion.Name = "SeguridadCboAplicacion";
            this.SeguridadCboAplicacion.Size = new System.Drawing.Size(163, 33);
            this.SeguridadCboAplicacion.TabIndex = 10;
            // 
            // SeguridadCboModulo
            // 
            this.SeguridadCboModulo.DropDownWidth = 180;
            this.SeguridadCboModulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadCboModulo.FormattingEnabled = true;
            this.SeguridadCboModulo.Location = new System.Drawing.Point(189, 66);
            this.SeguridadCboModulo.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadCboModulo.Name = "SeguridadCboModulo";
            this.SeguridadCboModulo.Size = new System.Drawing.Size(163, 33);
            this.SeguridadCboModulo.TabIndex = 9;
            // 
            // SeguridadCboUsuario
            // 
            this.SeguridadCboUsuario.DropDownWidth = 180;
            this.SeguridadCboUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadCboUsuario.FormattingEnabled = true;
            this.SeguridadCboUsuario.Location = new System.Drawing.Point(5, 66);
            this.SeguridadCboUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadCboUsuario.Name = "SeguridadCboUsuario";
            this.SeguridadCboUsuario.Size = new System.Drawing.Size(163, 33);
            this.SeguridadCboUsuario.TabIndex = 8;
            // 
            // SeguridadLblUsuario
            // 
            this.SeguridadLblUsuario.AutoSize = true;
            this.SeguridadLblUsuario.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblUsuario.Location = new System.Drawing.Point(6, 41);
            this.SeguridadLblUsuario.Name = "SeguridadLblUsuario";
            this.SeguridadLblUsuario.Size = new System.Drawing.Size(66, 21);
            this.SeguridadLblUsuario.TabIndex = 1;
            this.SeguridadLblUsuario.Text = "Usuario";
            // 
            // SeguridadLblModulo
            // 
            this.SeguridadLblModulo.AutoSize = true;
            this.SeguridadLblModulo.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblModulo.Location = new System.Drawing.Point(197, 41);
            this.SeguridadLblModulo.Name = "SeguridadLblModulo";
            this.SeguridadLblModulo.Size = new System.Drawing.Size(63, 21);
            this.SeguridadLblModulo.TabIndex = 3;
            this.SeguridadLblModulo.Text = "Módulo";
            // 
            // SeguridadLblAplicacion
            // 
            this.SeguridadLblAplicacion.AutoSize = true;
            this.SeguridadLblAplicacion.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblAplicacion.Location = new System.Drawing.Point(399, 41);
            this.SeguridadLblAplicacion.Name = "SeguridadLblAplicacion";
            this.SeguridadLblAplicacion.Size = new System.Drawing.Size(85, 21);
            this.SeguridadLblAplicacion.TabIndex = 5;
            this.SeguridadLblAplicacion.Text = "Aplicación";
            // 
            // colIngresar
            // 
            this.colIngresar.HeaderText = "Ingresar";
            this.colIngresar.MinimumWidth = 6;
            this.colIngresar.Name = "colIngresar";
            this.colIngresar.ReadOnly = true;
            // 
            // colAplicacion
            // 
            this.colAplicacion.HeaderText = "Aplicación";
            this.colAplicacion.MinimumWidth = 6;
            this.colAplicacion.Name = "colAplicacion";
            this.colAplicacion.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.MinimumWidth = 6;
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // SeguridadDgvAsignaciones
            // 
            this.SeguridadDgvAsignaciones.AllowUserToAddRows = false;
            this.SeguridadDgvAsignaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.SeguridadDgvAsignaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SeguridadDgvAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeguridadDgvAsignaciones.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SeguridadDgvAsignaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SeguridadDgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeguridadDgvAsignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuario,
            this.colAplicacion,
            this.colIngresar});
            this.SeguridadDgvAsignaciones.EnableHeadersVisualStyles = false;
            this.SeguridadDgvAsignaciones.Location = new System.Drawing.Point(9, 20);
            this.SeguridadDgvAsignaciones.MultiSelect = false;
            this.SeguridadDgvAsignaciones.Name = "SeguridadDgvAsignaciones";
            this.SeguridadDgvAsignaciones.ReadOnly = true;
            this.SeguridadDgvAsignaciones.RowHeadersVisible = false;
            this.SeguridadDgvAsignaciones.RowHeadersWidth = 51;
            this.SeguridadDgvAsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SeguridadDgvAsignaciones.Size = new System.Drawing.Size(692, 277);
            this.SeguridadDgvAsignaciones.TabIndex = 13;
            // 
            // SeguridadGbxAsignaciones
            // 
            this.SeguridadGbxAsignaciones.Controls.Add(this.SeguridadBtnInsertar);
            this.SeguridadGbxAsignaciones.Controls.Add(this.SeguridadBtnSalir);
            this.SeguridadGbxAsignaciones.Controls.Add(this.SeguridadBtnQuitar);
            this.SeguridadGbxAsignaciones.Controls.Add(this.SeguridadBtnBuscar);
            this.SeguridadGbxAsignaciones.Controls.Add(this.SeguridadDgvAsignaciones);
            this.SeguridadGbxAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadGbxAsignaciones.Location = new System.Drawing.Point(12, 329);
            this.SeguridadGbxAsignaciones.Name = "SeguridadGbxAsignaciones";
            this.SeguridadGbxAsignaciones.Size = new System.Drawing.Size(943, 315);
            this.SeguridadGbxAsignaciones.TabIndex = 20;
            this.SeguridadGbxAsignaciones.TabStop = false;
            this.SeguridadGbxAsignaciones.Text = "Asignaciones";
            // 
            // SeguridadBtnInsertar
            // 
            this.SeguridadBtnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.SeguridadBtnInsertar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_guardarN;
            this.SeguridadBtnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnInsertar.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.SeguridadBtnInsertar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnInsertar.Location = new System.Drawing.Point(741, 142);
            this.SeguridadBtnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnInsertar.Name = "SeguridadBtnInsertar";
            this.SeguridadBtnInsertar.Size = new System.Drawing.Size(74, 74);
            this.SeguridadBtnInsertar.TabIndex = 17;
            this.SeguridadBtnInsertar.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnSalir
            // 
            this.SeguridadBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.SeguridadBtnSalir.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_salirN;
            this.SeguridadBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnSalir.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.SeguridadBtnSalir.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnSalir.Location = new System.Drawing.Point(828, 142);
            this.SeguridadBtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnSalir.Name = "SeguridadBtnSalir";
            this.SeguridadBtnSalir.Size = new System.Drawing.Size(74, 74);
            this.SeguridadBtnSalir.TabIndex = 16;
            this.SeguridadBtnSalir.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnQuitar
            // 
            this.SeguridadBtnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.SeguridadBtnQuitar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_eliminarN;
            this.SeguridadBtnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnQuitar.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.SeguridadBtnQuitar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnQuitar.Location = new System.Drawing.Point(828, 42);
            this.SeguridadBtnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnQuitar.Name = "SeguridadBtnQuitar";
            this.SeguridadBtnQuitar.Size = new System.Drawing.Size(74, 74);
            this.SeguridadBtnQuitar.TabIndex = 15;
            this.SeguridadBtnQuitar.UseVisualStyleBackColor = false;
            // 
            // SeguridadBtnBuscar
            // 
            this.SeguridadBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.SeguridadBtnBuscar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.Buscar;
            this.SeguridadBtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnBuscar.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.SeguridadBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnBuscar.Location = new System.Drawing.Point(741, 42);
            this.SeguridadBtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnBuscar.Name = "SeguridadBtnBuscar";
            this.SeguridadBtnBuscar.Size = new System.Drawing.Size(74, 74);
            this.SeguridadBtnBuscar.TabIndex = 14;
            this.SeguridadBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-60, -67);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 24);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Asignación de Aplicación a Usuario";
            // 
            // SeguridadPnlEncabezado
            // 
            this.SeguridadPnlEncabezado.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.panel_fondo;
            this.SeguridadPnlEncabezado.Controls.Add(this.SeguridadBtnAyuda);
            this.SeguridadPnlEncabezado.Controls.Add(this.SeguridadPbMascota);
            this.SeguridadPnlEncabezado.Controls.Add(this.SeguridadLblDescripcion);
            this.SeguridadPnlEncabezado.Controls.Add(this.SeguridadLblTitulo);
            this.SeguridadPnlEncabezado.Controls.Add(this.SeguridadPbIconoAsignacion);
            this.SeguridadPnlEncabezado.Location = new System.Drawing.Point(2, 11);
            this.SeguridadPnlEncabezado.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadPnlEncabezado.Name = "SeguridadPnlEncabezado";
            this.SeguridadPnlEncabezado.Size = new System.Drawing.Size(1017, 154);
            this.SeguridadPnlEncabezado.TabIndex = 24;
            // 
            // SeguridadBtnAyuda
            // 
            this.SeguridadBtnAyuda.Image = global::CapaVista_Seguridad.Properties.Resources.btn_ayuda;
            this.SeguridadBtnAyuda.Location = new System.Drawing.Point(859, 23);
            this.SeguridadBtnAyuda.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadBtnAyuda.Name = "SeguridadBtnAyuda";
            this.SeguridadBtnAyuda.Size = new System.Drawing.Size(94, 103);
            this.SeguridadBtnAyuda.TabIndex = 4;
            this.SeguridadBtnAyuda.UseVisualStyleBackColor = true;
            // 
            // SeguridadPbMascota
            // 
            this.SeguridadPbMascota.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadPbMascota.Image = global::CapaVista_Seguridad.Properties.Resources._8;
            this.SeguridadPbMascota.Location = new System.Drawing.Point(619, 11);
            this.SeguridadPbMascota.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadPbMascota.Name = "SeguridadPbMascota";
            this.SeguridadPbMascota.Size = new System.Drawing.Size(92, 133);
            this.SeguridadPbMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeguridadPbMascota.TabIndex = 3;
            this.SeguridadPbMascota.TabStop = false;
            // 
            // SeguridadLblDescripcion
            // 
            this.SeguridadLblDescripcion.AutoSize = true;
            this.SeguridadLblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadLblDescripcion.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblDescripcion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SeguridadLblDescripcion.Location = new System.Drawing.Point(178, 91);
            this.SeguridadLblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeguridadLblDescripcion.Name = "SeguridadLblDescripcion";
            this.SeguridadLblDescripcion.Size = new System.Drawing.Size(338, 18);
            this.SeguridadLblDescripcion.TabIndex = 2;
            this.SeguridadLblDescripcion.Text = "Administra la asignación de aplicaciones a usuarios.";
            // 
            // SeguridadLblTitulo
            // 
            this.SeguridadLblTitulo.AutoSize = true;
            this.SeguridadLblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadLblTitulo.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.SeguridadLblTitulo.Location = new System.Drawing.Point(176, 57);
            this.SeguridadLblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeguridadLblTitulo.Name = "SeguridadLblTitulo";
            this.SeguridadLblTitulo.Size = new System.Drawing.Size(410, 25);
            this.SeguridadLblTitulo.TabIndex = 1;
            this.SeguridadLblTitulo.Text = "Asignación de Aplicación a Usuario";
            // 
            // SeguridadPbIconoAsignacion
            // 
            this.SeguridadPbIconoAsignacion.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadPbIconoAsignacion.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.Btn_prf_apl;
            this.SeguridadPbIconoAsignacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadPbIconoAsignacion.Location = new System.Drawing.Point(57, 11);
            this.SeguridadPbIconoAsignacion.Margin = new System.Windows.Forms.Padding(2);
            this.SeguridadPbIconoAsignacion.Name = "SeguridadPbIconoAsignacion";
            this.SeguridadPbIconoAsignacion.Size = new System.Drawing.Size(104, 119);
            this.SeguridadPbIconoAsignacion.TabIndex = 0;
            this.SeguridadPbIconoAsignacion.TabStop = false;
            // 
            // FrmAsignacionAplicacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1051, 656);
            this.Controls.Add(this.SeguridadPnlEncabezado);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.SeguridadGbxDatos);
            this.Controls.Add(this.SeguridadGbxAsignaciones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAsignacionAplicacionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2011 - Asignación de Aplicación a Usuario";
            this.SeguridadGbxDatos.ResumeLayout(false);
            this.SeguridadGbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvAsignaciones)).EndInit();
            this.SeguridadGbxAsignaciones.ResumeLayout(false);
            this.SeguridadPnlEncabezado.ResumeLayout(false);
            this.SeguridadPnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPbIconoAsignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.GroupBox SeguridadGbxDatos;
        private System.Windows.Forms.Label SeguridadLblUsuario;
        private System.Windows.Forms.Label SeguridadLblModulo;
        private System.Windows.Forms.Label SeguridadLblAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridView SeguridadDgvAsignaciones;
        private System.Windows.Forms.GroupBox SeguridadGbxAsignaciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel SeguridadPnlEncabezado;
        private System.Windows.Forms.Button SeguridadBtnAyuda;
        private System.Windows.Forms.PictureBox SeguridadPbMascota;
        private System.Windows.Forms.Label SeguridadLblDescripcion;
        private System.Windows.Forms.Label SeguridadLblTitulo;
        private System.Windows.Forms.PictureBox SeguridadPbIconoAsignacion;
        private System.Windows.Forms.Button SeguridadBtnBuscar;
        private System.Windows.Forms.Button SeguridadBtnQuitar;
        private System.Windows.Forms.Button SeguridadBtnSalir;
        private System.Windows.Forms.Button SeguridadBtnInsertar;
        private System.Windows.Forms.ComboBox SeguridadCboAplicacion;
        private System.Windows.Forms.ComboBox SeguridadCboModulo;
        private System.Windows.Forms.ComboBox SeguridadCboUsuario;
    }
}