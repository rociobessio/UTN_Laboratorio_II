using System;

namespace Unidad_02_Ejercicio_01_Vis
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroIngresado = 0;
            int acumulador = 0;
            int minimo = 0;
            int maximo = 0;
            float promedio = 0;

            bool isNumber;

            for (int i = 0; i < 10; i++)
            {

                do
                {
                    Console.WriteLine("INGRESA UN NUMERO ENTRE [-100 y 100]: ");
                    isNumber = int.TryParse(Console.ReadLine(), out numeroIngresado);

                    //seguira pidiendo ingreso mientras no se cumpla la condicion
                } while (!isNumber || Validador.Validar(numeroIngresado, -100, 100) == false);

                if (i == 0)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                    else
                    {
                        if (numeroIngresado < minimo)
                        {
                            minimo = numeroIngresado;
                        }
                    }
                }
                acumulador = acumulador + numeroIngresado;
            }
            promedio = (float)acumulador / 10;
            Console.WriteLine("NUMERO MAXIMO: {0}\nNUMERO MINIMO: {1}\nPROMEDIO: {2}", maximo, minimo, promedio);

        }
    }
}
