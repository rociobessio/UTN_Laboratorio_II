using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                              VIENEN CON UN SISTEMA DE AUTO NAVEGACION
 *                          ------------------------------------------------
 *                              UNIDAD 03 - CLASES - EJER. I02
 * 
 * 
 * 
 */



namespace MiBiblioteca
{
    public class Conductores
    {
        #region ATRIBUTOS
        public string nombre;
        public int[] kilometros;
        public int dia;
        #endregion

        #region METODOS

        #region CONSTRUCTOR
        public Conductores(string nombre,int[] kilometros,int dias)
        {
            this.nombre = nombre;
            this.dia = dias;
            this.kilometros = kilometros;
        }
        #endregion

        #region SETTERS

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetKilometros(int[] kilometros)
        {
            this.kilometros = kilometros;
        }

        public void SetDias(int dias)
        {
            this.dia = dias;
        }
        #endregion

        #region  GETTERS

        public string GetNombre()
        {
            return this.nombre;
        }

        public int[] GetKilometros()
        {
            return this.kilometros;
        }

        public int GetDias()
        {
            return this.dia;
        }

        #endregion

        public string Recorrido()
        {
            StringBuilder sb = new StringBuilder();

            int []kilometros = this.GetKilometros();
            int dias = this.GetDias();
            for(int i = 1;i<=dias;i++)
            {
                sb.AppendLine($"\nDIA {i}: {kilometros[i]} kms.");
            }

            return sb.ToString();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string mostrarDias = this.Mostrar();

            sb.AppendLine($"\nNOMBRE DEL CONDUCTOR: {this.nombre}\n\nKILOMETROS RECORRIDOS POR CADA DIA DE LA SEMANA: {mostrarDias}");

            return sb.ToString();
        }



        #endregion



    }
}
