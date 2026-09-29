using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Text.RegularExpressions;

namespace CapaModelo_Consultas
{
    /*
    Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "15/09/26"
    Repositorio de la Consulta Simple. Único lugar del componente donde se arman y se
    ejecutan las sentencias SQL del filtrado (EST-10 sección 3: el SQL vive en Modelo).
    El valor que escribe el usuario SIEMPRE viaja como parámetro; el nombre de la tabla
    y el del campo no se pueden parametrizar en SQL, así que se validan contra la lista
    real de columnas antes de concatenarse.
    */
    public class ClsSentenciasFiltroSimple
    {
        private readonly ClsConexion _Conexion = new ClsConexion();

        // Operadores que el Modelo acepta. Cualquier otro se rechaza.
        private static readonly string[] _OperadoresPermitidos =
        {
            "=", "<>", ">", "<", ">=", "<=", "LIKE"
        };

        /// <summary>
        /// Devuelve los nombres de las columnas de una tabla, en el orden en que
        /// están definidas. Se usa para poblar el combo de campos y, sobre todo,
        /// como lista blanca para validar el campo que llega desde la Vista.
        /// </summary>
        public List<string> ConsultasFuncObtenerCampos(string NombreTabla)
        {
            ConsultasMetValidarIdentificador(NombreTabla, "tabla");

            List<string> Campos = new List<string>();

            string Consulta =
                "SELECT COLUMN_NAME " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_SCHEMA = DATABASE() " +
                "AND TABLE_NAME = ? " +
                "ORDER BY ORDINAL_POSITION;";

            using (OdbcConnection Conexion = _Conexion.ConsultasFuncConexion())
            {
                using (OdbcCommand Comando = new OdbcCommand(Consulta, Conexion))
                {
                    Comando.Parameters.AddWithValue("?", NombreTabla);

                    using (OdbcDataReader Lector = Comando.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Campos.Add(Lector["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }

            return Campos;
        }

        /// <summary>
        /// Trae una página de registros de la tabla aplicando un filtro opcional.
        /// Si Campo u Operador vienen vacíos, devuelve la tabla sin filtrar.
        /// </summary>
        public DataTable ConsultasFuncFiltrarTabla(
            string NombreTabla,
            string Campo,
            string Operador,
            string Valor,
            int Pagina,
            int RegistrosPorPagina)
        {
            ConsultasMetValidarIdentificador(NombreTabla, "tabla");

            bool HayFiltro = ConsultasFuncHayFiltro(Campo, Operador);

            if (HayFiltro)
            {
                ConsultasMetValidarCampo(NombreTabla, Campo);
                ConsultasMetValidarOperador(Operador);
            }

            DataTable Resultado = new DataTable();

            int Inicio = (Pagina - 1) * RegistrosPorPagina;

            string Consulta = "SELECT * FROM " + NombreTabla;

            if (HayFiltro)
            {
                Consulta += " WHERE " + Campo + " " + Operador + " ?";
            }

            Consulta += " LIMIT ? OFFSET ?;";

            using (OdbcConnection Conexion = _Conexion.ConsultasFuncConexion())
            {
                using (OdbcCommand Comando = new OdbcCommand(Consulta, Conexion))
                {
                    // ODBC usa parámetros posicionales: el orden en que se agregan
                    // debe ser el mismo orden en que aparecen los "?" en la sentencia.
                    if (HayFiltro)
                    {
                        Comando.Parameters.AddWithValue("?", Valor ?? string.Empty);
                    }

                    Comando.Parameters.AddWithValue("?", RegistrosPorPagina);
                    Comando.Parameters.AddWithValue("?", Inicio);

                    using (OdbcDataAdapter AdaptadorResultado = new OdbcDataAdapter(Comando))
                    {
                        AdaptadorResultado.Fill(Resultado);
                    }
                }
            }

            return Resultado;
        }

        /// <summary>
        /// Cuenta cuántos registros cumplen el filtro. Lo necesita la paginación
        /// para saber cuántas páginas dibujar.
        /// </summary>
        public int ConsultasFuncContarFiltrados(
            string NombreTabla,
            string Campo,
            string Operador,
            string Valor)
        {
            ConsultasMetValidarIdentificador(NombreTabla, "tabla");

            bool HayFiltro = ConsultasFuncHayFiltro(Campo, Operador);

            if (HayFiltro)
            {
                ConsultasMetValidarCampo(NombreTabla, Campo);
                ConsultasMetValidarOperador(Operador);
            }

            string Consulta = "SELECT COUNT(*) FROM " + NombreTabla;

            if (HayFiltro)
            {
                Consulta += " WHERE " + Campo + " " + Operador + " ?";
            }

            Consulta += ";";

            using (OdbcConnection Conexion = _Conexion.ConsultasFuncConexion())
            {
                using (OdbcCommand Comando = new OdbcCommand(Consulta, Conexion))
                {
                    if (HayFiltro)
                    {
                        Comando.Parameters.AddWithValue("?", Valor ?? string.Empty);
                    }

                    object Total = Comando.ExecuteScalar();

                    return Total == null || Total == DBNull.Value
                        ? 0
                        : Convert.ToInt32(Total);
                }
            }
        }

        private bool ConsultasFuncHayFiltro(string Campo, string Operador)
        {
            return !string.IsNullOrWhiteSpace(Campo)
                && !string.IsNullOrWhiteSpace(Operador);
        }

        /// <summary>
        /// Un identificador de SQL (tabla o columna) no se puede parametrizar,
        /// así que solo se aceptan nombres con forma de identificador válido.
        /// </summary>
        private void ConsultasMetValidarIdentificador(
            string Identificador,
            string Descripcion)
        {
            if (string.IsNullOrWhiteSpace(Identificador))
            {
                throw new ArgumentException(
                    "El nombre de la " + Descripcion + " no puede estar vacío.");
            }

            if (!Regex.IsMatch(Identificador, @"^[A-Za-z_][A-Za-z0-9_]*$"))
            {
                throw new ArgumentException(
                    "El nombre de la " + Descripcion +
                    " contiene caracteres no válidos: " + Identificador);
            }
        }

        /// <summary>
        /// Defensa real contra inyección en el nombre del campo: además de la forma,
        /// el campo tiene que existir de verdad en la tabla.
        /// </summary>
        private void ConsultasMetValidarCampo(string NombreTabla, string Campo)
        {
            ConsultasMetValidarIdentificador(Campo, "columna");

            List<string> CamposReales = ConsultasFuncObtenerCampos(NombreTabla);

            bool Existe = CamposReales.Exists(
                CampoReal => string.Equals(
                    CampoReal,
                    Campo,
                    StringComparison.OrdinalIgnoreCase));

            if (!Existe)
            {
                throw new ArgumentException(
                    "La columna '" + Campo + "' no existe en la tabla '" +
                    NombreTabla + "'.");
            }
        }

        private void ConsultasMetValidarOperador(string Operador)
        {
            if (Array.IndexOf(_OperadoresPermitidos, Operador) < 0)
            {
                throw new ArgumentException(
                    "El operador '" + Operador + "' no está permitido.");
            }
        }

        public string ConsultasFuncTraducirOperador(string OperadorVisible)
        {
            if (string.IsNullOrWhiteSpace(OperadorVisible))
            {
                return string.Empty;
            }

            switch (OperadorVisible)
            {
                case "Contiene":
                case "Comienza con":
                case "Termina con":
                    return "LIKE";

                default:
                    return OperadorVisible;
            }
        }

        public string ConsultasFuncPrepararValor(
           string OperadorVisible,
           string Valor)
        {
            string ValorLimpio = (Valor ?? string.Empty).Trim();

            // Se escapan los comodines que el usuario haya escrito, para que
            // un "%" tecleado se busque como texto y no como comodín.
            string ValorEscapado = ValorLimpio
                .Replace("\\", "\\\\")
                .Replace("%", "\\%")
                .Replace("_", "\\_");

            switch (OperadorVisible)
            {
                case "Contiene":
                    return "%" + ValorEscapado + "%";

                case "Comienza con":
                    return ValorEscapado + "%";

                case "Termina con":
                    return "%" + ValorEscapado;

                default:
                    return ValorLimpio;
            }
        }
    }
    // Fin del código de "José Pablo Cano Cóbar" - Carné: "0901-23-1727" - Fecha: "15/09/26"
}
