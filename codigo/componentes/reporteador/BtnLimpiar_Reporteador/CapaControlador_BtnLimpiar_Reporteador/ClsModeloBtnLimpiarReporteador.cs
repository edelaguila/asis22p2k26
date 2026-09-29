using CapaModelo_BtnLimpiar_Reporteador.RepositoriosBtnLimpiarReporteador;

namespace CapaControlador_BtnLimpiar_Reporteador
{
    public class ClsModeloBtnLimpiarReporteador
    {
        private readonly ClsRepositorioBtnLimpiarReporteador
            _Repositorio;

        public ClsModeloBtnLimpiarReporteador()
        {
            _Repositorio =
                new ClsRepositorioBtnLimpiarReporteador();
        }

        public bool ReporteadorMetEjecutarLimpieza(
            out string Mensaje)
        {
            bool Resultado =
                _Repositorio.ReporteadorMetLimpiarDatos(
                    out string MensajeError);

            if (Resultado)
            {
                Mensaje =
                    "Los campos fueron limpiados " +
                    "correctamente.";

                return true;
            }

            if (string.IsNullOrWhiteSpace(
                MensajeError))
            {
                Mensaje =
                    "No se pudieron limpiar los campos.";
            }
            else
            {
                Mensaje =
                    MensajeError;
            }

            return false;
        }
    }
}