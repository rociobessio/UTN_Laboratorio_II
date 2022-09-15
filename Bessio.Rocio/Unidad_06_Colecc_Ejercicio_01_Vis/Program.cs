using System;
using MiBiblioteca;

/*
 * FALTA POR HACER:
 *-----------------
 * - En Tinta validar los  de +
 * - En Paleta verificar si esta bien el implicit, los operadores + y -
 */
namespace Unidad_06_Colecc_Ejercicio_01_Vis
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TEMPERAS TIMEEEEEEE
            Tempera tempera1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera tempera2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera tempera3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera tempera4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera tempera5 = new Tempera(ConsoleColor.Green, "Temperita", 50);

           /* Console.WriteLine(tempera1 == tempera2);
            Console.WriteLine(tempera1 == tempera3);
            Console.WriteLine(tempera1 == tempera4);
            Console.WriteLine(tempera1 == null);
            Console.WriteLine(null == tempera1);

            Console.WriteLine(tempera1 + tempera2);
            Console.WriteLine(tempera1 + tempera3);
            Console.WriteLine(tempera1 + tempera4);
            Console.WriteLine(tempera1 + null);

            Console.WriteLine(tempera1 + 20);
            Console.WriteLine(tempera2 + 30);
            #endregion
           */
            #region PALETA TIMEEEEEEEE
            Paleta lista = 3;

            Console.WriteLine(lista == tempera1);

            Console.WriteLine("suma\n");

            lista += tempera1;
            Console.WriteLine((string)lista);
            Console.WriteLine(" ");

            lista += tempera2;
            Console.WriteLine((string)lista);
            Console.WriteLine(" ");

            /* lista += tempera3;
             Console.WriteLine((string)lista);
             Console.WriteLine(" ");

             lista += tempera4;
             Console.WriteLine((string)lista);
             Console.WriteLine(" ");

             lista += tempera5;
             Console.WriteLine((string)lista);
             Console.WriteLine(" ");



             Console.WriteLine("restaa\n");

             lista -= tempera1;
             Console.WriteLine((string)lista);
             Console.WriteLine(" ");

             lista -= tempera2;
             Console.WriteLine((string)lista);
             Console.WriteLine(" ");

             lista -= tempera5;
             Console.WriteLine((string)lista);
             Console.WriteLine(" ");


             Paleta lista2 = 2;

             Console.WriteLine("segunda lista\n");

             lista2 += tempera1;
             Console.WriteLine((string)lista2);
             Console.WriteLine(" ");

             lista2 += tempera2;
             Console.WriteLine((string)lista2);
             Console.WriteLine(" ");

             lista2 += tempera3;
             Console.WriteLine((string)lista2);
             Console.WriteLine(" ");

             lista2 += tempera4;
             Console.WriteLine((string)lista2);
             Console.WriteLine(" ");

             lista2 += tempera5;
             Console.WriteLine((string)lista2);
             Console.WriteLine(" ");

             Console.WriteLine("lista unidas\n");

             lista = lista + lista2;
             Console.WriteLine((string)lista);
            */
            Tempera tempAux = lista[0];

            Console.WriteLine(Tempera.Mostrar(tempAux));

            Console.WriteLine(lista[-5]);
            Console.WriteLine(lista[55]);

            lista[0] = new Tempera(ConsoleColor.Black, "sadsasd", 100);
            Console.WriteLine(Tempera.Mostrar(lista[0]));
            lista[-5] = tempera2;


            #endregion
            #endregion

        }
    }
}
