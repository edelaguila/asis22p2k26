using System;
using System.Windows.Forms;
using CapaVista_Consultas;

namespace Ejecucion_Consultas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] Tablas =
            {
                "vwDetalleCompras",
                "vwComprasPorProveedor",
                "vwComprasPorProducto",
                "tblConsulta"
            };
            Application.Run(new FrmEjecucion());
            
        }
    }
}