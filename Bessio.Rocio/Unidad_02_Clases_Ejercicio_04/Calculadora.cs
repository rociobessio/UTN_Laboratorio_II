using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Clases_Ejercicio_04
{
    class Calculadora
    {
        /// <summary>
        /// REALIZA EL CALCULO DE LA OPERACION SELECCIONADA
        /// Y RETORNA EL VALOR
        /// </summary>
        /// <param name="primerNumero">RECIBE EL PRIMER NUMERO</param>
        /// <param name="segundoNumero">RECIBE EL SEGUNDO NUMERO</param>
        /// <param name="operacion">RECIBE LA OPERACION MATEMATICA</param>
        /// <returns>DEVUELEVE EL RESULTADO DE LA OPERACION</returns>
        public static int Calcular(int primerNumero, int segundoNumero, char operacion)
        {
            int retorno = 0;
            bool esOperando;

            switch (operacion)
            {
                case '+':
                    retorno = primerNumero + segundoNumero;
                    break;
                case '-':
                    //PODRIA VALIDARSE QUE NUM2 NO SEA MAYOR QUE NUM1
                    retorno = primerNumero - segundoNumero;
                    break;
                case '*':
                    retorno = primerNumero * segundoNumero;
                    break;
                case '/':
                    esOperando = Calculadora.Validar(segundoNumero);
                    if (esOperando == true)
                    {
                        retorno = primerNumero / segundoNumero;
                    }
                    else
                    {
                        retorno = 0;
                    }
                    break;
            }

            return retorno;
        }

        private static bool Validar(int segundoOperando)
        {
            bool esOperando = false;

            if (segundoOperando != 0)
            {
                esOperando = true;
            }
            return esOperando;
        }



    }
}
