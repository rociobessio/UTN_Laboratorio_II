using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Clases_Explicacion_0._1
{
    /// <summary>
    /// Esta es una clase estatica.
    /// DOCUMENTACION XML
    /// </summary>
    class Class1
    {

        //ATRIBUTO dentro de clase, "campo DENTRO DE ESTRUCTURA"
        public static string cadena;

        //PUEDO DEFINIR DISTINTOS ELEMENTOS DENTRO DE UNA CLASE
        //LOS METODOS Y LAS CLASES NO PUEDEN ESTAR SUELTOS, dentro de namespaces

        //              GENERO EL METODO DENTRO DE LA CLASE
        //public = modificador de visibilidad
        //static = como utilizo el elemento, comportamiento
        //void = tipo de retorno del metodo
        //Verbos = nombre del metodo (siempre mayusc 1ra)
        //() = argumentos, tipo de dato y nombre 

        /// <summary>
        /// METODO PARA RECIBIR CADENAS
        /// </summary>
        /// <param name="cadena"></param>
        public static void Verbos(string cadena)
        {
            //CODIGO
            Class1.cadena = "adsjasd";//Puedo acceder asi tambien =   cadena = "asdasdsd"; (pero no debe de hacerse).
        }


        //METODOS LLAMANDO A OTRO
        public static void OtroMetodo()
        {
            Class1.Verbos("");
        }

    }
}
