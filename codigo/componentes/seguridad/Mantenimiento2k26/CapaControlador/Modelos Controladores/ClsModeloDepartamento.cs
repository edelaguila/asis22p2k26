using CapaControlador_Seguridad;
using Mantenimiento2k26.Modelo;
using System;
using System.Collections.Generic;
using Mantenimiento2k26.Modelo;
using System;
using System.Collections.Generic;

namespace Mantenimiento2k26.Controlador
{
    public class ClsModeloDepartamento
    {
        private ClsRepositorioDepartamento _Repositorio;
        private List<ClsModeloDepartamento> _Lista;

        public EstadoEntidad Estado { private get; set; }
        public string CodigoDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public string EstatusDepartamento { get; set; }

        public ClsModeloDepartamento()
        {
            _Repositorio = new ClsRepositorioDepartamento();
        }

        public string GrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var Datos = new ClsDepartamento
                {
                    CodigoDepartamento = CodigoDepartamento,
                    NombreDepartamento = NombreDepartamento,
                    EstatusDepartamento = EstatusDepartamento
                };
                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _Repositorio.Agregar(Datos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "departamento", 0, "Se agregó departamento: " + NombreDepartamento);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _Repositorio.Editar(Datos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "departamento", 0, "Se actualizó departamento: " + NombreDepartamento);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _Repositorio.Remover(Datos);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "departamento", 0, "Se eliminó departamento: " + CodigoDepartamento);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (Exception Ex) { Mensaje = Ex.ToString(); }
            return Mensaje;
        }

        public List<ClsModeloDepartamento> ObtenerTodos()
        {
            _Lista = new List<ClsModeloDepartamento>();
            ClsModeloBitacora.SeguridadMetRegistrarAccion("SELECT", "departamento", 0, "Consulta de departamentos");
            foreach (var Item in _Repositorio.ObtenerTodos())
            {
                _Lista.Add(new ClsModeloDepartamento
                {
                    CodigoDepartamento = Item.CodigoDepartamento,
                    NombreDepartamento = Item.NombreDepartamento,
                    EstatusDepartamento = Item.EstatusDepartamento
                });
            }
            return _Lista;
        }
    }
}