using System.Windows.Forms;
using CapaVista_Navegador.formularios;

// Inicio - José Javier Torres Martínez 0901-23-1091.
namespace CapaVista_Navegador
{
    // Qué hace cada botón del Navegador. Recibe el formulario que contiene al control (ahí se dibujan la
    // grilla y el panel) y delega el trabajo en ClsCrudEventos; la ayuda la abre ClsNavegadorAyuda.
    public class ClsNavegadorAcciones
    {
        private readonly Navegador _Formulario;
        private readonly ClsCrudEventos _Eventos;

        public ClsNavegadorAcciones(Navegador Formulario, string Tabla)
        {
            _Formulario = Formulario;
            _Eventos = new ClsCrudEventos(Formulario, Tabla);
            _Eventos.NavegadorMetCargar();
        }

        // Cambia la tabla del CRUD y la vuelve a consultar.
        public void NavegadorMetCambiarTabla(string Tabla)
        {
            _Eventos.NombreTabla = Tabla;
            _Eventos.NavegadorMetConsultar();
        }

        public void NavegadorMetEjecutar(string Accion)
        {
            switch (Accion)
            {
                case "INGRESAR": _Eventos.NavegadorMetIngresar(); break;
                case "CONSULTAR": _Eventos.NavegadorMetConsultar(); break;
                case "MODIFICAR": _Eventos.NavegadorMetModificar(); break;
                case "ELIMINAR": _Eventos.NavegadorMetEliminar(); break;
                case "REFRESCAR": _Eventos.NavegadorMetRefrescar(); break;
                case "GUARDAR": _Eventos.NavegadorMetGuardar(); break;
                case "CANCELAR": _Eventos.NavegadorMetCancelar(); break;
                case "INICIO": _Eventos.NavegadorMetInicio(); break;
                case "ANTERIOR": _Eventos.NavegadorMetAnterior(); break;
                case "SIGUIENTE": _Eventos.NavegadorMetSiguiente(); break;
                case "FIN": _Eventos.NavegadorMetFin(); break;
                case "IMPRIMIR": _Eventos.NavegadorMetImprimir(); break;
                case "AYUDA": ClsNavegadorAyuda.NavegadorMetMostrar(_Formulario); break;
                case "SALIR": _Eventos.NavegadorMetMinimizar(); break;
            }
        }
    }
}
// Fin - José Javier Torres Martínez 0901-23-1091.
