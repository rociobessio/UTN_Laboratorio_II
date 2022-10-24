using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_13_Generics_Biblioteca_Ejercicio_I01
{
    /// <summary>
    /// Clase del tipo GENERICO
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Torneo<T>
       where T : Unidad_12_Generics_Biblioteca_Ejercicio_I01.Equipo
    {
        #region ATRIBUTOS DE LA CLASE
        protected List<T> equipos;
        protected string nombre;
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La sobrecarga del operador == controla si un equipo ya esta inscripto en el torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator ==(Torneo<T> torneo,T equipo)
        {
            bool estaONo = false;
            if (torneo is not null & equipo is not null)
            {
                foreach (T item in torneo.equipos)
                {
                    if (item == equipo)
                    {
                        estaONo = true;
                    }
                }
            }
            return estaONo;
        }

        public static bool operator !=(Torneo<T> torneo,T equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// La sobrecarga del operador + agrega un equipo a la lista si no esta en el torneo.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            bool pudoAgregar = false;
            if (torneo is not null && equipo is not null)
            {
               if (torneo != equipo)
               {
                   torneo.equipos.Add(equipo);
                   pudoAgregar = true;
               }
            }
            return pudoAgregar;
        }
        #endregion

        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in equipos)
            {

                sb.AppendLine(item.Ficha());
            }
            sb.ToString();
        }

        /// <summary>
        /// El método privado CalcularPartido recibirá dos elementos del tipo T, que deberán ser del
        /// tipo Equipo o sus herencias, y calculará utilizando la clase Random un resultado del
        /// partido. Retornará el resultado como un string con el siguiente formato donde EQUIPOX es 
        /// el nombre del equipo y RESULTADOX la cantidad de goles/puntos:
        /// [EQUIPO1] [RESULTADO1] – [RESULTADO2] [EQUIPO2]
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        private string CalcularPartido(T e1, T e2)
        {
            Random rd = new Random();
            return $"{e1.nombre}{rd.Next(0, 10)} - {e2.nombre}{rd.Next(0, 10)}";
        }

        /// <summary>
        /// La propiedad pública JugarPartido tomará dos equipos de la lista al azar y calculará el resultado
        /// del partido a través del método CalcularPartido.
        /// </summary>
        public string JugarPartido
        {
            get
            {
                Random rand = new Random();//Instancio random
                T equipo1;
                T equipo2;
                do
                {
                    equipo1 = equipos[(rand.Next(0, 10))];
                    equipo2 = equipos[(rand.Next(0, 10))];
                } while (equipo1 == equipo2);//Mientras los equipos sean iguales...
                return CalcularPartido(equipo1, equipo2);
            }
        }
        #endregion
    }
}
