using System;

/*
 *                                       CALCULADORA DE AREA
 *                                  ----------------------------
 *                                      (clase 02 - 24/08/22)
 * CONSIGNA:
             Realizar una clase llamada CalculadoraDeArea que posea
             tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
             
                public double CalcularAreaCuadrado(double longitudLado)

                public double CalcularAreaTriangulo(double base, double altura)

                public double CalcularAreaCirculo(double radio)

            El ingreso de los datos como la visualizacion se deberan realizar desde el metodo Main().
                                    -------------------------------
                                       /////    SI ANDA    \\\\\
                                    -------------------------------
 */

namespace Unidad_02_Clases_Ejercicio_06_Vrd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;
            int baseTriangulo = 0;
            int opcion = 0;
            Console.WriteLine("\nCALCULADOR DE AREAS!");

            do
            {
                Console.WriteLine("\nINGRESA UN NUMERO: ");
                while (!(int.TryParse(Console.ReadLine(), out numeroIngresado)) || numeroIngresado < 0)
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 0]: ");
                }

                Console.WriteLine("\nINGRESA UN NUMERO PARA LA BASE DEL TRIANGULO: ");
                while (!(int.TryParse(Console.ReadLine(), out baseTriangulo)) || baseTriangulo < 0)
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 0]: ");
                }

                //MUESTRO LOS RESULTADOS DESDE MAIN:
                Console.WriteLine("\nEL AREA DEL CUADRADO ES: {0}", CalculadoraDeArea.CalcularAreaCuadrado(numeroIngresado));
                Console.WriteLine("\nEL AREA DEL CIRCULO ES: {0}", CalculadoraDeArea.CalcularAreaCirculo(numeroIngresado));
                Console.WriteLine("\nEL AREA DEL TRIANGULO ES: {0}", CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, numeroIngresado));

                Console.WriteLine("\n¿DESEA SEGUIR INGRESANDO NUMEROS?\n1.SI\n2.NO");
                while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }

                Console.Clear();

            } while (opcion != 2);
            Console.WriteLine("\n[PROGRAMA FINALIZADO]");
        }

    }
}

