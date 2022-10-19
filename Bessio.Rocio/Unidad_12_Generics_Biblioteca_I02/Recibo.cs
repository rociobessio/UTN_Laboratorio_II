using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I02
{
    public class Recibo : Documento
    {
        #region CONSTRUCTORES
        /// <summary>
        /// El constructor sin parámetros de Recibo asignará 0 como número de documento.
        /// Inicializa en 0
        /// </summary>
        public Recibo() : this(0)
        {

        }

        /// <summary>
        /// Hereda el constructor de la clase padre
        /// </summary>
        /// <param name="numero"></param>
        public Recibo(int numero) : base(numero)
        {

        }
        #endregion
    }
}
