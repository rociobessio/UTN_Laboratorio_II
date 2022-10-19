using System;
using MiBiblioteca_Unidad_09_Polimorfismo;

namespace Unidad_09_Polimorfismo_Ejercicio_01_Vis
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto("GREW",2,EMarcas.Honda,120);
            Moto moto2 = new Moto("FAFA", 2, EMarcas.Iveco, 45);


            Auto auto1 = new Auto("FETW", 4, EMarcas.Ford, 456);
            Auto auto2 = new Auto("LLPO", 4, EMarcas.Scanavia, 789);


            Camion camion1 = new Camion("TREW", 4, EMarcas.Zanella, 545);
            Camion camion2 = new Camion("QEQW", 4, EMarcas.Flat, 455);

            Lavadero lavadero = new Lavadero(100,250,63);

            lavadero += auto1;
            lavadero += camion1;
            lavadero += moto1;

            Console.WriteLine(lavadero.Detalle);

            
            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(lavadero.Detalle);

            lavadero.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(lavadero.Detalle);


        }
    }
}
