using System;
/*
 *                                         UN NUMERO PERFECTO  
 * CONSIGNA:
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
            (excluido el mismo) que son divisores del número.

            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            Escribir una aplicación que encuentre los 4 primeros números perfectos.

 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas.
                    
                                    -------------------------------
                                       /////    SI ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_01_Metodos_Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //INICIALIZO LAS VARIABLES
            int contador = 0;
            int i = 2;

            //Escribir una aplicación que encuentre los 4 primeros números perfectos.
            Console.WriteLine("LOS PRIMEROS CUATRO NUMEROS PERFECTOS SON: ");

            while (contador != 4)//los primeros 4 numeros
            {
                int numero = 0;

                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        numero += k;
                    }
                }

                //SI i coincide con el numero perfecto:
                if (i == numero)
                {
                    //tiene que imprimir 6,28,496 y 8128
                    Console.WriteLine(i);
                    contador++;
                }

                i++;
            }

            Console.WriteLine("\n[PRESIONE UNA TECLA PARA FINALIZAR EL PROGRAMA.]");
            Console.ReadKey();
        }
    }
}
