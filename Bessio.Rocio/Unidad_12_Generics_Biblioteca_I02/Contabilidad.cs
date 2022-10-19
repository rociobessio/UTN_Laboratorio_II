using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I02
{
    /// <summary>
    /// Clase GENERICA
    /// Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Contabilidad<T,U>
        where T : Documento
        where U :Documento, new() //Del tipo documento, new() = El argumento de tipo debe tener un constructor público sin parámetros.
    {
        #region ATRIBUTOS
        public List<T> egresos;
        public List<U> ingresos;
        #endregion

        #region  CONSTRUCTORES
        /// <summary>
        /// Crear en Contabilidad un constructor que no reciba parámetros e inicialice las listas.
        /// </summary>
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
        /// </summary>
        /// <param name="contabilidad"></param>
        /// <param name="egreso"></param>
        /// <returns></returns>
        public static Contabilidad<T,U> operator +(Contabilidad<T, U> contabilidad,T egreso)
        {
            if (contabilidad is not null && egreso is not null)
            {
                contabilidad.egresos.Add(egreso);
            }
            return contabilidad;
        }

        /// <summary>
        /// El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        /// </summary>
        /// <param name="contabilidad"></param>
        /// <param name="ingreso"></param>
        /// <returns></returns>
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (contabilidad is not null && ingreso is not null)
            {
                contabilidad.ingresos.Add(ingreso);
            }
            return contabilidad;
        }
        #endregion

    }
}
