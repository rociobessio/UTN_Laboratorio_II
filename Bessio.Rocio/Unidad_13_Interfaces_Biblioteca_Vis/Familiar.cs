using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Vis
{
    public class Familiar : Auto
    {
        #region ATRIBUTOS
        protected int cantAsientos;
        #endregion

        #region CONSTRUCTOR
        public Familiar(double precio, string patente,int cantAsientos) : base(precio,patente)
        {
            this.cantAsientos = cantAsientos;
        }
        #endregion
    }
}
