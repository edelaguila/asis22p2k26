/*
 * ==================================================================
 * Área   : Mantenimiento2k26u
 * Autor  : José Pablo Cano Cóbar
 * Carné  : 0901-23-1727
 * Fecha  : 13/10/2026
 * ==================================================================
 * Propósito :
 *   Diseñador del formulario de mantenimiento de Películas. Aplica la
 *   paleta y la tipografía del estándar EST-10: fondo crema #EDE7DA,
 *   azul #2E4A63 para las acciones, verde #4E8078 para confirmar y
 *   terracota #C4573F para eliminar; Tahoma en los títulos de grupo y
 *   Segoe UI en el cuerpo.
 *
 * Reglas específicas :
 *   No usa ComponentResourceManager: el formulario no incrusta
 *   imágenes ni iconos, así que compila aunque el .resx esté vacío.
 *   El tamaño 1100x660 entra completo en la resolución mínima de
 *   1366x768 que fija el estándar.
 * ===================================================================
*/

namespace CapaVista_Mantenimiento2k26u
{
    partial class FrmMantenimientoPeliculas
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.MantenimientoLblTitulo = new System.Windows.Forms.Label();
            this.MantenimientoGbxDatos = new System.Windows.Forms.GroupBox();
            this.MantenimientoLblId = new System.Windows.Forms.Label();
            this.MantenimientoTxtId = new System.Windows.Forms.TextBox();
            this.MantenimientoLblNombre = new System.Windows.Forms.Label();
            this.MantenimientoTxtNombre = new System.Windows.Forms.TextBox();
            this.MantenimientoLblClasificacion = new System.Windows.Forms.Label();
            this.MantenimientoCboClasificacion = new System.Windows.Forms.ComboBox();
            this.MantenimientoLblGenero = new System.Windows.Forms.Label();
            this.MantenimientoCboGenero = new System.Windows.Forms.ComboBox();
            this.MantenimientoLblSubtitulado = new System.Windows.Forms.Label();
            this.MantenimientoCboSubtitulado = new System.Windows.Forms.ComboBox();
            this.MantenimientoLblIdioma = new System.Windows.Forms.Label();
            this.MantenimientoCboIdioma = new System.Windows.Forms.ComboBox();
            this.MantenimientoLblPrecio = new System.Windows.Forms.Label();
            this.MantenimientoTxtPrecio = new System.Windows.Forms.TextBox();
            this.MantenimientoChkEstado = new System.Windows.Forms.CheckBox();
            this.MantenimientoDgvPeliculas = new System.Windows.Forms.DataGridView();
            this.MantenimientoLblContador = new System.Windows.Forms.Label();
            this.MantenimientoLblUsuario = new System.Windows.Forms.Label();
            this.MantenimientoFlpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.MantenimientoBtnIngresar = new System.Windows.Forms.Button();
            this.MantenimientoBtnModificar = new System.Windows.Forms.Button();
            this.MantenimientoBtnEliminar = new System.Windows.Forms.Button();
            this.MantenimientoBtnGuardar = new System.Windows.Forms.Button();
            this.MantenimientoBtnCancelar = new System.Windows.Forms.Button();
            this.MantenimientoBtnConsultar = new System.Windows.Forms.Button();
            this.MantenimientoBtnRefrescar = new System.Windows.Forms.Button();
            this.MantenimientoFlpNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.MantenimientoBtnInicio = new System.Windows.Forms.Button();
            this.MantenimientoBtnAnterior = new System.Windows.Forms.Button();
            this.MantenimientoBtnSiguiente = new System.Windows.Forms.Button();
            this.MantenimientoBtnFin = new System.Windows.Forms.Button();
            this.MantenimientoBtnImprimir = new System.Windows.Forms.Button();
            this.MantenimientoBtnAyuda = new System.Windows.Forms.Button();
            this.MantenimientoBtnSalir = new System.Windows.Forms.Button();
            this.MantenimientoGbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MantenimientoDgvPeliculas)).BeginInit();
            this.MantenimientoFlpAcciones.SuspendLayout();
            this.MantenimientoFlpNavegacion.SuspendLayout();
            this.SuspendLayout();
            //
            // MantenimientoLblTitulo
            //
            this.MantenimientoLblTitulo.AutoSize = true;
            this.MantenimientoLblTitulo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.MantenimientoLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblTitulo.Location = new System.Drawing.Point(20, 15);
            this.MantenimientoLblTitulo.Name = "MantenimientoLblTitulo";
            this.MantenimientoLblTitulo.Size = new System.Drawing.Size(329, 23);
            this.MantenimientoLblTitulo.TabIndex = 0;
            this.MantenimientoLblTitulo.Text = "Mantenimiento de Películas";
            //
            // MantenimientoLblUsuario
            //
            this.MantenimientoLblUsuario.AutoSize = true;
            this.MantenimientoLblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            this.MantenimientoLblUsuario.Location = new System.Drawing.Point(560, 22);
            this.MantenimientoLblUsuario.Name = "MantenimientoLblUsuario";
            this.MantenimientoLblUsuario.Size = new System.Drawing.Size(60, 15);
            this.MantenimientoLblUsuario.TabIndex = 1;
            this.MantenimientoLblUsuario.Text = "Usuario:";
            //
            // MantenimientoGbxDatos
            //
            this.MantenimientoGbxDatos.BackColor = System.Drawing.Color.Transparent;
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblId);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoTxtId);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblNombre);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoTxtNombre);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblClasificacion);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoCboClasificacion);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblGenero);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoCboGenero);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblSubtitulado);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoCboSubtitulado);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblIdioma);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoCboIdioma);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoLblPrecio);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoTxtPrecio);
            this.MantenimientoGbxDatos.Controls.Add(this.MantenimientoChkEstado);
            this.MantenimientoGbxDatos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.MantenimientoGbxDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoGbxDatos.Location = new System.Drawing.Point(20, 50);
            this.MantenimientoGbxDatos.Name = "MantenimientoGbxDatos";
            this.MantenimientoGbxDatos.Size = new System.Drawing.Size(1050, 175);
            this.MantenimientoGbxDatos.TabIndex = 2;
            this.MantenimientoGbxDatos.TabStop = false;
            this.MantenimientoGbxDatos.Text = "Datos de la película";
            //
            // MantenimientoLblId
            //
            this.MantenimientoLblId.AutoSize = true;
            this.MantenimientoLblId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblId.Location = new System.Drawing.Point(20, 36);
            this.MantenimientoLblId.Name = "MantenimientoLblId";
            this.MantenimientoLblId.Size = new System.Drawing.Size(21, 15);
            this.MantenimientoLblId.TabIndex = 0;
            this.MantenimientoLblId.Text = "Id";
            //
            // MantenimientoTxtId
            //
            this.MantenimientoTxtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoTxtId.Location = new System.Drawing.Point(110, 33);
            this.MantenimientoTxtId.Name = "MantenimientoTxtId";
            this.MantenimientoTxtId.ReadOnly = true;
            this.MantenimientoTxtId.Size = new System.Drawing.Size(80, 23);
            this.MantenimientoTxtId.TabIndex = 1;
            this.MantenimientoTxtId.TabStop = false;
            //
            // MantenimientoLblNombre
            //
            this.MantenimientoLblNombre.AutoSize = true;
            this.MantenimientoLblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblNombre.Location = new System.Drawing.Point(220, 36);
            this.MantenimientoLblNombre.Name = "MantenimientoLblNombre";
            this.MantenimientoLblNombre.Size = new System.Drawing.Size(55, 15);
            this.MantenimientoLblNombre.TabIndex = 2;
            this.MantenimientoLblNombre.Text = "Nombre";
            //
            // MantenimientoTxtNombre
            //
            this.MantenimientoTxtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoTxtNombre.Location = new System.Drawing.Point(300, 33);
            this.MantenimientoTxtNombre.MaxLength = 45;
            this.MantenimientoTxtNombre.Name = "MantenimientoTxtNombre";
            this.MantenimientoTxtNombre.Size = new System.Drawing.Size(320, 23);
            this.MantenimientoTxtNombre.TabIndex = 3;
            //
            // MantenimientoLblClasificacion
            //
            this.MantenimientoLblClasificacion.AutoSize = true;
            this.MantenimientoLblClasificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblClasificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblClasificacion.Location = new System.Drawing.Point(650, 36);
            this.MantenimientoLblClasificacion.Name = "MantenimientoLblClasificacion";
            this.MantenimientoLblClasificacion.Size = new System.Drawing.Size(80, 15);
            this.MantenimientoLblClasificacion.TabIndex = 4;
            this.MantenimientoLblClasificacion.Text = "Clasificación";
            //
            // MantenimientoCboClasificacion
            //
            this.MantenimientoCboClasificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoCboClasificacion.FormattingEnabled = true;
            this.MantenimientoCboClasificacion.Location = new System.Drawing.Point(760, 33);
            this.MantenimientoCboClasificacion.MaxLength = 45;
            this.MantenimientoCboClasificacion.Name = "MantenimientoCboClasificacion";
            this.MantenimientoCboClasificacion.Size = new System.Drawing.Size(250, 23);
            this.MantenimientoCboClasificacion.TabIndex = 5;
            //
            // MantenimientoLblGenero
            //
            this.MantenimientoLblGenero.AutoSize = true;
            this.MantenimientoLblGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblGenero.Location = new System.Drawing.Point(20, 81);
            this.MantenimientoLblGenero.Name = "MantenimientoLblGenero";
            this.MantenimientoLblGenero.Size = new System.Drawing.Size(48, 15);
            this.MantenimientoLblGenero.TabIndex = 6;
            this.MantenimientoLblGenero.Text = "Género";
            //
            // MantenimientoCboGenero
            //
            this.MantenimientoCboGenero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoCboGenero.FormattingEnabled = true;
            this.MantenimientoCboGenero.Location = new System.Drawing.Point(110, 78);
            this.MantenimientoCboGenero.MaxLength = 45;
            this.MantenimientoCboGenero.Name = "MantenimientoCboGenero";
            this.MantenimientoCboGenero.Size = new System.Drawing.Size(240, 23);
            this.MantenimientoCboGenero.TabIndex = 7;
            //
            // MantenimientoLblSubtitulado
            //
            this.MantenimientoLblSubtitulado.AutoSize = true;
            this.MantenimientoLblSubtitulado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblSubtitulado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblSubtitulado.Location = new System.Drawing.Point(380, 81);
            this.MantenimientoLblSubtitulado.Name = "MantenimientoLblSubtitulado";
            this.MantenimientoLblSubtitulado.Size = new System.Drawing.Size(74, 15);
            this.MantenimientoLblSubtitulado.TabIndex = 8;
            this.MantenimientoLblSubtitulado.Text = "Subtitulado";
            //
            // MantenimientoCboSubtitulado
            //
            this.MantenimientoCboSubtitulado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoCboSubtitulado.FormattingEnabled = true;
            this.MantenimientoCboSubtitulado.Location = new System.Drawing.Point(470, 78);
            this.MantenimientoCboSubtitulado.MaxLength = 45;
            this.MantenimientoCboSubtitulado.Name = "MantenimientoCboSubtitulado";
            this.MantenimientoCboSubtitulado.Size = new System.Drawing.Size(150, 23);
            this.MantenimientoCboSubtitulado.TabIndex = 9;
            //
            // MantenimientoLblIdioma
            //
            this.MantenimientoLblIdioma.AutoSize = true;
            this.MantenimientoLblIdioma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblIdioma.Location = new System.Drawing.Point(650, 81);
            this.MantenimientoLblIdioma.Name = "MantenimientoLblIdioma";
            this.MantenimientoLblIdioma.Size = new System.Drawing.Size(45, 15);
            this.MantenimientoLblIdioma.TabIndex = 10;
            this.MantenimientoLblIdioma.Text = "Idioma";
            //
            // MantenimientoCboIdioma
            //
            this.MantenimientoCboIdioma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoCboIdioma.FormattingEnabled = true;
            this.MantenimientoCboIdioma.Location = new System.Drawing.Point(760, 78);
            this.MantenimientoCboIdioma.MaxLength = 45;
            this.MantenimientoCboIdioma.Name = "MantenimientoCboIdioma";
            this.MantenimientoCboIdioma.Size = new System.Drawing.Size(250, 23);
            this.MantenimientoCboIdioma.TabIndex = 11;
            //
            // MantenimientoLblPrecio
            //
            this.MantenimientoLblPrecio.AutoSize = true;
            this.MantenimientoLblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblPrecio.Location = new System.Drawing.Point(20, 126);
            this.MantenimientoLblPrecio.Name = "MantenimientoLblPrecio";
            this.MantenimientoLblPrecio.Size = new System.Drawing.Size(44, 15);
            this.MantenimientoLblPrecio.TabIndex = 12;
            this.MantenimientoLblPrecio.Text = "Precio";
            //
            // MantenimientoTxtPrecio
            //
            this.MantenimientoTxtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoTxtPrecio.Location = new System.Drawing.Point(110, 123);
            this.MantenimientoTxtPrecio.MaxLength = 12;
            this.MantenimientoTxtPrecio.Name = "MantenimientoTxtPrecio";
            this.MantenimientoTxtPrecio.Size = new System.Drawing.Size(140, 23);
            this.MantenimientoTxtPrecio.TabIndex = 13;
            this.MantenimientoTxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // MantenimientoChkEstado
            //
            this.MantenimientoChkEstado.AutoSize = true;
            this.MantenimientoChkEstado.Checked = true;
            this.MantenimientoChkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MantenimientoChkEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoChkEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoChkEstado.Location = new System.Drawing.Point(300, 125);
            this.MantenimientoChkEstado.Name = "MantenimientoChkEstado";
            this.MantenimientoChkEstado.Size = new System.Drawing.Size(132, 19);
            this.MantenimientoChkEstado.TabIndex = 14;
            this.MantenimientoChkEstado.Text = "Película activa";
            this.MantenimientoChkEstado.UseVisualStyleBackColor = true;
            //
            // MantenimientoDgvPeliculas
            //
            this.MantenimientoDgvPeliculas.AllowUserToAddRows = false;
            this.MantenimientoDgvPeliculas.AllowUserToDeleteRows = false;
            this.MantenimientoDgvPeliculas.BackgroundColor = System.Drawing.Color.White;
            this.MantenimientoDgvPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MantenimientoDgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MantenimientoDgvPeliculas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoDgvPeliculas.Location = new System.Drawing.Point(20, 235);
            this.MantenimientoDgvPeliculas.MultiSelect = false;
            this.MantenimientoDgvPeliculas.Name = "MantenimientoDgvPeliculas";
            this.MantenimientoDgvPeliculas.ReadOnly = true;
            this.MantenimientoDgvPeliculas.RowHeadersVisible = false;
            this.MantenimientoDgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MantenimientoDgvPeliculas.Size = new System.Drawing.Size(1050, 255);
            this.MantenimientoDgvPeliculas.TabIndex = 3;
            this.MantenimientoDgvPeliculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MantenimientoDgvPeliculas_CellClick);
            //
            // MantenimientoLblContador
            //
            this.MantenimientoLblContador.AutoSize = true;
            this.MantenimientoLblContador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblContador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblContador.Location = new System.Drawing.Point(20, 498);
            this.MantenimientoLblContador.Name = "MantenimientoLblContador";
            this.MantenimientoLblContador.Size = new System.Drawing.Size(180, 15);
            this.MantenimientoLblContador.TabIndex = 4;
            this.MantenimientoLblContador.Text = "Mostrando 0 de 0 registros";
            //
            // MantenimientoFlpAcciones
            //
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnIngresar);
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnModificar);
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnEliminar);
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnGuardar);
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnCancelar);
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnConsultar);
            this.MantenimientoFlpAcciones.Controls.Add(this.MantenimientoBtnRefrescar);
            this.MantenimientoFlpAcciones.Location = new System.Drawing.Point(20, 520);
            this.MantenimientoFlpAcciones.Name = "MantenimientoFlpAcciones";
            this.MantenimientoFlpAcciones.Size = new System.Drawing.Size(1050, 48);
            this.MantenimientoFlpAcciones.TabIndex = 5;
            //
            // MantenimientoBtnIngresar
            //
            this.MantenimientoBtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnIngresar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnIngresar.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnIngresar.Location = new System.Drawing.Point(3, 3);
            this.MantenimientoBtnIngresar.Name = "MantenimientoBtnIngresar";
            this.MantenimientoBtnIngresar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnIngresar.TabIndex = 0;
            this.MantenimientoBtnIngresar.Text = "Ingresar";
            this.MantenimientoBtnIngresar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnIngresar.Click += new System.EventHandler(this.MantenimientoBtnIngresar_Click);
            //
            // MantenimientoBtnModificar
            //
            this.MantenimientoBtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnModificar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnModificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnModificar.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnModificar.Location = new System.Drawing.Point(149, 3);
            this.MantenimientoBtnModificar.Name = "MantenimientoBtnModificar";
            this.MantenimientoBtnModificar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnModificar.TabIndex = 1;
            this.MantenimientoBtnModificar.Text = "Modificar";
            this.MantenimientoBtnModificar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnModificar.Click += new System.EventHandler(this.MantenimientoBtnModificar_Click);
            //
            // MantenimientoBtnEliminar
            //
            this.MantenimientoBtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(63)))));
            this.MantenimientoBtnEliminar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnEliminar.Location = new System.Drawing.Point(295, 3);
            this.MantenimientoBtnEliminar.Name = "MantenimientoBtnEliminar";
            this.MantenimientoBtnEliminar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnEliminar.TabIndex = 2;
            this.MantenimientoBtnEliminar.Text = "Eliminar";
            this.MantenimientoBtnEliminar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnEliminar.Click += new System.EventHandler(this.MantenimientoBtnEliminar_Click);
            //
            // MantenimientoBtnGuardar
            //
            this.MantenimientoBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            this.MantenimientoBtnGuardar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnGuardar.Location = new System.Drawing.Point(441, 3);
            this.MantenimientoBtnGuardar.Name = "MantenimientoBtnGuardar";
            this.MantenimientoBtnGuardar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnGuardar.TabIndex = 3;
            this.MantenimientoBtnGuardar.Text = "Guardar";
            this.MantenimientoBtnGuardar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnGuardar.Click += new System.EventHandler(this.MantenimientoBtnGuardar_Click);
            //
            // MantenimientoBtnCancelar
            //
            this.MantenimientoBtnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.MantenimientoBtnCancelar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnCancelar.Location = new System.Drawing.Point(587, 3);
            this.MantenimientoBtnCancelar.Name = "MantenimientoBtnCancelar";
            this.MantenimientoBtnCancelar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnCancelar.TabIndex = 4;
            this.MantenimientoBtnCancelar.Text = "Cancelar";
            this.MantenimientoBtnCancelar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnCancelar.Click += new System.EventHandler(this.MantenimientoBtnCancelar_Click);
            //
            // MantenimientoBtnConsultar
            //
            this.MantenimientoBtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnConsultar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnConsultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnConsultar.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnConsultar.Location = new System.Drawing.Point(733, 3);
            this.MantenimientoBtnConsultar.Name = "MantenimientoBtnConsultar";
            this.MantenimientoBtnConsultar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnConsultar.TabIndex = 5;
            this.MantenimientoBtnConsultar.Text = "Consultar";
            this.MantenimientoBtnConsultar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnConsultar.Click += new System.EventHandler(this.MantenimientoBtnConsultar_Click);
            //
            // MantenimientoBtnRefrescar
            //
            this.MantenimientoBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnRefrescar.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnRefrescar.Location = new System.Drawing.Point(879, 3);
            this.MantenimientoBtnRefrescar.Name = "MantenimientoBtnRefrescar";
            this.MantenimientoBtnRefrescar.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnRefrescar.TabIndex = 6;
            this.MantenimientoBtnRefrescar.Text = "Refrescar";
            this.MantenimientoBtnRefrescar.UseVisualStyleBackColor = false;
            this.MantenimientoBtnRefrescar.Click += new System.EventHandler(this.MantenimientoBtnRefrescar_Click);
            //
            // MantenimientoFlpNavegacion
            //
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnInicio);
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnAnterior);
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnSiguiente);
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnFin);
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnImprimir);
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnAyuda);
            this.MantenimientoFlpNavegacion.Controls.Add(this.MantenimientoBtnSalir);
            this.MantenimientoFlpNavegacion.Location = new System.Drawing.Point(20, 572);
            this.MantenimientoFlpNavegacion.Name = "MantenimientoFlpNavegacion";
            this.MantenimientoFlpNavegacion.Size = new System.Drawing.Size(1050, 48);
            this.MantenimientoFlpNavegacion.TabIndex = 6;
            //
            // MantenimientoBtnInicio
            //
            this.MantenimientoBtnInicio.BackColor = System.Drawing.Color.White;
            this.MantenimientoBtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoBtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnInicio.Location = new System.Drawing.Point(3, 3);
            this.MantenimientoBtnInicio.Name = "MantenimientoBtnInicio";
            this.MantenimientoBtnInicio.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnInicio.TabIndex = 0;
            this.MantenimientoBtnInicio.Text = "|< Inicio";
            this.MantenimientoBtnInicio.UseVisualStyleBackColor = false;
            this.MantenimientoBtnInicio.Click += new System.EventHandler(this.MantenimientoBtnInicio_Click);
            //
            // MantenimientoBtnAnterior
            //
            this.MantenimientoBtnAnterior.BackColor = System.Drawing.Color.White;
            this.MantenimientoBtnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnAnterior.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoBtnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnAnterior.Location = new System.Drawing.Point(149, 3);
            this.MantenimientoBtnAnterior.Name = "MantenimientoBtnAnterior";
            this.MantenimientoBtnAnterior.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnAnterior.TabIndex = 1;
            this.MantenimientoBtnAnterior.Text = "< Anterior";
            this.MantenimientoBtnAnterior.UseVisualStyleBackColor = false;
            this.MantenimientoBtnAnterior.Click += new System.EventHandler(this.MantenimientoBtnAnterior_Click);
            //
            // MantenimientoBtnSiguiente
            //
            this.MantenimientoBtnSiguiente.BackColor = System.Drawing.Color.White;
            this.MantenimientoBtnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoBtnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnSiguiente.Location = new System.Drawing.Point(295, 3);
            this.MantenimientoBtnSiguiente.Name = "MantenimientoBtnSiguiente";
            this.MantenimientoBtnSiguiente.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnSiguiente.TabIndex = 2;
            this.MantenimientoBtnSiguiente.Text = "Siguiente >";
            this.MantenimientoBtnSiguiente.UseVisualStyleBackColor = false;
            this.MantenimientoBtnSiguiente.Click += new System.EventHandler(this.MantenimientoBtnSiguiente_Click);
            //
            // MantenimientoBtnFin
            //
            this.MantenimientoBtnFin.BackColor = System.Drawing.Color.White;
            this.MantenimientoBtnFin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoBtnFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnFin.Location = new System.Drawing.Point(441, 3);
            this.MantenimientoBtnFin.Name = "MantenimientoBtnFin";
            this.MantenimientoBtnFin.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnFin.TabIndex = 3;
            this.MantenimientoBtnFin.Text = "Fin >|";
            this.MantenimientoBtnFin.UseVisualStyleBackColor = false;
            this.MantenimientoBtnFin.Click += new System.EventHandler(this.MantenimientoBtnFin_Click);
            //
            // MantenimientoBtnImprimir
            //
            this.MantenimientoBtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            this.MantenimientoBtnImprimir.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnImprimir.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnImprimir.Location = new System.Drawing.Point(587, 3);
            this.MantenimientoBtnImprimir.Name = "MantenimientoBtnImprimir";
            this.MantenimientoBtnImprimir.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnImprimir.TabIndex = 4;
            this.MantenimientoBtnImprimir.Text = "Imprimir";
            this.MantenimientoBtnImprimir.UseVisualStyleBackColor = false;
            this.MantenimientoBtnImprimir.Click += new System.EventHandler(this.MantenimientoBtnImprimir_Click);
            //
            // MantenimientoBtnAyuda
            //
            this.MantenimientoBtnAyuda.BackColor = System.Drawing.Color.White;
            this.MantenimientoBtnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoBtnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoBtnAyuda.Location = new System.Drawing.Point(733, 3);
            this.MantenimientoBtnAyuda.Name = "MantenimientoBtnAyuda";
            this.MantenimientoBtnAyuda.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnAyuda.TabIndex = 5;
            this.MantenimientoBtnAyuda.Text = "Ayuda (F1)";
            this.MantenimientoBtnAyuda.UseVisualStyleBackColor = false;
            this.MantenimientoBtnAyuda.Click += new System.EventHandler(this.MantenimientoBtnAyuda_Click);
            //
            // MantenimientoBtnSalir
            //
            this.MantenimientoBtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(87)))), ((int)(((byte)(63)))));
            this.MantenimientoBtnSalir.FlatAppearance.BorderSize = 0;
            this.MantenimientoBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MantenimientoBtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MantenimientoBtnSalir.ForeColor = System.Drawing.Color.White;
            this.MantenimientoBtnSalir.Location = new System.Drawing.Point(879, 3);
            this.MantenimientoBtnSalir.Name = "MantenimientoBtnSalir";
            this.MantenimientoBtnSalir.Size = new System.Drawing.Size(140, 38);
            this.MantenimientoBtnSalir.TabIndex = 6;
            this.MantenimientoBtnSalir.Text = "Salir";
            this.MantenimientoBtnSalir.UseVisualStyleBackColor = false;
            this.MantenimientoBtnSalir.Click += new System.EventHandler(this.MantenimientoBtnSalir_Click);
            //
            // FrmMantenimientoPeliculas
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1090, 635);
            this.Controls.Add(this.MantenimientoLblTitulo);
            this.Controls.Add(this.MantenimientoLblUsuario);
            this.Controls.Add(this.MantenimientoGbxDatos);
            this.Controls.Add(this.MantenimientoDgvPeliculas);
            this.Controls.Add(this.MantenimientoLblContador);
            this.Controls.Add(this.MantenimientoFlpAcciones);
            this.Controls.Add(this.MantenimientoFlpNavegacion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMantenimientoPeliculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4100 - Mantenimiento de Películas";
            this.MantenimientoGbxDatos.ResumeLayout(false);
            this.MantenimientoGbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MantenimientoDgvPeliculas)).EndInit();
            this.MantenimientoFlpAcciones.ResumeLayout(false);
            this.MantenimientoFlpNavegacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label MantenimientoLblTitulo;
        private System.Windows.Forms.Label MantenimientoLblUsuario;
        private System.Windows.Forms.GroupBox MantenimientoGbxDatos;
        private System.Windows.Forms.Label MantenimientoLblId;
        private System.Windows.Forms.TextBox MantenimientoTxtId;
        private System.Windows.Forms.Label MantenimientoLblNombre;
        private System.Windows.Forms.TextBox MantenimientoTxtNombre;
        private System.Windows.Forms.Label MantenimientoLblClasificacion;
        private System.Windows.Forms.ComboBox MantenimientoCboClasificacion;
        private System.Windows.Forms.Label MantenimientoLblGenero;
        private System.Windows.Forms.ComboBox MantenimientoCboGenero;
        private System.Windows.Forms.Label MantenimientoLblSubtitulado;
        private System.Windows.Forms.ComboBox MantenimientoCboSubtitulado;
        private System.Windows.Forms.Label MantenimientoLblIdioma;
        private System.Windows.Forms.ComboBox MantenimientoCboIdioma;
        private System.Windows.Forms.Label MantenimientoLblPrecio;
        private System.Windows.Forms.TextBox MantenimientoTxtPrecio;
        private System.Windows.Forms.CheckBox MantenimientoChkEstado;
        private System.Windows.Forms.DataGridView MantenimientoDgvPeliculas;
        private System.Windows.Forms.Label MantenimientoLblContador;
        private System.Windows.Forms.FlowLayoutPanel MantenimientoFlpAcciones;
        private System.Windows.Forms.Button MantenimientoBtnIngresar;
        private System.Windows.Forms.Button MantenimientoBtnModificar;
        private System.Windows.Forms.Button MantenimientoBtnEliminar;
        private System.Windows.Forms.Button MantenimientoBtnGuardar;
        private System.Windows.Forms.Button MantenimientoBtnCancelar;
        private System.Windows.Forms.Button MantenimientoBtnConsultar;
        private System.Windows.Forms.Button MantenimientoBtnRefrescar;
        private System.Windows.Forms.FlowLayoutPanel MantenimientoFlpNavegacion;
        private System.Windows.Forms.Button MantenimientoBtnInicio;
        private System.Windows.Forms.Button MantenimientoBtnAnterior;
        private System.Windows.Forms.Button MantenimientoBtnSiguiente;
        private System.Windows.Forms.Button MantenimientoBtnFin;
        private System.Windows.Forms.Button MantenimientoBtnImprimir;
        private System.Windows.Forms.Button MantenimientoBtnAyuda;
        private System.Windows.Forms.Button MantenimientoBtnSalir;
    }
}
