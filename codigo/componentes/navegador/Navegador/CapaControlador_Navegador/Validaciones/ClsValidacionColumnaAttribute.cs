// Inicio - Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429.
// Inicio cambio - Gabriel André Guillén Pocón - 0901-23-1998: nombres ajustados a EST-10 (prefijo Cls, PascalCase).
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;
using CapaModelo_Navegador;

namespace CapaControlador_Navegador
{
    // El sufijo "Attribute" lo exige C# para poder usarse como [ClsValidacionColumna].
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ClsValidacionColumnaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object Valor, ValidationContext Contexto)
        {
            var Campo = (ClsModeloCampo)Contexto.ObjectInstance;
            string Error = NavegadorFuncValidarAtributo((string)Valor, Campo.Columna);
            return string.IsNullOrEmpty(Error) ? ValidationResult.Success
                : new ValidationResult(Error, new[] { Campo.Columna == null ? "Valor" : Campo.Columna.Nombre });
        }
        private static readonly string[] _TiposTexto =
        {
            "string", "char", "nchar", "varchar", "nvarchar", "varchar2",
            "nvarchar2", "character", "character varying", "text", "ntext",
            "tinytext", "mediumtext", "longtext", "memo", "clob", "nclob",
            "citext", "json", "jsonb", "xml", "enum", "set"
        };

        private static readonly string[] _TiposEnteros =
        {
            "byte", "sbyte", "int16", "int32", "int64", "uint16", "uint32",
            "uint64", "tinyint", "smallint", "mediumint", "int", "integer",
            "bigint", "int2", "int4", "int8", "serial", "smallserial",
            "bigserial", "counter", "year"
        };

        private static readonly string[] _TiposDecimales =
        {
            "decimal", "numeric", "number", "money", "smallmoney", "currency"
        };

        private static readonly string[] _TiposReales =
        {
            "single", "double", "double precision", "float", "real"
        };

        private static readonly string[] _TiposFecha =
        {
            "date", "dateonly", "datetime", "datetime2", "smalldatetime",
            "timestamp", "timestamptz", "datetimeoffset"
        };

        private static readonly string[] _TiposBinarios =
        {
            "byte[]", "binary", "varbinary", "longvarbinary", "blob", "bytea",
            "image", "rowversion"
        };

        // Valida nulabilidad, longitud y tipo usando los metadatos reales de la columna.
        public string NavegadorFuncValidarAtributo(string Valor, ClsColumnaInfo Columna)
        {
            if (Columna == null)
                return "No se recibió la información del atributo.";

            if (string.IsNullOrWhiteSpace(Valor))
                return !Columna.Nullable && !Columna.EsAutoincremento && !new RequiredAttribute().IsValid(Valor)
                    ? "El atributo '" + Columna.Nombre + "' es obligatorio."
                    : "";

            if (NavegadorFuncEsBooleano(Columna))
            {
                string Booleano = Valor.Trim().ToLowerInvariant();
                return Regex.IsMatch(Booleano, @"^(0|1|true|false|yes|no|si)$")
                    ? "" : NavegadorFuncError(Columna, "booleano");
            }

            if (NavegadorFuncEsTipo(Columna, _TiposBinarios)) return "";

            if (NavegadorFuncEsTipo(Columna, _TiposEnteros))
                return Regex.IsMatch(Valor, @"^[+-]?\d+$")
                    ? "" : NavegadorFuncError(Columna, "entero");

            if (NavegadorFuncEsTipo(Columna, _TiposDecimales))
            {
                decimal Numero;
                return NavegadorFuncEsDecimal(Valor, out Numero)
                    ? "" : NavegadorFuncError(Columna, "decimal");
            }

            if (NavegadorFuncEsTipo(Columna, _TiposReales))
            {
                double Numero;
                return NavegadorFuncEsReal(Valor, out Numero)
                    ? "" : NavegadorFuncError(Columna, "numérico");
            }

            if (NavegadorFuncEsTipo(Columna, new[] { "guid", "uuid", "uniqueidentifier" }))
            {
                Guid Identificador;
                return Guid.TryParse(Valor, out Identificador)
                    ? "" : NavegadorFuncError(Columna, "identificador único");
            }

            if (NavegadorFuncEsTipo(Columna, _TiposFecha))
            {
                DateTime Fecha;
                return DateTime.TryParse(Valor, out Fecha)
                    ? "" : NavegadorFuncError(Columna, "fecha");
            }

            if (NavegadorFuncEsTipo(Columna, new[] { "time", "timeonly", "timespan", "interval" }))
            {
                TimeSpan Hora;
                return TimeSpan.TryParse(Valor, out Hora)
                    ? "" : NavegadorFuncError(Columna, "hora");
            }

            if (NavegadorFuncEsTipo(Columna, _TiposTexto))
            {
                long Limite = Columna.Longitud > 0
                    ? Columna.Longitud : Columna.TamanoColumna;

                if (Limite > 0 && Limite <= int.MaxValue && !new StringLengthAttribute((int)Limite).IsValid(Valor))
                    return "El atributo '" + Columna.Nombre +
                        "' admite como máximo " + Limite + " caracteres.";
            }

            // Los tipos propios del motor se delegan al proveedor ODBC.
            return "";
        }

        private bool NavegadorFuncEsBooleano(ClsColumnaInfo Columna)
        {
            string TipoCompleto = (Columna.TipoColumnaTexto ?? "")
                .ToLowerInvariant().Replace(" ", "");

            return NavegadorFuncEsTipo(Columna, new[] { "bool", "boolean" }) ||
                   TipoCompleto.Contains("tinyint(1)") ||
                   (NavegadorFuncEsTipo(Columna, new[] { "bit" }) &&
                    Columna.TamanoColumna <= 1);
        }

        private bool NavegadorFuncEsTipo(
            ClsColumnaInfo Columna,
            string[] Tipos)
        {
            string[] Fuentes =
            {
                Columna.TipoDato, Columna.TipoNet, Columna.TipoColumnaTexto
            };

            foreach (string FuenteOriginal in Fuentes)
            {
                string Fuente = NavegadorFuncTipoBase(FuenteOriginal);
                foreach (string Tipo in Tipos)
                    if (Fuente == Tipo || Fuente.StartsWith(Tipo + " ")) return true;
            }

            return false;
        }

        private string NavegadorFuncTipoBase(string Tipo)
        {
            if (string.IsNullOrWhiteSpace(Tipo)) return "";
            string Resultado = Tipo.Trim().ToLowerInvariant();
            int Parentesis = Resultado.IndexOf('(');
            if (Parentesis >= 0) Resultado = Resultado.Substring(0, Parentesis);
            return Resultado.Replace(" unsigned", "").Replace(" zerofill", "").Trim();
        }

        private bool NavegadorFuncEsDecimal(string Valor, out decimal Numero)
        {
            return decimal.TryParse(Valor, NumberStyles.Number,
                       CultureInfo.CurrentCulture, out Numero) ||
                   decimal.TryParse(Valor, NumberStyles.Number,
                       CultureInfo.InvariantCulture, out Numero);
        }

        private bool NavegadorFuncEsReal(string Valor, out double Numero)
        {
            bool Valido = double.TryParse(Valor, NumberStyles.Float,
                              CultureInfo.CurrentCulture, out Numero) ||
                          double.TryParse(Valor, NumberStyles.Float,
                              CultureInfo.InvariantCulture, out Numero);

            return Valido && !double.IsNaN(Numero) && !double.IsInfinity(Numero);
        }

        private string NavegadorFuncError(ClsColumnaInfo Columna, string Tipo)
        {
            return "El atributo '" + Columna.Nombre + "' debe ser de tipo " + Tipo + ".";
        }
    }
}
// Fin cambio - Gabriel André Guillén Pocón - 0901-23-1998
// Fin - Roger Yankhel de Jesús Herrera Alcántara 0901-23-2429.
