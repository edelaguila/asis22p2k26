using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;

namespace CapaVista_Navegador
{
    // Aplica los permisos de Seguridad (Insertar/Editar/Eliminar/Imprimir) sobre los botones de un
    // formulario CRUD del Navegador. Solo depende de CapaControlador_Seguridad; así CapaVista_Navegador
    // no referencia a CapaVista_Seguridad (que a su vez referencia al Navegador) y se evita la
    // dependencia circular entre ambas capas de vista.
    public static class ClsNavegadorPermisos
    {
        public static ClsPermisoAplicacion NavegadorMetInicializarPermisos(
            int IdModulo,
            int IdAplicacion,
            Dictionary<Control, TipoPermiso> MapaBotones)
        {
            var ModeloPermisos = new ClsModeloAsigAppPerf();
            ModeloPermisos.SeguridadMetObtenerTodos();

            var Permisos = ModeloPermisos.SeguridadMetObtenerPermisosSesion(IdModulo, IdAplicacion);
            NavegadorMetAplicarPermisosEnBotones(Permisos, MapaBotones);
            return Permisos;
        }

        private static void NavegadorMetAplicarPermisosEnBotones(
            ClsPermisoAplicacion Permisos,
            Dictionary<Control, TipoPermiso> MapaBotones)
        {
            if (MapaBotones == null) return;

            foreach (var Par in MapaBotones)
            {
                bool Puede = false;
                switch (Par.Value)
                {
                    case TipoPermiso.Insertar: Puede = Permisos.PuedeInsertar; break;
                    case TipoPermiso.Editar: Puede = Permisos.PuedeEditar; break;
                    case TipoPermiso.Eliminar: Puede = Permisos.PuedeEliminar; break;
                    case TipoPermiso.Imprimir: Puede = Permisos.PuedeImprimir; break;
                }
                Par.Key.Enabled = Puede;
                if (!Puede && Par.Key.BackgroundImage != null)
                    Par.Key.BackgroundImage = NavegadorMetConvertirGris(Par.Key.BackgroundImage);
            }
        }

        // Matriz de color 5x5 que mezcla los canales en porcentajes para producir escala de grises.
        private static Image NavegadorMetConvertirGris(Image Imagen)
        {
            var Bmp = new Bitmap(Imagen.Width, Imagen.Height);
            using (var G = Graphics.FromImage(Bmp))
            {
                var Matrix = new ColorMatrix(new float[][]
                {
                    new float[] { .3f,  .3f,  .3f,  0, 0 },
                    new float[] { .59f, .59f, .59f, 0, 0 },
                    new float[] { .11f, .11f, .11f, 0, 0 },
                    new float[] { 0,    0,    0,    1, 0 },
                    new float[] { 0,    0,    0,    0, 1 }
                });
                using (var Attrs = new ImageAttributes())
                {
                    Attrs.SetColorMatrix(Matrix);
                    G.DrawImage(Imagen,
                        new Rectangle(0, 0, Bmp.Width, Bmp.Height),
                        0, 0, Imagen.Width, Imagen.Height,
                        GraphicsUnit.Pixel, Attrs);
                }
            }
            return Bmp;
        }
    }
}
