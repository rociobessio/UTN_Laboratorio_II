using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I01
{
    public class Torneo<T> //Crear clase Torneo con tipo GENERICO <T>
       where T : Equipo //Restringo el tipo de dato A Equipo, es decir, la clase solo podra ser de Equipo
    {
        /// <summary>
        /// Tendrá un atributo equipos de tipo List<T> y otro nombre de tipo string.
        /// </summary>
        #region ATRIBUTOS
        protected List<T> equipos;
        protected string nombre;
        #endregion

        #region CONSTRUCTOR
        public Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        /// <summary>
        /// Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator ==(Torneo<T> torneo,T equipo)
        {
            bool estaInscripto = false;
            if (torneo is not null && equipo is not null)
            {
                foreach (T item in torneo.equipos)//Busco si item (del tipo generico pero restringido a equipo) esta en la lista del equipo
                {
                    if (item == equipo)
                    {
                        estaInscripto = true;
                    }
                }
            }
            return estaInscripto;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            bool agregado = false;
            if (torneo is not null && equipo is not null && torneo != equipo)//Si torneo es distinto a equipo, y los parametros no son nulos...
            {
                torneo.equipos.Add(equipo);
                agregado = true;
            }
            return agregado;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método Mostrar retornará los datos del torneo y de los equipos participantes.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            foreach (T item in equipos)
            {
                sb.AppendLine($"Equipo: {item.Ficha()}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// El método privado CalcularPartido recibirá dos elementos del tipo T, que deberán ser del tipo Equipo o sus herencias, 
        /// y calculará utilizando la clase Random un resultado del partido. Retornará el resultado como un string con el siguiente 
        /// formato donde EQUIPOX es el nombre del equipo y RESULTADOX la cantidad de goles/puntos:
        /// </summary>
        /// <param name="equipo1"></param>
        /// <param name="equipo2"></param>
        /// <returns></returns>
        private string CalcularPartido(T e1, T e2)
        {
            Random rd = new Random();
            return $"{e1.nombre}{rd.Next(0, 10)} - {e2.nombre}{rd.Next(0, 10)}";
        }
        /// <summary>
        /// La propiedad pública JugarPartido tomará dos equipos de la lista al azar y calculará el resultado del 
        /// partido a través del método CalcularPartido.
        /// </summary>
        /// <returns></returns>
        public string JugarPartido
        {
            get
            {
                Random rand = new Random();//Instancio random
                T equipo1;
                T equipo2;
                do
                {
                    equipo1 = equipos[(rand.Next(0,10))];
                    equipo2 = equipos[(rand.Next(0, 10))];
                } while (equipo1 == equipo2);//Mientras los equipos sean iguales...
                return CalcularPartido(equipo1,equipo2);
            }
        }


        #endregion


    }
}
