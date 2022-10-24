using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Implementar la interfaz IAduana en Paquete de forma implícita.
    /// </summary>
    public interface IAduana
    {
        #region PROPIEDADES
        decimal Impuestos { get; }
        #endregion

        #region METODOS
        decimal AplicarImpuestos();
        #endregion
    }
}
