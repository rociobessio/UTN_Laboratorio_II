using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public static class Excepciones
    {
        public static List<int> lista;

        #region Ejemplo 1
        public static void Ejemplo1()
        {
            int[] array = { 1, 2, 3, 4 };
            try
            {
                array = null;
                array[4] = 2;
          
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        #endregion

        #region Ejemplo 2
        public static void Ejemplo2Metodo1()
        {
            try
            {
                Excepciones.Ejemplo2Metodo2();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Ejemplo2Metodo2()
        {
            Excepciones.Ejemplo2Metodo3();
        }

        public static void Ejemplo2Metodo3()
        {
            int cero = 0;
            try
            {
              int noSePuedeDividirPorCero = 2 / cero;
            }
            catch (OutOfMemoryException e)
            {

            }
        }
        #endregion

        #region Ejemplo 3
        public static void Ejemplo3Metodo1()
        {
            try
            {
                Excepciones.Ejemplo3Metodo2();
            }
            finally
            {
                Console.WriteLine("Finally método 1");
            }
        }

        public static void Ejemplo3Metodo2()
        {
            try
            {
                Excepciones.Ejemplo3Metodo3();
            }
            finally
            {
                Console.WriteLine("Finally método 2");
            }

        }

        public static void Ejemplo3Metodo3()
        {
            try
            {
                Console.WriteLine("Ingrese un número:");
                int algo = int.Parse(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally método 3");
            }
        }

        #endregion

        #region Ejemplo 4
        public static void Ejemplo4Metodo1()
        {

            try
            {
                Excepciones.Ejemplo4Metodo2();
            }
            catch (NullReferenceException e)
            {

                throw e;
            }
        }

        public static void Ejemplo4Metodo2()
        {
            try
            {
                Excepciones.Ejemplo4Metodo3();
            }
            catch (NullReferenceException e)
            {

                throw e;
            }

        }

        public static void Ejemplo4Metodo3()
        {
            try
            {
                Excepciones.lista.Add(1);
            }
            catch (NullReferenceException e)
            {

                throw e;
            }

        }
        #endregion

        #region Ejemplo 5
        public static void Ejemplo5Metodo1()
        {
            try
            {
                Excepciones.Ejemplo5Metodo2();
            }
            finally
            {

            }
            
        }

        public static void Ejemplo5Metodo2()
        {
            Excepciones.Ejemplo5Metodo3();
        }

        public static void Ejemplo5Metodo3()
        {
            try
            {
                Excepciones.lista.Add(1);
            }
            catch (NullReferenceException e)
            {
             throw new MiPropiaException("Lanzo la excepcion en el método 3", e);
            }
        }

        #endregion


    }
}
