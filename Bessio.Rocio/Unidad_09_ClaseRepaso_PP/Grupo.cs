using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIBiblioteca_Unidad_09_ClaseRepaso_PP;
using Unidad_09_ClaseRepaso_PP;

namespace MIBiblioteca_Unidad_09_ClaseRepaso_PP
{
    public enum ETipoManada { Unica,Mixta}

    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;

        public ETipoManada Tipo { set { Grupo.tipo = value; } }

        static Grupo()
        {
            Grupo.tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }

        /// <summary>
        /// Un Grupo será igual a una Mascota si esta última forma parte de la lista.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Grupo g, Mascota m)
        {
            return g.manada.Contains(m);
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        /// <summary>
        ///  Si una mascota no forma parte de la lista, se podrá agregar con el +.
        /// Informar caso contrario.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
            {
                g.manada.Add(m);
            }
            else
                Console.WriteLine($"Ya esta '{m.ToString()}' en el grupo");

            return g;
        }

        /// <summary>
        /// Si una mascota forma parte de la lista, se podrá quitar con el 
        /// Informar caso contrario.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
            }
            else
                Console.WriteLine($"No esta '{m.ToString()}' en el grupo");

            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Grupo:{g.nombre} - tipo:{Grupo.tipo}");
            texto.AppendLine($"Integrantes:({g.manada.Count})");
            foreach (Mascota item in g.manada)
            {
                texto.AppendLine($"{item.ToString()}");
            }

            return texto.ToString();
        }



    }
}
