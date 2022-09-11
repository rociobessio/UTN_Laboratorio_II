using System;

 
using ConversorBinRecargado_Unidad_04;
/*
 *                                  CONVERSOR BINARIO
 *                          ----------------------------------
 *                          UNIDAD 04 - SOBRECARGA - EJER. C01
 * CONSIGNA:
 *          Partiendo del ejercicio Conversor binario, se pide agregar las clases:

            NumeroBinario:
            1. Único atributo numero de tipo string.
            2. Único constructor privado (recibe un parámetro de tipo string).

            NumeroDecimal:
            1. Único atributo numero de tipo double.
            2. Único constructor privado (recibe un parámetro de tipo double).
           Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:

            NumeroBinario:
            string + (NumeroBinario, NumeroDecimal)
            string - (NumeroBinario, NumeroDecimal)
            bool == (NumeroBinario, NumeroDecimal)
            bool != (NumeroBinario, NumeroDecimal)

            NumeroDecimal:
            double + (NumeroDecimal, NumeroBinario)
            double - (NumeroDecimal, NumeroBinario)
            bool == (NumeroDecimal, NumeroBinario)
            bool != (NumeroDecimal, NumeroBinario)

            Agregar conversiones implícitas para poder ejecutar:
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
    
            Agregar conversiones explícitas para poder ejecutar:
            string binario = (string)objBinario;
            double numeroDecimal = (double)objDecimal;

        Generar el código en el método Main para instanciar un objeto de cada tipo y operar entre ellos,
        imprimiendo cada resultado por pantalla.    

 */

namespace Unidad_04_SobreCarg_Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONVERSIONES IMPLICITAS:
            NumeroBinario objBinario = (NumeroBinario)"1001";
            NumeroDecimal objDecimal = (NumeroDecimal)9;


            Console.WriteLine($"El numero binario es {objBinario.numero}, sumado con el decimal de un total de {objDecimal + objBinario}");
            Console.WriteLine($"El numero decimal es {objDecimal.numero}, sumado con el binario de un total de {objBinario + objDecimal}");

        }
    }
}
