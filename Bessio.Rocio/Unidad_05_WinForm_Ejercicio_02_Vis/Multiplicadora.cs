using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_05_WinForm_Ejercicio_02_Vis
{
    class Multiplicadora
    {
        public static string TablaMultiplicar(int numero)
        {
            StringBuilder newString = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                newString.AppendLine($"{numero} x {i} = {(numero * i)}     ");
                //resultado = numero * i;
                //newString.AppendFormat("{0} x {1} = {2}\n", numero, i, resultado);
            }

            return newString.ToString();
        }

        public static bool validarNumeros(int numeros)
        {
            bool retorno = true;
            if ((numeros >= 32 && numeros <= 47) || (numeros >= 58 && numeros <= 255))
            {
                retorno = false;
            }
            return retorno;
        }

    }
}
