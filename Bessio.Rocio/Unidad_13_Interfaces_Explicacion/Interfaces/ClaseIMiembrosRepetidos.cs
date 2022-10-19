using System;

namespace Interfaces
{
    public class ClaseIMiembrosRepetidos : IMiembrosRepetidos, IMiembrosRepetidos2
    {

        public void Metodo()
        {
            Console.WriteLine("Método de IMiembrosRepetidos");
        }

        void IMiembrosRepetidos2.Metodo()
        {
            Console.WriteLine("Método de IMiembrosRepetidos2");
        }

    }
}