using System;
using Unidad_12_Generics_Biblioteca_I01;

namespace Unidad_12_Generics_Ejercicio_I01
{
          /// <summary>
         /// Generar dos torneos, uno de Futbol y otro de Basquet.
        /// Crear 3 equipos de cada tipo.
       /// Agregar los equipos en tantos torneos como se pueda.
      /// Llamar al método Mostrar de Torneo e imprimir su retorno por pantalla.
     /// Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo e imprimir su respuesta por pantalla.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> equipoF1 = new Torneo<EquipoFutbol>("Primera Division");
            EquipoFutbol equipoFutbol1 = new EquipoFutbol("Racing",new DateTime(1997,02,21));
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("River Plate", new DateTime(1982, 12, 13));
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("Lanus", new DateTime(2003, 08, 17));
            _ = equipoF1 + equipoFutbol1;
            _ = equipoF1 + equipoFutbol2;
            _ = equipoF1 + equipoFutbol3;


            Torneo<EquipoBasket> equipoB1 = new Torneo<EquipoBasket>("NBA");
            EquipoBasket equipoBasket1 = new EquipoBasket("Lakers", new DateTime(2001, 10, 20));
            EquipoBasket equipoBasket2 = new EquipoBasket("Celtics", new DateTime(2006, 12, 09));
            EquipoBasket equipoBasket3 = new EquipoBasket("Warriors", new DateTime(2018, 09, 03));

            //bool type
            _ = equipoB1 + equipoBasket1;
            _ = equipoB1 + equipoBasket2;
            _ = equipoB1 + equipoBasket3;

            Console.WriteLine(equipoB1.Mostrar());
            Console.WriteLine(equipoF1.Mostrar());
        }
    }
}
