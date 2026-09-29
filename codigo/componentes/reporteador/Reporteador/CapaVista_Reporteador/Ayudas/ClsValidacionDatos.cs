using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CapaVista_Reporteador.Ayudas
{
    /// <summary>
    /// Clase auxiliar para validar entidades utilizando
    /// DataAnnotations.
    /// </summary>
    public class ClsValidacionDatos
    {
        private readonly ValidationContext
            _Contexto;

        private readonly List<ValidationResult>
            _Resultados;

        private readonly bool
            _Valido;

        public ClsValidacionDatos(
            object Instancia)
        {
            _Contexto =
                new ValidationContext(
                    Instancia);

            _Resultados =
                new List<ValidationResult>();

            _Valido =
                Validator.TryValidateObject(
                    Instancia,
                    _Contexto,
                    _Resultados,
                    true);
        }

        /// <summary>
        /// Muestra los errores encontrados
        /// durante la validación.
        /// </summary>
        public bool ReporteadorMetValidar()
        {
            if (!_Valido)
            {
                string Mensaje =
                    string.Empty;

                foreach (
                    ValidationResult Resultado
                    in _Resultados)
                {
                    Mensaje +=
                        Resultado.ErrorMessage
                        + "\n";
                }

                MessageBox.Show(
                    Mensaje,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return _Valido;
        }
    }
}