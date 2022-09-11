using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_04_SobreCargas_Explicacion
{
    class Vehiculo
    {

        private int puertas;
        private string color;
        private int litrosNafte;
        private string marca;

        #region CONSTRUCTORES
        public Vehiculo(int puertas)
        {
            this.puertas = puertas;
        }

        public Vehiculo(string marca, int puertas) : this(puertas)
        {
            this.marca = marca;
        }

        public Vehiculo(string marca, int puertas, string color) : this(marca, puertas)
        {
            this.color = color;
        }

        public Vehiculo(string marca, int puertas, string color, int litrosNafta) : this(marca, puertas, color)
        {
            this.litrosNafte = litrosNafta;
        }
        #endregion

        #region SETTERS

        //EN VEZ DE CREAR METODOS USO UNA PROPIEDAD:
        public string Color
        {
            set
            {

                if (value != null)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "";
                }
            }
            get
            {
                return $"COLOR: {this.color}";
            }
        }

        public string Marca
        {
            set { this.marca = value; }
            get { return this.marca; }
        }
        public int LitrosNafta
        {
            set { this.litrosNafte = value; }
            get { return this.litrosNafte; }
        }

        public int Puertas
        {
            set { this.puertas = value; }
            get { return this.puertas; }
        }
        #endregion

        #region SOBRECARGA DE METODOS

        //DISTINTAS SOBRECARGAS DE UN MISMO METODO PERO CON DISTINTOS PARAMETROS
        //DEBE DE DEVOLVER EL MISMO TIPO DE DATO
        public string Mostrar(string msj1)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"PUERTAS: {this.puertas}");
            sb.AppendLine(msj1);
            sb.AppendLine($"MARCAS: {this.marca}");
            sb.AppendLine($"LITROS: {this.litrosNafte}");

            return sb.ToString();
        }
        public string Mostrar(string mensaje1, int mensaje2)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"PUERTAS: {this.puertas}");
            sb.AppendLine(mensaje1);
            sb.AppendLine($"MARCAS: {this.marca}");
            sb.AppendLine($"LITROS: {this.litrosNafte}");

            return sb.ToString();
        }

        public string Mostrar(int mensaje2)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"PUERTAS: {this.puertas}");
            sb.AppendLine();
            sb.AppendLine($"MARCAS: {this.marca}");
            sb.AppendLine($"LITROS: {this.litrosNafte}");

            return sb.ToString();
        }

        //PARA DEVOLVER UN VALOR DISTINTO CREO UN NUEVO METODO
        public int Mostrar2(string mensaje1, int mensaje2)
        {
            return 2;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// De visibilidad, SIMEPRE SERA ESTATICO, TIPO DE RETORNO, OPERATOR + (cualquier operador)
        /// Los parametros siempre deben de ser del MISMO TIPO
        /// </summary>
        /// <returns></returns>
        public static int operator +(Vehiculo v1, int num1)
        {
            return v1.litrosNafte + num1;
        }

        public static int operator -(Vehiculo v1, int num1)
        {
            return v1.litrosNafte - num1;
        }

        //Unario 
        public static int operator ++(Vehiculo v1)
        {
            return v1.litrosNafte++;
        }
        public static int operator --(Vehiculo v1)
        {
            return v1.litrosNafte++;
        }
        //Se puede comparar un objeto CLASE y otro tipo de dato
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.marca == v2.marca;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        #endregion

        #region SOBRECARGA EXPLICITA E IMPLICITA
        //Sirve para hacer UN CASTEO IMPLICITO, en este caso de Vehiculo.marca a string
        public static implicit operator string(Vehiculo v1)
        {//Si quiero mostrar 1 o mas de dos atributos puedo hacerlo con el StringBuilder y que retorne el string
            return v1.marca;
        }

        //Hago unn casteo explicito (int), casteo de Vehiculo a int
        public static explicit operator int(Vehiculo v1)
        {
            return v1.litrosNafte;
        }


        #endregion
    }
}
