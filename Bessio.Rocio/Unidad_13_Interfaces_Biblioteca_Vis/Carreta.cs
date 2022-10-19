using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Vis
{
    public class Carreta : Vehiculo
    {
        #region METODOS (CONSTRUCTOR)

        /// <summary>
        /// Hereda de Vehiculo
        /// </summary>
        /// <param name="precio"></param>
        public Carreta(double precio) : base(precio) { }

        #endregion
    }
}
