using CapaVista_Navegador;
using CapaVista_Seguridad.frmReportes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblAplicacion", 4, 6);
            SeguridadMetInterceptarAyuda();
        }

        private void navegador1_NavegadorAccionSolicitada(string obj)
        {
            switch (obj)
            {
                case "IMPRIMIR":
                    new FrmReporteMantenimientoAplicacioncs().Show();
                    break;
            }

        }

        private void SeguridadMetInterceptarAyuda()
        {
            var btn = navegador1.Controls.Find("NavegadorBtnAyuda", true).FirstOrDefault();
            if (btn == null) return;

            var fi = typeof(Component).GetField("events", BindingFlags.NonPublic | BindingFlags.Instance);
            var eventList = fi?.GetValue(btn) as EventHandlerList;
            var clickKey = typeof(Control).GetField("EventClick", BindingFlags.NonPublic | BindingFlags.Static)
                                          ?.GetValue(null);

            if (eventList != null && clickKey != null)
                eventList.RemoveHandler(clickKey, eventList[clickKey]);

            btn.Click += (s, ev) =>
                System.Diagnostics.Process.Start(
                    @"C:\Plantilla para examen\ayuda\componentes\seguridad\SeguridadAyudas\SeguridadAyudas.chm");
        }
    }
}
