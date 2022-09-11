using System;
/*
 *                                      TIRAME UN CENTRO
 * CONSIGNA:
            Un centro numérico es un número que separa una lista de números enteros (comenzando en 1)
            en dos grupos de números, cuyas sumas son iguales.

            El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5)
            y (7; 8) cuyas sumas son ambas iguales a 15.
            El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49)
            cuyas sumas son ambas iguales a 595.

            Se pide elaborar una aplicación que calcule los centros numéricos entre 1 Y
            el número que el usuario ingrese por consola.
 * 
 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas.
                    
                                    -------------------------------
                                       /////     NO ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_01_Metodos_Ejercicios_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            int acumuladorNumMenores = 0;
            int acumuladorNumMayores = 0;

            Console.WriteLine("INGRESA UN NUMERO: ");
            while (int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                //LA LISTA COMIENZA EN 1
                for (int centroNumerico = 1; centroNumerico < numeroIngresado; centroNumerico++)
                {
                    for (int i = 0; i < centroNumerico; i++)
                    {
                        //POR UNA PARTE SE DEBE DE SUMAR LOS NUMEROS ANTERIORES AL CENTRO NUMERICO
                        acumuladorNumMenores += i;
                    }

                    //POR LA OTRA AQUELLOS NUMEROS SUPERIORES AL CENTRO NUMERICO
                    for (int j = centroNumerico + 1; j <= acumuladorNumMenores; j++)//recorro hasta que j sea menor o igual a la suma de los anteriores al centro
                    {
                        //VERIFICO QUE LA SUMA DE LOS INFERIORES SEA IGUAL A LA DE LOS SUPERIORES O
                        //QUE EN SU DEFECTO LOS SUPERIORES SEAN MAYORES A LOS ANTERIORES
                        if ((acumuladorNumMenores == acumuladorNumMayores) || (acumuladorNumMayores > acumuladorNumMenores))
                            break; //rompo el bucle
                        acumuladorNumMayores += j;
                    }

                    //UNA VEZ QUE EL ACUMULADOR DE LO MISMO IMPRIMO POR PANTALLA
                    if (acumuladorNumMenores == acumuladorNumMayores)
                    {
                        Console.WriteLine("ES UN CENTRO NUMERICO: {0} ", centroNumerico);
                    }
                }
            }
            Console.WriteLine("NO ES UN NUMERO");
            //COMO UN SYSTEM(PAUSE)
            Console.ReadKey();
        }
    }
}
