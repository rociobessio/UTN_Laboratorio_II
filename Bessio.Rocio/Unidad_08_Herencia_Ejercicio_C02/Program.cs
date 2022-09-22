using System;
using MiBiblioteca_EnciendanMotores_Unidad_08;
namespace Unidad_08_Herencia_Ejercicio_C02
{
    class Program
    {
        static void Main(string[] args)
        {

            AutoF1 a1 = new AutoF1(1, "Ford");
            AutoF1 a2 = new AutoF1(1, "Fiat", 20);
            AutoF1 a3 = new AutoF1(1, "Fiat", 20);

            MotoCross m1 = new MotoCross(5, "Harley", 1000);
            Console.WriteLine(a1.MostrarDatos());

            Competencia comp = new Competencia(10, 6, Competencia.TipoCompetencia.F1);
            bool _ = comp + a1;//Añado el auto a la competencia

            Console.WriteLine($"Add a1: {comp + a1}");
            Console.WriteLine($"Add a2: {comp + a2}");
            Console.WriteLine($"Add a3: {comp + a3}");
            Console.WriteLine($"Add m1: {comp + m1}");
            Console.WriteLine($"a2 == a3: {a2 == a3}");//COMPARO AUTO 1 Y 3
            Console.WriteLine($"remover a1: {comp - a1}");
            Console.WriteLine($"Add new VehiculoDeCarrera: {comp + new VehiculoDeCarrera(2, "Macumba")}");
            Console.WriteLine($"Add new AutoF1: {comp + new AutoF1(2, "Mercedes")}\n");

            Console.WriteLine(comp.MostrarDatos());

            Console.ReadKey();
        }
    }
}
