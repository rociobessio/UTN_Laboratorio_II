using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Clases_Ejercicio_03
{
    class Conversor
    {
        /// <summary>
        ///  Que convierte un número entero del sistema decimal al sistema binario.
        /// </summary>
        /// <param name="numeroEntero">El numero que recibe</param>
        /// <returns>Una string de 0s y 1s (binario)</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";

            while (numeroEntero > 0)
            {
                //Divido el numero entre 2 y despues sumamos la cacdena,ya que hay que invertir los restos.
                binario = numeroEntero % 2 + binario;

                //voy decrementando el numero
                numeroEntero = numeroEntero / 2;
            }

            return binario;//retorno un binaio
        }

        /// <summary>
        /// Que convierte un número entero del sistema binario al sistema decimal.
        /// </summary>
        /// <param name="numeroEntero">El numero que recibe</param>
        /// <returns>Un entero (decimal)</returns>
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numAux = numeroEntero;

            int valorADevolver = 0;

            int base1 = 1;

            int buff = numAux;

            while (buff > 0)
            {
                int ultimoDigito = buff % 10;
                buff = buff / 10;

                valorADevolver += ultimoDigito * base1;

                base1 = base1 * 2;
            }

            return valorADevolver;
        }

    }
}
