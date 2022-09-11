using System;

namespace Unidad_02_Clases_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;


            int decimalNum;
            int binarioDecimal = 10101001; //deberia imprimir 2

            int numero = 15;

            binario = Conversor.ConvertirDecimalABinario(numero);

            Console.WriteLine("NUMERO DECIMAL {0} EN BINARIO: {1}", numero, binario);

            decimalNum = Conversor.ConvertirBinarioADecimal(binarioDecimal);
            Console.WriteLine("NUMERO DE BINARIO {0} A DECIMAL: {1}", binarioDecimal, decimalNum);

        }
    }
}
