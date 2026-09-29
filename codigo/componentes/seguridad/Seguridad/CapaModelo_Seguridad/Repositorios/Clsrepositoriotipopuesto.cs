using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioTipoPuesto : ClsSentencias, IRepositorioTipoPuesto
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioTipoPuesto()
        {
            _SelectAll = "SELECT idTipoPuesto, nombreTipoPuesto, descripcionTipoPuesto, is_active, created_at, updated_at FROM tblTipoPuesto ORDER BY idTipoPuesto";
            _Insert = "INSERT INTO tblTipoPuesto (nombreTipoPuesto, descripcionTipoPuesto, is_active) VALUES (?, ?, ?)";
            _Update = "UPDATE tblTipoPuesto SET nombreTipoPuesto=?, descripcionTipoPuesto=?, is_active=? WHERE idTipoPuesto=?";
            _Delete = "DELETE FROM tblTipoPuesto WHERE idTipoPuesto=?";
        }

        public int SeguridadMetAgregar(ClsTipoPuesto Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_nombreTipoPuesto", Entidad.NombreTipoPuesto));
            Parametros.Add(new OdbcParameter("p_descripcionTipoPuesto", ValorODescripcion(Entidad.DescripcionTipoPuesto)));
            Parametros.Add(new OdbcParameter("p_isActive", Entidad.IsActive ? 1 : 0));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsTipoPuesto Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_nombreTipoPuesto", Entidad.NombreTipoPuesto));
            Parametros.Add(new OdbcParameter("p_descripcionTipoPuesto", ValorODescripcion(Entidad.DescripcionTipoPuesto)));
            Parametros.Add(new OdbcParameter("p_isActive", Entidad.IsActive ? 1 : 0));
            Parametros.Add(new OdbcParameter("p_idTipoPuesto", Entidad.IdTipoPuesto));

            return SeguridadMetEjecucionNonQuery(_Update, Parametros, CommandType.Text);
        }

        public int SeguridadMetRemover(ClsTipoPuesto Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idTipoPuesto", Entidad.IdTipoPuesto));

            return SeguridadMetEjecucionNonQuery(_Delete, Parametros, CommandType.Text);
        }

        public IEnumerable<ClsTipoPuesto> SeguridadMetObtenerTodos()
        {
            var ListaTipoPuesto = new List<ClsTipoPuesto>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var TipoPuesto = new ClsTipoPuesto();
                TipoPuesto.IdTipoPuesto = Convert.ToInt32(Fila[0]);
                TipoPuesto.NombreTipoPuesto = Fila[1].ToString();
                TipoPuesto.DescripcionTipoPuesto = Fila[2] == DBNull.Value ? null : Fila[2].ToString();
                TipoPuesto.IsActive = Convert.ToBoolean(Fila[3]);
                TipoPuesto.CreatedAt = Convert.ToDateTime(Fila[4]);
                TipoPuesto.UpdatedAt = Convert.ToDateTime(Fila[5]);
                ListaTipoPuesto.Add(TipoPuesto);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaTipoPuesto;
        }

        // La descripción es opcional: si viene vacía se guarda NULL
        private object ValorODescripcion(string Descripcion)
        {
            return string.IsNullOrWhiteSpace(Descripcion) ? (object)DBNull.Value : Descripcion.Trim();
        }
    }
}