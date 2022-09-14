using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Veterinaria
    {
        #region Atributos
        public int capacidad;
        public List<Mascota> lista;
        #endregion

        #region Constructores
        public Veterinaria()
        {
            this.lista = new List<Mascota>();
            this.capacidad = 4;
        }

        public Veterinaria(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        #endregion

        #region Métodos
        public bool buscarMascota(Mascota m)
        {
            bool esta = false;
            foreach (Mascota item in this.lista)
            {
                if (item == m)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        public bool Agregar(Mascota m)
        {
            bool agrega = false;
            if (this.lista.Count < this.capacidad)
            {
                if (!this.buscarMascota(m))
                {
                    this.lista.Add(m);
                    agrega = true;
                }else
                {
                    Console.WriteLine("Ya se encuentra en la veterinaria\n");
                }
            }
            else
            {
                Console.WriteLine("No hay lugar en la veterinaria!\n");
            }
            return agrega;
        }

        public bool Eliminar(Mascota m)
        {
            bool elimina = false;
            for (int i = 0; i < this.lista.Count; i++)
            {
                if(this.lista[i]==m)
                {
                    this.lista.RemoveAt(i);
                    elimina = true;
                    break;
                }
            }
            return elimina;
        }

        #endregion

     
    }
}
