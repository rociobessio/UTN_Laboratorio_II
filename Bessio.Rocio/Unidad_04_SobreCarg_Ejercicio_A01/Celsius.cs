using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_04_SobreCarg_Ejercicio_A01
{
    public class Celsius
    {
        #region ATRIBUTOS
        public int valor;
        #endregion

        #region CONSTRUCTOR
        public Celsius(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region PASAR A:
        public int AFarenheit()
        {
            return (this.valor * 9/5) + 32;//F = C * (9/5) + 32
        }

        public int AKelvin()
        {
            double resultado = this.valor + 273.15;
            return (int)resultado;
        }
        #endregion

        #region OPERADORES EXPLICITOS E IMPLICITOS:
        public static explicit operator Kelvin(Celsius c)
        {
            int numero = 0;

            if (!(c == null))//o is null
            {
                numero = c.AKelvin();
            }
            Kelvin aux = new Kelvin(numero);
            return aux;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            int numero = 0;

            if (!(c == null))//o is null
            {
                numero = c.AFarenheit();
            }
            Fahrenheit aux = new Fahrenheit(numero);
            return aux;
        }
        #region OPERADORES BOOLEANOS
        public static bool operator == (Celsius c1, Celsius c2)
        {
            bool respuesta = false;

            if (!(c1 == null) && !(c2 == null))
            {
                respuesta = c1.valor.Equals(c2.valor);
            }
            return respuesta;
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        #endregion
        
        #region OPERADORES + y -
        public static int operator +(Celsius c1, Celsius c2)
        {
            int resultado = 0;
            if(!(c1 == null) && !(c2 == null))
            {
                resultado = c1.valor + c2.valor;
            }
            return resultado;
        }
        public static int operator -(Celsius c1, Celsius c2)
        {
            int resultado = 0;
            if (!(c1 == null) && !(c2 == null))
            {
                resultado = c1.valor - c2.valor;
            }
            return resultado;
        }

        #endregion

        #endregion
    }
}
