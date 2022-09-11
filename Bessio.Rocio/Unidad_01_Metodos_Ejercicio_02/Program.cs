using System;
/*
 *                                  ERROR AL CUBO
 * CONSIGNA:
            Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
            Se debe validar que el número sea mayor que cero,
            caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 * 
 * IMPORTANTE:
            Utilizar el método Pow de la clase Math para calcular las potencias.

                                    ---------------------------------------
                                       /////    HECHO EN CLASE    \\\\\
                                    ---------------------------------------
 */

namespace Unidad_01_Metodos_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numero2;
            int numero3;

            //TOMAR INPUT DE INT O FLOAT
            Console.WriteLine("\nIngresa el numero: ");//Escrbir en consola, reemplazo/equivalente del printf
            numeroIngresado = int.Parse(Console.ReadLine());//HACEMOS UN PARSEO DE NUMERO, YA QUE Console.ReadLine devuelve string

            //while...
            if (numeroIngresado <= 0)
            {
                Console.WriteLine("\nERRO REINGRESE NUMERO ");
            }
            else
            {
                numero2 = (int)Math.Pow(numeroIngresado, 2);//Se debe de castear math.pow porque devuelve un double
                numero3 = (int)Math.Pow(numeroIngresado, 3);
                Console.WriteLine("\nEL CUBO ES {0} Y EL CUADRADO ES {1}", numero3, numero2);
            }

            Console.ReadKey();
        }
    }
}
