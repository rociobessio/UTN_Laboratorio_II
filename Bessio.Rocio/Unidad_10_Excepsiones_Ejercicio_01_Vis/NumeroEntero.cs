using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_10_Excepciones_Ejercicio_01_Vis
{
    public class NumeroEntero
    {
        /// <summary>
        /// Debe devolver dos cosas por eso el out int y el bool
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool TryParse(string cadena, out int numero)
        {
            bool esNumero = true;
            numero = 0;//Parametro de SALIDA
            try
            {
                numero = int.Parse(cadena);//Parsea la cadena
            }
            catch (Exception e)
            {
                esNumero = false;
            }

            return esNumero;
        }



    }
}
