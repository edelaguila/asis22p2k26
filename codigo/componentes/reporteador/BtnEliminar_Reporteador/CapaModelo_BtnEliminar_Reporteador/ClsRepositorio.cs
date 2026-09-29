using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CapaModelo_BtnEliminar_Reporteador
{
    public abstract class ClsRepositorio
    {
        protected readonly string _RutaArchivo;

        private static readonly object _Candado =
            new object();

        protected ClsRepositorio()
        {
            _RutaArchivo =
                ReporteadorMetRutaPorDefecto();
        }

        private string ReporteadorMetRutaPorDefecto()
        {
            string Carpeta =
                AppDomain.CurrentDomain.BaseDirectory;

            return Path.Combine(
                Carpeta,
                "ReportesDeshabilitados.txt");
        }

        protected List<int> ReporteadorMetLeerNumeros()
        {
            lock (_Candado)
            {
                if (!File.Exists(_RutaArchivo))
                {
                    return new List<int>();
                }

                List<int> Lista =
                    new List<int>();

                foreach (
                    string Linea
                    in File.ReadAllLines(_RutaArchivo))
                {
                    int Numero;

                    if (int.TryParse(
                        Linea.Trim(),
                        out Numero))
                    {
                        if (!Lista.Contains(Numero))
                        {
                            Lista.Add(Numero);
                        }
                    }
                }

                return Lista;
            }
        }

        protected void ReporteadorMetEscribirNumeros(
            IEnumerable<int> Numeros)
        {
            lock (_Candado)
            {
                IEnumerable<string> Lineas =
                    Numeros
                    .Distinct()
                    .OrderBy(
                        Numero => Numero)
                    .Select(
                        Numero => Numero.ToString());

                File.WriteAllLines(
                    _RutaArchivo,
                    Lineas);
            }
        }
    }
}