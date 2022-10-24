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
namespace MiBiblioteca_EnciendanMotores_Unidad_08
{
    public class Competencia<T>
       where T : VehiculoDeCarrera
    {
        #region ATRIBUTOS
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;
        #endregion

        #region PROPIEDADES
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        /// <summary>
        /// INDEXADOR
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public VehiculoDeCarrera this[int i]
        {
            get { if (i < 0 || i > competidores.Count)
                    return null;
                return competidores[i];
            }
        }

        #endregion


        #region METODOS DE LA CLASE

        #region CONSTRUCTORES
        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        #endregion

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"   TIPO DE COMPETENCIA  ");
            sb.AppendLine($"{Tipo}");
            sb.AppendLine($"   COMPETIDORES  ");
            //  sb.AppendLine($"COMPETIDORES:  {this.competidores}");
            if (this.competidores.Count > 0)//Me fijo que haya competidores
            {
                foreach (VehiculoDeCarrera objVec in this.competidores)//Busco que sea del tipo Vehiculo
                {
                    sb.AppendLine(objVec.MostrarDatos());
                    sb.AppendLine($"TIPO VEHICULO: {objVec.GetType()}");
                    sb.AppendLine("-\n");
                }
            }
            else sb.AppendLine("NO HAY VEHICULOS EN COMPETENCIA");
            return sb.ToString();
        }

        #region SOBRECARGA DE OPERADORES
        public static bool operator +(T c, VehiculoDeCarrera a1)
        {
            bool estaONo = false;
            if (c is not null && a1 is not null)
            {
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    /* foreach (AutoF1 objAuto in c.competidores)//Busco que no este en la lista
                     {
                         if (objAuto == a1)
                         {
                             estaONo = false;
                         }
                     }*/
                    //Si no esta...
                    c.competidores.Add(a1);
                    a1.EnCompetencia = true;
                    a1.VueltasRestantes = c.cantidadVueltas;
                    Random r = new Random();//Se asigna aleatorio a cantidadCombustible
                    a1.CantidadCombustible = (short)r.Next(15, 100);
                    estaONo = true;
                }
                else estaONo = false;
            }
            return estaONo;
        }

        public static bool operator -( Competencia c, AutoF1 a1)
        {
            bool estaONo = false;
            if (c is not null && a1 is not null)
            {
                if (c.cantidadCompetidores > c.competidores.Count)
                {
                    foreach (AutoF1 autoF1 in c.competidores)
                    {
                        if (autoF1 == a1)
                        {
                            c.competidores.Remove(autoF1);
                            estaONo = true;
                            break;
                        }
                    }
                }
            }
            return estaONo;
        }

        public static bool operator ==(T c, AutoF1 a1)
        {
            bool estaONo = false;
            if (c is not null && a1 is not null)
            {
                if (c.cantidadCompetidores > c.competidores.Count)
                {
                    foreach (AutoF1 autoF1 in c.competidores)
                    {
                        if (autoF1 == a1)
                        {
                            estaONo = true;
                            break;
                        }
                    }
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
        public enum TipoCompetencia { F1, MotoCross }
    }

}
