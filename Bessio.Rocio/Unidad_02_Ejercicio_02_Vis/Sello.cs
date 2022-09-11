using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Ejercicio_02_Vis
{
    class Sello
    {

        public static string mensaje;

        public static ConsoleColor color;

        public static string Imprimir()//AHORA PASA A ARMAR FORMATO MENSAJE
        {
            //Console.WriteLine(mensaje);
            string mensaje;
            mensaje = ArmarFormatoMensaje();//guardo en mensaje lo que retorna el nuevo formato
            return mensaje;
            //return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirColor()
        {
            Console.ForegroundColor = Sello.color;//CAMBIO COLOR DE LETRA DE LA STRING
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();//VUELVO A PONER LA STRING EN BLANCO
        }

        static string ArmarFormatoMensaje()
        {
            int sizeCadena = Sello.mensaje.Length;
            string formato = "";
            string textoFormato = "";

            if (sizeCadena != 0)
            {
                for (int i = 0; i < (sizeCadena + 2); i++)
                {
                    formato = formato + "*";
                }

                textoFormato = formato + "\n*" + Sello.mensaje + "*\n" + formato;
            }
            return textoFormato;

        }

    }
}
