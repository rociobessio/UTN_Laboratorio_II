using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*                                                 SUMADOR
*                                           -------------------
*                                           Unidad 04 - Ejer.01
 * 
 * Consigna:
 * ---------
 *         1.Crear dos constructores:
                Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
                Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.

           2. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
                En el caso de Sumar(long, long) sumará los valores numéricos
                En el de Sumar(string, string) concatenará las cadenas de texto.
                Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

            Seguido:

            Generar una conversión explícita que retorne cantidadSumas.

            Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente 
            al resultado de la suma del atributo cantidadSumas de cada argumento.

            Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos
            sumadores tienen igual valor en el atributo cantidadSumas.

            Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
 */
namespace MiBiblioteca
{
    public class Sumador
    {
        #region ATRIBUTOS
        private int cantidadSumas;
        #endregion

        #region METODOS

        #region CONSTRUCTORES
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)//UN CONSTRUCTOR QUE LLAMA AL OTRO SUMADOR E INICIALIZA EN 0 
        {
        }
        #endregion

        #region SOBRECARGAS
        //Declara un operador de CONVERSION de tipo DEFINIDO por el usuario que se debe de INVOCAR con una CONVERSION
        #region OPERADORES EXPLICITOS

        /// <summary>
        /// Genera una CONVERSION EXPLICITA que RETORNA cantidadSumas. 
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        /// <summary>
        /// Se sobrecarga el operador + (suma)con dos OPERADORES del tipo Sumador. Devuelve un long
        /// que CORRESPONDE a la suma del ATRIBUTO cantidadSumas de cada argumento
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator | (Sumador s1,Sumador s2)
        {
            bool retorno = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }

            return retorno;
        }
        #endregion

        /// <summary>
        /// El metodo Sumar incrementara cantidadSumas en 1 y concatenara las cadenas de texto
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;

            return a + b;
        }

        /// <summary>
        /// El metodo Sumar incrementara cantidadSumas en 1 y sumara los velores numericos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        #endregion

        #endregion
    }
}
