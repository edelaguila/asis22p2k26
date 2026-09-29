using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Entidades;

/*
 * ==================================================================
 * Área: Seguridad
 * Autores: Lourdes Isabel Melendez Pineda
 * Fecha o ultima edicion: 23/09/2026
 * ==================================================================
 * Propósito : Contrato de la capa Modelo para el repositorio de
 * Asignación Aplicación Perfil. Hereda del repositorio
 * genérico para obligar  a tener los
 * métodos básicos de agregar, editar, eliminar y consultar.
 * ===================================================================
 */

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioAsigAppPerf: IRepositorioGenerico<ClsAsigAppPerf> 
    { }
    
}
