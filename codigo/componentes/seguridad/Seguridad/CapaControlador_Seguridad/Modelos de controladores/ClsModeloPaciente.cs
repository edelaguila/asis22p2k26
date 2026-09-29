using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Seguridad.Modelos_de_controladores
{
    public class ClsModeloPaciente
    {
        private int _idPaciente;
        private string _nombrePaci;
        private string _apellidoPaci;
        private DateTime _FechaNacimiento;
        private string _Genero;
        private bool _is_active;
        private DateTime _CreatedAt;
        private DateTime _UpdatedAt;

        //private ClsRepositorioPrueba _RepositorioPrueba;

        public EstadoEntidad Estado { private get; set; }

        // CAMBIAR: nombre de la lista (usada para BuscarPorId/Nombre)
        private List<ClsModeloPaciente> _ListaPrueba;

    }
}
