using System;
using System.Collections.Generic;
using Entidades;

namespace TiposGenericos2022
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple
            /*
            ClaseSimple<string> objString = new ClaseSimple<string>();
            ClaseSimple<int> objInt = new ClaseSimple<int>(2);
            ClaseSimple<bool> objBool = new ClaseSimple<bool>(true);
            ClaseSimple<Clase> objClase = new ClaseSimple<Clase>(new Clase());

            Console.WriteLine(objString.ToString());
            Console.WriteLine(objInt.ToString());
            Console.WriteLine(objBool.ToString());
            Console.WriteLine(objClase.ToString());
            */
            
            #endregion

            #region Menos Simple
            /*
            ClaseMenosSimple<int,double> objIntDouble = new ClaseMenosSimple<int,double>();
            ClaseMenosSimple<bool,string> objBoolString = new ClaseMenosSimple<bool,string>();
            ClaseMenosSimple<Clase,ClaseDerivada> objClase = new ClaseMenosSimple<Clase,ClaseDerivada>();

            objIntDouble.MiAtributo = 4;
            objIntDouble.MiAtributo2 = 4.5;

            objBoolString.MiAtributo = true;
            objBoolString.MiAtributo2 = "Hola";

            objClase.MiAtributo = new Clase();
            objClase.MiAtributo2 = new ClaseDerivada();

            Console.WriteLine(objIntDouble.MiAtributo.ToString());
            Console.WriteLine(objIntDouble.MiAtributo2.ToString());
            Console.WriteLine(objBoolString.MiAtributo.ToString());
            Console.WriteLine(objBoolString.MiAtributo2.ToString());
            Console.WriteLine(objClase.MiAtributo.ToString());
            Console.WriteLine(objClase.MiAtributo2.ToString());
            */
            #endregion

            #region Con restricción
            /*
            ClaseConRestriccion<ClaseDerivada,ConsoleColor,Clase> claseRestrictiva =  new ClaseConRestriccion<ClaseDerivada,ConsoleColor,Clase>(new ClaseDerivada(),ConsoleColor.Blue,new Clase());

            claseRestrictiva.Mostrar();
            */
            #endregion

            #region Métodos genéricos
            /*
            string mje=ClaseConMetodosGenericos.Metodo<string>("Accedo al Método Genérico");
            Console.WriteLine(mje);
            ClaseConMetodosGenericos.Metodo2<IAlgunaInterfase>();
            mje= ClaseConMetodosGenericos.Metodo3<string, ClaseDerivada, ClaseDerivada>("Accedo al Método3 Genérico",new ClaseDerivada(),new ClaseDerivada());
            Console.WriteLine(mje);*/ 
            #endregion

            Console.ReadKey();
        }
    }
}
