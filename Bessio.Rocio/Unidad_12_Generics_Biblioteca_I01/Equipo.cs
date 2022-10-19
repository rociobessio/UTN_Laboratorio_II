using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I01
{
    public abstract class Equipo
    {
        #region ATRIBUTOS
        public string nombre;
        protected DateTime FechaCreacion;
        #endregion

        #region CONSTRUCTOR
        public Equipo(string nombre,DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.FechaCreacion = fechaCreacion;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e1,Equipo e2)
        {
            bool esIgual = false;
            if (e1 is not null && e2 is not null)
            {
                esIgual = e1.nombre == e2.nombre && e1.FechaCreacion == e2.FechaCreacion;
            }
            return esIgual;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente formato:
        /// [EQUIPO] fundado el[FECHA]
        /// </summary>
        /// <returns></returns>
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} fundado el {this.FechaCreacion.ToString()}");
            return sb.ToString();
        }
        #endregion
    }
}
