using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad_09_ClaseRepaso_PP;

namespace MIBiblioteca_Unidad_09_ClaseRepaso_PP
{
    public class Perro : Mascota
    {

        #region ATRIBUTOS
        private int edad;
        private bool esAlfa;
        #endregion


        #region METODOS
        #region CONSTRUCTORES
        /// <summary>
        ///  Contará con un constructor con dos sobrecargas, en caso de no recibir edad ni esAlfa, 
        ///  deberán inicializarlos como 0 (cero) y false respectivamente.Reutilizar código.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="raza"></param>
        public Perro(string nombre, string raza) : this(nombre,raza,0,false) {}

        public Perro(string nombre, string raza,int edad,bool esAlfa) : base(nombre, raza) 
        { 
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Dos Perros serán iguales si comparten nombre, raza y edad.
        /// Reutilizar código.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator == (Perro p1,Perro p2)
        {
            bool esIgual = false;
            if (p1 is not null && p2 is not null)
            {
                esIgual = ((p1 == ((Mascota)p2)) && p1.edad == p2.edad);
            }
            return esIgual;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Conversión explicita de Perro a entero, retornando su edad
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator int(Perro p)
        {
            return p.edad;
        }

        #endregion

        #region POLIMORFISMO

        //Implementar el método Ficha(). Retornará toda la información del Perro con el siguiente formato:
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.DatosCompletos());
            if (this.esAlfa)//Compara por true por defecto
            {
                sb.AppendLine($"{this.Raza} - {this.Nombre} - es alfa de la manada - {this.edad}");
            }
            else
            {
                sb.AppendLine($"{this.Raza} - {this.Nombre} - {this.edad}");
            }
            return sb.ToString();
        }


        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Perro)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Perro)obj);
            }
            return esNull;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #endregion


    }

}
