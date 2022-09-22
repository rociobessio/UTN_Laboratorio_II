using System;
using System.Collections.Generic;

namespace Herencia._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            Padre p = new Padre(56);
            Hija h = new Hija(24, "Soy hija", 4.5);
            Nieta n = new Nieta(8, "Soy nieta", 1.2, new Padre(1));

            //Protected no se accede de afuera de la clase.
            //p.booleano = true;

            List<Padre> familia = new List<Padre>();

            familia.Add(p);
            familia.Add(h);
            familia.Add(n);

            foreach (Padre item in familia)
            {
                Console.WriteLine("---------------------");

                if (item is Nieta)
                Console.WriteLine(((Nieta)item).MostrarNieta());
                else if (item is Hija)
                Console.WriteLine(((Hija)item).MostrarHija());
                else if (item is Padre)
                Console.WriteLine(item.Mostrar());

                Console.WriteLine("---------------------");
            }


            Console.ReadKey();
        }
    }
}
