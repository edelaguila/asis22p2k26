using System;

namespace Mantenimiento2k26.Modelo
{
    public class ClsPaciente
    {
        public int PkIdPaciente { get; set; }
        public string NombrePaci { get; set; }
        public string ApellidoPaci { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Genero { get; set; }
        public string DireccionPaci { get; set; }
        public int Telefono { get; set; }
        public int EstadoPaci { get; set; }

        public string GeneroTexto => Genero == 1 ? "Masculino" : "Femenino";
        public string EstadoTexto => EstadoPaci == 1 ? "Activo" : "Inactivo";
    }
}
