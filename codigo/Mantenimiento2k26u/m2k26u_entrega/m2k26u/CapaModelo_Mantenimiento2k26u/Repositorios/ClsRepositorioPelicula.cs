

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using CapaModelo_Mantenimiento2k26u.Contratos;
using CapaModelo_Mantenimiento2k26u.Entidades;
using CapaModelo_Seguridad;

namespace CapaModelo_Mantenimiento2k26u.Repositorios
{
    public class ClsRepositorioPelicula : ClsSentencias, IRepositorioPelicula
    {
        private readonly string _SelectAll;
        private readonly string _SelectPorId;
        private readonly string _SelectPorNombre;
        private readonly string _SelectReporte;
        private readonly string _Insert;
        private readonly string _Update;
        private readonly string _Delete;

        public ClsRepositorioPelicula()
        {
            _SelectAll =
                "SELECT idPelicula, nombrePelicula, clasificacionPelicula, generoPelicula, " +
                "       subtituladoPelicula, idiomaPelicula, precioPelicula, is_active " +
                "  FROM tblpelicula " +
                " ORDER BY idPelicula";

            _SelectPorId =
                "SELECT idPelicula, nombrePelicula, clasificacionPelicula, generoPelicula, " +
                "       subtituladoPelicula, idiomaPelicula, precioPelicula, is_active " +
                "  FROM tblpelicula " +
                " WHERE idPelicula = ?";

            _SelectPorNombre =
                "SELECT idPelicula, nombrePelicula, clasificacionPelicula, generoPelicula, " +
                "       subtituladoPelicula, idiomaPelicula, precioPelicula, is_active " +
                "  FROM tblpelicula " +
                " WHERE nombrePelicula LIKE ? ESCAPE '\\' " +
                " ORDER BY nombrePelicula";

            _SelectReporte =
                "SELECT idPelicula            AS IdPelicula, " +
                "       nombrePelicula        AS NombrePelicula, " +
                "       clasificacionPelicula AS ClasificacionPelicula, " +
                "       generoPelicula        AS GeneroPelicula, " +
                "       subtituladoPelicula   AS SubtituladoPelicula, " +
                "       idiomaPelicula        AS IdiomaPelicula, " +
                "       precioPelicula        AS PrecioPelicula, " +
                "       CAST(is_active AS UNSIGNED) AS IsActive " +
                "  FROM tblpelicula " +
                " ORDER BY nombrePelicula";

            _Insert =
                "INSERT INTO tblpelicula " +
                "      (nombrePelicula, clasificacionPelicula, generoPelicula, " +
                "       subtituladoPelicula, idiomaPelicula, precioPelicula, is_active) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?)";

            _Update =
                "UPDATE tblpelicula " +
                "   SET nombrePelicula        = ?, " +
                "       clasificacionPelicula = ?, " +
                "       generoPelicula        = ?, " +
                "       subtituladoPelicula   = ?, " +
                "       idiomaPelicula        = ?, " +
                "       precioPelicula        = ?, " +
                "       is_active             = ? " +
                " WHERE idPelicula = ?";

            _Delete = "DELETE FROM tblpelicula WHERE idPelicula = ?";
        }


        public int MantenimientoFuncAgregar(ClsPelicula Entidad)
        {
            using (OdbcConnection Conexion = SeguridadMetObtenerConexion())
            {
                Conexion.Open();

                using (OdbcCommand Comando = new OdbcCommand(_Insert, Conexion))
                {
                    Comando.CommandType = CommandType.Text;
                    Comando.Parameters.Add(new OdbcParameter("p_nombrePelicula", Entidad.NombrePelicula));
                    Comando.Parameters.Add(new OdbcParameter("p_clasificacionPelicula", Entidad.ClasificacionPelicula));
                    Comando.Parameters.Add(new OdbcParameter("p_generoPelicula", Entidad.GeneroPelicula));
                    Comando.Parameters.Add(new OdbcParameter("p_subtituladoPelicula", Entidad.SubtituladoPelicula));
                    Comando.Parameters.Add(new OdbcParameter("p_idiomaPelicula", Entidad.IdiomaPelicula));
                    Comando.Parameters.Add(new OdbcParameter("p_precioPelicula", OdbcType.Double) { Value = Entidad.PrecioPelicula });
                    Comando.Parameters.Add(new OdbcParameter("p_is_active", Entidad.IsActive ? 1 : 0));
                    Comando.ExecuteNonQuery();
                }

                // Misma conexión: LAST_INSERT_ID() es por conexión.
                using (OdbcCommand Identidad = new OdbcCommand("SELECT LAST_INSERT_ID()", Conexion))
                {
                    object Valor = Identidad.ExecuteScalar();
                    return Valor == null || Valor == DBNull.Value ? 0 : Convert.ToInt32(Valor);
                }
            }
        }

