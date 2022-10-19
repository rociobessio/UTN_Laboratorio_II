using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Excepciones.Ejemplo1();
            }
            catch (Exception e)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("StackTrace:");

                Console.WriteLine(e.StackTrace);
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
                Console.WriteLine("------------------------------------------------------------------------");
                if (e.InnerException!=null)
                {
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("Mi innerException: " + e.InnerException);
                    Console.WriteLine("************************************************************************");
                }
            
            }

            Console.ReadKey();
        }
    }
}
