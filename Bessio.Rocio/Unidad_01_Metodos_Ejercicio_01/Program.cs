using System;

/*
 * CONSIGNA:
 * Ingresar 5 números por consola, guardándolos en una variable escalar.
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 * 
 * IMPORTANTE:
 * Un escalar es una constante o variable que contiene un dato atómico y unidimensional.
 * En contraposición al concepto de escalar, están los conceptos de array, lista y objeto,
 * que pueden tener almacenado en su estructura más de un valor.​
 */

namespace Unidad_01_Metodos_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeroIngresado = new int[5];//Variable escalar = unidimensional, array
            int maximo = 0;
            int minimo = 0;
            float promedio;
            int acumulador = 0;


            //int.TryParse

            for (int i = 0; i < numeroIngresado.Length; i++) //numeroIngresado.Length tamanio del array
            {
                //TOMAR INPUT DE INT O FLOAT
                Console.WriteLine("\nIngresa el numero {0}: ", i);//Escrbir en consola, reemplazo/equivalente del printf
                numeroIngresado[i] = int.Parse(Console.ReadLine());//HACEMOS UN PARSEO DE NUMERO, YA QUE Console.ReadLine devuelve string

                acumulador += numeroIngresado[i];

                if (numeroIngresado[i] < minimo || i == 0)
                {
                    minimo = numeroIngresado[i];
                }
                if (numeroIngresado[i] > maximo || i == 0)
                {
                    maximo = numeroIngresado[i];
                }
            }

            promedio = (float)acumulador / numeroIngresado.Length;

            Console.WriteLine("\nEL NUMERO MAXIMO ES {0}, EL MINIMO ES {1} y EL PROMEDIO ES {2}", maximo, minimo, promedio);//Escrbir en consola, reemplazo/equivalente del printf

        }
    }
}
