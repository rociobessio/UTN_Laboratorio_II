using System;

using Billetes;
/*
 *                                          COTIZADOR
 *                                    ----------------------
 *                                     UNIDAD 04 - EJER. 02

 CONSIGNA:
            Crear un proyecto de tipo biblioteca de clases. Construir tres clases dentro de un namespace llamado 
            Billetes: Pesos, Euro y Dolar.

            Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con
            total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro equivale a 1,17 Dólares 
            y 1 Dólar equivale a 102,65 Pesos.
            
            1. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

            2. Los constructores estáticos le darán a las clases una cotización por defecto respecto del dólar.

            3. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.

            4. Los operadores de comparación == compararán cantidades.

            5. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.

            6. Crear un proyecto de consola y colocar dentro del método Main el código necesario para probar todas las funcionalidades.
 */

namespace Unidad_04_SobreCarga_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro billeteEuro = 1;
            Peso billetePeso = (Peso)billeteEuro;
            //Console.WriteLine("\n{0} EUROS EQUIVALEN A {1} PESOS",billeteEuro,billetePeso.GetCantidad);
            Console.WriteLine(billetePeso.GetCantidad);

            Dolar billeteDolar = 100;
            billetePeso = (Peso)billeteDolar;
            Console.WriteLine("\nCANTIDAD DE DOLARES CONVERTIDOS A PESOS {0} ", billetePeso.GetCantidad);

            Console.WriteLine("[PROGRAMA FINALIZADO!]");
        }
    }
}
