using System;
using System.Windows.Forms;

namespace CapaVista_Navegador.formularios
{
    public class ClsCrudEventos
    {
        private readonly ClsCrudCoordinador _Coordinador;

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Se quitaron UsuarioActual y CodigoModulo: no se usaban (el usuario sale de la sesión de Seguridad).
        public ClsCrudEventos(Navegador Formulario, string Tabla)
        {
            _Coordinador = new ClsCrudCoordinador(Formulario, Tabla);
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        // Nombre de la tabla sobre la que trabaja el CRUD; lo cambia quien usa el navegador.
        public string NombreTabla
        {
            get { return _Coordinador.NombreTabla; }
            set { _Coordinador.NombreTabla = value; }
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        public void NavegadorMetCargar()
        {
            _Coordinador.NavegadorMetOcultarGrid();
        }

        public void NavegadorMetIngresar()
        {
            _Coordinador.NavegadorMetIngresar();
        }

        public void NavegadorMetConsultar()
        {
            _Coordinador.NavegadorMetConsultar();
        }

        public void NavegadorMetRefrescar()
        {
            _Coordinador.NavegadorMetRefrescar();
        }

        public void NavegadorMetModificar()
        {
            _Coordinador.NavegadorMetModificar();
        }

        public void NavegadorMetEliminar()
        {
            _Coordinador.NavegadorMetEliminar();
        }

        // Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998
        public void NavegadorMetMinimizar()
        {
            _Coordinador.NavegadorMetMinimizar();
        }
        // Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998

        public void NavegadorMetGuardar()
        {
            _Coordinador.NavegadorMetGuardar();
        }

        public void NavegadorMetCancelar()
        {
            _Coordinador.NavegadorMetCancelar();
        }

        public void NavegadorMetInicio()
        {
            _Coordinador.NavegadorMetInicio();
        }

        public void NavegadorMetAnterior()
        {
            _Coordinador.NavegadorMetAnterior();
        }

        public void NavegadorMetSiguiente()
        {
            _Coordinador.NavegadorMetSiguiente();
        }

        public void NavegadorMetFin()
        {
            _Coordinador.NavegadorMetFin();
        }

        public void NavegadorMetImprimir()
        {
            _Coordinador.NavegadorMetImprimir();
        }
    }
}