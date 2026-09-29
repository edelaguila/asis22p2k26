using CapaModelo_Consultas;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaControlador_Consultas
{
    /*
    Inicio de código de "José Pablo Cano Cóbar" - carné: "0901-23-1727" - Fecha: "15/09/26"
    Controlador de la Consulta Simple. Traduce lo que el usuario eligió en pantalla
    ("Contiene", "Comienza con"...) al operador de SQL que entiende el Modelo, y le
    prepara el valor con los comodines que correspondan. No arma sentencias SQL:
    eso es responsabilidad exclusiva de la Capa Modelo (EST-10 sección 3).
    */
    public class ClsControladorFiltroSimple
    {
        private readonly ClsSentenciasFiltroSimple _Sentencias = new ClsSentenciasFiltroSimple();

        /// <summary>
        /// Lista de campos de la tabla, para poblar el combo de la Vista.
        /// Devuelve texto, no controles: el Modelo y el Controlador no conocen
        /// System.Windows.Forms.
        /// </summary>
        public List<string> ConsultasFuncObtenerCampos(string NombreTabla)
        {
            if (string.IsNullOrWhiteSpace(NombreTabla))
            {
                return new List<string>();
            }

            return _Sentencias.ConsultasFuncObtenerCampos(NombreTabla);
        }

        /// <summary>
        /// Operadores que se le ofrecen al usuario en el combo, en el texto que él lee.
        /// </summary>
        public List<string> ConsultasFuncObtenerOperadores()
        {
            return new List<string>
            {
                "=",
                "<>",
                ">",
                "<",
                ">=",
                "<=",
                "Contiene",
                "Comienza con",
                "Termina con"
            };
        }

        /// <summary>
        /// Ejecuta la búsqueda filtrada y devuelve la página pedida.
        /// </summary>
        public DataTable ConsultasFuncBuscar(
            string NombreTabla,
            string Campo,
            string OperadorVisible,
            string Valor,
            int Pagina,
            int RegistrosPorPagina)
        {
            string OperadorSql = ConsultasFuncTraducirOperador(OperadorVisible);
            string ValorSql = ConsultasFuncPrepararValor(OperadorVisible, Valor);

            return _Sentencias.ConsultasFuncFiltrarTabla(
                NombreTabla,
                Campo,
                OperadorSql,
                ValorSql,
                Pagina,
                RegistrosPorPagina);
        }

        /// <summary>
        /// Total de registros que cumplen el filtro, para la paginación.
        /// </summary>
        public int ConsultasFuncContar(
            string NombreTabla,
            string Campo,
            string OperadorVisible,
            string Valor)
        {
            string OperadorSql = ConsultasFuncTraducirOperador(OperadorVisible);
            string ValorSql = ConsultasFuncPrepararValor(OperadorVisible, Valor);

            return _Sentencias.ConsultasFuncContarFiltrados(
                NombreTabla,
                Campo,
                OperadorSql,
                ValorSql);
        }

        /// <summary>
        /// Valida lo que el usuario llenó antes de ir a la base de datos.
        /// Devuelve null si todo está bien, o el mensaje a mostrar si falta algo.
        /// </summary>
        public string ConsultasFuncValidarFiltro(
            string Campo,
            string OperadorVisible,
            string Valor)
        {
            if (string.IsNullOrWhiteSpace(Campo))
            {
                return "Seleccione el campo por el que desea filtrar.";
            }

            if (string.IsNullOrWhiteSpace(OperadorVisible))
            {
                return "Seleccione el operador de comparación.";
            }

            if (string.IsNullOrWhiteSpace(Valor))
            {
                return "Escriba el valor que desea buscar.";
            }

            return null;
        }

        private string ConsultasFuncTraducirOperador(string OperadorVisible)
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

        //Inicio del código de Migurl David Contreras Jacinto 0901-21-3878 el 21/09/2026
        public Type ConsultasFuncObtenerTipoCampo(
        string NombreTabla,
        string NombreCampo)
        {
            return _Sentencias.ConsultasFuncObtenerTipoCampo(
                NombreTabla,
                NombreCampo);
        }

        //Fin del código de Migurl David Contreras Jacinto 0901-21-3878 el 21/09/2026

        private string ConsultasFuncPrepararValor(
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
