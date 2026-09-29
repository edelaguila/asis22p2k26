using System;

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsBitacora
    {
        public int IdBitacora { get; set; }
        public int? IdUsuario { get; set; }
        public string AccionBitacora { get; set; }
        public string TablaBitacora { get; set; }
        public int IdRegistroBitacora { get; set; }
        public string DetallesBitacora { get; set; }
        public string IpBitacora { get; set; }
        public DateTime FechaHoraBitacora { get; set; }
    }
}
