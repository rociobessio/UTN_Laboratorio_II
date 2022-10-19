using System;

namespace Interfaces
{
    public interface IGenerica<T> where T : new()
    {
        void Metodo(T param);
        T MetodoRetorno(T param);
    }
}