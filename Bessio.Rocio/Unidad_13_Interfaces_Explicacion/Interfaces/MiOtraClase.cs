using System;

namespace Interfaces
{
    public class MiOtraClase : IGenerica<ClaseConstructorDefecto>
    {
        public void Metodo(ClaseConstructorDefecto param)
        {
            Console.WriteLine(param.ToString());
        }

        public ClaseConstructorDefecto MetodoRetorno(ClaseConstructorDefecto param)
        {
            return param;
        }
    }
}