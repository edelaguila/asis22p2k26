namespace CapaVista_Seguridad



 /* ============================================================
 * Área : Seguridad
 * Autor : Daniella Jurado
 * Carné : 0901-23-3679
 * Fecha : 23/09/2026
 * ============================================================
 * Propósito :
 * Este archivo contiene la configuración visual de la ventana
 * de asignación de perfiles. Aquí se definen los paneles,
 * botones, listas, campos de selección, tablas e imágenes que
 * forman parte de la interfaz. La ventana se divide en una
 * sección para consultar los perfiles de un usuario y otra para
 * realizar nuevas asignaciones, incluyendo los controles para
 * agregar, cancelar y guardar los cambios. También se configura
 * la apariencia, tamaño, ubicación y distribución de los elementos
 * que forman parte del formulario.
 * ============================================================
 */
{
    partial class FrmAsignacionPerfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionPerfiles));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BtnSeguridadAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMascota = new System.Windows.Forms.PictureBox();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SeguridadBanner = new System.Windows.Forms.PictureBox();
            this.panelContenedorListas = new System.Windows.Forms.Panel();
            this.BtnSeguridadReporte = new System.Windows.Forms.Button();
            this.BtnSeguridadAnterior = new System.Windows.Forms.Button();
            this.tableLayoutPanelContenido = new System.Windows.Forms.TableLayoutPanel();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCancelarConsulta = new System.Windows.Forms.Button();
            this.panelListaConsulta = new System.Windows.Forms.Panel();
            this.dataGridViewPerfilesUsuario = new System.Windows.Forms.DataGridView();
            this.comboBoxUsuariosConsulta = new System.Windows.Forms.ComboBox();
            this.labelUsuariosConsulta = new System.Windows.Forms.Label();
            this.labelTituloConsulta = new System.Windows.Forms.Label();
            this.panelAsignacion = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonAsignar = new System.Windows.Forms.Button();
            this.buttonCancelarAsignacion = new System.Windows.Forms.Button();
            this.panelListaAsignacion = new System.Windows.Forms.Panel();
            this.dataGridViewAsignacion = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.comboBoxPerfilesAsignacion = new System.Windows.Forms.ComboBox();
            this.comboBoxUsuariosAsignacion = new System.Windows.Forms.ComboBox();
            this.labelPerfilesAsignacion = new System.Windows.Forms.Label();
            this.labelUsuariosAsignacion = new System.Windows.Forms.Label();
            this.labelTituloAsignacion = new System.Windows.Forms.Label();
            this.BtnSeguridadSalir = new System.Windows.Forms.Button();
            this.BtnSeguridadSiguiente = new System.Windows.Forms.Button();
            this.BtnSeguridadFin = new System.Windows.Forms.Button();
            this.BtnSeguridadInicio = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadBanner)).BeginInit();
            this.panelContenedorListas.SuspendLayout();
            this.tableLayoutPanelContenido.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelListaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfilesUsuario)).BeginInit();
            this.panelAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelListaAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelHeader.Controls.Add(this.BtnSeguridadAyuda);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.pictureBoxMascota);
            this.panelHeader.Controls.Add(this.labelSubtitulo);
            this.panelHeader.Controls.Add(this.labelTitulo);
            this.panelHeader.Controls.Add(this.SeguridadBanner);
            this.panelHeader.Location = new System.Drawing.Point(27, 31);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1500, 217);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // BtnSeguridadAyuda
            // 
            this.BtnSeguridadAyuda.BackColor = System.Drawing.Color.Linen;
            this.BtnSeguridadAyuda.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_ayuda;
            this.BtnSeguridadAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadAyuda.Image = global::CapaVista_Seguridad.Properties.Resources.btn_ayuda;
            this.BtnSeguridadAyuda.Location = new System.Drawing.Point(1320, 48);
            this.BtnSeguridadAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadAyuda.Name = "BtnSeguridadAyuda";
            this.BtnSeguridadAyuda.Size = new System.Drawing.Size(141, 159);
            this.BtnSeguridadAyuda.TabIndex = 6;
            this.BtnSeguridadAyuda.UseVisualStyleBackColor = false;
            this.BtnSeguridadAyuda.Click += new System.EventHandler(this.BtnSeguridadAyuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista_Seguridad.Properties.Resources.iconAsignacionPerfiles;
            this.pictureBox1.Location = new System.Drawing.Point(44, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMascota
            // 
            this.pictureBoxMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMascota.BackColor = System.Drawing.Color.Linen;
            this.pictureBoxMascota.Image = global::CapaVista_Seguridad.Properties.Resources._8;
            this.pictureBoxMascota.Location = new System.Drawing.Point(897, 2);
            this.pictureBoxMascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMascota.Name = "pictureBoxMascota";
            this.pictureBoxMascota.Size = new System.Drawing.Size(188, 205);
            this.pictureBoxMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMascota.TabIndex = 4;
            this.pictureBoxMascota.TabStop = false;
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.BackColor = System.Drawing.Color.Linen;
            this.labelSubtitulo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelSubtitulo.Location = new System.Drawing.Point(177, 115);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(562, 30);
            this.labelSubtitulo.TabIndex = 3;
            this.labelSubtitulo.Text = "Administra la consulta y asignación de perfiles a usuarios.";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Linen;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.labelTitulo.Location = new System.Drawing.Point(176, 48);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(484, 60);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Asignación de Perfiles";
            // 
            // SeguridadBanner
            // 
            this.SeguridadBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeguridadBanner.BackColor = System.Drawing.Color.Linen;
            this.SeguridadBanner.Image = global::CapaVista_Seguridad.Properties.Resources.banner;
            this.SeguridadBanner.Location = new System.Drawing.Point(-15, -20);
            this.SeguridadBanner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeguridadBanner.Name = "SeguridadBanner";
            this.SeguridadBanner.Size = new System.Drawing.Size(1532, 303);
            this.SeguridadBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SeguridadBanner.TabIndex = 0;
            this.SeguridadBanner.TabStop = false;
            // 
            // panelContenedorListas
            // 
            this.panelContenedorListas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorListas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.panelContenedorListas.Controls.Add(this.BtnSeguridadReporte);
            this.panelContenedorListas.Controls.Add(this.BtnSeguridadAnterior);
            this.panelContenedorListas.Controls.Add(this.tableLayoutPanelContenido);
            this.panelContenedorListas.Controls.Add(this.BtnSeguridadSalir);
            this.panelContenedorListas.Controls.Add(this.BtnSeguridadSiguiente);
            this.panelContenedorListas.Controls.Add(this.BtnSeguridadFin);
            this.panelContenedorListas.Controls.Add(this.BtnSeguridadInicio);
            this.panelContenedorListas.Location = new System.Drawing.Point(12, 252);
            this.panelContenedorListas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedorListas.Name = "panelContenedorListas";
            this.panelContenedorListas.Size = new System.Drawing.Size(1558, 739);
            this.panelContenedorListas.TabIndex = 1;
            // 
            // BtnSeguridadReporte
            // 
            this.BtnSeguridadReporte.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_reporte;
            this.BtnSeguridadReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadReporte.Location = new System.Drawing.Point(872, 2);
            this.BtnSeguridadReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadReporte.Name = "BtnSeguridadReporte";
            this.BtnSeguridadReporte.Size = new System.Drawing.Size(105, 108);
            this.BtnSeguridadReporte.TabIndex = 20;
            this.BtnSeguridadReporte.UseVisualStyleBackColor = true;
            this.BtnSeguridadReporte.Click += new System.EventHandler(this.BtnSeguridadReporte_Click);
            // 
            // BtnSeguridadAnterior
            // 
            this.BtnSeguridadAnterior.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_anteriorN;
            this.BtnSeguridadAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadAnterior.Location = new System.Drawing.Point(539, 2);
            this.BtnSeguridadAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadAnterior.Name = "BtnSeguridadAnterior";
            this.BtnSeguridadAnterior.Size = new System.Drawing.Size(105, 108);
            this.BtnSeguridadAnterior.TabIndex = 19;
            this.BtnSeguridadAnterior.UseVisualStyleBackColor = true;
            this.BtnSeguridadAnterior.Click += new System.EventHandler(this.BtnSeguridadAnterior_Click);
            // 
            // tableLayoutPanelContenido
            // 
            this.tableLayoutPanelContenido.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelContenido.ColumnCount = 2;
            this.tableLayoutPanelContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.64604F));
            this.tableLayoutPanelContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.35396F));
            this.tableLayoutPanelContenido.Controls.Add(this.panelConsulta, 0, 0);
            this.tableLayoutPanelContenido.Controls.Add(this.panelAsignacion, 1, 0);
            this.tableLayoutPanelContenido.Location = new System.Drawing.Point(29, 117);
            this.tableLayoutPanelContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelContenido.Name = "tableLayoutPanelContenido";
            this.tableLayoutPanelContenido.RowCount = 1;
            this.tableLayoutPanelContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenido.Size = new System.Drawing.Size(1503, 610);
            this.tableLayoutPanelContenido.TabIndex = 0;
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelConsulta.Controls.Add(this.pictureBox2);
            this.panelConsulta.Controls.Add(this.buttonCancelarConsulta);
            this.panelConsulta.Controls.Add(this.panelListaConsulta);
            this.panelConsulta.Controls.Add(this.comboBoxUsuariosConsulta);
            this.panelConsulta.Controls.Add(this.labelUsuariosConsulta);
            this.panelConsulta.Controls.Add(this.labelTituloConsulta);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(3, 2);
            this.panelConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 14, 2);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(639, 606);
            this.panelConsulta.TabIndex = 0;
            this.panelConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsulta_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista_Seguridad.Properties.Resources.btn_consultarN;
            this.pictureBox2.Location = new System.Drawing.Point(21, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCancelarConsulta
            // 
            this.buttonCancelarConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.buttonCancelarConsulta.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_cancelarN;
            this.buttonCancelarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelarConsulta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCancelarConsulta.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarConsulta.Location = new System.Drawing.Point(384, 106);
            this.buttonCancelarConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarConsulta.Name = "buttonCancelarConsulta";
            this.buttonCancelarConsulta.Size = new System.Drawing.Size(105, 108);
            this.buttonCancelarConsulta.TabIndex = 2;
            this.buttonCancelarConsulta.UseVisualStyleBackColor = false;
            // 
            // panelListaConsulta
            // 
            this.panelListaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelListaConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.panelListaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListaConsulta.Controls.Add(this.dataGridViewPerfilesUsuario);
            this.panelListaConsulta.Location = new System.Drawing.Point(36, 225);
            this.panelListaConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelListaConsulta.Name = "panelListaConsulta";
            this.panelListaConsulta.Size = new System.Drawing.Size(520, 320);
            this.panelListaConsulta.TabIndex = 1;
            // 
            // dataGridViewPerfilesUsuario
            // 
            this.dataGridViewPerfilesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerfilesUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPerfilesUsuario.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPerfilesUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPerfilesUsuario.Name = "dataGridViewPerfilesUsuario";
            this.dataGridViewPerfilesUsuario.RowHeadersWidth = 62;
            this.dataGridViewPerfilesUsuario.RowTemplate.Height = 28;
            this.dataGridViewPerfilesUsuario.Size = new System.Drawing.Size(518, 318);
            this.dataGridViewPerfilesUsuario.TabIndex = 0;
            // 
            // comboBoxUsuariosConsulta
            // 
            this.comboBoxUsuariosConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUsuariosConsulta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBoxUsuariosConsulta.FormattingEnabled = true;
            this.comboBoxUsuariosConsulta.Location = new System.Drawing.Point(36, 162);
            this.comboBoxUsuariosConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUsuariosConsulta.Name = "comboBoxUsuariosConsulta";
            this.comboBoxUsuariosConsulta.Size = new System.Drawing.Size(299, 33);
            this.comboBoxUsuariosConsulta.TabIndex = 0;
            // 
            // labelUsuariosConsulta
            // 
            this.labelUsuariosConsulta.AutoSize = true;
            this.labelUsuariosConsulta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUsuariosConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelUsuariosConsulta.Location = new System.Drawing.Point(36, 129);
            this.labelUsuariosConsulta.Name = "labelUsuariosConsulta";
            this.labelUsuariosConsulta.Size = new System.Drawing.Size(87, 28);
            this.labelUsuariosConsulta.TabIndex = 4;
            this.labelUsuariosConsulta.Text = "Usuarios";
            // 
            // labelTituloConsulta
            // 
            this.labelTituloConsulta.AutoSize = true;
            this.labelTituloConsulta.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelTituloConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.labelTituloConsulta.Location = new System.Drawing.Point(99, 45);
            this.labelTituloConsulta.Name = "labelTituloConsulta";
            this.labelTituloConsulta.Size = new System.Drawing.Size(386, 36);
            this.labelTituloConsulta.TabIndex = 3;
            this.labelTituloConsulta.Text = "Consulta de Perfiles a Usuarios";
            // 
            // panelAsignacion
            // 
            this.panelAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panelAsignacion.Controls.Add(this.pictureBox3);
            this.panelAsignacion.Controls.Add(this.buttonAsignar);
            this.panelAsignacion.Controls.Add(this.buttonCancelarAsignacion);
            this.panelAsignacion.Controls.Add(this.panelListaAsignacion);
            this.panelAsignacion.Controls.Add(this.buttonAgregar);
            this.panelAsignacion.Controls.Add(this.comboBoxPerfilesAsignacion);
            this.panelAsignacion.Controls.Add(this.comboBoxUsuariosAsignacion);
            this.panelAsignacion.Controls.Add(this.labelPerfilesAsignacion);
            this.panelAsignacion.Controls.Add(this.labelUsuariosAsignacion);
            this.panelAsignacion.Controls.Add(this.labelTituloAsignacion);
            this.panelAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAsignacion.Location = new System.Drawing.Point(670, 2);
            this.panelAsignacion.Margin = new System.Windows.Forms.Padding(14, 2, 3, 2);
            this.panelAsignacion.Name = "panelAsignacion";
            this.panelAsignacion.Size = new System.Drawing.Size(830, 606);
            this.panelAsignacion.TabIndex = 1;
            this.panelAsignacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAsignacion_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaVista_Seguridad.Properties.Resources.iconAsignacionPerfiles;
            this.pictureBox3.Location = new System.Drawing.Point(26, 32);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // buttonAsignar
            // 
            this.buttonAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.buttonAsignar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAsignar.ForeColor = System.Drawing.Color.White;
            this.buttonAsignar.Location = new System.Drawing.Point(596, 440);
            this.buttonAsignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAsignar.Name = "buttonAsignar";
            this.buttonAsignar.Size = new System.Drawing.Size(195, 58);
            this.buttonAsignar.TabIndex = 4;
            this.buttonAsignar.Text = "ASIGNAR";
            this.buttonAsignar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelarAsignacion
            // 
            this.buttonCancelarAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.buttonCancelarAsignacion.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_cancelarN;
            this.buttonCancelarAsignacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelarAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonCancelarAsignacion.ForeColor = System.Drawing.Color.White;
            this.buttonCancelarAsignacion.Location = new System.Drawing.Point(641, 300);
            this.buttonCancelarAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelarAsignacion.Name = "buttonCancelarAsignacion";
            this.buttonCancelarAsignacion.Size = new System.Drawing.Size(105, 108);
            this.buttonCancelarAsignacion.TabIndex = 3;
            this.buttonCancelarAsignacion.UseVisualStyleBackColor = false;
            // 
            // panelListaAsignacion
            // 
            this.panelListaAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelListaAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.panelListaAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListaAsignacion.Controls.Add(this.dataGridViewAsignacion);
            this.panelListaAsignacion.Location = new System.Drawing.Point(36, 300);
            this.panelListaAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelListaAsignacion.Name = "panelListaAsignacion";
            this.panelListaAsignacion.Size = new System.Drawing.Size(520, 244);
            this.panelListaAsignacion.TabIndex = 2;
            // 
            // dataGridViewAsignacion
            // 
            this.dataGridViewAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsignacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAsignacion.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAsignacion.Name = "dataGridViewAsignacion";
            this.dataGridViewAsignacion.RowHeadersWidth = 62;
            this.dataGridViewAsignacion.RowTemplate.Height = 28;
            this.dataGridViewAsignacion.Size = new System.Drawing.Size(518, 242);
            this.dataGridViewAsignacion.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(283, 225);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(237, 58);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // comboBoxPerfilesAsignacion
            // 
            this.comboBoxPerfilesAsignacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPerfilesAsignacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBoxPerfilesAsignacion.FormattingEnabled = true;
            this.comboBoxPerfilesAsignacion.Location = new System.Drawing.Point(441, 162);
            this.comboBoxPerfilesAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPerfilesAsignacion.Name = "comboBoxPerfilesAsignacion";
            this.comboBoxPerfilesAsignacion.Size = new System.Drawing.Size(303, 33);
            this.comboBoxPerfilesAsignacion.TabIndex = 1;
            // 
            // comboBoxUsuariosAsignacion
            // 
            this.comboBoxUsuariosAsignacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBoxUsuariosAsignacion.FormattingEnabled = true;
            this.comboBoxUsuariosAsignacion.Location = new System.Drawing.Point(36, 162);
            this.comboBoxUsuariosAsignacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUsuariosAsignacion.Name = "comboBoxUsuariosAsignacion";
            this.comboBoxUsuariosAsignacion.Size = new System.Drawing.Size(382, 33);
            this.comboBoxUsuariosAsignacion.TabIndex = 0;
            // 
            // labelPerfilesAsignacion
            // 
            this.labelPerfilesAsignacion.AutoSize = true;
            this.labelPerfilesAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPerfilesAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelPerfilesAsignacion.Location = new System.Drawing.Point(441, 129);
            this.labelPerfilesAsignacion.Name = "labelPerfilesAsignacion";
            this.labelPerfilesAsignacion.Size = new System.Drawing.Size(73, 28);
            this.labelPerfilesAsignacion.TabIndex = 7;
            this.labelPerfilesAsignacion.Text = "Perfiles";
            // 
            // labelUsuariosAsignacion
            // 
            this.labelUsuariosAsignacion.AutoSize = true;
            this.labelUsuariosAsignacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUsuariosAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labelUsuariosAsignacion.Location = new System.Drawing.Point(36, 129);
            this.labelUsuariosAsignacion.Name = "labelUsuariosAsignacion";
            this.labelUsuariosAsignacion.Size = new System.Drawing.Size(87, 28);
            this.labelUsuariosAsignacion.TabIndex = 6;
            this.labelUsuariosAsignacion.Text = "Usuarios";
            // 
            // labelTituloAsignacion
            // 
            this.labelTituloAsignacion.AutoSize = true;
            this.labelTituloAsignacion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelTituloAsignacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(92)))));
            this.labelTituloAsignacion.Location = new System.Drawing.Point(102, 45);
            this.labelTituloAsignacion.Name = "labelTituloAsignacion";
            this.labelTituloAsignacion.Size = new System.Drawing.Size(413, 36);
            this.labelTituloAsignacion.TabIndex = 5;
            this.labelTituloAsignacion.Text = "Asignacion de Perfiles a Usuarios";
            // 
            // BtnSeguridadSalir
            // 
            this.BtnSeguridadSalir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSeguridadSalir.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_salirN;
            this.BtnSeguridadSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeguridadSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSeguridadSalir.Location = new System.Drawing.Point(983, 2);
            this.BtnSeguridadSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadSalir.Name = "BtnSeguridadSalir";
            this.BtnSeguridadSalir.Size = new System.Drawing.Size(105, 108);
            this.BtnSeguridadSalir.TabIndex = 15;
            this.BtnSeguridadSalir.UseVisualStyleBackColor = false;
            this.BtnSeguridadSalir.Click += new System.EventHandler(this.BtnSeguridadSalir_Click);
            // 
            // BtnSeguridadSiguiente
            // 
            this.BtnSeguridadSiguiente.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_siguienteN;
            this.BtnSeguridadSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadSiguiente.Location = new System.Drawing.Point(650, 5);
            this.BtnSeguridadSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadSiguiente.Name = "BtnSeguridadSiguiente";
            this.BtnSeguridadSiguiente.Size = new System.Drawing.Size(105, 108);
            this.BtnSeguridadSiguiente.TabIndex = 16;
            this.BtnSeguridadSiguiente.UseVisualStyleBackColor = true;
            this.BtnSeguridadSiguiente.Click += new System.EventHandler(this.BtnSeguridadSiguiente_Click);
            // 
            // BtnSeguridadFin
            // 
            this.BtnSeguridadFin.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_finN;
            this.BtnSeguridadFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadFin.Location = new System.Drawing.Point(761, 2);
            this.BtnSeguridadFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadFin.Name = "BtnSeguridadFin";
            this.BtnSeguridadFin.Size = new System.Drawing.Size(105, 108);
            this.BtnSeguridadFin.TabIndex = 18;
            this.BtnSeguridadFin.UseVisualStyleBackColor = true;
            this.BtnSeguridadFin.Click += new System.EventHandler(this.BtnSeguridadFin_Click);
            // 
            // BtnSeguridadInicio
            // 
            this.BtnSeguridadInicio.BackgroundImage = global::CapaVista_Seguridad.Properties.Resources.btn_inicioN;
            this.BtnSeguridadInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeguridadInicio.Location = new System.Drawing.Point(427, 5);
            this.BtnSeguridadInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSeguridadInicio.Name = "BtnSeguridadInicio";
            this.BtnSeguridadInicio.Size = new System.Drawing.Size(105, 108);
            this.BtnSeguridadInicio.TabIndex = 17;
            this.BtnSeguridadInicio.UseVisualStyleBackColor = true;
            this.BtnSeguridadInicio.Click += new System.EventHandler(this.BtnSeguridadInicio_Click);
            // 
            // FrmAsignacionPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1620, 1002);
            this.Controls.Add(this.panelContenedorListas);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1342, 720);
            this.Name = "FrmAsignacionPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2009 - Asignación de Perfiles";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadBanner)).EndInit();
            this.panelContenedorListas.ResumeLayout(false);
            this.tableLayoutPanelContenido.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelListaConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfilesUsuario)).EndInit();
            this.panelAsignacion.ResumeLayout(false);
            this.panelAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelListaAsignacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox SeguridadBanner;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.PictureBox pictureBoxMascota;
        private System.Windows.Forms.Panel panelContenedorListas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenido;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Label labelTituloConsulta;
        private System.Windows.Forms.Label labelUsuariosConsulta;
        private System.Windows.Forms.ComboBox comboBoxUsuariosConsulta;
        private System.Windows.Forms.Panel panelListaConsulta;
        private System.Windows.Forms.Button buttonCancelarConsulta;
        private System.Windows.Forms.Panel panelAsignacion;
        private System.Windows.Forms.Label labelTituloAsignacion;
        private System.Windows.Forms.Label labelUsuariosAsignacion;
        private System.Windows.Forms.Label labelPerfilesAsignacion;
        private System.Windows.Forms.ComboBox comboBoxUsuariosAsignacion;
        private System.Windows.Forms.ComboBox comboBoxPerfilesAsignacion;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Panel panelListaAsignacion;
        private System.Windows.Forms.Button buttonCancelarAsignacion;
        private System.Windows.Forms.Button buttonAsignar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewPerfilesUsuario;
        private System.Windows.Forms.DataGridView dataGridViewAsignacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnSeguridadAyuda;
        private System.Windows.Forms.Button BtnSeguridadAnterior;
        private System.Windows.Forms.Button BtnSeguridadFin;
        private System.Windows.Forms.Button BtnSeguridadInicio;
        private System.Windows.Forms.Button BtnSeguridadSiguiente;
        private System.Windows.Forms.Button BtnSeguridadSalir;
        private System.Windows.Forms.Button BtnSeguridadReporte;
    }
}
