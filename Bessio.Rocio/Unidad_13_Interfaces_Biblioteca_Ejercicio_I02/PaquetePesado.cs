using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Hereda de Paquete.
    /// </summary>
    public class PaquetePesado : Paquete, IAfip //Implementar la interfaz IAfip en PaquetePesado.
    {
        #region CONSTRUCTOR
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKG)
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKG)
        {

        }
        #endregion

        #region PROPIEDAD
        /// <summary>
        /// Implementa la propiedad TienePrioridad retornando false ya que los paquetes pesados NO tienen prioridad
        /// </summary>
        public override bool TienePrioridad { get { return false; } }

        /// <summary>
        /// La propiedad Impuestos deberá ser implementada de forma explícita.
        /// </summary>
        decimal IAfip.Impuestos { get { return base.costoEnvio * 0.25M; } }
        #endregion

        #region METODO
        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio + Impuestos + ((IAfip)this).Impuestos;//Casteo this a IAfip para poder usar de forma explicita la propiedad Impuestos
        }
        #endregion
    }
}
