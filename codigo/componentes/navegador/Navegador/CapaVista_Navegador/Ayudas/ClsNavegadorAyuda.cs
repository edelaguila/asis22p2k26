using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

//-----------------------------------------------------
// - Hecho por: Natali Sofía Montenegro Portillo
// - Carne: 0901-23-10017
namespace CapaVista_Navegador
{
    // Ayuda permanente del componente: el archivo Navegador.chm viaja DENTRO de CapaVista_Navegador
    // (recurso incrustado), así que no se parametriza ninguna ruta ni hay que copiar el archivo junto
    // al ejecutable. Como HTML Help necesita un archivo en disco, se extrae a una carpeta temporal
    // la primera vez (o si cambió de tamaño) y desde ahí se abre.
    public static class ClsNavegadorAyuda
    {
        private const string _Recurso = "Navegador.chm";

        public static void NavegadorMetMostrar(Control Padre)
        {
            try
            {
                string mensaje = "========================================\n" +
                                 "       MANUAL DE AYUDA DE USUARIO\n" +
                                 "========================================\n\n" +
                                 "1. INSERTAR: Ingrese los datos en los campos y presione Guardar para agregar un registro.\n" +
                                 "2. MODIFICAR: Seleccione un registro de la grilla, modifique los datos y presione Guardar.\n" +
                                 "3. ELIMINAR: Seleccione un registro y presione el botón Eliminar.\n" +
                                 "4. CONSULTAR: Permite buscar y filtrar registros existentes.\n" +
                                 "5. IMPRIMIR / REPORTE: Genera el resumen y reporte general del mantenimiento.\n" +
                                 "6. NAVEGACIÓN: Utilice los botones de Primero, Anterior, Siguiente y Último.\n\n" +
                                 "Todas las acciones son auditadas y registradas en la Bitácora de Seguridad.";

                MessageBox.Show(
                    mensaje,
                    "Ayuda del Sistema - Mantenimiento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "Error al desplegar la ayuda: " + Excepcion.Message,
                    "Ayuda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Devuelve la ruta del .chm extraído del recurso incrustado .
        private static string NavegadorFuncExtraer()
        {
            string Carpeta = Path.Combine(Path.GetTempPath(), "Navegador");
            string Ruta = Path.Combine(Carpeta, _Recurso);

            using (Stream Origen = Assembly.GetExecutingAssembly().GetManifestResourceStream(_Recurso))
            {
                if (Origen == null)
                {
                    throw new FileNotFoundException("La ayuda no está incluida en el componente Navegador.");
                }

                if (!File.Exists(Ruta) || new FileInfo(Ruta).Length != Origen.Length)
                {
                    Directory.CreateDirectory(Carpeta);

                    using (FileStream Destino = File.Create(Ruta))
                    {
                        Origen.CopyTo(Destino);
                    }
                }
            }

            return Ruta;
        }
    }
}
//--------------------------------------------------
// - Final: Natali Sofía Montenegro Portillo
// - Carne: 0901-23-10017
