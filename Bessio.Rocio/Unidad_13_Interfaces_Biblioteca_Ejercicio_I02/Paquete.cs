using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Interfaces_Biblioteca_Ejercicio_I02
{
    /// <summary>
    /// Es una clase abstracta.
    /// </summary>
    public abstract class Paquete : IAduana
    {
        #region ATRIBUTOS
        private string codigoSeguimiento;
        protected decimal costoEnvio;//Su atributo costoEnvio es protegido.
        private string destino;
        private string origen;
        private double pesoKG;
        #endregion

        #region PROPIEDADES
        public abstract bool TienePrioridad { get; }

        /// <summary>
        /// la propiedad Impuestos,  cuando se invoca de forma implícita desde una instancia de PaqueteFragil,
        /// retorne el 35% del costo de envío.
        /// </summary>
        public decimal Impuestos { get { return this.costoEnvio * 0.35M; } }
        
        #endregion

        #region  METODOS
        #region  CONSTRUCTOR
        protected Paquete(string codigoSeguimiento,decimal costoEnvio,string destino,string origen,double pesoKG)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKG = pesoKG;
        }
        #endregion

        /// <summary>
        /// El método ObtenerInformacionDePaquete retorna todos los datos del paquete (incluyendo si tiene prioridad) 
        /// como una cadena de texto.
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento} - Costo envio: {this.costoEnvio} - Destino: {this.destino}" +
                $"- Origen {this.origen} - Peso KG: {this.pesoKG}kgs.");
            if (TienePrioridad)
            {
                sb.AppendLine($"[TIENE PRIORIDAD]");
            }
            else
            {
                sb.AppendLine($"[NO TIENE PRIORIDAD]");
            }
            return sb.ToString();
        }

        /// <summary>
        /// El metodo AplicarImpuestos debera ser virtual
        /// </summary>
        /// <returns></returns>
        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + Impuestos;
        }

        #endregion
    }
}
