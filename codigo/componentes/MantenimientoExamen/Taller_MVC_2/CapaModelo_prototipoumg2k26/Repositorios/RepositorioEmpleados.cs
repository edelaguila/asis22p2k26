using CapaModelo_prototipoumg2k26.Contratos;
using CapaModelo_prototipoumg2k26.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_prototipoumg2k26.Repositorios
{
    // Se conserva el nombre del repositorio para no mover/renombrar archivos del proyecto.
    // Este repositorio trabaja ahora con la tabla tbl_roles.
    public class RepositorioEmpleados : RepositorioMaestro, IRepositorioEmpleados
    {
        private readonly string selectAll;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;

        public RepositorioEmpleados()
        {
            selectAll = "SELECT id_rol, nombre_rol, descripcion_rol FROM tbl_roles ORDER BY id_rol";
            insert = "INSERT INTO tbl_roles (nombre_rol, descripcion_rol) VALUES (?, ?)";
            update = "UPDATE tbl_roles SET nombre_rol = ?, descripcion_rol = ? WHERE id_rol = ?";
            delete = "DELETE FROM tbl_roles WHERE id_rol = ?";
        }

        public int Agregar(Empleados entidad)
        {
            var parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombre_rol", entidad.NombreRol),
                new OdbcParameter("p_descripcion_rol", (object)entidad.DescripcionRol ?? DBNull.Value)
            };

            return EjecucionNonQuery(insert, parametros, CommandType.Text);
        }

        public int Editar(Empleados entidad)
        {
            var parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombre_rol", entidad.NombreRol),
                new OdbcParameter("p_descripcion_rol", (object)entidad.DescripcionRol ?? DBNull.Value),
                new OdbcParameter("p_id_rol", entidad.IdRol)
            };

            return EjecucionNonQuery(update, parametros, CommandType.Text);
        }

        public int Remover(Empleados entidad)
        {
            var parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_id_rol", entidad.IdRol)
            };

            return EjecucionNonQuery(delete, parametros, CommandType.Text);
        }

        public IEnumerable<Empleados> GetAll()
        {
            var listaRoles = new List<Empleados>();
            var tabla = EjecucionConsulta(selectAll, CommandType.Text);

            foreach (DataRow row in tabla.Rows)
            {
                listaRoles.Add(new Empleados
                {
                    IdRol = Convert.ToInt32(row["id_rol"]),
                    NombreRol = row["nombre_rol"].ToString(),
                    DescripcionRol = row["descripcion_rol"] == DBNull.Value
                        ? string.Empty
                        : row["descripcion_rol"].ToString()
                });
            }

            tabla.Clear();
            return listaRoles;
        }
    }
}
