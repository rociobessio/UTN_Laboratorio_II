using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_15_Serializacion_Biblioteca_Ejercicio_C01
{
    public class ArchivoIncorrectoException : Exception
    {
        #region CONSTRUCTOR
        public ArchivoIncorrectoException(string msj) : base (msj)
        {

        }
        #endregion

    }
}
