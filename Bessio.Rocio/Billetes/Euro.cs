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
    public class Euro
    {
        #region ATRIBUTOS
        private double cantidad;
        private static double cotizarRespectoDolar;
        #endregion

        #region CONSTRUCTORES

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// El constructor estatico le dara una COTIZACION POR DEFECTO
        /// </summary>
        static Euro()
        {
            cotizarRespectoDolar = 1/1.08;//1 Euro equivale a 1,17 Dólares 
        }

        public Euro(double cantidad, double cotizacion) :this (cantidad)
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
        /// EL METODO GET COTIZACION ES ESTATICO IGUAL QUE EL ATRIBUTO DE cotizarRespectoEuros
        /// </summary>
        /// <returns></returns>
        public static double GetCotizacion
        {
            get
            {
                return Euro.cotizarRespectoDolar;
            }
        }
        #endregion
        #endregion

        #region SOBRECARGAS DE OPERADORES EXPLICIT y/o IMPLICIT

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }


        //SOBRE CARGAR EXPLICITA PARA DOLAR Y PESO
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.cantidad / Dolar.GetCotizacion));
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);//REUTILIZAMOS LAS CONVERSIONES EXPLICITAS
        }

        #region SOBRECARGA PARA COMPARADORES Y OPERADORES ARITMETICOS:

        #region OPERADORES BOOLEANOS:
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad == e2.GetCantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);//Se reutiliza el codigo anterior.
        }

        //PARA DOLAR
        public static bool operator ==(Euro e1, Dolar d)
        {
            return (e1.GetCantidad == ((Euro)d).GetCantidad);
        }
        public static bool operator !=(Euro e1, Dolar d)
        {
            return !(e1 == d);
        }

        //PARA PESO
        public static bool operator ==(Euro e, Peso p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }
        public static bool operator !=(Euro e1, Peso p)
        {
            return !(e1 == p);
        }
        #endregion

        #region OPERADORES + y - :

        public static Euro operator - (Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad - ((Euro)d).GetCantidad));
        }
        public static Euro operator - (Euro e, Peso p)
        {
            return new Euro((e.GetCantidad - ((Euro)p).GetCantidad));
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            return new Euro((e.GetCantidad + ((Euro)d).GetCantidad));
        }
        public static Euro operator + (Euro e, Peso p)
        {
            return new Euro((e.GetCantidad + ((Euro)p).GetCantidad));
        }

        #endregion


        #endregion

        #endregion
    }
}
