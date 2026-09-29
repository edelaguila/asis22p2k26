using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioBitacora : ClsSentencias, IRepositorioBitacora
    {
        private string _SelectAll;
        private string _Insert;

        public ClsRepositorioBitacora()
        {
            _SelectAll = "SELECT idBitacora, idUsuario, accionBitacora, tablaBitacora, idRegistroBitacora, detallesBitacora, ipBitacora, fechaHoraBitacora FROM tblBitacora";
            _Insert = "INSERT INTO tblBitacora (idUsuario, accionBitacora, tablaBitacora, idRegistroBitacora, detallesBitacora, ipBitacora, fechaHoraBitacora) VALUES (?, ?, ?, ?, ?, ?, ?)";
        }

        public int SeguridadMetAgregar(ClsBitacora Entidad)
        {
            var Parametros = new List<OdbcParameter>();
            Parametros.Add(new OdbcParameter("p_idUsuario", Entidad.IdUsuario.HasValue ? (object)Entidad.IdUsuario.Value : DBNull.Value));
            Parametros.Add(new OdbcParameter("p_accionBitacora", Entidad.AccionBitacora));
            Parametros.Add(new OdbcParameter("p_tablaBitacora", Entidad.TablaBitacora));
            Parametros.Add(new OdbcParameter("p_idRegistroBitacora", Entidad.IdRegistroBitacora));
            Parametros.Add(new OdbcParameter("p_detallesBitacora", Entidad.DetallesBitacora));
            Parametros.Add(new OdbcParameter("p_ipBitacora", Entidad.IpBitacora));
            Parametros.Add(new OdbcParameter("p_fechaHoraBitacora", Entidad.FechaHoraBitacora.ToString("yyyy-MM-dd HH:mm:ss")));

            return SeguridadMetEjecucionNonQuery(_Insert, Parametros, CommandType.Text);
        }

        public int SeguridadMetEditar(ClsBitacora Entidad)
        {
            throw new NotImplementedException("No se permite editar registros de la bitácora.");
        }

        public int SeguridadMetRemover(ClsBitacora Entidad)
        {
            throw new NotImplementedException("No se permite eliminar registros de la bitácora.");
        }

        public IEnumerable<ClsBitacora> SeguridadMetObtenerTodos()
        {
            var ListaBitacora = new List<ClsBitacora>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Bitacora = new ClsBitacora();
                Bitacora.IdBitacora = Convert.ToInt32(Fila[0]);
                Bitacora.IdUsuario = Fila[1] == DBNull.Value ? (int?)null : Convert.ToInt32(Fila[1]);
                Bitacora.AccionBitacora = Fila[2].ToString();
                Bitacora.TablaBitacora = Fila[3].ToString();
                Bitacora.IdRegistroBitacora = Convert.ToInt32(Fila[4]);
                Bitacora.DetallesBitacora = Fila[5].ToString();
                Bitacora.IpBitacora = Fila[6].ToString();
                Bitacora.FechaHoraBitacora = Convert.ToDateTime(Fila[7]);
                ListaBitacora.Add(Bitacora);
            }
            return ListaBitacora;
        }
    }
}
