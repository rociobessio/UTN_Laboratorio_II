using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Ejercicio_01_Vis
{
    class Validador
    {

        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false; //lo seteo como falso

            if (valor <= max && valor >= min)
            {
                retorno = true;
            }

            return retorno;
        }

    }
}
