using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *                                   FAHRENHEIT 451
 *                          ------------------------------
 *                           UNIDAD 04 - SOBRECARGA - A01
 * CONSIGNA:
 *          Crear un proyecto de consola y un proyecto de biblioteca de clases. Agregar al último tres clases 
 *          Fahrenheit, Celsius y Kelvin.

            Realizar la implementación necesaria para poder convertir una temperatura en sus distintas 
            unidades de medida (Fahrenheit, Celsius y Kelvin).

            Utilizar sobrecargas de métodos, operadores y/o conversiones.


                                    NO ANDAAAAAAA
 */

namespace Unidad_04_SobreCarg_Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INSTANCIO LOS OBJETOS
            Celsius c1 = new Celsius(15);
            Celsius c2 = new Celsius(5);

            Fahrenheit f1 = new Fahrenheit(45);
            Fahrenheit f2 = new Fahrenheit(35);

            Kelvin k1 = new Kelvin(315);
            Kelvin k2 = new Kelvin(305);
            #endregion

            //CELSIUS
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("+ {0}\n",c1 + c2);
            sb.AppendFormat("- {0}\n", c1 - c2);
            sb.AppendFormat("== {0}\n", c1 == c2);
            sb.AppendFormat("!= {0}\n", c1 != c2);
            //FAHRENHEIT
            sb.AppendFormat("+ {0}\n", f1 + f2);
            sb.AppendFormat("- {0}\n", f1 - f2);
            sb.AppendFormat("== {0}\n", f1 == f2);
            sb.AppendFormat("!= {0}\n", f1 != f2);
            //KELVIN
            sb.AppendFormat("(KELVIN)c1 {0}\n", (((Kelvin)c1).valor));
            sb.AppendFormat("(FAHRENHEIT)c1 {0}\n\n", (((Fahrenheit)c1).valor));
            sb.AppendFormat("!= {0}\n\n", k1 != k2);

            Console.WriteLine(sb.ToString());


            Console.WriteLine("[PROGRAMA FINALIZADO!]");
        }
    }
}
