using System;
using MiBiblioteca;
namespace Unidad_07_Encapsulamiento_Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro librito = new Libro();

            //AGREGO TEXTO A LAS PAGINAS DEL LIBRO, MEDIANTE EL INDICE QUE QUIERO
            librito[0] = "PROGRAMACION ORIENTADA A OBJETOS";
            librito[1] = "ENCAPSULAMIENTO";
            librito[2] = "CLASES";
            librito[3] = "METODOS";
            librito[4] = "COLECCIONES";
            librito[5] = "WINFORMS";
            Console.WriteLine("                    LIBRO SOBRE PROGRAMACION II");
            Console.WriteLine("                ------------------------------------");
            Console.WriteLine("INDICE DE PAGINAS:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0}. ",i);
                Console.WriteLine(librito[i]);
            }
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("                    LIBRO SOBRE PROGRAMACION II ACTUALIZADO");
            Console.WriteLine("                ------------------------------------");
            Console.WriteLine("INDICE DE PAGINAS:");
            //Sobreesrcibo uno de los Indices que ya existe
            librito[1] = "SOBRECARGA";
            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0}. ", i);
                Console.WriteLine(librito[i]);
            }


        }
    }
}