        public int MantenimientoFuncEditar(ClsPelicula Entidad)
        {
            List<OdbcParameter> Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombrePelicula", Entidad.NombrePelicula),
                new OdbcParameter("p_clasificacionPelicula", Entidad.ClasificacionPelicula),
                new OdbcParameter("p_generoPelicula", Entidad.GeneroPelicula),
                new OdbcParameter("p_subtituladoPelicula", Entidad.SubtituladoPelicula),
                new OdbcParameter("p_idiomaPelicula", Entidad.IdiomaPelicula),
                new OdbcParameter("p_precioPelicula", OdbcType.Double) { Value = Entidad.PrecioPelicula },
                new OdbcParameter("p_is_active", Entidad.IsActive ? 1 : 0),
                new OdbcParameter("p_idPelicula", Entidad.IdPelicula)
            };
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int MantenimientoFuncRemover(ClsPelicula Entidad)
        {
            List<OdbcParameter> Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_idPelicula", Entidad.IdPelicula)
            };
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public DataTable MantenimientoFuncObtenerTabla()
        {
            return SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
        }

        public DataTable MantenimientoFuncObtenerReporte()
        {
            return SeguridadMetEjecucionConsulta(_SelectReporte, CommandType.Text);
        }

        public DataTable MantenimientoFuncBuscarPorNombre(string Filtro)
        {
            string Texto = Filtro == null ? string.Empty : Filtro.Trim();

            Texto = Texto.Replace("\\", "\\\\").Replace("%", "\\%").Replace("_", "\\_");

            List<OdbcParameter> Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_nombrePelicula", "%" + Texto + "%")
            };
            return SeguridadMetEjecucionConsulta(_SelectPorNombre, CommandType.Text, Parametros);
        }

        public ClsPelicula MantenimientoFuncObtenerPorId(int IdPelicula)
        {
            List<OdbcParameter> Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("p_idPelicula", IdPelicula)
            };

            DataTable Tabla = SeguridadMetEjecucionConsulta(_SelectPorId, CommandType.Text, Parametros);
            if (Tabla.Rows.Count == 0) { return null; }
            return MantenimientoFuncMapear(Tabla.Rows[0]);
        }

        public IEnumerable<ClsPelicula> MantenimientoFuncObtenerTodas()
        {
            List<ClsPelicula> Lista = new List<ClsPelicula>();
            DataTable Tabla = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);

            foreach (DataRow Fila in Tabla.Rows)
            {
                Lista.Add(MantenimientoFuncMapear(Fila));
            }
            return Lista;
        }

        private static ClsPelicula MantenimientoFuncMapear(DataRow Fila)
        {
            return new ClsPelicula
            {
                IdPelicula            = Convert.ToInt32(Fila[0]),
                NombrePelicula        = Fila[1] == DBNull.Value ? string.Empty : Fila[1].ToString(),
                ClasificacionPelicula = Fila[2] == DBNull.Value ? string.Empty : Fila[2].ToString(),
                GeneroPelicula        = Fila[3] == DBNull.Value ? string.Empty : Fila[3].ToString(),
                SubtituladoPelicula   = Fila[4] == DBNull.Value ? string.Empty : Fila[4].ToString(),
                IdiomaPelicula        = Fila[5] == DBNull.Value ? string.Empty : Fila[5].ToString(),
                PrecioPelicula        = Fila[6] == DBNull.Value ? 0 : Convert.ToDouble(Fila[6]),
                IsActive              = Fila[7] != DBNull.Value && Convert.ToInt32(Fila[7]) == 1
            };
        }
    }
}
