using System;

/*
 *                                       APRENDETE LAS TABLAS
 *                                  ----------------------------
 *                                      (clase 02 - 24/08/22)
 * CONSIGNA:
            Crear una aplicación de consola que permita al usuario ingresar un número entero.

            Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación 
            de ese número en formato string.

            Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.   

            Mostrar en la consola el resultado.

            Por ejemplo, si se ingresa el número 2 la salida deberá ser:
            Tabla de multiplicar del número 2:
            2 x 1 = 2
            2 x 2 = 4
            2 x 3 = 6
            2 x 4 = 8
            2 x 5 = 10
            2 x 6 = 12
            2 x 7 = 14
            2 x 8 = 16
            2 x 9 = 18
                                    -------------------------------
                                       /////    - ANDA    \\\\\
                                    -------------------------------
 */

namespace Unidad_02_Clases_Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int opcion = 0;
            string tabla = " ";

            do
            {
                Console.WriteLine("\nINGRESA UN NUMERO ENTERO: ");
                while (!(int.TryParse(Console.ReadLine(), out numeroIngresado) || numeroIngresado < 0))
                {

                    Console.WriteLine("\n[VALOR INVALIDO, REINGRESA UN NUMERO VALIDO: ] ");
                }

                tabla = Multiplicadora.TablaMultiplicar(numeroIngresado);
                Console.WriteLine("\nTABLA DE MULTIPLICAR DEL {0}: ", numeroIngresado);
                Console.WriteLine(tabla);

                Console.WriteLine("\n¿DESEA SEGUIR INGRESANDO NUMEROS?\n1.SI\n2.NO");
                while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }
            } while (opcion != 2);

            Console.WriteLine("\n[PROGRAMA FINALIZADO]");
        }
    }
}
