using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                             INVENTO ARGENTINO
 *                      ------------------------------
 *                      UNIDAD 03 - CLASES - EJER. I04
 * 
 */



namespace MiBiblioteca
{
    public class Boligrafo
    {
        #region ATRIBUTOS

        private ConsoleColor color;
        private short tinta;
        public const short cantidadTintaMaxima = 100;

        #endregion

        #region CONSTRUCTOR

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.color = color;
            //this.tinta = tinta;
            this.SetTinta(tinta);
        }

        #endregion

        #region GETTERS
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }
        #endregion
        #region SETTER

        private void SetTinta(short tinta)
        {
            int resultado;

            if(tinta <= 0)//Si lo que llega es negativo hay que sacar la tinta
            {
                short aResto = Convert.ToInt16(tinta * -1);
                resultado = this.tinta - aResto;
                if(resultado >= 0 && resultado < cantidadTintaMaxima)
                {
                    this.tinta -= aResto;
                }
            }
            else//Si llega positivo cargo la tinta
            {
                this.tinta = tinta;
                /*
                resultado = this.tinta + tinta;
                if(resultado >=0 && resultado <= cantidadTintaMaxima)
                {
                    this.tinta += tinta;
                }
                */
            }
        }

        #endregion
        
        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = true;
            dibujo = "";

            if(this.tinta <=0)//Si NO tiene tinta, devulve fañse
            {
                retorno = false;
            }
            else
            {
                if(gasto <= this.tinta)
                {
                    this.SetTinta(Convert.ToInt16(gasto*-1));
 
                    for(int i = 0;i<gasto;i++)
                    {
                        dibujo += '*';
                    }
                }
                else//Si quiere gastar mas de la tinta que hay, gasta lo que queda
                {
                    for(int i = 0;i < this.tinta;i++)
                    {
                        dibujo += '*';
                    }
                    this.SetTinta(Convert.ToInt16(this.tinta * -1));
                }
            }
            return retorno;
        }
    }
}
