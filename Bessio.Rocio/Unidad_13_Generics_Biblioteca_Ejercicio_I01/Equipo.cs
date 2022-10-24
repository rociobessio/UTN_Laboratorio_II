using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_Ejercicio_I01
{
    public abstract class Equipo
    {
        #region ATRIBUTOS
        protected string nombre;
        protected DateTime fechaCreacion;
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// La sobrecarga del operador ==, dos equipos seran iguales si son coincidentes sus nombres
        /// y fecha de creacion
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e1,Equipo e2)
        {
            bool sonIguales = false;

            if (e1 is not null && e2 is not null)
            {
                sonIguales = e1.nombre == e2.nombre &&  e1.fechaCreacion == e2.fechaCreacion;
            }
            return sonIguales;
        }

        public static bool operator !=(Equipo e1,Equipo e2)
        {
            return !(e1 == e2);
        }
        #endregion

        #region METODOS
        /// <summary>
        /// El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente
        /// formato: [EQUIPO] fundado el[FECHA]
        /// </summary>
        /// <returns></returns>
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion.ToString()}");
            return sb.ToString();
        }
        #endregion

    }

}
