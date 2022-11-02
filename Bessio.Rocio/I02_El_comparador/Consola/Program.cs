using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            #region PUNTO 2
            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            // Punto 2: Usando el método Comparar, indicar cuál es el texto con más caracteres.
            // Sumistrar el argumento del tipo delegado usando una expresión lambda.
            Comparar(primerTexto, segundoTexto, (p, s) => p.Length - s.Length);
            //Paso las cadenas, se asignan a p y s, con => invoco a la funcion
            #endregion

            #region PUNTO 3
            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            // Punto 3
            //Usando el método Comparar, indicar cuál es el texto con más palabras.
            //Sumistrar el argumento del tipo delegado usando una expresión lambda.
            // Considerar palabras distintas si las separa un salto de línea.
            Comparar(primerTexto,segundoTexto, (p, s)
               => p.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length - s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
            //Expresion lambda, con el split elimino los espacios vacios y paso el length para la comparacion
            #endregion

            #region PUNTO 4
            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            // Punto 4
            //Usando el método Comparar, indicar cuál es el texto con más vocales. Sumistrar el argumento del tipo delegado usando una expresión lambda.
            //Utilizar el método ContarVocales provisto en la solución.
            Comparar(primerTexto,segundoTexto, (p,s) => ContarVocales(p) - ContarVocales(s));
            #endregion

            #region PUNTO 5
            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            // Punto 5
            //Usando el método Comparar, indicar cuál es el texto con más signos de puntuación. Sumistrar el argumento del tipo delegado usando una expresión lambda.
            //Utilizar el método ContarSignosPuntuacion provisto en la solución.
            Comparar(primerTexto,segundoTexto, (p,s) => ContarSignosPuntuacion(p) - ContarSignosPuntuacion(s));
            #endregion
        }

        #region DELEGADOS
        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Crear un método Comparar que reciba dos textos y un delegado.
        /// El delegado representará el criterio de comparación de dos textos y retornará un entero en base a la siguiente premisa:
        /// Si el primer texto es mayor al segundo, retorna un valor positivo.
        /// Si el primer texto es menor al segundo, retorna un valor negativo.
        /// Si los textos son iguales, retorna cero.
        /// El método Comparar invocará al delegado y en base a su resultado mostrará por consola si el primer texto es mayor, menor o igual al segundo.
        /// </summary>
        /// <param name="cadena1"></param>
        /// <param name="cadena2"></param>
        /// <param name="delegadoComparacion"></param>
        public static void Comparar(string cadena1,string cadena2, DelegadoComparacion delegadoComparacion)
        {
            int resultadoComparacion = delegadoComparacion(cadena1,cadena2);// retornará un entero 

            if (resultadoComparacion > 0)//Si el resultado es positivo, el primero es mayor que el segundo. 
            {
                Console.WriteLine($"El primer texto: '{cadena1}' es mayor que el texto dos: '{cadena2}'");
            }
            else if(resultadoComparacion < 0)//Si el primer texto es menor al segundo, retorna un valor negativo.
            {
                Console.WriteLine($"El segundo texto: '{cadena2}' es mayor que el texto uno: '{cadena1}'");
            }
            else if (resultadoComparacion == 0)
            {
                Console.WriteLine($"Tanto la cadena 1 como la cadena 2 son IGUALES.");
            }

        }

        #endregion
    }
}
