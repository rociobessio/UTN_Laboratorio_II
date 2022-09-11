using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *                                                  LA ESTANTERIA
 *                                             -----------------------
 *                                              UNIDAD 04 - EJER. C02
 * Consigna: 
 *          1. Posee dos atributos privados. Uno será un entero que indicará la ubicación del estante y el otro es 
 *             un array de tipo Producto.
            2. El constructor de instancia privado será el único que incializará el array. La sobrecarga pública 
               del constructor inicializará la ubicación del estante, recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
            3. El método público GetProductos, retornará el array de productos.
            4. El método público de clase (estático) MostrarEstante, retornará una cadena con toda la 
               información del estante incluyendo el detalle de cada uno de sus productos. Reutilizar código.
            5. Posee las siguientes sobrecargas de operadores:
                ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
                +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
                -: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.
 */
namespace Unidad_04_Biblioteca_LaEstanteria
{
    public class Estante
    {
        #region ATRIBUTOS
        private Producto[] productos;
        private int ubicacionEstante;
        #endregion

        #region CONSTRUCTORES
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int ubicacionEstante,int capacidad) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }
        #endregion

        #region METODOS
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"UBICACION DEL ESTANTE: {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e.productos[i], null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                    sb.AppendLine("----------------------");

                }
            }
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS

        #region OPERADORES BOOLEANOS
        /// <summary>
        /// ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator == (Estante e,Producto p)
        {
            bool retorno = false;
            for(int i = 0; i< e.productos.Length;i++)
            {
                if(e.productos[i] == p)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator != (Estante e, Producto p)
        {
            return !(e == p);
        }
        #endregion

        #region OPERADOR + y -

        public static bool operator + (Estante e,Producto p)
        {
            bool retorno = false;

            if(e != p )
            {
                for(int i = 0; i > e.productos.Length;i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static Estante operator - (Estante e, Producto p)
        {
            for(int i = 0;i<e.productos.Length;i++)
            {
                if(e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
        #endregion

        #endregion
    }
}
