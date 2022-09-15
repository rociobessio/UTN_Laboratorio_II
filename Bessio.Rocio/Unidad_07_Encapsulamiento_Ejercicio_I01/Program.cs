using System;
using MiBiblioteca;

namespace Unidad_07_Encapsulamiento_Ejercicio_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CREO LOS OBJETOS
            Cliente c1 = new Cliente(1, "Lautaro");
            Cliente c2 = new Cliente(2, "Mauricio");
            Cliente c3 = new Cliente(3, "Esteban");
            Negocio n1 = new Negocio("Kiosco-24");
            #endregion

            //Intento agregar al cliente (c1) a la cola de atencion (n1)
            if (n1 + c1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }

            //Intento ver si efectivamente el cliente ya esta dentro de la lista
            if (!(n1 + c1))
            {
                Console.WriteLine("Cliente c1 ya esta en la cola");
            }

            //Intento agregar al cliente (c2) a la cola de atencion (n1)
            if (n1 + c2)
            {
                Console.WriteLine("Se agrego c2 a la cola");
            }

            //Intento agregar al cliente (c3) a la cola de atencion (n1)
            if (n1 + c3)
            {
                Console.WriteLine("Se agrego c3 a la cola");
            }

            //Con la propiedad ClientesPendientes muestro la cantidad de clientes que faltan por atender
            Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);

            //Seguira realizando la accion de atender al cliente mientras haya clientes pendientes en la cola
            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
            }
        }
    }
}
