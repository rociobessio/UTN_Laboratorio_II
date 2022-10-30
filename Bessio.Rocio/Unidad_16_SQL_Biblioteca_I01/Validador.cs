using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace Unidad_16_SQL_Biblioteca_I01
{
    public class Validador
    {
        #region STRINGS
        /// <summary>
        /// Me fijo que la cadena no sea null o que este vacia
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Si es falso retorna true</returns>
        private static bool ValidarTexto(string dato)
        {
            return !string.IsNullOrEmpty(dato);
        }

        /// <summary>
        /// Sobrecarga de metodo, le paso una string y me fijo que no sea null
        /// </summary>
        /// <param name="string1"></param>
        /// <returns></returns>
        public static bool ValidarIngresoDatos(string string1)
        {
            return (Validador.ValidarTexto(string1));
        }

        /// <summary>
        /// Sobrecarga de metodos le paso dos strings y me fijo que no sean nulas
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public static bool ValidarIngresoDatos(string string1, string string2)
        {
            return (Validador.ValidarTexto(string1) && Validador.ValidarTexto(string1));
        }
        #endregion

    }
}
