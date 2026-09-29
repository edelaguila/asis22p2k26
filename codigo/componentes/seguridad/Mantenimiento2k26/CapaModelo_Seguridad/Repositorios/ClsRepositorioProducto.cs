using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioProducto : ClsSentencias, IRepositorioGenerico<ClsProducto>
    {
        private readonly string _SelectAll;
        private readonly string _Insert;
        private readonly string _Update;
        private readonly string _Delete;
        private readonly string _SelectReporte;

        public ClsRepositorioProducto()
        {
            _SelectAll = "SELECT idProducto, nombreProducto, descripcionProducto, precioUnitario, is_active FROM tblProducto";
            _Insert = "INSERT INTO tblProducto (nombreProducto, descripcionProducto, precioUnitario, is_active) VALUES (?, ?, ?, ?)";
            _Update = "UPDATE tblProducto SET nombreProducto=?, descripcionProducto=?, precioUnitario=?, is_active=? WHERE idProducto=?";
            _Delete = "DELETE FROM tblProducto WHERE idProducto=?";
            _SelectReporte = "SELECT idProducto AS IdProducto, nombreProducto AS NombreProducto, descripcionProducto AS DescripcionProducto, precioUnitario AS PrecioUnitario, CAST(is_active AS UNSIGNED) AS IsActive FROM tblProducto";
        }

        public int SeguridadMetAgregar(ClsProducto Entidad)
        {
            var Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("nombreProducto",    OdbcType.VarChar)  { Value = Entidad.NombreProducto },
                new OdbcParameter("descripcionProducto", OdbcType.VarChar){ Value = Entidad.DescripcionProducto },
                new OdbcParameter("precioUnitario",    OdbcType.Decimal)  { Value = Entidad.PrecioUnitario },
                new OdbcParameter("is_active",         OdbcType.Bit)      { Value = Entidad.IsActive }
            };
            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsProducto Entidad)
        {
            var Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("nombreProducto",    OdbcType.VarChar)  { Value = Entidad.NombreProducto },
                new OdbcParameter("descripcionProducto", OdbcType.VarChar){ Value = Entidad.DescripcionProducto },
                new OdbcParameter("precioUnitario",    OdbcType.Decimal)  { Value = Entidad.PrecioUnitario },
                new OdbcParameter("is_active",         OdbcType.Bit)      { Value = Entidad.IsActive },
                new OdbcParameter("idProducto",        OdbcType.Int)      { Value = Entidad.IdProducto }
            };
            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsProducto Entidad)
        {
            var Parametros = new List<OdbcParameter>
            {
                new OdbcParameter("idProducto", OdbcType.Int) { Value = Entidad.IdProducto }
            };
            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsProducto> SeguridadMetObtenerTodos()
        {
            var Tabla = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            var Lista = new List<ClsProducto>();
            foreach (DataRow Fila in Tabla.Rows)
            {
                Lista.Add(new ClsProducto
                {
                    IdProducto = (int)Fila["idProducto"],
                    NombreProducto = Fila["nombreProducto"].ToString(),
                    DescripcionProducto = Fila["descripcionProducto"].ToString(),
                    PrecioUnitario = (decimal)Fila["precioUnitario"],
                    IsActive = (Fila["is_active"].ToString() == "1")
                });
            }
            return Lista;
        }

        public DataTable SeguridadMetObtenerProductosTabla()
        {
            return SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
        }

        public DataTable SeguridadMetObtenerProductosReporte()
        {
            return SeguridadMetEjecucionConsulta(_SelectReporte, CommandType.Text);
        }
    }
}