using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using CapaModelo_Consultas;

namespace CapaControlador_Consultas
{
    //Inicio del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457
    public class ClsControladorMantenimiento
    {
        private readonly ClsModeloMantenimiento _Modelo =
            new ClsModeloMantenimiento();

        public List<KeyValuePair<string, string>> ConsultasMetObtenerColumnas(
            string Tabla)
        {
            ConsultasProcValidarIdentificador(Tabla, "tabla");
            return _Modelo.ConsultasFuncObtenerColumnas(Tabla);
        }

        public void ConsultasProcValidarCondicion(
            string Campo,
            string Operador,
            string Valor,
            Dictionary<string, string> Tipos)
        {
            ConsultasProcValidarIdentificador(Campo, "campo");

            if (!string.IsNullOrEmpty(Operador))
            {
                _Modelo.ConsultasFuncFormatearCondicion(
                    new ClsCondicion
                    {
                        Campo = Campo,
                        Operador = Operador,
                        Valor = Valor
                    },
                    Tipos);
            }
        }

        public string ConsultasFuncConstruirQuery(
            string Tabla,
            List<(string Campo, string Operador, string Valor,
                  string Orden, string Conector)> Filas,
            Dictionary<string, string> Tipos)
        {
            ConsultasProcValidarIdentificador(Tabla, "tabla");

            List<ClsCondicion> FilasModelo = new List<ClsCondicion>();

            foreach (var Fila in Filas)
            {
                ConsultasProcValidarIdentificador(Fila.Campo, "campo");

                FilasModelo.Add(new ClsCondicion
                {
                    Campo = Fila.Campo,
                    Operador = Fila.Operador,
                    Valor = Fila.Valor,
                    Orden = Fila.Orden,
                    Conector = Fila.Conector
                });
            }

            return _Modelo.ConsultasFuncConstruirQuery(
                Tabla, FilasModelo, Tipos);
        }

        private static void ConsultasProcValidarIdentificador(
            string Nombre,
            string Auxiliar)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new ArgumentException(
                    "Selecciona " +
                    (Auxiliar == "tabla"
                        ? "una tabla o vista."
                        : "un campo."));
            }

            if (!Regex.IsMatch(Nombre, "^[A-Za-z0-9_]+$"))
            {
                throw new ArgumentException(
                    "El nombre de " + Auxiliar +
                    " no es válido: " + Nombre);
            }
        }

        public void ConsultasProcGuardar(
            string Nombre,
            string Tabla,
            string Query)
        {
            Nombre = (Nombre ?? "").Trim();

            if (Nombre.Length == 0)
            {
                throw new ArgumentException(
                    "Escribe un nombre para la consulta.");
            }

            if (Nombre.Length > 100)
            {
                throw new ArgumentException(
                    "El nombre no puede pasar de 100 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(Tabla))
            {
                throw new ArgumentException(
                    "Selecciona una tabla o vista.");
            }

            ConsultasProcValidarEsSelect(Query);

            if (_Modelo.ConsultasFuncExisteNombre(Nombre))
            {
                throw new ArgumentException(
                    "Ya existe una consulta con ese nombre. Usa otro.");
            }

            _Modelo.ConsultasProcInsertarConsulta(
                Nombre, Tabla, Query);
        }

        public DataTable ConsultasFuncPrueba(string Query)
        {
            ConsultasProcValidarEsSelect(Query);
            return _Modelo.ConsultasFuncEjecutarConsulta(Query, 500);
        }

        private void ConsultasProcValidarEsSelect(string Query)
        {
            if (!_Modelo.ConsultasFuncEsInstruccionSelect(Query))
            {
                throw new ArgumentException(
                    "Primero arma la consulta: elige una tabla o vista.");
            }
        }
    }
    //Fin del código realizado por Diana Mishel Loeiza Ramírez 9959-23-3457
}