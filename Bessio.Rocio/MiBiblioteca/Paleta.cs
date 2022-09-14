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

        #region CONSTRUCTOR
        /// <summary>
        /// Inicializa las temperas
        /// </summary>
        private Paleta()
        {
            this.temperas = new List<Tempera>();
           // this.cantidadMaximaColores = 0;
        }
        /// <summary>
        /// CantidadMaxima de colores
        /// </summary>
        /// <param name="cantidadMaximaColores"></param>
        private Paleta(int cantidadMaximaColores): this()
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        public static implicit operator Paleta(int cant)
        {
            return new Paleta(cant); //???
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        #region OPERADORES BOOLEANOS
        public static bool operator ==(Paleta p, Tempera t)
        {
            bool esta = false;

            int retorno = p.obtenerIndice(t);//Si retorna +0 quiere decir que esta en la Lista
            if(retorno >-1)
            {
                esta = true;
            }
            return esta;
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
            int retorno = p.obtenerIndice(t);
            if (retorno>-1)
            {
                //Como incremento la cantidad de la tempera
               

            }
            else
            {
                if(p.temperas.Count < p.cantidadMaximaColores)//siempre y cuando, no supere la cantidad maxima de colores
                {
                    p.temperas.Add(t);//agrega la tempera a la paleta
                }
            }

            /*    //Otra forma de hacerlo
                if (p.temperas.Count < p.cantidadMaximaColores)
                {
                    if (p.obtenerIndice(t)>-1)
                    {
                        //incremento la tinta
                    }
                    else
                    {
                        p.temperas.Add(t);//agrega la tempera a la paleta
                    }
                }
            */
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
            Paleta p3 = new Paleta();
            
            


        }
        #endregion

        #region OPERADOR -
        public static Paleta operator - (Paleta p,Tempera t)
        {
            int retorno = p.obtenerIndice(t);
            if (retorno > -1)//Si es mayor a 0 quiere decir que esta
            {
              /*    //decremento la tinta
                  if(cantidad<=0)
                  {
                      p.temperas.RemoveAt(retorno);//Elimino el indice de  la tempera dentro de la lista
                  }
                t += -numNeg;
               */
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
            int estaoNo = -1;
            int contador = 0;
            foreach (Tempera temp in this.temperas)//Recorro la lista en busca de la tempera 
            {
                if (temp == t)
                {
                   estaoNo = contador;//Consigo el indice de contador
                }
               contador++;
            }
            return estaoNo;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Temperas: {this.temperas}\nCantidad Maxima Colores: {this.cantidadMaximaColores}");
            return sb.ToString();
        }
        #endregion

    }
}
