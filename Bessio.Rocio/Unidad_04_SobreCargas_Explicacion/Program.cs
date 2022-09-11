using System;

namespace Unidad_04_SobreCargas_Explicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            double color;
            string marca;

            Vehiculo v1 = new Vehiculo("dasddasd",5,"rojo");


            //USO SOBRECARGAS EXPLICITA, es decir, UN CASTEO DEL TIPO DE DATO.
            marca = (string)v1;

            //Uso sobrecarga IMPLICITA ocurre por detras
            marca = v1;

            Console.WriteLine("Hello World!");
        }
    }
}
