using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClaseConMetodosGenericos
    {
        public static F Metodo<F>(F parametro)
        {
            return parametro;
        }

        public static void Metodo2<T>() where T : IAlgunaInterfase
        {
            Console.WriteLine("Accedo al Método2 Genérico");
        }

        public static T Metodo3<T,U,P>(T param,U param2,P param3)
                            where T: class
                            where U: ClaseDerivada, new()
                            where P: U
        {
            return param;
        }
            

    }
}
