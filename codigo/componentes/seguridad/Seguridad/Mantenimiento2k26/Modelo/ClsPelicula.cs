using System;

namespace Mantenimiento2k26.Modelo.Entidades
{
    public class ClsPelicula
    {
        public int IdPeliculas { get; set; }

        public string Nombre { get; set; }

        public string Clasificacion { get; set; }

        public string Genero { get; set; }

        public string Subtitulado { get; set; }

        public string Idioma { get; set; }

        public double Precio { get; set; }
    }
}