using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_Unidad_09_Polimorfismo
{
    public abstract class Vehiculo
    {
        #region ATRIBUTOS
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        #endregion

        #region PROPIEDADES
        public string Patente { get { return this.patente; } }        
        public EMarcas Marca { get{ return this.marca; } }
        #endregion

        #region METODOS

        public Vehiculo(string patente,Byte cantRuedas,EMarcas marca)
        {
            this.patente = patente;
            this.marca = marca;
            this.cantRuedas = cantRuedas;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"PATENTE:{this.patente}\nCANT RUEDAS: {this.cantRuedas}\nMARCA: {this.marca}");
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator  ==(Vehiculo v1,Vehiculo v2)
        {
            bool esNull = false;
            if (v1 is not null && v2 is not null)
            {
                esNull = (v1.patente == v2.patente && v1.marca == v2.marca);
            }
            else if (v1 is null && v2 is null)
                esNull = true;
            return esNull;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion

        #region POLIMORFISMO
        public override bool Equals(object obj)
        {
            bool esNull = false;
            if (obj is Vehiculo)
            {//Comparo si son iguales con el operador de sobrecarga y casteo
                esNull = this == ((Vehiculo)obj);
            }
            return esNull; 
        }

        /// <summary>
        /// GetHashCode compara e identifica dos objetos,
        /// si son iguales deberan de retornar el mismo Hh
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
