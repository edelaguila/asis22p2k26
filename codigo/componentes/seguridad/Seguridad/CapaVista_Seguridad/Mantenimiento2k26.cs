/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Oscar Emilio Morales Lemus
 * Carné : 9959-23-3070
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  Se implementaron los manejadores de clic de los botones del
 *  menú lateral del FrmMDISeguridad, encargados de validar el
 *  acceso del usuario a cada módulo/aplicación antes de abrir
 *  la ventana correspondiente (Empleados, Usuarios, Módulos,
 *  Aplicaciones, Perfiles, Asignaciones y Bitácora).
 * Reglas especificas:
 *  Antes de abrir cualquier ventana se valida el acceso con
 *  ClsSeguridadFormHelper.SeguridadMetTieneAcceso(IdModulo,
 *  IdAplicacion); si el usuario no tiene permiso, se muestra el
 *  mensaje "No tienes acceso a este módulo." y no se abre la
 *  ventana.
 * ===================================================================
*/


using System;

namespace CapaVista_Seguridad
{
    internal class Mantenimiento2k26
    {
        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}