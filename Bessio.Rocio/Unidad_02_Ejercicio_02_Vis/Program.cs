using System;

namespace Unidad_02_Ejercicio_02_Vis
{
    class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "hola mundo";

            //Imprimir retorna string
            Console.WriteLine(Sello.Imprimir());

            //Sello.Borrar();
            Sello.color = ConsoleColor.Red;

            //Sello.Imprimir();
            Sello.ImprimirColor();

            //Console.WriteLine("{0}", mostrarMsj);
            Console.WriteLine(Sello.Imprimir());

        }
    }
}
