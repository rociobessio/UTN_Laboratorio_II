using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *              UNIDAD 04 EXPLICACION DE SOBRECARGA
 * 
 * 
 * 
 * 
 */

namespace MiBiblioteca
{
    public class Cosa
    {

        #region ATRIBUTOS
        private int entero;
        private string cadena;
        private DateTime fecha;
        #endregion

        #region CONSTRUCTORES

        public Cosa(DateTime fecha, int entero, string cadena) : this(entero, cadena)
        {
            this.fecha = fecha;
        }

        public Cosa(int entero, string cadena) : this(cadena)
        {
            this.entero = entero;
        }

        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
        }

        public Cosa()
        {
            DateTime fecha = DateTime.Now;
            this.fecha = fecha;
            this.cadena = "SIN VALOR";
            this.entero = 10;
        }


        #endregion



        #region ????METODO SOBRECARGA INICIALIZO ENTERO CONSTRUCTORES
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
        #endregion

        //String retorna los valores
        #region METODO MOSTRAR

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ENTERO: {this.entero}");
            sb.AppendLine($"STRING: {this.cadena}");
            sb.AppendLine($"FECHA: {this.fecha}");

            return sb.ToString();
        }

        public static string Mostrar(Cosa cosa)
        {//reutlizacion de codigo..!
            return cosa.Mostrar();
        }

        #endregion




    }
}
