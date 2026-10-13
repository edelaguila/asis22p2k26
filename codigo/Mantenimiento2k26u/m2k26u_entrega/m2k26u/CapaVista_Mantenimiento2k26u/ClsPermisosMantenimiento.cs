
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaVista_Mantenimiento2k26u
{
    public static class ClsPermisosMantenimiento
    {

        public static ClsPermisoAplicacion MantenimientoFuncAplicarPermisos(
            Form Formulario,
            int IdModulo,
            int IdAplicacion,
            Dictionary<Control, TipoPermiso> MapaBotones)
        {
            ClsPermisoAplicacion Permisos = new ClsPermisoAplicacion();

            if (!ClsSesionSeguridad.HaySesionActiva)
            {
                MessageBox.Show(
                    "No hay una sesión activa. Inicie sesión desde el Login de Seguridad " +
                    "para habilitar el mantenimiento.",
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MantenimientoProcAplicarMapa(MapaBotones, Permisos);
                return Permisos;
            }

            try
            {
                ClsModeloAsigAppPerf Modelo = new ClsModeloAsigAppPerf();
                Permisos = Modelo.SeguridadMetObtenerPermisosSesion(IdModulo, IdAplicacion)
                           ?? new ClsPermisoAplicacion();
            }
            catch (Exception Error)
            {
                MessageBox.Show(
                    "No se pudieron leer los permisos del usuario." + Environment.NewLine +
                    Environment.NewLine + Error.Message,
                    "Mantenimiento de Películas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MantenimientoProcAplicarMapa(MapaBotones, Permisos);
            return Permisos;
        }

        private static void MantenimientoProcAplicarMapa(
            Dictionary<Control, TipoPermiso> MapaBotones,
            ClsPermisoAplicacion Permisos)
        {
            if (MapaBotones == null) { return; }

            foreach (KeyValuePair<Control, TipoPermiso> Par in MapaBotones)
            {
                if (Par.Key == null) { continue; }

                bool Habilitado;
                switch (Par.Value)
                {
                    case TipoPermiso.Insertar: Habilitado = Permisos.PuedeInsertar; break;
                    case TipoPermiso.Editar:   Habilitado = Permisos.PuedeEditar;   break;
                    case TipoPermiso.Eliminar: Habilitado = Permisos.PuedeEliminar; break;
                    case TipoPermiso.Imprimir: Habilitado = Permisos.PuedeImprimir; break;
                    default:                   Habilitado = false;                  break;
                }

                Par.Key.Enabled = Habilitado;

                if (!Habilitado)
                {
                    Par.Key.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
                    Par.Key.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
                }
            }
        }
    }
}
