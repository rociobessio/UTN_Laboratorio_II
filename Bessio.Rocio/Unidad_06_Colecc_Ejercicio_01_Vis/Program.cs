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
            #region CREO LAS 5 TEMPERAS
            Tempera t1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera t4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Temperita", 50);
            #endregion

            #region COMPARAR (temperas)
            Console.WriteLine("COMPARACION DE OPERADOR == (Tempera,Tempera)");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Es la tinta1 igual a tinta2?: ");
            Console.WriteLine(t1 == t2); 
            Console.WriteLine("\n Datos de la Temp1");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine("Datos de la Temp2");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Tempera.Mostrar(t2));
            Console.WriteLine("------------------------------------------------");
            Console.Write("Es la tinta1 igual a tinta3?: ");
            Console.WriteLine(t1 == t3);
            Console.WriteLine("\n Datos de la Temp1");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine("\n Datos de la Temp3");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Tempera.Mostrar(t3));
            Console.WriteLine("------------------------------------------------");
            Console.Write("Es la tinta1 igual a tinta4?: ");
            Console.WriteLine(t1 == t4);
            Console.WriteLine("\n Datos de la Temp1");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Tempera.Mostrar(t1));
            Console.WriteLine("\n Datos de la Temp4");
            Console.WriteLine("-----------------------");
            Console.WriteLine(Tempera.Mostrar(t4));
            Console.WriteLine("------------------------------------------------");
            Console.Write("Es la tinta1 igual a null?: ");
            Console.WriteLine(t1 == null);
            Console.WriteLine("------------------------------------------------");
            Console.Write("Es la null igual a tinta4?: ");
            Console.WriteLine(null == t1);
            Console.WriteLine("------------------------------------------------");
            #endregion

            #region SUMAR (Tempera, Tempera)
            Console.WriteLine("\n\n    SOBRECARGA DEL OPERADOR + (Tempera,Tempera)");
            Console.WriteLine("------------------------------------------------");
            Console.Write("La suma entre la tinta1 y tinta2 es: ");
            Console.WriteLine(t1 + t2);
            Console.Write("La suma entre la tinta1 y tinta3 es: ");
            Console.WriteLine(t1 + t3);
            Console.Write("La suma entre la tinta1 y tinta4 es: ");
            Console.WriteLine(t1 + t4);
            Console.Write("La suma entre la tinta1 y null es: ");
          //  Console.WriteLine(t1 + null);
            #endregion
            #region SUMAR (Tempera,int)
            Console.WriteLine("\n\n    SOBRECARGA DEL OPERADOR + (Tempera,int)");
            Console.WriteLine("------------------------------------------------");
            Console.Write("La suma entre la tinta1 y 20 es: ");
            Console.WriteLine(t1 + 20);
            Console.Write("La suma entre la tinta2 y 30 es: ");
            Console.WriteLine(t1 + 30);
            #endregion

        }
    }
}
