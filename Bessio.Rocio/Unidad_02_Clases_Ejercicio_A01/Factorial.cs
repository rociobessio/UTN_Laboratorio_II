using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Clases_Ejercicio_A01
{
    class Factorial
    {
        public static int CalcularFactorial(int numeroIngresado)
        {
            int factorial = 1;

            for (int i = 1; i <= numeroIngresado; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

    }
}
