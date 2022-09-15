using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                                          ENTIDAD DE LA UNIDAD 06
 *                                       -----------------------------
 *                                            EJERCICIO DE SLACK 
 *                                                  PARTE 03
 *                                                  
 */

namespace MiBiblioteca
{
    public class Paleta
    {
        #region ATRIBUTOS
        private List<Tempera> temperas; //Lista GENERICA de temperas
        private int cantidadMaximaColores;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Inicializa las temperas
        /// </summary>
        private Paleta()
        {
            this.temperas = new List<Tempera>();
            this.cantidadMaximaColores = 0;
        }
        /// <summary>
        /// CantidadMaxima de colores
        /// </summary>
        /// <param name="cantidadMaximaColores"></param>
        private Paleta(int cantidadMaximaColores) : this()
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        public static implicit operator Paleta(int cant)
        {
            return new Paleta(cant);//Casteo cantidad a una nueva Paleta, y me retorna un nuevo objeto de tipo Paleta
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();//Retorna la descripcion de la cadena en formato de cadena porq el metodo es privado
        }

        #region OPERADORES BOOLEANOS
        public static bool operator ==(Paleta p, Tempera t)
        {
            bool esta = false;
            if (p.obtenerIndice(t) > -1)//Si no es negativo quiere decir que esta
            {
                esta = true;
            }
            return esta;
            //return (p.obtenerIndice(t) > -1);
        }

        public static bool operator !=(Paleta p,Tempera t)
        {
            return !(p == t);
        }
        #endregion

        #region OPERADOR +
        /// <summary>
        /// Si la tempera esta en la paleta, incrememnta la cantidad
        /// Si NO esta, agrega la tempera a la paleta, simpere y cuando no supere la cantidad maxima de colores
        /// </summary>
        /// <param name="p"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Paleta operator + (Paleta p,Tempera t)
        {
            int indice = p.obtenerIndice(t);
         
            if (indice > -1)//Se fija si la tempera esta en la paleta
            {
                //Como incremento la cantidad de la tempera
                p.temperas[indice] += t;
            }
            else
            {
                if (p.temperas.Count < p.cantidadMaximaColores)//siempre y cuando, no supere la cantidad maxima de colores
                {
                    p.temperas.Add(t);//agrega la tempera a la paleta
                }
            }
            return p;
        }
        
        /// <summary>
        /// GENERA UNA PALETA CON LOS COLORES DE AMBAS PALETAS,
        /// SI TEMPERAS SON IGUALES -> SUMA LAS CANTIDADES
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            //Sumar dos paletas
            int cantMax = p1.temperas.Count + p2.temperas.Count;
            Paleta p3 = new Paleta(cantMax);

            //Le paso las temperas de una lista a la otra
            p3.temperas = p1.temperas;

            foreach (Tempera tempera in p2.temperas)
            {   //Con el operador +:
                //Busco si existe y acumulo las cantidades
                p3 += tempera;//Reutilizo codigo
            }
            return p3;
        }
        #endregion

        #region OPERADOR -
        public static Paleta operator - (Paleta p,Tempera t)
        {
            int indice = p.obtenerIndice(t);
            if (indice > -1)//Si es mayor a 0 quiere decir que esta
            {
                //decremento la tinta
                p.temperas[indice] += (-t);
                if (p.temperas[indice] < 1)//Por el implicit devuelve la cantidad y compara
                {
                    p.temperas.RemoveAt(indice);//Elimino el indice de  la tempera dentro de la lista
                }
            }

          return p;
        }
        #endregion

        #endregion

        #region METODOS
        /// <summary>
        /// Retorna EL INDICE donde se encuentra la tempera, o valor negativo (-1) si no la encuentra
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private int obtenerIndice(Tempera t)
        {
            int estaoNo = -1;//Si no esta devuelve un negativo
            for (int i = 0; i < this.temperas.Count; i++)//Recorro la lista
            {
                if (t == this.temperas[i])//Busco el objeto
                {
                    estaoNo = i;//Consigo el indice de contador
                    break;//Rompo porque lo encontre
                }
            }
            /*
             * ES LO MISMO: 
            int contador = 0;
            foreach (Tempera temp in this.temperas)//Recorro la lista en busca de la tempera 
            {
                if (temp == t)
                {
                   estaoNo = contador;//Consigo el indice de contador
                }
               contador++;
            }*/
            return estaoNo;//Retorno el indice
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Tempera temp in this.temperas)//Recorro la lista de las temperas en busca de obj Tempera
            {
                sb.AppendLine(Tempera.Mostrar(temp));//Muestro los datos de las temperas
            }
            sb.AppendLine($"Cantidad Maxima Colores: {this.cantidadMaximaColores}");
            return sb.ToString();
        }
        #endregion


        #region PROPIEDADES

        public Tempera this[int index]
        {
            get
            {
                if (index < 0 || index > temperas.Count)
                {
                    return null;
                }
                return temperas[index];
            }
            set
            {
                if (!(index < 0 || index > temperas.Count))
                {
                   temperas[index] = value;//value representa al valor que va a la derecha del igual, en este caso del tipo Tempera
                }
            }
        }

        #endregion
    }
}
