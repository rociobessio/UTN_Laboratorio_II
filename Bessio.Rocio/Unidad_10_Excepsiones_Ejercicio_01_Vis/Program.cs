using System;
using Unidad_10_Excepciones_Ejercicio_01_Vis;

namespace Unidad_10_Excepsiones_Ejercicio_01_Vis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingresa un numero: ");
            string cadenaNumero = Console.ReadLine();
            while (!NumeroEntero.TryParse(cadenaNumero,out numero))//Mientras NO pueda parsearlo....
            {
                Console.WriteLine("[NO SE PUDO REALIZAR EL PARSE!]");
                Console.WriteLine("Reingresa un numero: ");//Pido reingreso de los datos.
                cadenaNumero = Console.ReadLine();
            }

            Console.WriteLine("[PARSEO REALIZADO CORRECTAMENTE]: {0}",numero);
        }
    }
}
