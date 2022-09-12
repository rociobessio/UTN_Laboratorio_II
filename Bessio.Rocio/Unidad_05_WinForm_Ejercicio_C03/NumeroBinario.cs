using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_05_WinForm_Ejercicio_C03
{
    class NumeroBinario
    {
        #region ATRIBUTOS
        public string numero;
        #endregion

        #region CONSTRUCTORES
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        #endregion

        #region GETTER CON PROPIEDAD
        public string GetNumero
        {
            get
            {
                return this.numero;
            }
        }
        #endregion

        #region METODOS DE CONVERSION DEL PUNTO I03 DE LA UNIDAD 01

        public double BinarioADecimal(string valor)
        {
            double resultado = 0;
            int cantCaracteres = valor.Length;//Se guarda con la propiedad .Length la longitud de la cadena.

            /*
             * el foreach no es un bucle sino un constructor, el cual solo puede iterar en arrays y objetos, 
             * en cambio el for es un bucle, es decir, se repite tantas veces como nosotros queramos.
             */
            foreach (char caracter in valor)
            {
                cantCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantCaracteres);
                }
            }
            return resultado;
        }

        #endregion


        #region SOBRECARGAS
        /// <summary>
        /// OPERADOR EXPLICITO
        /// </summary>
        /// <param name="numero"></param>
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario nummeroBinario)
        {
            return (NumeroDecimal)nummeroBinario.BinarioADecimal(nummeroBinario.numero);
        }

        #region SOBRECARGA DE COMPARACION, OPERADOR SUMA Y RESTA

        /// <summary>
        /// OPERADOR BOOLEANO DE COMPARACION ==
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns>
        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.numero == ((NumeroBinario)numeroDecimal).numero;
        }

        /// <summary>
        /// OPERADOR BOOLEANO DE COMPARACION !=
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <param name="numeroDecimal"></param>
        /// <returns></returns>
        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalABinario(((NumeroDecimal)numeroBinario).numero + numeroDecimal.numero);
        }
        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalABinario(((NumeroDecimal)numeroBinario).numero - numeroDecimal.numero);
        }

        #endregion

        #endregion

    }
}
