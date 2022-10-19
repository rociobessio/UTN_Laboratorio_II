using System;
using Unidad_10_Excepciones_Ejercicio_2_Vis;

namespace Unidad_10_Excepciones_Ejercicio_2_Vis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MisMetodos.MetodoUno();
            }
            catch (MisExcepciones e)
            {
                Console.WriteLine(e.Mensaje);
            }
       
        }
    }
}
