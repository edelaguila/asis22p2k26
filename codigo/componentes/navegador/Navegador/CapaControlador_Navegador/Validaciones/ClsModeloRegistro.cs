// Inicio - Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429.
// Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998: nombres ajustados a EST-10 (prefijo Cls, PascalCase, campos con _).
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaModelo_Navegador;

namespace CapaControlador_Navegador
{
    public class ClsModeloCampo
    {
        public ClsColumnaInfo Columna { get; set; }

        [ClsValidacionColumna]
        public string Valor { get; set; }
    }

    // Las columnas cambian según la tabla: no se fijan propiedades de empleados.
    public class ClsModeloRegistro : IValidatableObject
    {
        private readonly Dictionary<string, string> _Datos;
        private readonly List<ClsColumnaInfo> _Columnas;

        public ClsModeloRegistro(Dictionary<string, string> Datos, List<ClsColumnaInfo> Columnas)
        {
            _Datos = Datos;
            _Columnas = Columnas;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext Contexto)
        {
            if (_Columnas == null || _Columnas.Count == 0)
            {
                yield return new ValidationResult("No se encontró el esquema de la tabla.");
                yield break;
            }
            if (_Datos == null || _Datos.Count == 0)
            {
                yield return new ValidationResult("La colección de datos está vacía.");
                yield break;
            }
            // Validar solo los campos enviados permite actualizar parcialmente y eliminar por PK.
            foreach (var Dato in _Datos)
            {
                var Columna = _Columnas.Find(Item =>
                    string.Equals(Item.Nombre, Dato.Key, StringComparison.OrdinalIgnoreCase));
                if (Columna == null)
                {
                    yield return new ValidationResult("El atributo '" + Dato.Key + "' no existe en la tabla.", new[] { Dato.Key });
                    continue;
                }
                var Campo = new ClsModeloCampo { Columna = Columna, Valor = Dato.Value };
                var Resultados = new List<ValidationResult>();
                // TryValidateObject no recorre objetos hijos automáticamente.
                Validator.TryValidateObject(Campo, new ValidationContext(Campo), Resultados, true);
                foreach (var Resultado in Resultados)
                    yield return Resultado;
            }
        }
    }
}
// Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
// Fin - Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429.
