using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CapaVista_Seguridad.Ayudas
{
    public class ClsValidacionDatos
    {
        private ValidationContext _Contexto;
        private List<ValidationResult> _Resultados;
        private bool _Valido;
        private String _Mensaje;

        public ClsValidacionDatos(object Instancia)
        {
            _Contexto = new ValidationContext(Instancia);
            _Resultados = new List<ValidationResult>();
            _Valido = Validator.TryValidateObject(Instancia, _Contexto, _Resultados, true);
        }

        public bool SeguridadMetValidar()
        {
            if (_Valido == false)
            {
                foreach (ValidationResult Item in _Resultados)
                {
                    _Mensaje += Item.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(_Mensaje);
            }
            return _Valido;
        }
    }
}