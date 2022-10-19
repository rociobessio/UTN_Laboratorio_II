using System;
using MiBiblioteca;
namespace Unidad_06_Colecc_Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CREO LOS OBJETOS
            Equipo equipoList = new Equipo(4,"CCVA");

            Jugador j1 = new Jugador(456,"Juan",4,6);
            Jugador j2 = new Jugador(56, "GianFranco", 0, 11);
            Jugador j3 = new Jugador(56, "Tomi", 10, 2);
            Jugador j4 = new Jugador(7892, "Agus", 7, 10);
            Jugador j5 = new Jugador(563, "JuanCruz", 4, 3);
            #endregion

            #region TESTEO LOS METODOS Y SOBRECARGAS
            if (equipoList + j1)//Se fija si esta en el equipo y añade a la lista si [NO] esta
                Console.WriteLine(j1.MostrarDatos());

            if (equipoList + j2)//Se fija si esta en el equipo y añade a la lista si [NO] esta
                Console.WriteLine(j2.MostrarDatos());
    
            if (equipoList + j3)//Se fija si esta en el equipo y añade a la lista si [NO] esta
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO A "+ j3.MostrarDatos());
            }

            if (equipoList + j4)//Se fija si esta en el equipo y añade a la lista si [NO] esta
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO A " + j4.MostrarDatos());
            }

            if (equipoList + j5)//Se fija si esta en el equipo y añade a la lista si [NO] esta
            {
                Console.WriteLine(j5.MostrarDatos());
            }
            #endregion

        }
    }
}
