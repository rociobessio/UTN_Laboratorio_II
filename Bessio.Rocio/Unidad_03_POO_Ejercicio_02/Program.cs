using System;

using MiBiblioteca;
namespace Unidad_03_POO_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaUno = new DateTime(2003, 08, 13);
            Persona sujetoUno = new Persona("MARTIN",fechaUno,"45.013.997");
            string MostrarInformacion = " ";

            MostrarInformacion = sujetoUno.Mostrar();
            Console.WriteLine("\n   DATOS DEL SUJETO Nº1");
            Console.WriteLine("------------------------------");
            Console.WriteLine(MostrarInformacion);
            Console.WriteLine("---------------------------------------------------------------");

            DateTime fechaDos = new DateTime(2010, 11, 25);
            Persona sujetoDos = new Persona("JUANA", fechaDos, "50.126.897");

            MostrarInformacion = sujetoDos.Mostrar();
            Console.WriteLine("\n   DATOS DEL SUJETO Nº2");
            Console.WriteLine("------------------------------");
            Console.WriteLine(MostrarInformacion);
            Console.WriteLine("---------------------------------------------------------------");

            DateTime fechaTres = new DateTime(1990, 05, 07);
            Persona sujetoTres = new Persona("FACUNDO", fechaTres, "39.456.745");

            MostrarInformacion = sujetoTres.Mostrar();
            Console.WriteLine("\n   DATOS DEL SUJETO Nº3");
            Console.WriteLine("------------------------------");
            Console.WriteLine(MostrarInformacion);
            Console.WriteLine("---------------------------------------------------------------");


        }
    }
}
