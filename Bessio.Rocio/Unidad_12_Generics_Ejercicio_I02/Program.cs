using System;
using Unidad_12_Generics_Biblioteca_I02;
namespace Unidad_12_Generics_Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio los objetos
            Recibo recibo1 = new Recibo();//imprime 0
            Factura factura1 = new Factura(123);
            Factura factura2 = new Factura(456);

            //Instancio la coleccion GENERICA, que recibee dos tipos de dato, FACTURA y RECIBO
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            //Los agrego a la listas respectivas (egresos, ingresos)
            contabilidad += recibo1;
            contabilidad += factura1;
            contabilidad += factura2;

            foreach (Documento item in contabilidad.egresos)
            {
                Console.WriteLine(item.numero);
            }
            foreach (Documento item in contabilidad.ingresos)
            {
                Console.WriteLine(item.numero);
            }

        }
    }
}
