/*
 * ==================================================================
  Área : Seguridad
 * Autor : Victor Omar Gomez y Andre de jesus 
 * Carné : 9959-23-10733 y 9959-23-3117
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  El ClsModeloUsuarios es el controlador que valida y prepara los
 *  datos de un usuario antes de enviarlos al repositorio, aplica
 *  reglas especificas: no permitir que un empleado tenga 2 usuarios, no
 *  permitir espacios en la contraseña ni que sea menor a 6 caracteres y no permite numeros en el nombre de usuarios
 *  registrar cada operación (Agregar, Editar, Eliminar) en la
 *  bitácora del sistema.
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
    public class ClsModeloUsuario
    {
        private int _IdUsuario;
        private int _IdEmpleado;
        private string _NombreUsuario;
        private string _ContrasenaUsuario;
        private string _ConfirmarContrasenaUsuario;
        private DateTime _UltimoAccesoUsuario;
        private int _IsActive;
        private string _NombreEmpleado;
        private List<ClsRolInfo> _Roles = new List<ClsRolInfo>();
        private ClsRepositorioUsuarios _RepositorioUsuarios;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloUsuario> _ListaUsuario;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        [Required(ErrorMessage = "Debe seleccionar un empleado")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un empleado válido")]
        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }

        [Required]
        [RegularExpression("^[a-zA-Zá-ú ]+$", ErrorMessage = "El campo Nombre debe ser solo letras")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }

        [Required]
        [RegularExpression(@"^\S+$", ErrorMessage = "La contraseña no debe contener espacios")]
        [StringLength(100, MinimumLength = 6)]
        public string ContrasenaUsuario { get => _ContrasenaUsuario; set => _ContrasenaUsuario = value; }
        //Comparacion de contraseñas para asegurarse de que coincidan
        [Compare("ContrasenaUsuario", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmarContrasenaUsuario{ get => _ConfirmarContrasenaUsuario; set => _ConfirmarContrasenaUsuario = value;}
        public DateTime UltimoAccesoUsuario { get => _UltimoAccesoUsuario; set => _UltimoAccesoUsuario = value; }
        public int IsActive { get => _IsActive; set => _IsActive = value; }

        public string NombreEmpleado { get => _NombreEmpleado; set => _NombreEmpleado = value; }

        public List<ClsRolInfo> Roles { get => _Roles; set => _Roles = value; }

        public ClsModeloUsuario()
        {
            _RepositorioUsuarios = new ClsRepositorioUsuarios();
        }

        public string SeguridadMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatosUsuarios = new ClsUsuarios();
                ModeloDatosUsuarios.IdUsuario = _IdUsuario;
                ModeloDatosUsuarios.IdEmpleado = _IdEmpleado;
                ModeloDatosUsuarios.NombreUsuario = _NombreUsuario;

                ModeloDatosUsuarios.ContrasenaUsuario = string.IsNullOrEmpty(_ContrasenaUsuario)
                    ? _ContrasenaUsuario
                    : BCrypt.Net.BCrypt.HashPassword(_ContrasenaUsuario);
                ModeloDatosUsuarios.UltimoAccesoUsuario = _UltimoAccesoUsuario;
                ModeloDatosUsuarios.IsActive = _IsActive;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _RepositorioUsuarios.SeguridadMetAgregar(ModeloDatosUsuarios);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("INSERT", "tblUsuario", ModeloDatosUsuarios.IdUsuario, "Se agregó el usuario: " + _NombreUsuario);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioUsuarios.SeguridadMetEditar(ModeloDatosUsuarios);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("UPDATE", "tblUsuario", ModeloDatosUsuarios.IdUsuario, "Se actualizó el usuario: " + _NombreUsuario);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioUsuarios.SeguridadMetRemover(ModeloDatosUsuarios);
                        ClsModeloBitacora.SeguridadMetRegistrarAccion("DELETE", "tblUsuario", ModeloDatosUsuarios.IdUsuario, "Se eliminó el usuario ID: " + ModeloDatosUsuarios.IdUsuario);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (OdbcException exOdbc)  // / código MySQL para llave/índice duplicado
            {
                if (exOdbc.Errors[0].NativeError == 1062)
                {
                    Mensaje = "Este empleado ya tiene un usuario asignado.";
                }
                else
                {
                    Mensaje = exOdbc.Message;
                }
            }
            catch (Exception ex)  // Manejo de otras excepciones
            {
                Mensaje = ex.ToString();
            }
            return Mensaje;  
        }
        

        public List<ClsModeloUsuario> SeguridadMetObtenerTodos()
        {
            var ModeloDatosUsuarios = _RepositorioUsuarios.SeguridadMetObtenerTodos();
            _ListaUsuario = new List<ClsModeloUsuario>();
            foreach (ClsUsuarios Item in ModeloDatosUsuarios)
            {
                _ListaUsuario.Add(new ClsModeloUsuario
                {
                    _IdUsuario = Item.IdUsuario,
                    _IdEmpleado = Item.IdEmpleado,
                    _NombreUsuario = Item.NombreUsuario,
                    _ContrasenaUsuario = Item.ContrasenaUsuario,
                    _UltimoAccesoUsuario = Item.UltimoAccesoUsuario,
                    _IsActive = Item.IsActive
                });
            }
            return _ListaUsuario;
        }
        
        public IEnumerable<ClsModeloUsuario> SeguridadMetBuscarPorId(string Filtro)
        {
            return _ListaUsuario.FindAll(u => u.IdUsuario.Equals(Filtro) || u._NombreUsuario.Contains(Filtro));
        }

        public DataTable SeguridadMetObtenerEmpleados()
        {
            return _RepositorioUsuarios.SeguridadMetObtenerEmpleados();
        }

       


        public bool SeguridadMetIniciarSesion(string NombreUsuario, string ContrasenaUsuario)
        {
            var resultado = _RepositorioUsuarios.SeguridadMetValidarLogin(NombreUsuario, ContrasenaUsuario);
            if (resultado == null) return false;

            bool Coincide = BCrypt.Net.BCrypt.Verify(ContrasenaUsuario, resultado.ContrasenaUsuario);
            if (!Coincide) return false;

            _IdUsuario = resultado.IdUsuario;
            _NombreUsuario = resultado.NombreUsuario;
            _NombreEmpleado = resultado.NombreEmpleado;

            _Roles = new List<ClsRolInfo>();
            DataTable TablaRoles = _RepositorioUsuarios.SeguridadMetObtenerRolesPorUsuario(_IdUsuario);
            foreach (DataRow Fila in TablaRoles.Rows)
            {
                _Roles.Add(new ClsRolInfo
                {
                    IdRol = Convert.ToInt32(Fila["idRol"]),
                    NombreRol = Fila["nombreRol"].ToString()
                });
            }

                        /*
             * ==================================================================
             * Área      : Seguridad
             * Autores   : Lourdes Isabel Melendez Pineda
             * Fecha o ultima edicion: 23/09/2026
             * ==================================================================
             * Propósito : Guarda en la sesión los datos del usuario que acaba de
             * iniciar sesión como usuario, empleado y sus roles, para
             * que estén disponibles mientras el sistema esté abierto, esto es parte
             * de usuario conectado.
             * ===================================================================
             */

            ClsSesionSeguridad.SeguridadMetIniciarSesion(
               _IdUsuario,
               _NombreUsuario,
               _NombreEmpleado,
               _Roles
            );
            //Fin del Codigo de Isabel Melendez Pineda        

            ClsModeloBitacora.SeguridadMetRegistrarAccion("LOGIN", "tblUsuario", resultado.IdUsuario, "Inicio de sesión exitoso del usuario: " + resultado.NombreUsuario);
            return true;
        }
    }
}