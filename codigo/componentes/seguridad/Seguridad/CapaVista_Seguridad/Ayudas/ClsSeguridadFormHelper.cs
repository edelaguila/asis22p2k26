using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaVista_Seguridad.Ayudas
{
    public static class ClsSeguridadFormHelper
    {
        public static ClsPermisoAplicacion SeguridadMetInicializarSeguridad(
            Form FormActual,
            int IdModulo,
            int IdAplicacion,
            Dictionary<Control, TipoPermiso> MapaBotones)
        {
            var ModeloPermisos = new ClsModeloAsigAppPerf();
            ModeloPermisos.SeguridadMetObtenerTodos();

            var Permisos = ModeloPermisos.SeguridadMetObtenerPermisosSesion(IdModulo, IdAplicacion);

            if (!Permisos.TieneAcceso)
            {
                SeguridadMetDeshabilitarFormulario(FormActual);
                MessageBox.Show("No tienes acceso a este módulo.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Permisos;
            }

            SeguridadMetAplicarPermisosEnBotones(Permisos, MapaBotones);
            return Permisos;
        }

        private static void SeguridadMetAplicarPermisosEnBotones(
            ClsPermisoAplicacion Permisos,
            Dictionary<Control, TipoPermiso> MapaBotones)
        {
            if (MapaBotones == null) return;

            foreach (var Par in MapaBotones)
            {
                switch (Par.Value)
                {
                    case TipoPermiso.Insertar:
                        Par.Key.Enabled = Permisos.PuedeInsertar;
                        break;
                    case TipoPermiso.Editar:
                        Par.Key.Enabled = Permisos.PuedeEditar;
                        break;
                    case TipoPermiso.Eliminar:
                        Par.Key.Enabled = Permisos.PuedeEliminar;
                        break;
                    case TipoPermiso.Imprimir:
                        Par.Key.Enabled = Permisos.PuedeImprimir;
                        break;
                }
            }
        }

        public static void SeguridadMetDeshabilitarFormulario(Control ContenedorRaiz)
        {
            foreach (Control Ctrl in ContenedorRaiz.Controls)
                SeguridadMetDeshabilitarRecursivo(Ctrl);
        }

        private static void SeguridadMetDeshabilitarRecursivo(Control Ctrl)
        {
            Ctrl.Enabled = false;
            foreach (Control Hijo in Ctrl.Controls)
                SeguridadMetDeshabilitarRecursivo(Hijo);
        }
    }
}