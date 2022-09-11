using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_04_SobreCarg_Ejercicio_A01
{
    public class Fahrenheit
    {
        #region ATRIBUTOS
        public int valor;
        #endregion

        #region CONSTRUCTOR
        public Fahrenheit(int valor)
        {
            this.valor = valor;
        }
        #endregion

        #region PASAR A:
        public int ACelsius()
        {
            double resultado = (this.valor - 32) * 5 / 9;
            return (int)resultado;
        }

        public int AKelvin()
        {
            double resultado = (this.valor - 32) * 5 / 9 + 273.15;
            return (int)resultado;
        }
        #endregion

        #region SOBRECARGA
        #region IMPLICITOS Y EXPLICITOS:
        public static explicit operator Kelvin(Fahrenheit f)
        {
            int numero = 0;

            if (!(f == null))//o is null
            {
                numero = f.AKelvin();
            }
            Kelvin aux = new Kelvin(numero);
            return aux;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            int numero = 0;

            if (!(f == null))//o is null
            {
                numero = f.AKelvin();
            }
            Celsius aux = new Celsius(numero);
            return aux;
        }
        #endregion

        #region OPERADORES BOOLEANOS
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            bool respuesta = false;

            if (!(f1 == null) && !(f2 == null))
            {
                respuesta = f1.valor.Equals(f2.valor);
            }
            return respuesta;
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }
        #endregion

        #region OPERADORES + y -
        public static int operator +(Fahrenheit f1, Fahrenheit f2)
        {
            int resultado = 0;
            if (!(f1 == null) && !(f2 == null))
            {
                resultado = f1.valor + f2.valor;
            }
            return resultado;
        }
        public static int operator -(Fahrenheit f1, Fahrenheit f2)
        {
            int resultado = 0;
            if (!(f1 == null) && !(f2 == null))
            {
                resultado = f1.valor - f2.valor;
            }
            return resultado;
        }

        #endregion

        #endregion


    }
}
