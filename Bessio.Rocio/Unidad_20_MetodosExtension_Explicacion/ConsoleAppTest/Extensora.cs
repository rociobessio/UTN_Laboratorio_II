using System;
using System.Text;
using Entidades;

namespace ConsoleAppTest
{
    public static class Extensora
    {

        #region Para clases propias

        public static string ObtenerInfoExtension(this Persona p)
        {
            return p.Nombre + " - " + p.Edad;
        }

        #endregion

        #region Para object

        public static bool EsNulo(this object o)
        {
            return o == null;
        }

        #endregion

        #region Para string

        public static int CantidadDePalabras(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        #endregion

    }
}
