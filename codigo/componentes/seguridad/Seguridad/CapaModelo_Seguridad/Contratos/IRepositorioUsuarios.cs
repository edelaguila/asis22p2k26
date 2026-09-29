using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioUsuarios : IRepositorioGenerico<ClsUsuarios>
    {
        ClsUsuarios SeguridadMetValidarLogin(string NombreUsuario, string ContrasenaUsuario);

        // AGREGADO para recuperación de contraseña
        void SeguridadMetActualizarContrasena(int IdUsuario, string ContrasenaHasheada);
    }
}