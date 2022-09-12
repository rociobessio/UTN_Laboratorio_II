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
    public class Peso
    {
        #region ATRIBUTOS
        private double cantidad;
        private static double cotizarRespectoDolar;
        #endregion

        #region CONSTRUCTORES

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// El constructor estatico le dara una COTIZACION POR DEFECTO
        /// </summary>
        static Peso()
        {
            cotizarRespectoDolar = 0.023;//y 1 Dólar equivale a 102,65 Pesos. 
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
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
                return Peso.cotizarRespectoDolar;
            }
        }
        #endregion
        #endregion

        #region SOBRECARGAS DE OPERADORES EXPLICIT y/o IMPLICIT

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        //SOBRE CARGAR EXPLICITA PARA EURO Y DOLAR
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.GetCantidad / Peso.GetCotizacion));
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro )((Dolar)p);//REUTILIZAMOS LAS CONVERSIONES EXPLICITAS
        }


        #region SOBRECARGA PARA COMPARADORES Y OPERADORES ARITMETICOS:

        #region OPERADORES BOOLEANOS:
        public static bool operator == (Peso p1, Peso p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);//Se reutiliza el codigo anterior.
        }

        //PARA DOLAR
        public static bool operator == (Peso p1, Dolar d)
        {
            return (p1.GetCantidad == ((Peso)d).GetCantidad);
        }
        public static bool operator !=(Peso p1, Dolar d)
        {
            return !(p1 == d);
        }

        //PARA PESO
        public static bool operator == (Peso p, Euro e)
        {
            return (p.GetCantidad == ((Peso)e).GetCantidad);
        }
        public static bool operator !=(Peso p1, Euro e)
        {
            return !(p1 == e);
        }
        #endregion

        #region OPERADORES + y - :

        public static Peso operator - (Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad - ((Peso)d).GetCantidad));
        }
        public static Peso operator - (Peso p, Euro e)
        {
            return new Peso((p.GetCantidad - ((Peso)e).GetCantidad));
        }

        public static Peso operator + (Peso p, Dolar d)
        {
            return new Peso((p.GetCantidad + ((Peso)d).GetCantidad));
        }
        public static Peso operator + (Peso p, Euro e)
        {
            return new Peso((p.GetCantidad + ((Peso)e).GetCantidad));
        }

        #endregion




        #endregion


        #endregion
    }
}
