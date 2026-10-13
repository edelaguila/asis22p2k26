/*
 * ==================================================================
 * Área   : Mantenimiento2k26u
 * Autor  : José Pablo Cano Cóbar
 * Carné  : 0901-23-1727
 * Fecha  : 13/10/2026
 * ==================================================================
 * Propósito :
 *   Diseñador de la variante que hospeda el control Navegador.
 *
 * Reglas específicas :
 *   El control Navegador trae tamaño 1438x111 por diseño. Antes de
 *   poder arrastrarlo desde la caja de herramientas hay que compilar
 *   CapaVista_Navegador en Debug x64 y agregar su DLL con
 *   clic derecho en la caja de herramientas → Elegir elementos.
 *   Si se prefiere no tocar el diseñador, este archivo ya lo instancia
 *   a mano y funciona igual.
 * ===================================================================
*/

namespace CapaVista_Mantenimiento2k26u
{
    partial class FrmPeliculasNavegador
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
            this.MantenimientoPnlNavegador = new System.Windows.Forms.GroupBox();
            this.MantenimientoNavegador = new CapaVista_Navegador.Navegador();
            this.MantenimientoLblTitulo = new System.Windows.Forms.Label();
            this.MantenimientoLblUsuario = new System.Windows.Forms.Label();
            this.MantenimientoLblAccion = new System.Windows.Forms.Label();
            this.MantenimientoPnlNavegador.SuspendLayout();
            this.SuspendLayout();
            //
            // MantenimientoLblTitulo
            //
            this.MantenimientoLblTitulo.AutoSize = true;
            this.MantenimientoLblTitulo.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.MantenimientoLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblTitulo.Location = new System.Drawing.Point(20, 15);
            this.MantenimientoLblTitulo.Name = "MantenimientoLblTitulo";
            this.MantenimientoLblTitulo.Size = new System.Drawing.Size(440, 23);
            this.MantenimientoLblTitulo.TabIndex = 0;
            this.MantenimientoLblTitulo.Text = "Películas — CRUD con el componente Navegador";
            //
            // MantenimientoLblUsuario
            //
            this.MantenimientoLblUsuario.AutoSize = true;
            this.MantenimientoLblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            this.MantenimientoLblUsuario.Location = new System.Drawing.Point(23, 45);
            this.MantenimientoLblUsuario.Name = "MantenimientoLblUsuario";
            this.MantenimientoLblUsuario.Size = new System.Drawing.Size(60, 15);
            this.MantenimientoLblUsuario.TabIndex = 1;
            this.MantenimientoLblUsuario.Text = "Usuario:";
            //
            // MantenimientoPnlNavegador
            //
            this.MantenimientoPnlNavegador.Controls.Add(this.MantenimientoNavegador);
            this.MantenimientoPnlNavegador.Location = new System.Drawing.Point(20, 70);
            this.MantenimientoPnlNavegador.Name = "MantenimientoPnlNavegador";
            this.MantenimientoPnlNavegador.Size = new System.Drawing.Size(1450, 600);
            this.MantenimientoPnlNavegador.TabIndex = 2;
            this.MantenimientoPnlNavegador.TabStop = false;
            //
            // MantenimientoNavegador
            //
            this.MantenimientoNavegador.Location = new System.Drawing.Point(5, 15);
            this.MantenimientoNavegador.Name = "MantenimientoNavegador";
            this.MantenimientoNavegador.Size = new System.Drawing.Size(1438, 111);
            this.MantenimientoNavegador.TabIndex = 0;
            //
            // MantenimientoLblAccion
            //
            this.MantenimientoLblAccion.AutoSize = true;
            this.MantenimientoLblAccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MantenimientoLblAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.MantenimientoLblAccion.Location = new System.Drawing.Point(23, 680);
            this.MantenimientoLblAccion.Name = "MantenimientoLblAccion";
            this.MantenimientoLblAccion.Size = new System.Drawing.Size(100, 15);
            this.MantenimientoLblAccion.TabIndex = 3;
            this.MantenimientoLblAccion.Text = "Última acción: —";
            //
            // FrmPeliculasNavegador
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1490, 710);
            this.Controls.Add(this.MantenimientoLblTitulo);
            this.Controls.Add(this.MantenimientoLblUsuario);
            this.Controls.Add(this.MantenimientoPnlNavegador);
            this.Controls.Add(this.MantenimientoLblAccion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmPeliculasNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4102 - Películas (Navegador)";
            this.MantenimientoPnlNavegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label MantenimientoLblTitulo;
        private System.Windows.Forms.Label MantenimientoLblUsuario;
        private System.Windows.Forms.GroupBox MantenimientoPnlNavegador;
        private CapaVista_Navegador.Navegador MantenimientoNavegador;
        private System.Windows.Forms.Label MantenimientoLblAccion;
    }
}
