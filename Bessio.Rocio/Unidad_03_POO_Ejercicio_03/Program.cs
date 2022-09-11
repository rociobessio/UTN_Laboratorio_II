using System;

using MiBiblioteca;

/*
 *                                       EL EJEMPLO UNIVERSAL
 *                                  ----------------------------
 *                                      (clase 03 - 30/08/22)
 * CONSIGNA:
 *          Crear una aplicación de consola y una biblioteca de clases que contenga 
 *          la clase del siguiente diagrama: https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I03-el-ejemplo-universal/
 *          
 *          La clase Estudiante:
            - Tendrá un constructor estático que inicializará el atributo estático random.
            - Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
            - El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
            - El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
            - El método privado CalcularPromedio retornará el promedio de las dos notas.
            - El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
            - El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
            - Nombre, apellido y legajo.
            - Nota del primer y segundo parcial.
            - Promedio.
            - Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
            - Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            - Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            - Mostrar los datos de todos los alumnos.
 *          
 *          IMPORTANTE:
                 Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.


                                            NO ANDA PROMEDIO
                                    -------------------------------
                                       /////    - ANDA    \\\\\
                                    -------------------------------
 */

namespace Unidad_03_POO_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREO TRES OBJETOS DEL TIPO ESTUDIANTE
            Estudiante alumnoUno = new Estudiante("JOSE", "MARTINEZ", "1023");
            Estudiante alumnoDos = new Estudiante("FITO", "KLOPP", "1445");
            Estudiante alumnoTres = new Estudiante("MARIANA", "ESTEVANEZ", "1568");

            //CARGAR LAS NOTAS DEL PRIMER Y SEGUNDO PARCIAL DE LOS ALUMNOS, DOS DEBERAN DE ESTAR APROBADOS Y UNO DESAPROBADO

            //PRIMER PARCIAL
            alumnoUno.SetNotaPrimerParcial(8);
            alumnoDos.SetNotaPrimerParcial(3);
            alumnoTres.SetNotaPrimerParcial(7);

            //SEGUNDO PARCIAL
            alumnoUno.SetNotaSegundoParcial(7);
            alumnoDos.SetNotaSegundoParcial(2);
            alumnoTres.SetNotaSegundoParcial(9);

            //MOSTRAR LOS DATOS DE TODOS LOS ALUMNOS 
            string alumnoUnoString = "aaa";
            alumnoUnoString = alumnoUno.Mostrar();
            Console.WriteLine("\n        LOS DATOS DE LOS ALUMNOS");
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("\nALUMNO UNO: \n");
            Console.WriteLine(alumnoUnoString);


            string alumnoDosString = "bbb";
            alumnoDosString = alumnoDos.Mostrar();
            Console.WriteLine("\n----------------------");
            Console.WriteLine("\nALUMNO DOS: \n");
            Console.WriteLine(alumnoDosString);

            string alumnoTresString = "aaa";
            alumnoTresString = alumnoTres.Mostrar();
            Console.WriteLine("\n----------------------");
            Console.WriteLine("\nALUMNO TRES: \n");
            Console.WriteLine(alumnoTresString);
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("[PROGRAMA FINALIZADO!]");
            //  Console.Clear();
        }
    }
}
