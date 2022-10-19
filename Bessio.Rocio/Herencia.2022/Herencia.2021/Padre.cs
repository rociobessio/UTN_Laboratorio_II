using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia._2022
{
    abstract class Padre  
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
        protected virtual string Mostrar()//Palabra reservada VIRTUAL para la clase PADRE
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Entero:" + this.entero);
          
            return sb.ToString();
        }

        public override string ToString()//SOBREESCRIBO toString
        {
            return this.ToString();
        }
        #endregion


        public abstract void MetodoAbstracto(string c);
    
    }

}
