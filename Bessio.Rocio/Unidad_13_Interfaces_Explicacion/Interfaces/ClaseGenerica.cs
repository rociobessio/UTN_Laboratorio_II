using System;

namespace Interfaces
{
    public class ClaseGenerica<T> : IGenerica<T>
        where T : new()
    {
        public void Metodo(T param)
        {
            Console.WriteLine(param.ToString());
        }

        public T MetodoRetorno(T param)
        {
            throw new NotImplementedException();
        }
    }
}