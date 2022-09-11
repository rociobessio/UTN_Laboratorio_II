using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    class Multiplicadora
    {
        public static string TablaMultiplicar(int numero)
        {
            StringBuilder newString = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                newString.AppendLine($"{numero} x {i} = {(numero * i)}");
                //resultado = numero * i;
                //newString.AppendFormat("{0} x {1} = {2}\n", numero, i, resultado);
            }

            return newString.ToString();
        }
    }
}
