using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_04_SobreCarg_Ejercicio_A01
{
    public class Kelvin
    {
        #region ATRIBUTOS
        public int valor;
        #endregion

        #region CONSTRUCTOR
        public Kelvin(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region PASAR A:
        public int ACelsius()
        {
            double resultado = (this.valor - 273.15) ;
            return (int)resultado;
        }

        public int AFahrenheit()
        {
            double resultado = ACelsius() * 9 / 5 + 32;
            return (int)resultado;
        }
        #endregion

        #region SOBRECARGA

        #region OPERADORES EXPLICITOS
        public static explicit operator Fahrenheit(Kelvin k)
        {
            int numero = 0;

            if (!(k == null))//o is null
            {
                numero = k.AFahrenheit();
            }
            Fahrenheit aux = new Fahrenheit(numero);
            return aux;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            int numero = 0;

            if (!(k == null))//o is null
            {
                numero = k.ACelsius();
            }
            Celsius aux = new Celsius(numero);
            return aux;
        }
        #endregion

        #region OPERADORES BOOLEANOS
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            bool respuesta = false;

            if (!(k1 == null) && !(k2 == null))
            {
                respuesta = k1.valor.Equals(k2.valor);
            }
            return respuesta;
        }
        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }
        #endregion

        #region OPERADORES + y -
        public static int operator +(Kelvin k1, Kelvin k2)
        {
            int resultado = 0;
            if (!(k1 == null) && !(k2 == null))
            {
                resultado = k1.valor + k2.valor;
            }
            return resultado;
        }
        public static int operator -(Kelvin k1, Kelvin k2)
        {
            int resultado = 0;
            if (!(k1 == null) && !(k2 == null))
            {
                resultado = k1.valor - k2.valor;
            }
            return resultado;
        }

        #endregion

        #endregion
    }
}
