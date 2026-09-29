// Inicio - Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429.
// Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998: nombres ajustados a EST-10 (prefijo Cls, PascalCase, campos con _).
// Ayuda de la vista: ejecuta DataAnnotations sobre cualquier instancia
// y presenta todos los errores de validación en una sola ventana.
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CapaVista_Navegador.Ayudas
{
    // La vista recibe el modelo configurado sin conocer las reglas de la tabla.
    public class ClsValidacionDatos
    {
        private readonly ValidationContext _Contexto;
        private readonly List<ValidationResult> _Resultados;
        private readonly bool _Valido;

        // Evalúa las propiedades anotadas y conserva los resultados.
        public ClsValidacionDatos(object Instancia)
        {
            _Contexto = new ValidationContext(Instancia);
            _Resultados = new List<ValidationResult>();
            _Valido = Validator.TryValidateObject(Instancia, _Contexto, _Resultados, true);
        }

        // Permite continuar si no hay errores; en caso contrario los muestra.
        public bool NavegadorFuncValidar()
        {
            if (!_Valido)
            {
                string Mensaje = string.Join("\n", _Resultados.ConvertAll(Item => Item.ErrorMessage));
                MessageBox.Show(Mensaje, "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return _Valido;
        }
    }
}
// Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
// Fin - Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429.
