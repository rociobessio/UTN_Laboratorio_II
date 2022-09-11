using System;
/*
 *                                       CALCULAR UN FACTORIAL
 *                                  ------------------------------
 *                                      (clase 02 - 24/08/22)
 * CONSIGNA:
 *          El factorial de un número es una operación que consiste en multiplicar un numero “n” 
 *          por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

            En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
                                    -------------------------------
                                       /////    SI ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_02_Clases_Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int opcion = 0;
            int factorialDelNumero = 0;

            do
            {

                Console.WriteLine("\nINGRESA UN NUMERO PARA ENCONTRAR EL FACTORIAL: ");
                while (!(int.TryParse(Console.ReadLine(), out numeroIngresado)) || numeroIngresado < 0)
                {
                    Console.WriteLine("\n[VALOR INVALIDO, REINGRESA UN NUMERO]: ");
                }

                factorialDelNumero = Factorial.CalcularFactorial(numeroIngresado);

                Console.WriteLine("\nEL FACTORIAL DEL NUMERO {0} ES {1} !", numeroIngresado, factorialDelNumero);

                Console.WriteLine("\n¿DESEA SEGUIR INGRESANDO NUMEROS?\n1.SI\n2.NO");
                while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }
                Console.Clear();
            } while (opcion != 2);



            Console.WriteLine("[PROGRAMA FINALIZADO!]");
            Console.WriteLine("Hello World!");
        }
    }
}
