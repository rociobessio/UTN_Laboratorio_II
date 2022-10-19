using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LaCentralita
{
    abstract public  class Llamada
    {
        #region ATRIBUTOS DE LA CLASE
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region PROPIEDADES
        public float Duracion { get { return this.duracion; } }

        public string NroDestino { get { return this.nroDestino; } }

        public string NroOrigen { get { return this.nroOrigen; } }

        /// <summary>
        /// Centralita II propiedad abstracta de solo lectura
        /// </summary>
        public abstract float CostoLlamada { get; }
        #endregion

        #region CONSTRUCTOR
        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Mostrar es un método de instancia que deberá retornar todos los datos 
        /// de la llamada como texto. Utilizar StringBuilder.
        /// 
        /// Centralita II: El metodo mostrar sera deckarado como virtual, protegido y devuelve  uns string
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"DURACION: {Duracion}\nNUMERO DESTINO: {NroDestino}\nNUMERO ORIGEN: {NroOrigen}");
            return sb.ToString();
        }

        /// <summary>
        /// OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. 
        /// Se utilizará para ordenar una lista de llamadas de forma ascendente.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            int duracion = 0;
            if (llamada1.duracion > llamada2.duracion)
            {
                duracion = 1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                duracion = -1;
            }
            return duracion;
        }
        #endregion


        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Centralita II:
        /// El operador == compara dos llamadas y retorna true si son del mismo tipo (usando EQUALS sobreescrito)
        /// y los numeros de destino y origen son los mismos.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static bool operator ==(Llamada l1,Llamada l2)
        {
            bool esIgual = false;
            if (l1 is not null && l2 is not null)
            {
                esIgual = l1.nroOrigen == l2.nroOrigen && l1.NroDestino == l2.NroDestino;
            }

            return esIgual;
        }

        public static bool operator !=(Llamada l1,Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Centralita II:
        /// Retorna true si es del tipo LLAMADA y tiene mismo num de origen y destino.
        /// Se sobreescribe el metodo equal.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool esEqual = false;
            if (obj is not null && obj is Llamada)
            {
                Llamada l = ((Llamada)obj);//Casteo obj a Llamada
                if (l.NroDestino == this.NroDestino && l.NroOrigen == this.NroOrigen) 
                { esEqual = true; }
            }
            return esEqual;
        }
        #endregion

        #region  ENUMERADOS
        public enum TipoLlamada { Local, Provincial, Todas }
        #endregion

    }
}
