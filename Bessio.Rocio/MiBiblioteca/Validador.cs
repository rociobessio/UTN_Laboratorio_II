using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    class Validador
    {

        public bool validarNumeros(int numeros)
        {
            bool retorno = true;
            if ((numeros>= 32 && numeros<=47) || (numeros >= 58 && numeros <= 255))
            {
                retorno = false;
            }
            return retorno;
        }



    }
}
