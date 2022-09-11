using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Clases_Ejercicio_07
{
    class Teorema
    {
        public static double CalcularTeorema(int baseTriangulo, int altura)
        {
            int auxBase = 0;
            int auxAltura = 0;
            double suma = 0;
            double resultado = 0;

            auxBase = (int)Math.Pow(baseTriangulo, 2);
            auxAltura = (int)Math.Pow(altura, 2);

            suma = auxBase + auxAltura;

            resultado = Math.Sqrt(suma);

            return resultado;
        }

    }
}
