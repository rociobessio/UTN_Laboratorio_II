using System;

namespace Interfaces.Ejemplo
{
    public class Tortuga : Mascota
    {
        public int edad;

        public Tortuga(int edad)
        {
            this.edad = edad;
        }

        public override string ToString()
        {
            return this.edad.ToString();
        }
    }
}