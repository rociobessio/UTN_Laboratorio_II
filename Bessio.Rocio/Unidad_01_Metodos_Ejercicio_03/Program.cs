using System;
/*
 *                                              LOS PRIMOS
 * CONSIGNA:
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar. 
            Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 * 
 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas.
                    
                                    -------------------------------
                                       /////     SI ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_01_Metodos_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES
            int numero = 0;
            string userInput; //TIPO DE DATO STRING
            int opcion;

            Console.WriteLine("\n\nINGRESA UN NUMERO o 'SALIR' PARA CERRAR LA APLICACION: ");
            userInput = Console.ReadLine();//LEO LO QUE INGRESE EL USUARIO, STRING O INT

            //BUSCAR TOLOWER EN C#

            //Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            while (userInput != "salir" && !(int.TryParse(userInput, out numero)))
            {
                //VALIDO QUE EL INGRESO SEA VALIDO, TryParser devuelve booleano,
                //parseo la entrada en casi de ser int y lo guardo en numero
                Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE UN NUMERO O 'SALIR']: ");
                userInput = Console.ReadLine();//LEO LO QUE INGRESE EL USUARIO, STRING O INT
            }

            //Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            for (int i = 1; i <= numero; i++)
            {
                int contador = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) //veo si es un numero primo
                    {
                        contador++;
                    }
                }

                if (contador <= 2)
                {
                    //Mostrar por pantalla todos los números primos que
                    //haya hasta el número que ingrese el usuario por consola.
                    Console.WriteLine(i);
                }
            }

            //Al finalizar, preguntar al usuario si desea volver a operar. 
            Console.WriteLine("\n¿DESEA SEGUIR ITERANDO?\n1.SI\n2.NO");
            while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
            {
                Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
            }

            //Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
            if (opcion == 1)
            {
                Main(args);
            }
        }
    
    }
}
