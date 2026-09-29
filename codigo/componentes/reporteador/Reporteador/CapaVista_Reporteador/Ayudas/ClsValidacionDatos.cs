using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;



namespace CapaVista_Reporteador.Ayudas
{
    public class ClsValidacionDatos
    {
        private readonly ValidationContext contexto;
        private readonly List<ValidationResult> resultados;
        private readonly bool valido;

        public ClsValidacionDatos(object instancia)
        {
            contexto =
                new ValidationContext(instancia);

            resultados =
                new List<ValidationResult>();

            valido =
                Validator.TryValidateObject(
                    instancia,
                    contexto,
                    resultados,
                    true);
        }

        public bool Validar()
        {
            if (!valido)
            {
                string mensaje = "";

                foreach (ValidationResult item in resultados)
                {
                    mensaje +=
                        item.ErrorMessage + "\n";
                }

                MessageBox.Show(
                    mensaje,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return valido;
        }
    }
}