using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                          ESTADISTICA DEPORTIVA
 *                       --------------------------
 *                       UNIDAD 06 - COLECCIONES
 *                       
 * La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
   La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún en el 
   equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
 * 
 */
namespace MiBiblioteca
{
    public class Equipo
    {
        #region ATRIBUTOS
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region METODOS

        #region CONSTRUCTORES
        private Equipo()
        {
            this.cantidadDeJugadores = 0;
            this.jugadores = new List<Jugador>();
            this.nombre = "";
        }

        public Equipo(short cantidad,string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        #endregion

        public static bool operator +(Equipo e,Jugador j)
        {
            bool estaONo = false;
            //Agrega a la lista siiempre y cuando NO este YA en el equipo y se pueda seguir agregandp
            if (e.jugadores.Count < e.cantidadDeJugadores )
            {
                foreach (Jugador objJugador in e.jugadores)//Busco del tipo Jugador dentro de la lista de jugadores
                {
                    if (objJugador == j)//Me fijo que no este en la lista cpn la sobrecarga del == Jugador
                    {
                        estaONo = false;
                    }
                }
                e.jugadores.Add(j);
                estaONo = true;
            }
            else
            {
                estaONo = false;
            }
            return estaONo;
        }

        #endregion



    }
}
