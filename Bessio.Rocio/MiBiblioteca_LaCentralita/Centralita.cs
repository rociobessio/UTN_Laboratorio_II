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

        public string Mostrar(Llamada.TipoLlamada tipo)
        {
            Local local;
            Provincial provincial;
            StringBuilder str = new StringBuilder();
            str.AppendFormat("\tRazon social: {0} \n", razonSocial);
            str.AppendLine("\t-");

            foreach (Llamada l in Llamadas)
            {
                if (l is Local && (tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Local))
                {
                    local = (Local)l;
                    str.AppendLine(local.ToString());
                }
                else if (l is Provincial && (tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Provincial))
                {
                    provincial = (Provincial)l;
                    str.AppendLine(provincial.ToString());
                }
            }
            str.AppendLine("\t------------------------------------------------------------------------------------");
            str.Append("\tGANANCIAS:: ");
            switch (tipo)
            {
                case Llamada.TipoLlamada.Todas:
                    str.AppendFormat("¦  Total: {0}  ", GananciasPorTotal);
                    str.AppendFormat("¦  Local: {0}  ", GananciasPorLocal);
                    str.AppendFormat("¦  Provincial: {0}  ", GananciasPorProvincial);
                    break;
                case Llamada.TipoLlamada.Local:
                    str.AppendFormat("¦  Local: {0}  ", GananciasPorLocal);
                    break;
                case Llamada.TipoLlamada.Provincial:
                    str.AppendFormat("¦  Provincial: {0}  ", GananciasPorProvincial);
                    break;

            }
            str.AppendLine("  ¦\n");

            return str.ToString();
        }

        /// <summary>
        /// Centralita II:
        /// El metodo mostrar pasa a ser privado se sobreescribe con el metodo ToString
        /// 
        /// Centralita I:
        /// El método Mostrar expondrá la razón social, la ganancia total, 
        /// ganancia por llamados locales y provinciales y el detalle de las 
        /// llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            return this.Mostrar(Llamada.TipoLlamada.Todas);
        }
        /*
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion());
        }*/

        /// <summary>
        /// El método AgregarLlamada es privado. Recibe una instancia de Llamada y la agrega a la lista de llamadas.
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        private bool AgregarLlamada(Llamada l)
        {
            bool agregaOno = false;
            if (l is not null && l is Llamada)
            {
                this.Llamadas.Add(l);
                agregaOno = true;
            }
            return agregaOno;
        }

        #endregion

        #region POLIMORFISMO
        /// <summary>
        /// Sobreescribe el metodo Mostrar de la clase.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Centralita II:
        /// El operador == retornará true si la centralita contiene la llamada en su lista genérica. 
        /// Utilizar la sobrecarga del operador == de la clase Llamada.
        /// </summary>
        /// <param name="cen"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public static bool operator ==(Centralita cen, Llamada l)
        {
            bool estaONo = false;
            if (cen is not null && l is not null && cen is Centralita && l is Llamada)//Me fijo que no sea null y que sea de ese tipo
            {
                foreach (Llamada llamada in cen.listaDeLlamadas)
                {
                    if (llamada == l)//Me fijo si esta
                    {
                        estaONo = true;
                        break;//Rompo porq esta
                    }
                }
            }
            return estaONo;
        }
        public static bool operator !=(Centralita cen, Llamada l)
        {
            return !(cen == l);
        }


        
        /// <summary>
        /// El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita.
        /// Utilizar la sobrecarga del operador == de Centralita.
        /// </summary>
        /// <param name="cen"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public static Centralita operator +(Centralita cen, Llamada l)
        {
            if (cen != l)
            {
                cen.AgregarLlamada(l);
            }
            return cen;
        }
        #endregion


    }
}
