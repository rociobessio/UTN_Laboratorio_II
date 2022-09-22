using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2022
{
     public class Padre  
    {
        #region Atributos
        public int entero;
        private double doble;
        protected bool booleano;

        #endregion

        #region Propiedad
        public double Doble 
        { 
            get
            {
                return this.doble;
            }
            set
            {
                this.doble = value;
            }        
        }

        #endregion

        #region Constructor
        public Padre(int e)
        {
            this.entero = e;
        }
        #endregion

        #region Método
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Entero:" + this.entero);
          
            return sb.ToString();
        }
        #endregion
    }
}
