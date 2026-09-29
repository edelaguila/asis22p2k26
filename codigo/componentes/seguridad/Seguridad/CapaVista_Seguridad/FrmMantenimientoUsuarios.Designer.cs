namespace CapaVista_Seguridad
{
    partial class FrmMantenimientoUsuarios
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoUsuarios));
            this.SeguridadLblTitulo = new System.Windows.Forms.Label();
            this.SeguridadLblEmpleado = new System.Windows.Forms.Label();
            this.SeguridadCboEmpleado = new System.Windows.Forms.ComboBox();
            this.SeguridadLblIdEmpleado = new System.Windows.Forms.Label();
            this.SeguridadTxtIdEmpleado = new System.Windows.Forms.TextBox();
            this.SeguridadLblContrasena = new System.Windows.Forms.Label();
            this.SeguridadTxtContrasena = new System.Windows.Forms.TextBox();
            this.SeguridadLblConfirmarContrasena = new System.Windows.Forms.Label();
            this.SeguridadTxtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.pnlIngresoDatos = new System.Windows.Forms.Panel();
            this.SeguridadChkMostrarContra = new System.Windows.Forms.CheckBox();
            this.SeguridadChkActivo = new System.Windows.Forms.CheckBox();
            this.SeguridadTxtUsuario = new System.Windows.Forms.TextBox();
            this.SeguridadLblUsuario = new System.Windows.Forms.Label();
            this.SeguridadLblEstado = new System.Windows.Forms.Label();
            this.SeguridadPicMascota = new System.Windows.Forms.PictureBox();
            this.SeguridadDgvUsuarios = new System.Windows.Forms.DataGridView();
            this.SeguridadBtnModificar = new System.Windows.Forms.Button();
            this.SeguridadBtnSalir = new System.Windows.Forms.Button();
            this.SeguridadBtnReporte = new System.Windows.Forms.Button();
            this.SeguridadBtnLimpiar = new System.Windows.Forms.Button();
            this.SeguridadBtnGuardar = new System.Windows.Forms.Button();
            this.SeguridadBtnAyuda = new System.Windows.Forms.Button();
            this.SeguridadPicCrearUsuario = new System.Windows.Forms.PictureBox();
            this.SeguridadBtnConsultar = new System.Windows.Forms.Button();
            this.SeguridadTxtConsultar = new System.Windows.Forms.TextBox();
            this.SeguridadBtnRefrescar = new System.Windows.Forms.Button();
            this.SeguridadBtnInicio = new System.Windows.Forms.Button();
            this.SeguridadBtnAnterior = new System.Windows.Forms.Button();
            this.SeguridadBtnSiguiente = new System.Windows.Forms.Button();
            this.SeguridadBtnFin = new System.Windows.Forms.Button();
            this.pnlIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPicMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPicCrearUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // SeguridadLblTitulo
            // 
            this.SeguridadLblTitulo.AutoSize = true;
            this.SeguridadLblTitulo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.SeguridadLblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblTitulo.Location = new System.Drawing.Point(267, 0);
            this.SeguridadLblTitulo.Name = "SeguridadLblTitulo";
            this.SeguridadLblTitulo.Size = new System.Drawing.Size(259, 50);
            this.SeguridadLblTitulo.TabIndex = 0;
            this.SeguridadLblTitulo.Text = "Crear Usuario";
            // 
            // SeguridadLblEmpleado
            // 
            this.SeguridadLblEmpleado.AutoSize = true;
            this.SeguridadLblEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblEmpleado.Location = new System.Drawing.Point(77, 30);
            this.SeguridadLblEmpleado.Name = "SeguridadLblEmpleado";
            this.SeguridadLblEmpleado.Size = new System.Drawing.Size(95, 23);
            this.SeguridadLblEmpleado.TabIndex = 2;
            this.SeguridadLblEmpleado.Text = "Empleado:";
            // 
            // SeguridadCboEmpleado
            // 
            this.SeguridadCboEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.SeguridadCboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeguridadCboEmpleado.FormattingEnabled = true;
            this.SeguridadCboEmpleado.Location = new System.Drawing.Point(289, 30);
            this.SeguridadCboEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadCboEmpleado.Name = "SeguridadCboEmpleado";
            this.SeguridadCboEmpleado.Size = new System.Drawing.Size(383, 24);
            this.SeguridadCboEmpleado.TabIndex = 3;
            // 
            // SeguridadLblIdEmpleado
            // 
            this.SeguridadLblIdEmpleado.AutoSize = true;
            this.SeguridadLblIdEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblIdEmpleado.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblIdEmpleado.Location = new System.Drawing.Point(77, 66);
            this.SeguridadLblIdEmpleado.Name = "SeguridadLblIdEmpleado";
            this.SeguridadLblIdEmpleado.Size = new System.Drawing.Size(111, 23);
            this.SeguridadLblIdEmpleado.TabIndex = 4;
            this.SeguridadLblIdEmpleado.Text = "Id Empleado";
            // 
            // SeguridadTxtIdEmpleado
            // 
            this.SeguridadTxtIdEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.SeguridadTxtIdEmpleado.Enabled = false;
            this.SeguridadTxtIdEmpleado.Location = new System.Drawing.Point(288, 66);
            this.SeguridadTxtIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtIdEmpleado.Name = "SeguridadTxtIdEmpleado";
            this.SeguridadTxtIdEmpleado.ReadOnly = true;
            this.SeguridadTxtIdEmpleado.Size = new System.Drawing.Size(80, 22);
            this.SeguridadTxtIdEmpleado.TabIndex = 5;
            this.SeguridadTxtIdEmpleado.TabStop = false;
            // 
            // SeguridadLblContrasena
            // 
            this.SeguridadLblContrasena.AutoSize = true;
            this.SeguridadLblContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblContrasena.Location = new System.Drawing.Point(77, 153);
            this.SeguridadLblContrasena.Name = "SeguridadLblContrasena";
            this.SeguridadLblContrasena.Size = new System.Drawing.Size(104, 23);
            this.SeguridadLblContrasena.TabIndex = 6;
            this.SeguridadLblContrasena.Text = "Contraseña:";
            // 
            // SeguridadTxtContrasena
            // 
            this.SeguridadTxtContrasena.BackColor = System.Drawing.Color.White;
            this.SeguridadTxtContrasena.Location = new System.Drawing.Point(289, 153);
            this.SeguridadTxtContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtContrasena.Name = "SeguridadTxtContrasena";
            this.SeguridadTxtContrasena.PasswordChar = '*';
            this.SeguridadTxtContrasena.Size = new System.Drawing.Size(288, 22);
            this.SeguridadTxtContrasena.TabIndex = 7;
            // 
            // SeguridadLblConfirmarContrasena
            // 
            this.SeguridadLblConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblConfirmarContrasena.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblConfirmarContrasena.Location = new System.Drawing.Point(72, 186);
            this.SeguridadLblConfirmarContrasena.Name = "SeguridadLblConfirmarContrasena";
            this.SeguridadLblConfirmarContrasena.Size = new System.Drawing.Size(203, 42);
            this.SeguridadLblConfirmarContrasena.TabIndex = 8;
            this.SeguridadLblConfirmarContrasena.Text = "Confirmar Contraseña:";
            this.SeguridadLblConfirmarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeguridadLblConfirmarContrasena.UseCompatibleTextRendering = true;
            // 
            // SeguridadTxtConfirmarContrasena
            // 
            this.SeguridadTxtConfirmarContrasena.BackColor = System.Drawing.Color.White;
            this.SeguridadTxtConfirmarContrasena.Location = new System.Drawing.Point(289, 197);
            this.SeguridadTxtConfirmarContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtConfirmarContrasena.Name = "SeguridadTxtConfirmarContrasena";
            this.SeguridadTxtConfirmarContrasena.PasswordChar = '*';
            this.SeguridadTxtConfirmarContrasena.Size = new System.Drawing.Size(288, 22);
            this.SeguridadTxtConfirmarContrasena.TabIndex = 9;
            // 
            // pnlIngresoDatos
            // 
            this.pnlIngresoDatos.BackColor = System.Drawing.Color.OldLace;
            this.pnlIngresoDatos.Controls.Add(this.SeguridadChkMostrarContra);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadChkActivo);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtUsuario);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadLblUsuario);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadLblEstado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadLblEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadPicMascota);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadCboEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadLblIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtIdEmpleado);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtContrasena);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadTxtConfirmarContrasena);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadLblContrasena);
            this.pnlIngresoDatos.Controls.Add(this.SeguridadLblConfirmarContrasena);
            this.pnlIngresoDatos.Location = new System.Drawing.Point(301, 132);
            this.pnlIngresoDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIngresoDatos.Name = "pnlIngresoDatos";
            this.pnlIngresoDatos.Size = new System.Drawing.Size(955, 304);
            this.pnlIngresoDatos.TabIndex = 16;
            // 
            // SeguridadChkMostrarContra
            // 
            this.SeguridadChkMostrarContra.AutoSize = true;
            this.SeguridadChkMostrarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadChkMostrarContra.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadChkMostrarContra.Location = new System.Drawing.Point(585, 153);
            this.SeguridadChkMostrarContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadChkMostrarContra.Name = "SeguridadChkMostrarContra";
            this.SeguridadChkMostrarContra.Size = new System.Drawing.Size(52, 24);
            this.SeguridadChkMostrarContra.TabIndex = 15;
            this.SeguridadChkMostrarContra.Text = "👁 ";
            this.SeguridadChkMostrarContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SeguridadChkMostrarContra.UseVisualStyleBackColor = true;
            this.SeguridadChkMostrarContra.CheckedChanged += new System.EventHandler(this.SeguridadChkMostrarContra_CheckedChanged);
            // 
            // SeguridadChkActivo
            // 
            this.SeguridadChkActivo.AutoSize = true;
            this.SeguridadChkActivo.Checked = true;
            this.SeguridadChkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SeguridadChkActivo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SeguridadChkActivo.ForeColor = System.Drawing.Color.DimGray;
            this.SeguridadChkActivo.Location = new System.Drawing.Point(289, 257);
            this.SeguridadChkActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadChkActivo.Name = "SeguridadChkActivo";
            this.SeguridadChkActivo.Size = new System.Drawing.Size(78, 25);
            this.SeguridadChkActivo.TabIndex = 14;
            this.SeguridadChkActivo.Text = "Activo";
            // 
            // SeguridadTxtUsuario
            // 
            this.SeguridadTxtUsuario.Location = new System.Drawing.Point(288, 103);
            this.SeguridadTxtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadTxtUsuario.Name = "SeguridadTxtUsuario";
            this.SeguridadTxtUsuario.Size = new System.Drawing.Size(376, 22);
            this.SeguridadTxtUsuario.TabIndex = 13;
            // 
            // SeguridadLblUsuario
            // 
            this.SeguridadLblUsuario.AutoSize = true;
            this.SeguridadLblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblUsuario.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblUsuario.Location = new System.Drawing.Point(77, 103);
            this.SeguridadLblUsuario.Name = "SeguridadLblUsuario";
            this.SeguridadLblUsuario.Size = new System.Drawing.Size(70, 23);
            this.SeguridadLblUsuario.TabIndex = 12;
            this.SeguridadLblUsuario.Text = "Usuario";
            // 
            // SeguridadLblEstado
            // 
            this.SeguridadLblEstado.AutoSize = true;
            this.SeguridadLblEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeguridadLblEstado.ForeColor = System.Drawing.Color.DarkCyan;
            this.SeguridadLblEstado.Location = new System.Drawing.Point(85, 257);
            this.SeguridadLblEstado.Name = "SeguridadLblEstado";
            this.SeguridadLblEstado.Size = new System.Drawing.Size(63, 23);
            this.SeguridadLblEstado.TabIndex = 10;
            this.SeguridadLblEstado.Text = "Estado";
            // 
            // SeguridadPicMascota
            // 
            this.SeguridadPicMascota.Image = global::CapaVista_Seguridad.Properties.Resources._5;
            this.SeguridadPicMascota.Location = new System.Drawing.Point(717, 16);
            this.SeguridadPicMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadPicMascota.Name = "SeguridadPicMascota";
            this.SeguridadPicMascota.Size = new System.Drawing.Size(235, 267);
            this.SeguridadPicMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeguridadPicMascota.TabIndex = 19;
            this.SeguridadPicMascota.TabStop = false;
            // 
            // SeguridadDgvUsuarios
            // 
            this.SeguridadDgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeguridadDgvUsuarios.Location = new System.Drawing.Point(411, 460);
            this.SeguridadDgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadDgvUsuarios.Name = "SeguridadDgvUsuarios";
            this.SeguridadDgvUsuarios.RowHeadersWidth = 51;
            this.SeguridadDgvUsuarios.RowTemplate.Height = 24;
            this.SeguridadDgvUsuarios.Size = new System.Drawing.Size(748, 217);
            this.SeguridadDgvUsuarios.TabIndex = 21;
            this.SeguridadDgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeguridadDgvUsuarios_CellContentClick);
            // 
            // SeguridadBtnModificar
            // 
            this.SeguridadBtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnModificar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_modificarN;
            this.SeguridadBtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnModificar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnModificar.Location = new System.Drawing.Point(391, 52);
            this.SeguridadBtnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnModificar.Name = "SeguridadBtnModificar";
            this.SeguridadBtnModificar.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnModificar.TabIndex = 20;
            this.SeguridadBtnModificar.UseVisualStyleBackColor = false;
            this.SeguridadBtnModificar.Click += new System.EventHandler(this.SeguridadBtnModificar_Click);
            // 
            // SeguridadBtnSalir
            // 
            this.SeguridadBtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnSalir.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_salirN;
            this.SeguridadBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnSalir.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnSalir.Location = new System.Drawing.Point(561, 52);
            this.SeguridadBtnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnSalir.Name = "SeguridadBtnSalir";
            this.SeguridadBtnSalir.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnSalir.TabIndex = 14;
            this.SeguridadBtnSalir.UseVisualStyleBackColor = false;
            this.SeguridadBtnSalir.Click += new System.EventHandler(this.SeguridadBtnSalir_Click);
            // 
            // SeguridadBtnReporte
            // 
            this.SeguridadBtnReporte.BackColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.SeguridadBtnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnReporte.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnReporte.Location = new System.Drawing.Point(15, 96);
            this.SeguridadBtnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnReporte.Name = "SeguridadBtnReporte";
            this.SeguridadBtnReporte.Size = new System.Drawing.Size(91, 86);
            this.SeguridadBtnReporte.TabIndex = 11;
            this.SeguridadBtnReporte.UseVisualStyleBackColor = false;
            this.SeguridadBtnReporte.Click += new System.EventHandler(this.SeguridadBtnReporte_Click);
            // 
            // SeguridadBtnLimpiar
            // 
            this.SeguridadBtnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnLimpiar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_eliminarN;
            this.SeguridadBtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnLimpiar.Location = new System.Drawing.Point(476, 52);
            this.SeguridadBtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnLimpiar.Name = "SeguridadBtnLimpiar";
            this.SeguridadBtnLimpiar.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnLimpiar.TabIndex = 13;
            this.SeguridadBtnLimpiar.UseVisualStyleBackColor = false;
            this.SeguridadBtnLimpiar.Click += new System.EventHandler(this.SeguridadBtnLimpiar_Click);
            // 
            // SeguridadBtnGuardar
            // 
            this.SeguridadBtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnGuardar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_guardarN;
            this.SeguridadBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnGuardar.Location = new System.Drawing.Point(305, 52);
            this.SeguridadBtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnGuardar.Name = "SeguridadBtnGuardar";
            this.SeguridadBtnGuardar.Size = new System.Drawing.Size(80, 74);
            this.SeguridadBtnGuardar.TabIndex = 12;
            this.SeguridadBtnGuardar.UseVisualStyleBackColor = false;
            this.SeguridadBtnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SeguridadBtnAyuda
            // 
            this.SeguridadBtnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadBtnAyuda.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_ayudaN;
            this.SeguridadBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnAyuda.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnAyuda.Location = new System.Drawing.Point(15, 14);
            this.SeguridadBtnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBtnAyuda.Name = "SeguridadBtnAyuda";
            this.SeguridadBtnAyuda.Size = new System.Drawing.Size(91, 78);
            this.SeguridadBtnAyuda.TabIndex = 1;
            this.SeguridadBtnAyuda.UseVisualStyleBackColor = false;
            this.SeguridadBtnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // SeguridadPicCrearUsuario
            // 
            this.SeguridadPicCrearUsuario.BackColor = System.Drawing.Color.Transparent;
            this.SeguridadPicCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeguridadPicCrearUsuario.Image = global::CapaVista_Seguridad.Properties.Resources.fondo2;
            this.SeguridadPicCrearUsuario.Location = new System.Drawing.Point(0, 0);
            this.SeguridadPicCrearUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadPicCrearUsuario.Name = "SeguridadPicCrearUsuario";
            this.SeguridadPicCrearUsuario.Size = new System.Drawing.Size(1440, 802);
            this.SeguridadPicCrearUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeguridadPicCrearUsuario.TabIndex = 15;
            this.SeguridadPicCrearUsuario.TabStop = false;
            // 
            // SeguridadBtnConsultar
            // 
            this.SeguridadBtnConsultar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_consultarN;
            this.SeguridadBtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SeguridadBtnConsultar.Location = new System.Drawing.Point(1181, 46);
            this.SeguridadBtnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadBtnConsultar.Name = "SeguridadBtnConsultar";
            this.SeguridadBtnConsultar.Size = new System.Drawing.Size(56, 49);
            this.SeguridadBtnConsultar.TabIndex = 22;
            this.SeguridadBtnConsultar.UseVisualStyleBackColor = true;
            // 
            // SeguridadTxtConsultar
            // 
            this.SeguridadTxtConsultar.Location = new System.Drawing.Point(1245, 65);
            this.SeguridadTxtConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadTxtConsultar.Name = "SeguridadTxtConsultar";
            this.SeguridadTxtConsultar.Size = new System.Drawing.Size(177, 22);
            this.SeguridadTxtConsultar.TabIndex = 23;
            // 
            // SeguridadBtnRefrescar
            // 
            this.SeguridadBtnRefrescar.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_refrescarN;
            this.SeguridadBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnRefrescar.Location = new System.Drawing.Point(648, 52);
            this.SeguridadBtnRefrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadBtnRefrescar.Name = "SeguridadBtnRefrescar";
            this.SeguridadBtnRefrescar.Size = new System.Drawing.Size(79, 74);
            this.SeguridadBtnRefrescar.TabIndex = 24;
            this.SeguridadBtnRefrescar.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnInicio
            // 
            this.SeguridadBtnInicio.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_inicioN;
            this.SeguridadBtnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnInicio.Location = new System.Drawing.Point(735, 52);
            this.SeguridadBtnInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadBtnInicio.Name = "SeguridadBtnInicio";
            this.SeguridadBtnInicio.Size = new System.Drawing.Size(77, 74);
            this.SeguridadBtnInicio.TabIndex = 25;
            this.SeguridadBtnInicio.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnAnterior
            // 
            this.SeguridadBtnAnterior.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_anteriorN;
            this.SeguridadBtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnAnterior.Location = new System.Drawing.Point(820, 52);
            this.SeguridadBtnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadBtnAnterior.Name = "SeguridadBtnAnterior";
            this.SeguridadBtnAnterior.Size = new System.Drawing.Size(77, 74);
            this.SeguridadBtnAnterior.TabIndex = 26;
            this.SeguridadBtnAnterior.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnSiguiente
            // 
            this.SeguridadBtnSiguiente.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_siguienteN;
            this.SeguridadBtnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnSiguiente.Location = new System.Drawing.Point(905, 52);
            this.SeguridadBtnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadBtnSiguiente.Name = "SeguridadBtnSiguiente";
            this.SeguridadBtnSiguiente.Size = new System.Drawing.Size(77, 74);
            this.SeguridadBtnSiguiente.TabIndex = 27;
            this.SeguridadBtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // SeguridadBtnFin
            // 
            this.SeguridadBtnFin.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_finN;
            this.SeguridadBtnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SeguridadBtnFin.Location = new System.Drawing.Point(991, 52);
            this.SeguridadBtnFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SeguridadBtnFin.Name = "SeguridadBtnFin";
            this.SeguridadBtnFin.Size = new System.Drawing.Size(77, 74);
            this.SeguridadBtnFin.TabIndex = 28;
            this.SeguridadBtnFin.UseVisualStyleBackColor = true;
            // 
            // FrmMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 802);
            this.Controls.Add(this.SeguridadBtnFin);
            this.Controls.Add(this.SeguridadBtnSiguiente);
            this.Controls.Add(this.SeguridadBtnAnterior);
            this.Controls.Add(this.SeguridadBtnInicio);
            this.Controls.Add(this.SeguridadBtnRefrescar);
            this.Controls.Add(this.SeguridadTxtConsultar);
            this.Controls.Add(this.SeguridadBtnConsultar);
            this.Controls.Add(this.SeguridadDgvUsuarios);
            this.Controls.Add(this.SeguridadBtnModificar);
            this.Controls.Add(this.SeguridadBtnSalir);
            this.Controls.Add(this.SeguridadBtnReporte);
            this.Controls.Add(this.SeguridadBtnLimpiar);
            this.Controls.Add(this.SeguridadBtnGuardar);
            this.Controls.Add(this.SeguridadBtnAyuda);
            this.Controls.Add(this.SeguridadLblTitulo);
            this.Controls.Add(this.pnlIngresoDatos);
            this.Controls.Add(this.SeguridadPicCrearUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2005 - Crear Usuario";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pnlIngresoDatos.ResumeLayout(false);
            this.pnlIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPicMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadPicCrearUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeguridadLblTitulo;
        private System.Windows.Forms.Button SeguridadBtnAyuda;
        private System.Windows.Forms.Label SeguridadLblEmpleado;
        private System.Windows.Forms.ComboBox SeguridadCboEmpleado;
        private System.Windows.Forms.Label SeguridadLblIdEmpleado;
        private System.Windows.Forms.TextBox SeguridadTxtIdEmpleado;
        private System.Windows.Forms.Label SeguridadLblContrasena;
        private System.Windows.Forms.TextBox SeguridadTxtContrasena;
        private System.Windows.Forms.Label SeguridadLblConfirmarContrasena;
        private System.Windows.Forms.TextBox SeguridadTxtConfirmarContrasena;
        private System.Windows.Forms.Button SeguridadBtnReporte;
        private System.Windows.Forms.Button SeguridadBtnGuardar;
        private System.Windows.Forms.Button SeguridadBtnLimpiar;
        private System.Windows.Forms.Button SeguridadBtnSalir;
        private System.Windows.Forms.PictureBox SeguridadPicCrearUsuario;
        private System.Windows.Forms.Panel pnlIngresoDatos;
        private System.Windows.Forms.PictureBox SeguridadPicMascota;
        private System.Windows.Forms.Label SeguridadLblEstado;
        private System.Windows.Forms.Button SeguridadBtnModificar;
        private System.Windows.Forms.DataGridView SeguridadDgvUsuarios;
        private System.Windows.Forms.Label SeguridadLblUsuario;
        private System.Windows.Forms.TextBox SeguridadTxtUsuario;
        private System.Windows.Forms.CheckBox SeguridadChkActivo;
        private System.Windows.Forms.CheckBox SeguridadChkMostrarContra;
        private System.Windows.Forms.Button SeguridadBtnConsultar;
        private System.Windows.Forms.TextBox SeguridadTxtConsultar;
        private System.Windows.Forms.Button SeguridadBtnRefrescar;
        private System.Windows.Forms.Button SeguridadBtnInicio;
        private System.Windows.Forms.Button SeguridadBtnAnterior;
        private System.Windows.Forms.Button SeguridadBtnSiguiente;
        private System.Windows.Forms.Button SeguridadBtnFin;
    }
}
