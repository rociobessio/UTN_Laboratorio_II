using System;

/*
 *                                          LA CALCULADORA
 *                                  ----------------------------
 *                                      (clase 02 - 24/08/22)
 * CONSIGNA:
            Realizar un programa que permita realizar operaciones
            matemáticas simples (suma, resta, multiplicación y división).

            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando
            y la operación matemática. El método devolverá el resultado de la operación.

            Validar (privado): Recibirá como parámetro el segundo operando. 
            Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
            Este método devolverá true si el operando es distinto de cero.

            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
            (ingresando el caracter +, -, * o /).

            El usuario decidirá cuándo finalizar el programa.
                                    -------------------------------
                                       /////    SI ANDA    \\\\\
                                    -------------------------------
 */

namespace Unidad_02_Clases_Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumeroIngresado;
            int segundoNumeroIngresado;
            char operacion = 'x';
            int opcion = 0;

            float resultadoOperacion = 0;

            do
            {
                Console.WriteLine("\nINGRESA EL PRIMER NUMERO: ");
                while (!(int.TryParse(Console.ReadLine(), out primerNumeroIngresado)) || (primerNumeroIngresado < 1))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 1]: ");
                }

                Console.WriteLine("\nINGRESA EL SEGUNDO NUMERO: ");
                while (!(int.TryParse(Console.ReadLine(), out segundoNumeroIngresado)) || (segundoNumeroIngresado < 1))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 1]: ");
                }

                Console.WriteLine("\nINGRESA LA OPERACION MATEMATICA A REALIZAR [+,-,/,*]:");
                while (!(char.TryParse(Console.ReadLine(), out operacion)) || (operacion != '*' && operacion != '+' && operacion != '-' && operacion != '/'))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE LA OPERACION MATEMATICA A REALIZAR [+,-,/,*]]: ");
                }

                //LLAMO A LOS METODOS:
                resultadoOperacion = Calculadora.Calcular(primerNumeroIngresado, segundoNumeroIngresado, operacion);

                Console.WriteLine("\nEL RESULTADO DE LA OPERACION MATEMATICA ES: {0}", resultadoOperacion);

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
