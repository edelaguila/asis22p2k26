using CapaModelo.Contratos;
using CapaModelo_Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Mantenimiento2k26.Modelo
{
    public class ClsRepositorioDepartamento : ClsSentencias, IRepositorioDepartamento
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioDepartamento()
        {
            _SelectAll = "SELECT codigo_departamento, nombre_departamento, estatus_departamento FROM departamento ORDER BY codigo_departamento";
            _Insert = "INSERT INTO departamento (codigo_departamento, nombre_departamento, estatus_departamento) VALUES (?, ?, ?)";
            _Update = "UPDATE departamento SET nombre_departamento = ?, estatus_departamento = ? WHERE codigo_departamento = ?";
            _Delete = "DELETE FROM departamento WHERE codigo_departamento = ?";
        }

        public int Agregar(ClsDepartamento Entidad)
        {
            var P = new List<OdbcParameter>();
            P.Add(new OdbcParameter("p1", Entidad.CodigoDepartamento));
            P.Add(new OdbcParameter("p2", Entidad.NombreDepartamento));
            P.Add(new OdbcParameter("p3", Entidad.EstatusDepartamento));
            return SeguridadMetEjecucionNonQuery(_Insert, P, CommandType.Text);
        }

        public int Editar(ClsDepartamento Entidad)
        {
            var P = new List<OdbcParameter>();
            P.Add(new OdbcParameter("p1", Entidad.NombreDepartamento));
            P.Add(new OdbcParameter("p2", Entidad.EstatusDepartamento));
            P.Add(new OdbcParameter("p3", Entidad.CodigoDepartamento));
            return SeguridadMetEjecucionNonQuery(_Update, P, CommandType.Text);
        }

        public int Remover(ClsDepartamento Entidad)
        {
            var P = new List<OdbcParameter>();
            P.Add(new OdbcParameter("p1", Entidad.CodigoDepartamento));
            return SeguridadMetEjecucionNonQuery(_Delete, P, CommandType.Text);
        }

        public IEnumerable<ClsDepartamento> ObtenerTodos()
        {
            var Lista = new List<ClsDepartamento>();
            var Tabla = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in Tabla.Rows)
            {
                Lista.Add(new ClsDepartamento
                {
                    CodigoDepartamento = Fila[0].ToString(),
                    NombreDepartamento = Fila[1].ToString(),
                    EstatusDepartamento = Fila[2].ToString()
                });
            }
            return Lista;
        }
    }
}