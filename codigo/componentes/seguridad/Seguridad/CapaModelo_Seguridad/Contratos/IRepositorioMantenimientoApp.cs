using System;
using System.Collections.Generic;
using CapaModelo_Seguridad.Entidades;

/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Andy Alfonso Garcia Lopez
 * Carné : 9959-23-1494
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 *  La interfaz del repositorio de Mantenimiento de Aplicación define
 *  las operaciones CRUD heredadas desde IRepositorioGenerico para la 
 *  entidad ClsMantenimientoAplicacion, garantizando que cualquier 
 *  implementación cumpla con el contrato establecido en la capa 
 *  modelo del sistema de seguridad.
 * ===================================================================
*/

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioMantenimientoApp: IRepositorioGenerico<ClsMantenimientoAplicacion>
    {
    }
}
