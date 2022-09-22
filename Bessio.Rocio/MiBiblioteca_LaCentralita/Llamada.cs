using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LaCentralita
{
    public class Llamada
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
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
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

        public enum TipoLlamada { Local, Provincial, Todas }
    }
}
