using Mantenimiento2k26.Modelo.Contratos;
using Mantenimiento2k26.Modelo.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Mantenimiento2k26.Modelo.Repositorios
{
    public class ClsRepositorioPelicula
        : ClsSentencias, IRepositorioPelicula
    {
        private string _SelectAll;
        private string _Insert;
        private string _Update;
        private string _Delete;

        public ClsRepositorioPelicula()
        {
            _SelectAll =
                "SELECT * FROM tblPeliculas";

            _Insert =
                "INSERT INTO tblPeliculas " +
                "(idPeliculas, Nombre, Clasificacion, Genero, Subtitulado, Idioma, precio) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?)";

            _Update =
                "UPDATE tblPeliculas SET " +
                "Nombre=?, Clasificacion=?, Genero=?, Subtitulado=?, Idioma=?, precio=? " +
                "WHERE idPeliculas=?";

            _Delete =
                "DELETE FROM tblPeliculas " +
                "WHERE idPeliculas=?";
        }

        public int SeguridadMetAgregar(ClsPelicula Entidad)
        {
            var Parametros = new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_idPeliculas",
                    Entidad.IdPeliculas));

            Parametros.Add(
                new OdbcParameter(
                    "p_Nombre",
                    Entidad.Nombre));

            Parametros.Add(
                new OdbcParameter(
                    "p_Clasificacion",
                    Entidad.Clasificacion));

            Parametros.Add(
                new OdbcParameter(
                    "p_Genero",
                    Entidad.Genero));

            Parametros.Add(
                new OdbcParameter(
                    "p_Subtitulado",
                    Entidad.Subtitulado));

            Parametros.Add(
                new OdbcParameter(
                    "p_Idioma",
                    Entidad.Idioma));

            Parametros.Add(
                new OdbcParameter(
                    "p_precio",
                    Entidad.Precio));

            return SeguridadMetEjecucionNonQuery(
                _Insert,
                Parametros,
                CommandType.Text);
        }

        public int SeguridadMetEditar(ClsPelicula Entidad)
        {
            var Parametros = new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_Nombre",
                    Entidad.Nombre));

            Parametros.Add(
                new OdbcParameter(
                    "p_Clasificacion",
                    Entidad.Clasificacion));

            Parametros.Add(
                new OdbcParameter(
                    "p_Genero",
                    Entidad.Genero));

            Parametros.Add(
                new OdbcParameter(
                    "p_Subtitulado",
                    Entidad.Subtitulado));

            Parametros.Add(
                new OdbcParameter(
                    "p_Idioma",
                    Entidad.Idioma));

            Parametros.Add(
                new OdbcParameter(
                    "p_precio",
                    Entidad.Precio));

            Parametros.Add(
                new OdbcParameter(
                    "p_idPeliculas",
                    Entidad.IdPeliculas));

            return SeguridadMetEjecucionNonQuery(
                _Update,
                Parametros,
                CommandType.Text);
        }

        public int SeguridadMetRemover(ClsPelicula Entidad)
        {
            var Parametros = new List<OdbcParameter>();

            Parametros.Add(
                new OdbcParameter(
                    "p_idPeliculas",
                    Entidad.IdPeliculas));

            return SeguridadMetEjecucionNonQuery(
                _Delete,
                Parametros,
                CommandType.Text);
        }

       
    }
}