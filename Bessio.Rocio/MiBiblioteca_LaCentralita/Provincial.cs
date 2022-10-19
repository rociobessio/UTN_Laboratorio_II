using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LaCentralita
{
    public class Provincial : Llamada
    {
        #region ATRIBUTOS
        protected Franja franjaHoraria;
        #endregion

        #region PROPIEDADES
        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion

        #region CONSTRUCTORES
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen,Franja miFranja,float duracion, string destino) : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// CalcularCosto será privado y retornará el valor de la llamada a partir 
        /// de la duración y el costo de la misma. 
        /// Los valores serán:
        /// Franja_1: 0.99
        /// Franja_2: 1.25
        /// Franja_3: 0.66
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costoFinal = 0;

            switch (this.franjaHoraria)//Veo que franja horaria
            {
                case Franja.Franja_1:
                    costoFinal = (float)0.99;
                break;
                case Franja.Franja_2:
                    costoFinal = (float)1.25;
                break;
                case Franja.Franja_3:
                    costoFinal = (float)0.66;
                break;
            }
            return base.Duracion * costoFinal;
        }

        /// <summary>
        /// Centralita II:
        /// El método Mostrar será protegido. Reutilizará el código escrito en la clase base y
        /// agregará los datos de franjaHoraria y CostoLlamada al texto de retorno. Utilizar StringBuilder.
        /// </summary>
        /// <returns></returns>
        protected new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"COSTO LLAMADA: {this.CostoLlamada}\nFRANJA HORARIA: {this.franjaHoraria}");
            return sb.ToString();
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Centralita II:
        /// El metodo Equals retornara true solo si el objeto que recibe es de tipo Provincial
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool esEqual = false;
            if (obj is not null && obj is Provincial)
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

        #region ENUMERADOS
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        #endregion
    }
}
