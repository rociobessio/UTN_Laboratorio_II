using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_10_Excepciones_Ejercicio_2_Vis
{
    public class MisExcepciones : Exception
    {
        private string message;//Msj ya existente (?)

        #region CONSTRUCTOR

        /// <summary>
        /// El mensaje que tiene como parámetro de entrada en el constructor con el ya existente.
        /// </summary>
        /// <param name="mensaje"></param>
        public MisExcepciones(string mensaje)
        {
            this.message = mensaje;
        }

        /// <summary>
        /// Casteo inner para poder acceder a la nueva propiedad de esta clase
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public MisExcepciones(string mensaje,Exception innerException)
        {
            this.message  += ((MisExcepciones)innerException).Mensaje + mensaje;
        }
        #endregion

        #region PROPIEDAD

        /// <summary>
        /// Crear una clase que derive de Exception con una propiedad llamada Mensaje que concatene el
        /// mensaje que tiene como parámetro de entrada en el constructor con el ya existente.
        /// </summary>
        public string Mensaje { get { return this.message; } set { this.message = value; } }
        #endregion
    }
}
