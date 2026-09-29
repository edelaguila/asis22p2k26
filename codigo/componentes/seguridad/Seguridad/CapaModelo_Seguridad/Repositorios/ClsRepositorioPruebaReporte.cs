using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioPruebaReporte
        : ClsSentencias, IRepositorioPruebaReporte
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioPruebaReporte()
        {
            _SelectAll =
                "SELECT * FROM tblReporte";

            _Insert =
                "INSERT INTO tblReporte " +
                "(numeroReporte, nombreReporte, rutaReporte, fechaReporte) " +
                "VALUES (?, ?, ?, ?)";

            _Update =
                "UPDATE tblReporte SET " +
                "nombreReporte=?, rutaReporte=?, fechaReporte=? " +
                "WHERE numeroReporte=?";

            _Delete =
                "DELETE FROM tblReporte " +
                "WHERE numeroReporte=?";
        }

        public int SeguridadMetAgregar(
            ClsPruebaReporte Entidad)
        {
            var Parametros =
                new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_numeroReporte",
                    Entidad.NumeroReporte));

            Parametros.Add(
                new OdbcParameter(
                    "p_nombreReporte",
                    Entidad.NombreReporte));

            Parametros.Add(
                new OdbcParameter(
                    "p_rutaReporte",
                    Entidad.RutaReporte));

            Parametros.Add(
                new OdbcParameter(
                    "p_fechaReporte",
                    Entidad.FechaReporte));

            return SeguridadMetEjecucionNonQuery(
                _Insert,
                Parametros,
                CommandType.Text);
        }

        public int SeguridadMetEditar(
            ClsPruebaReporte Entidad)
        {
            var Parametros =
                new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_nombreReporte",
                    Entidad.NombreReporte));

            Parametros.Add(
                new OdbcParameter(
                    "p_rutaReporte",
                    Entidad.RutaReporte));

            Parametros.Add(
                new OdbcParameter(
                    "p_fechaReporte",
                    Entidad.FechaReporte));

            Parametros.Add(
                new OdbcParameter(
                    "p_numeroReporte",
                    Entidad.NumeroReporte));

            return SeguridadMetEjecucionNonQuery(
                _Update,
                Parametros,
                CommandType.Text);
        }

        public int SeguridadMetRemover(
            ClsPruebaReporte Entidad)
        {
            var Parametros =
                new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_numeroReporte",
                    Entidad.NumeroReporte));

            return SeguridadMetEjecucionNonQuery(
                _Delete,
                Parametros,
                CommandType.Text);
        }

        public IEnumerable<ClsPruebaReporte>
            SeguridadMetObtenerTodos()
        {
            var ListaReportes =
                new List<ClsPruebaReporte>();

            var TablaDatos =
                SeguridadMetEjecucionConsulta(
                    _SelectAll,
                    CommandType.Text);

            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Reporte =
                    new ClsPruebaReporte();

                Reporte.NumeroReporte =
                    Convert.ToInt32(Fila[0]);

                Reporte.NombreReporte =
                    Fila[1].ToString();

                Reporte.RutaReporte =
                    Fila[2].ToString();

                Reporte.FechaReporte =
                    Convert.ToDateTime(Fila[3]);

                Reporte.CreatedAt =
                    Convert.ToDateTime(Fila[4]);

                Reporte.UpdatedAt =
                    Convert.ToDateTime(Fila[5]);

                ListaReportes.Add(Reporte);
            }

            TablaDatos.Clear();
            TablaDatos = null;

            return ListaReportes;
        }
    }
}