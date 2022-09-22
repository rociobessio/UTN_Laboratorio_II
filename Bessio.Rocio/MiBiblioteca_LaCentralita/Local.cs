using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LaCentralita
{
    public class Local : Llamada
    {
        #region ATRIBUTOS
        protected float costo;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// La propiedad CostoLlamada retornará el precio, 
        /// que se calculará en el método CalcularCosto.
        /// </summary>
        public float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion

        #region CONSTRUCTORES
        public Local(Llamada llamada, float costo) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion,string destino,float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// CalcularCosto será privado. Retornará el valor de
        /// la llamada a partir de la duración y el costo de la misma.
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {//base hace referencia a la clase padre
            return base.Duracion * this.costo;
        }

        /// <summary>
        /// Método Mostrar retornará como texto todos los datos de la clase base y 
        /// agregará el costo de la llamada. Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LOCAL ");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"COSTO: {this.CostoLlamada}");
            return sb.ToString();
        }
        #endregion
    }
}
