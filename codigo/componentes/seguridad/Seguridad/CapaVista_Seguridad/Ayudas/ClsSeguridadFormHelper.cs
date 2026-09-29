using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; // para que se pyeda hacer la matriz de color de grises
using System.Drawing.Imaging; // libreria sirve para trabajar las clases con graficos e imagenes


/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha: 15/09/2026
 * ==================================================================
 * Propósito : Clase auxiliar de la capa Vista para el control de
 * seguridad por formulario. Consulta los permisos del
 * usuario en sesión (Insertar/Editar/Eliminar/Imprimir)
 * y los aplica sobre los botones y controles del formulario,
 * habilitándolos o deshabilitándolos según el acceso.
 * ===================================================================
 */

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
                SeguridadMetAplicarPermisosEnBotones(Permisos, MapaBotones);
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
                    Par.Key.BackgroundImage = SeguridadMetConvertirGris(Par.Key.BackgroundImage);
            }
        }
//---------------------------------------------------------------- INICIO CODIGO ANDRE Y EVELYN
/*
 * ==================================================================
 * Área : Seguridad
 * Autores : André De Jesús Gonzalez Camey
 *           Evelyn Sofia Andrade Luna
 * Fecha : 23/09/2026
 * ==================================================================
 * Propósito :
 * Se agregaron al helper los métodos SeguridadMetConvertirGris
 * y SeguridadMetAplicarPermisosEnBotones, los cuales permiten
 * que los botones de acción dentro de cada formulario se muestren
 * en escala de grises cuando el usuario no cuenta con el permiso
 * correspondiente para dicha operación.
 * ===================================================================
*/
        private static Image SeguridadMetConvertirGris(Image Imagen)
        {
            var Bmp = new Bitmap(Imagen.Width, Imagen.Height);
            using (var G = Graphics.FromImage(Bmp))
            {
    // esta matriz de 5x5 define como se van a mezclar los colores mediante porcentajes para producir el color 
    // gris de los botones 
                var Matrix = new ColorMatrix(new float[][]
                {
            new float[] { .3f,  .3f,  .3f,  0, 0 },
            new float[] { .59f, .59f, .59f, 0, 0 },
            new float[] { .11f, .11f, .11f, 0, 0 },
            new float[] { 0,    0,    0,    1, 0 },
            new float[] { 0,    0,    0,    0, 1 }
                });
                var Attrs = new ImageAttributes();
                Attrs.SetColorMatrix(Matrix);
                G.DrawImage(Imagen,
                    new Rectangle(0, 0, Bmp.Width, Bmp.Height),
                    0, 0, Imagen.Width, Imagen.Height,
                    GraphicsUnit.Pixel, Attrs);
            }
            return Bmp;
        }

// ---------------------------------------------------------------- FIN DE CODIGO ANDRE Y EVELYN
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

        public static void SeguridadMetAplicarPermisosEnBotonesMDI(
    Dictionary<Control, (int IdModulo, int IdAplicacion)> MapaBotones)
        {
            if (MapaBotones == null) return;
            foreach (var Par in MapaBotones)
            {
                bool TieneAcceso = SeguridadMetTieneAcceso(Par.Value.IdModulo, Par.Value.IdAplicacion);
                if (!TieneAcceso && Par.Key.BackgroundImage != null)
                    Par.Key.BackgroundImage = SeguridadMetConvertirGris(Par.Key.BackgroundImage);
            }
        }
        /*
 * ==================================================================
 * Área : Seguridad
 * Autor : Carlos David Calderón Ramirez
 * Carné : 9959-23-848
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 * Aqui unicamente agrege la funcion que permite el manejo de acceso
 * a los distintos form es decir si puede acceder o no.
 * ===================================================================
*/
        public static bool SeguridadMetTieneAcceso(int IdModulo, int IdAplicacion)
        {
            var ModeloPermisos = new ClsModeloAsigAppPerf();
            ModeloPermisos.SeguridadMetObtenerTodos();

            var Permisos = ModeloPermisos.SeguridadMetObtenerPermisosSesion(IdModulo, IdAplicacion);
            return Permisos.TieneAcceso;
        }
    }
}