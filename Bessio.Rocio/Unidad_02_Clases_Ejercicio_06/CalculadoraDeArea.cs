using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Clases_Ejercicio_07
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            //Calculo el area del CUADRADO
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            //UTILIZO DOS METODOS DE LA CLASE MATH
            return Math.PI * Math.Pow(radio, 2);
        }

    }
}
