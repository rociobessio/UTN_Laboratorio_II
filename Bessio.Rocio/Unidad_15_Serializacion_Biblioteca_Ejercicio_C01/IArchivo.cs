using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_15_Serializacion_Biblioteca_Ejercicio_C01
{
    /// <summary>
    /// Interfaz, recordar que NO LLEVAN IMPLEMENTACION!
    /// </summary>
    public interface IArchivo<T>
    {
        void Guardar(string path,T content);

        void GuardarComo(string path,T content);
       
        T Leer(string path);
    }
}
