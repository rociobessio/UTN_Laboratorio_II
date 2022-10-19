using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I02
{
    public class Factura : Documento
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Hereda el constructor de la clase padre
        /// </summary>
        /// <param name="numero"></param>
        public Factura (int numero) : base(numero)
        {

        }
        #endregion
    }
}
