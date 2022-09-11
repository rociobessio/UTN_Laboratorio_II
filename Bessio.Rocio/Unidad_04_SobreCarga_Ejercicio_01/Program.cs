using System;

using MiBiblioteca;



namespace Unidad_04_SobreCarga_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            //Instancio DOS OBJETOS DEL TIPO SUMADOR
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador();

            //Este metodo Sumar lo que hace es recibir DOS ENTEROS
            Console.WriteLine(s1.Sumar(21,22));

            //Este otro metodo Sumar lo que hace es CONCATENAR DOS STRINGS
            Console.WriteLine(s2.Sumar("Buenas","Tardes!"));

            //Guardo lo que devuelve s1 y s2
            a = (int)s1;
            b = (int)s2;


            Console.WriteLine(a);
            Console.WriteLine(b);

            //Con este Operador EXPLICITO SUMO
            Console.WriteLine(s1+s2);
            
            //Con este otro Operador EXPLICITO veo si devuele TRUE o FALSE
            Console.WriteLine(s1|s2);

            Console.ReadLine();

            Console.WriteLine("[PROGRAMA FINALIZADO!]");
        }
    }
}
