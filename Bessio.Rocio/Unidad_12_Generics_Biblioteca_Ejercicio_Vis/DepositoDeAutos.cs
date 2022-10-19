using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_Ejercicio_Vis
{
    public class DepositoDeAutos
    {
        #region ATRIBUTOS 
        protected int capacidadMaxima;
        protected List<Auto> lista;
        #endregion

        #region CONSTRUCTOR
        public DepositoDeAutos()
        {
            this.lista = new List<Auto>();
            this.capacidadMaxima = 0;
        }

        public DepositoDeAutos(int capacidadaMaxima) : this()
        {
            this.capacidadMaxima = capacidadaMaxima;
        }
        #endregion

        #region METODOS


        /// <summary>
        /// o Retorna el valor del índice en el cual se encuentra el auto pasado como parámetro. Se debe
        /// recorrer la lista genérica y retornar el índice de la primera ocurrencia, -1 si no se encuentra en
        /// la lista.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private int GetIndice(Auto a)
        {
            int index = -1;
            int contador = 0;
            foreach (Auto item in lista)
            {
                if (item == a)
                {
                    index = contador;
                }
                contador++;
            }
            return index;
        }

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Retorna true, si pudo agregar el auto al depósito de autos, false, caso contrario.
        /// Para poder agregar un auto a la lista genérica hay que tener en cuenta que la capacidad
        /// máxima del depósito no puede ser superada.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool operator +(DepositoDeAutos d, Auto a1)
        {
            bool pudo = false;
            if (a1 is not null)
            {
                foreach (Auto item in d.lista)
                {
                    if (item != a1 && d.lista.Count < d.capacidadMaxima)
                    {
                        d.lista.Add(a1);
                        pudo = true;
                        break;
                    }
                }

            }
            return pudo;
        }

        /// <summary>
        /// Retorna true, si pudo remover el auto del depósito de autos, false, caso contrario.
        // Para poder remover un auto a la lista genérica hay que invocar al método GetIndice. 
        /// </summary>
        /// <param name="lav"></param>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool removed = false;
            int indice = d.GetIndice(a);
            if(d is not null && a is not null)
            {
                d.lista.RemoveAt(indice);
                removed = true;
            }
            return removed;
        }
        #endregion

        /// <summary>
        /// Está asociado al operador +
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Agregar(Auto a)
        {
            bool pudoAgregar = false;

            if (a is not null)
            {
               // pudoAgregar = lista +  a;
            }
            return pudoAgregar;
        }

        /// <summary>
        /// Está asociado al operador -.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Remover(Auto a)
        {
            bool pudoRemover = false;

            if (a is not null)
            {
                
            }
            return pudoRemover;
        }
        #endregion

    }
}
