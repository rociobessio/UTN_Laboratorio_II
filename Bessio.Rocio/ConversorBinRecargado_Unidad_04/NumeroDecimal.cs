using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinRecargado_Unidad_04
{
    public class NumeroDecimal
    {
        #region ATRIBUTOS
        public double numero;
        #endregion

        #region CONSTRUCTOR
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        #endregion

        #region GETTER CON PROPIEDADES
        public double GetNumero
        {
            get
            {
                return this.numero;
            }
        }
        #endregion

        #region METODOS DE CONVERSION DEL PUNTO I03 DE LA UNIDAD 01

        /// <summary>
        /// PASA UN NUMERO DECIMAL A UN NUMERO BINARIO 
        /// </summary>
        /// <param name="numero">RECIBE UN DECIMAL</param>
        /// <returns></returns>
        public string DecimalABinario(double numero)
        {
            string valorBinario = string.Empty; // " ";
            int resultadoDivision = (int)numero;//casteo a int
            int restoDivision;

            if(resultadoDivision >= 0)//Se verific si el result de la division es igual a 0 y lo mismo para el rest
            {
                do
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    valorBinario = restoDivision.ToString() + valorBinario;//La ultima division pasa a la 1er division
                } while (resultadoDivision > 0);
            }
            return valorBinario;
        }
        #endregion

        #region SOBRECARGAS

        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalABinario(numeroDecimal.numero);
        }


        #region SOBRECARGA DE COMPARACION, OPERADOR SUMA Y RESTA

        /// <summary>
        /// OPERADOR BOOLEANO DE COMPARACION ==
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns>
        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero == ((NumeroDecimal)numeroBinario).numero;
        }

        /// <summary>
        /// OPERADOR BOOLEANO DE COMPARACION !=
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns>
        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }

        public static double operator +(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero + ((NumeroDecimal)numeroBinario).numero;
        }
        public static double operator -(NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero - ((NumeroDecimal)numeroBinario).numero;
        }

        #endregion
        #endregion
    }
}
