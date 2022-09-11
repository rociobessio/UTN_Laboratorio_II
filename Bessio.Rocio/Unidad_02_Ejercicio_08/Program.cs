using System;
/*
 *                                          EL TIEMPO PASA
 *                                  ----------------------------
 *                                      (clase 02 - 24/08/22)
 * CONSIGNA:
            Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde
            esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

            Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de
            días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

            Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
                                    -------------------------------
                                       /////    NO ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_02_Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int anio = 0;
            int dia = 0;
            int mes = 0;
            //DateTime fecha = new DateTime(dia, mes, anio);
            int diasVividos = 0;

            do
            {
                Console.WriteLine("\nINGRESA EL DIA DE NACIMINETO: ");
                while (!(int.TryParse(Console.ReadLine(), out dia)) || (dia < 1 && dia > 31))
                {
                    Console.WriteLine("\n[VALOR INVALIDO, REINGRESA UN DIA ENTRE 1 y 10]: ");
                }

                Console.WriteLine("\nINGRESA EL MES DE NACIMINETO: ");
                while (!(int.TryParse(Console.ReadLine(), out mes)) || (mes < 1 && mes > 12))
                {
                    Console.WriteLine("\n[VALOR INVALIDO, REINGRESA UN MES ENTRE 1 y 12]: ");
                }

                Console.WriteLine("\nINGRESA EL AÑO DE NACIMINETO: ");
                while (!(int.TryParse(Console.ReadLine(), out anio)) || (anio < 1 && anio > 2022))
                {
                    Console.WriteLine("\n[VALOR INVALIDO, REINGRESA UN DIA ENTRE 1 y 2022]: ");
                }

                diasVividos = ValidarFecha.CalcularDiasVividos(dia, mes, anio);
                Console.WriteLine("\nLA CANTIDAD DE DIAS VIVIDOS ES DE: {0} DIAS", diasVividos);



                Console.WriteLine("\n¿DESEA SEGUIR INGRESANDO NUMEROS?\n1.SI\n2.NO");
                while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }
                Console.Clear();
            } while (opcion != 2);

            Console.WriteLine("[PROGRAMA FINALIZADO!]");

        }
    }
}
