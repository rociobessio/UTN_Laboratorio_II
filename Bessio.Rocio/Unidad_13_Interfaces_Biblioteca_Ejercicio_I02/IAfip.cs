using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Ejercicio_I02
{
    public interface IAfip
    {
        #region PROPIEDADES
        decimal Impuestos { get; }
        #endregion

        #region METODOS
        decimal AplicarImpuestos();
        #endregion
    }
}
