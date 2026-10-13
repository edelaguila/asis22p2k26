
using System;

namespace CapaModelo_Mantenimiento2k26u.Entidades
{
    public class ClsPelicula
    {
        private int _IdPelicula;
        private string _NombrePelicula;
        private string _ClasificacionPelicula;
        private string _GeneroPelicula;
        private string _SubtituladoPelicula;
        private string _IdiomaPelicula;
        private double _PrecioPelicula;
        private bool _IsActive;

        public int IdPelicula { get => _IdPelicula; set => _IdPelicula = value; }
        public string NombrePelicula { get => _NombrePelicula; set => _NombrePelicula = value; }
        public string ClasificacionPelicula { get => _ClasificacionPelicula; set => _ClasificacionPelicula = value; }
        public string GeneroPelicula { get => _GeneroPelicula; set => _GeneroPelicula = value; }
        public string SubtituladoPelicula { get => _SubtituladoPelicula; set => _SubtituladoPelicula = value; }
        public string IdiomaPelicula { get => _IdiomaPelicula; set => _IdiomaPelicula = value; }
        public double PrecioPelicula { get => _PrecioPelicula; set => _PrecioPelicula = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }

        public ClsPelicula()
        {
            _NombrePelicula = string.Empty;
            _ClasificacionPelicula = string.Empty;
            _GeneroPelicula = string.Empty;
            _SubtituladoPelicula = string.Empty;
            _IdiomaPelicula = string.Empty;
            _PrecioPelicula = 0;
            _IsActive = true;
        }
    }
}
