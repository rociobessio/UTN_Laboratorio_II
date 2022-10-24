using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Ejercicio_I02
{   /// <summary>
    /// Hereda de Paquete.
    /// </summary>
    public class PaqueteFragil : Paquete
    {
        #region CONSTRUCTOR
        public PaqueteFragil(string codigoSeguimiento,decimal costoEnvio,string destino,string origen,double pesoKG) 
            : base(codigoSeguimiento,costoEnvio,destino,origen,pesoKG)
        {

        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Implementa la propiedad TienePrioridad retornando true ya que los paquetes frágiles tienen prioridad.
        /// </summary>
        public override bool TienePrioridad { get { return true; } }
        #endregion
    }
}
