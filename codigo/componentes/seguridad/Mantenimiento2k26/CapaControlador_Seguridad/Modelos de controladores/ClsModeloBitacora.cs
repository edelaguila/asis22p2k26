/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Victor Samayoa y Oscar Morales
 * Carné : 9959-23-3424 y 9959-23-3070
 * Fecha : 24/09/2026
 * ==================================================================
 * Propósito :
 *  El ClsModeloBitacora es el controlador encargado de registrar
 *  en la bitácora del sistema cada acción relevante (Insertar,
 *  Actualizar, Eliminar) realizada sobre las demás entidades,
 *  guardando quién la ejecutó, sobre qué tabla y registro, el
 *  detalle de la acción y la IP de origen.
 * Reglas especificas:
 *  Si no se recibe un usuario explícito, se toma el usuario de
 *  la sesión activa (ClsSesionSeguridad); si no se recibe una IP,
 *  se obtiene automáticamente la IP local del equipo.
 * ===================================================================
*/

using CapaControlador_Seguridad.Objetos_de_valor;
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Odbc;
using System.Linq;

namespace CapaControlador_Seguridad
{
    public class ClsModeloBitacora
    {
        private int _IdBitacora;
        private int? _IdUsuario;
        private string _NombreUsuario;
        private string _AccionBitacora;
        private string _TablaBitacora;
        private int _IdRegistroBitacora;
        private string _DetallesBitacora;
        private string _IpBitacora;
        private DateTime _FechaHoraBitacora;
        
        private ClsRepositorioBitacora _RepositorioBitacora;
        private List<ClsModeloBitacora> _ListaBitacora;

        public int IdBitacora { get => _IdBitacora; set => _IdBitacora = value; }
        public int? IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string AccionBitacora { get => _AccionBitacora; set => _AccionBitacora = value; }
        public string TablaBitacora { get => _TablaBitacora; set => _TablaBitacora = value; }
        public int IdRegistroBitacora { get => _IdRegistroBitacora; set => _IdRegistroBitacora = value; }
        public string DetallesBitacora { get => _DetallesBitacora; set => _DetallesBitacora = value; }
        public string IpBitacora { get => _IpBitacora; set => _IpBitacora = value; }
        public DateTime FechaHoraBitacora { get => _FechaHoraBitacora; set => _FechaHoraBitacora = value; }

        public ClsModeloBitacora()
        {
            _RepositorioBitacora = new ClsRepositorioBitacora();
        }

        public string SeguridadMetRegistrarBitacora(int? idUsuario, string accion, string tabla, int idRegistro, string detalles, string ip)
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsBitacora();
                ModeloDatos.IdUsuario = idUsuario ?? ClsSesionSeguridad.IdUsuario;
                ModeloDatos.AccionBitacora = accion;
                ModeloDatos.TablaBitacora = tabla;
                ModeloDatos.IdRegistroBitacora = idRegistro;
                ModeloDatos.DetallesBitacora = detalles;
                ModeloDatos.IpBitacora = string.IsNullOrEmpty(ip) ? ClsSesionSeguridad.SeguridadMetObtenerIPLocal() : ip;
                ModeloDatos.FechaHoraBitacora = DateTime.Now;

                _RepositorioBitacora.SeguridadMetAgregar(ModeloDatos);
                Mensaje = "Bitácora registrada con éxito";
            }
            catch (Exception ex)
            {
                Mensaje = "Error al registrar bitácora: " + ex.ToString();
            }
            return Mensaje;
        }

        // NAVEGADOR
        public string SeguridadMetRegistrarBitacora(int? idUsuario, string accion, string tabla, int idRegistro, string detalles, string ip, OdbcConnection Conexion, OdbcTransaction Transaccion)
        {
            var ModeloDatos = new ClsBitacora();
            ModeloDatos.IdUsuario = idUsuario ?? ClsSesionSeguridad.IdUsuario;
            ModeloDatos.AccionBitacora = accion;
            ModeloDatos.TablaBitacora = tabla;
            ModeloDatos.IdRegistroBitacora = idRegistro;
            ModeloDatos.DetallesBitacora = detalles;
            ModeloDatos.IpBitacora = string.IsNullOrEmpty(ip) ? ClsSesionSeguridad.SeguridadMetObtenerIPLocal() : ip;
            ModeloDatos.FechaHoraBitacora = DateTime.Now;

            _RepositorioBitacora.SeguridadMetAgregar(ModeloDatos, Conexion, Transaccion);
            return "Bitácora registrada con éxito";
        }
        // NAVEGADOR

        public static string SeguridadMetRegistrarAccion(string accion, string tabla, int idRegistro, string detalles)
        {
            try
            {
                var repo = new ClsRepositorioBitacora();
                var bitacora = new ClsBitacora
                {
                    IdUsuario = ClsSesionSeguridad.IdUsuario,
                    AccionBitacora = accion,
                    TablaBitacora = tabla,
                    IdRegistroBitacora = idRegistro,
                    DetallesBitacora = detalles,
                    IpBitacora = ClsSesionSeguridad.SeguridadMetObtenerIPLocal(),
                    FechaHoraBitacora = DateTime.Now
                };
                repo.SeguridadMetAgregar(bitacora);
                return "Bitácora registrada con éxito";
            }
            catch (Exception ex)
            {
                return "Error al registrar bitácora: " + ex.ToString();
            }
        }

        public List<ClsModeloBitacora> SeguridadMetObtenerTodas()
        {
            var DatosBitacora = _RepositorioBitacora.SeguridadMetObtenerTodos();
            _ListaBitacora = new List<ClsModeloBitacora>();
            foreach (ClsBitacora Item in DatosBitacora)
            {
                _ListaBitacora.Add(new ClsModeloBitacora
                {
                    _IdBitacora = Item.IdBitacora,
                    _IdUsuario = Item.IdUsuario,
                    _NombreUsuario = Item.NombreUsuario,
                    _AccionBitacora = Item.AccionBitacora,
                    _TablaBitacora = Item.TablaBitacora,
                    _IdRegistroBitacora = Item.IdRegistroBitacora,
                    _DetallesBitacora = Item.DetallesBitacora,
                    _IpBitacora = Item.IpBitacora,
                    _FechaHoraBitacora = Item.FechaHoraBitacora
                });
            }
            return _ListaBitacora;
        }
    }
}
