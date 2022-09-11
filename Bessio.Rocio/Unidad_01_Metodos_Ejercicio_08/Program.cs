using System;
/*
 *                       DIBUJANDO UN TRIANGULO RECTANGULO
 * CONSIGNA:
            Escribir un programa que imprima por consola un triángulo .
            El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
            Para el ejemplo anterior, la altura ingresada fue de 5.
 * 
 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas.

                                     -------------------------------
                                       /////    NO ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_01_Metodos_Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;


            Console.WriteLine("Ingresa la cantidad de filas del triangulo [5-10]: ");
            filas = int.Parse(Console.ReadLine());

            while (filas < 5 || filas > 10)
            {
                Console.WriteLine("\nERROR, REINGRESA LA CANTIDAD DE FILAS [5-10]: ");
                filas = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");
            for (int i = 1; i <= filas; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
                //Console.WriteLine("\n");
            }
        }
    }
}
