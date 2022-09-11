using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *                                          COTIZADOR
 *                                    ----------------------
 *                                     UNIDAD 04 - EJER. 02

 CONSIGNA:
            Crear un proyecto de tipo biblioteca de clases. Construir tres clases dentro de un namespace llamado 
            Billetes: Pesos, Euro y Dolar.

            Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con
            total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares 
            y 1 Dólar equivale a 102,65 Pesos.
 
 */

namespace Billetes
{
    public class Dolar
    {

        #region ATRIBUTOS
        private double cantidad;
        private static double cotizarRespectoDolar;
        #endregion

        #region CONSTRUCTORES

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// El constructor estatico le dara una COTIZACION POR DEFECTO
        /// </summary>
        static Dolar()
        {
            cotizarRespectoDolar = 1;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizarRespectoDolar = cotizacion;
        }
        #endregion

        #region METODOS

        #region GETTERS MEDIANTE PROPIEDADES
        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        /// <summary>
        /// EL METODO GET COTIZACION ES ESTATICO IGUAL QUE EL ATRIBUTO DE cotizarRespectoDolar
        /// </summary>
        /// <returns></returns>
        public static double GetCotizacion
        {
            get
            {
                return Dolar.cotizarRespectoDolar;
            }
        }
        #endregion
        #endregion

        #region SOBRECARGAS DE OPERADORES EXPLICIT y/o IMPLICIT

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }


        //SOBRE CARGAR EXPLICITA PARA EURO Y PESO
        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.cantidad * Euro.GetCotizacion));
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.cantidad * Peso.GetCotizacion));
        }


        #region COMPARADORES Y SOBRECARGA DE OPERADORES ARITMETICOS

        #region OPERADORES BOOLEANOS:
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad == d2.GetCantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);//Se reutiliza el codigo anterior.
        }

        //PARA EURO
        public static bool operator == (Dolar d1,Euro e)
        {
            return (d1.GetCantidad == ((Dolar)e).GetCantidad);
        }
        public static bool operator !=(Dolar d1, Euro e)
        {
            return !(d1 == e);
        }

        //PARA PESO
        public static bool operator  == (Dolar d, Peso p)
        {
            return (d.GetCantidad == ((Dolar)p).GetCantidad);
        }
        public static bool operator !=(Dolar d1, Peso p)
        {
            return !(d1 == p);
        }
        #endregion
        #region OPERADORES + y - :

        public static Dolar operator - (Dolar d,Euro e)
        {
            return new Dolar((d.GetCantidad - ((Dolar)e).GetCantidad));
        }
        public static Dolar operator - (Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad - ((Dolar)p).GetCantidad));
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad + ((Dolar)e).GetCantidad));
        }
        public static Dolar operator + (Dolar d, Peso p)
        {
            return new Dolar((d.GetCantidad + ((Dolar)p).GetCantidad));
        }

        #endregion
        #endregion

        #endregion
    }
}
