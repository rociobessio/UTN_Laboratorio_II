using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Ejercicio_I02
{
    public class GestionDeImpuestos
    {
        #region ATRIBUTOS
        private List<IAfip> impuestosAfip; 
        private List<IAduana> impuestosAduana;
        #endregion

        #region METODO

        #region CONSTRUCTOR
        /// <summary>
        /// Las listas se instanciarán en el constructor.
        /// </summary>
        public GestionDeImpuestos()
        {
            this.impuestosAduana = new List<IAduana>();
            this.impuestosAfip = new List<IAfip>();
        }
        #endregion



        /// <summary>
        /// La sobrecarga del método RegistrarImpuestos que recibe una lista de paquetes deberá agregar todos los paquetes a la lista impuestosAduana.
        /// Además, los paquetes que implementen IAfip deberán ser incorporados a la lista impuestosAfip. Reutilizar código.
        /// </summary>
        /// <param name="paquetes"></param>
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
                foreach (Paquete paquete in paquetes)
                {
                    RegistrarImpuestos(paquetes);
                }
        }

        /// <summary>
        /// La sobrecarga del método RegistrarImpuestos que recibe un paquete deberá agregar dicho paquete a la lista impuestosAduana.
        /// Además, si el paquete implementa IAfip deberá ser incorporado a la lista impuestosAfip.
        /// </summary>
        /// <param name="paquete"></param>
        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestosAduana.Add(paquete);
            if (paquete is IAfip)
            {
                impuestosAfip.Add((IAfip)paquete);
            }
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;
            foreach (IAfip Afip in impuestosAfip)
            {
                total += Afip.Impuestos;
            }
            return total;
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;
            foreach (IAduana Aduana in impuestosAduana)
            {
                total += Aduana.Impuestos;
            }
            return total;
        }

        #endregion

    }
}
