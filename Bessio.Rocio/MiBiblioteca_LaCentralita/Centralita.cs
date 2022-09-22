using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_LaCentralita
{
    public class Centralita
    {
        #region ATRIBUTOS
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region PROPIEDADES
        public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }
        #endregion

        #region CONSTRUCTORES
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada
        /// y retornará el valor de lo recaudado, según el criterio elegido (ganancias
        /// por las llamadas del tipo Local, Provincial o de Todas según corresponda).
        /// </summary>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acum = 0;
            Local local;
            Provincial provincial;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is  Local)
                    {
                        local = (Local)llamada;
                        acum += local.CostoLlamada;
                    }
                    else
                    {
                        provincial = (Provincial)llamada;
                        acum += provincial.CostoLlamada;
                    }

                }
                else if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (llamada is Provincial)//Me fijo si llamada coincide con obj Ptovincial
                    {
                        provincial = (Provincial)llamada;
                        acum += provincial.CostoLlamada;
                    }
                }
            }
            return acum;
        }

        /// <summary>
        /// El método Mostrar expondrá la razón social, la ganancia total, 
        /// ganancia por llamados locales y provinciales y el detalle de las 
        /// llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            Local local;
            Provincial provincial;
            sb.AppendLine($"RAZON SOCIAL: {this.razonSocial}");
            sb.AppendLine($"GANANCIA POR LOCAL: {GananciasPorLocal}");
            sb.AppendLine($"GANANCIA POR PROVINCIAL: {GananciasPorProvincial}");
            sb.AppendLine($"GANANCIA POR TOTAL: {GananciasPorTotal}");
            foreach (Llamada llamada in Llamadas)
            {
                if (llamada is Local)
                {
                    local = (Local)llamada;
                    sb.AppendLine(local.Mostrar());//Muestro llamadas locales
                }
                else
                {
                    provincial = (Provincial)llamada;
                    sb.AppendLine(provincial.Mostrar());//Muestro llamadas locales
                }
            }

            return sb.ToString();
        }
        /*
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion());
        }*/
        #endregion
    }
}
