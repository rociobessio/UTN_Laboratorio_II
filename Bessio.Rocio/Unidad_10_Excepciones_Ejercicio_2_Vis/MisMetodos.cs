using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_10_Excepciones_Ejercicio_2_Vis
{
    public class MisMetodos
    {

        public static void MetodoUno()
        {
            try
            {
                MisMetodos.MetodoDos();
            }
            catch (MisExcepciones e)
            {
                throw new MisExcepciones("Excepcion METODO UNO",e);
            }
        }

        public static void MetodoDos()
        {
            try
            {
                MisMetodos.MetodoTres();
            }
            catch (MisExcepciones e)
            {
                throw new MisExcepciones("Excepcion METODO DOS",e);
            }
        }
        public static void MetodoTres()
        {
            try
            {
                MisMetodos.MetodoUno();
            }
            catch (MisExcepciones e)
            {
                throw new MisExcepciones("Excepcion METODO TRES",e);
            }
        }

    }
}
