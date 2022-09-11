using System;

namespace Unidad_01_Metodos_Explicacion
{
    class Program//Clase que contiene al ENTRY POINT MAIN, no existen metodos sueltos.
    {
        static void Main(string[] args)
        {
            //VARIABLES
            string nombre;
            int edad = 8;


            Console.WriteLine("Hello World!");//Escrbir en consola, reemplazo/equivalente del printf
            //Console. es una CLASE y con el . accedemos a los METODOS
            //Una CLASE es un contenedor de elementos (variables comunes) parecido a una estructura
            //y los METODOS son las funciones que se pueden agregarle.

            //TOMAR INPUT DE STRING
            Console.WriteLine("Ingresa tu nombre: ");//Escrbir en consola, reemplazo/equivalente del printf
            nombre = Console.ReadLine();//Leo el ingreso del usuario

            //TOMAR INPUT DE INT O FLOAT
            Console.WriteLine("\nIngresa tu edad: ");//Escrbir en consola, reemplazo/equivalente del printf
            edad = int.Parse(Console.ReadLine());//HACEMOS UN PARSEO DE EDAD, YA QUE Console.ReadLine devuelve string

            //EL REEMPLAZO DE LAS MASCARAS ES {numero}
            Console.WriteLine("El nombre es {1} y la edad es de {0} anios", edad, nombre);//Escrbir en consola, reemplazo/equivalente del printf

        }
    }
}
