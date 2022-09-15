using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                          A CALENTAR MOTORES
 *                   --------------------------------
 *                     UNIDAD 06 - COLECCIONES - C02
 
    Consigna:
    - El constructor privado será el único capaz de inicializar la lista de competidores.
    - La sobrecarga del operador + agregará un competidor si es que aún hay espacio
        (validar con cantidadCompetidores) y el competidor no forma parte de la lista 
        (== entre Competencia y AutoF1).
    - Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, la cantidad de
      vueltasRestantes será igual a la cantidadVueltas de Competencia y se le asignará un número
      aleatorio entre 15 y 100 a cantidadCombustible.                                                  
 */
namespace MiBiblioteca
{
    public class Competencia
    {
        #region ATRIBUTOS
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        #endregion


        #region METODOS DE LA CLASE

        #region CONSTRUCTORES
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas,short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"   COMPETENCIA   ");
          //  sb.AppendLine($"COMPETIDORES:  {this.competidores}");
            foreach (AutoF1 objAuto in this.competidores)
            {
                sb.AppendLine(objAuto.MostrarDatos());
            }
            return sb.ToString();
        }

        #region SOBRECARGA DE OPERADORES
        public static bool operator + (Competencia c, AutoF1 a1)
        {
            bool estaONo = false;
            if (c.competidores.Count < c.cantidadCompetidores)
            {
                foreach (AutoF1 objAuto in c.competidores)//Busco que no este en la lista
                {
                    if (objAuto == a1)
                    {
                        estaONo = false;
                    }
                }
                //Si no esta...
                c.competidores.Add(a1);
                a1.EnCompetencia = true;
                a1.VueltasRestantes = c.cantidadVueltas;
                Random r = new Random();//Se asigna aleatorio a cantidadCombustible
                a1.CantidadCombustible = (short)r.Next(15, 100);
                estaONo = true;
            }
            else estaONo = false;
            return estaONo;
        } 

        public static bool operator - (Competencia c, AutoF1 a1)
        {
            bool estaONo = false;

            return estaONo;
        }

        public static bool operator ==(Competencia c, AutoF1 a1)
        {
            bool estaONo = false;
            foreach (AutoF1 autoF1 in c.competidores)
            {
                if (autoF1 == a1)
                {
                    estaONo = true;
                }
            }
            return estaONo;
        }

        public static bool operator !=(Competencia c, AutoF1 a1)
        {
            bool estaONo = true;
            foreach (AutoF1 autoF1 in c.competidores)
            {
                if (autoF1 == a1)
                {
                    estaONo = false;
                }
            }
            return estaONo;
        }



        #endregion

        #endregion

    }
}
