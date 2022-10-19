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
        /// Centralita II:
        /// Agrerga la propiedad CostoLlamada
        /// 
        /// Centralita I:
        /// La propiedad CostoLlamada retornará el precio, 
        /// que se calculará en el método CalcularCosto.
        /// </summary>
        public override float CostoLlamada { get { return CalcularCosto(); } }
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
        /// Centralita II:
        /// Sera protegido 
        /// Reutiliza codigo de la clase base.
        /// 
        /// ----
        /// Centralita I:
        /// Método Mostrar retornará como texto todos los datos de la clase base y 
        /// agregará el costo de la llamada. Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        protected new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LOCAL ");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"COSTO: {this.CostoLlamada}");
            return sb.ToString();
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// El metodo Equals retornara true solo si el objeto que recibe es de tipo Local
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool esEqual = false;
            if (obj is not null && obj is Local)
            { 
                esEqual = true; 
            }
            return esEqual;
        }

        /// <summary>
        /// El metodo ToStrinh reutilizara el codigo del metodo Mostrar().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion 

    }
}
