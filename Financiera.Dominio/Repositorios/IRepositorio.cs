using Financiera.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Financiera.Dominio.Repositorios
{
    /// <summary>
    /// Interfaz que representa al repositorio de acceso a los datos
    /// </summary>
    public interface IRepositorio
    {
        /// <summary>
        /// Metodo que busca una clase en un repositorio
        /// </summary>
        /// <typeparam name="T">Clase del objeto a buscar</typeparam>
        /// <param name="ao_llaves"></param>
        /// <returns>Instancia de la clase</returns>
        T Buscar<T>(params object[] ao_llaves) where T : EntidadBase;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ao_predicado"></param>
        /// <returns></returns>
        List<T> ListarPorExpresion<T>(Expression<Func<T, bool>> ao_predicado) where T : EntidadBase;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> Listar<T>() where T : EntidadBase;
    }
}
