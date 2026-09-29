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
                Help.ShowHelp(Padre, NavegadorFuncExtraer());
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(
                    "No se pudo abrir la ayuda del Navegador.\n\n" + Excepcion.Message,
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
