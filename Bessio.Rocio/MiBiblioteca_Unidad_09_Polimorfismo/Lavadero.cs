using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca_Unidad_09_Polimorfismo
{
    public enum EVehiculo { Moto,Auto,Camion}

    public class Lavadero
    {

        #region ATRIBUTOS
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        #endregion

        #region CONSTRUCTORES
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto,float precioCamion,float precioMoto) : this()
        {
            this.precioMoto = precioMoto;
            this.precioCamion = precioCamion;
            this.precioAuto = precioAuto;
        }

        #endregion

        #region PROPIEDADES
        public string Detalle { get { return this.Mostrar(); } }

        public List<Vehiculo> Vehiculos { get { return this.vehiculos; } }
        #endregion


        #region METODOS
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nPRECIO AUTOS: {this.precioAuto}\nPRECIO CAMION: {this.precioCamion}\nPRECIO MOTO: {this.precioMoto}");
            sb.AppendLine("         VEHICULOS");
            foreach (Vehiculo item in this.vehiculos)
            {
                if (item is Auto auto)
                {
                    sb.AppendLine(auto.MostrarAuto());
                }
                if (item is Moto moto)
                {
                    sb.AppendLine(moto.MostrarMoto());
                }
                if (item is Camion camion)
                {
                    sb.AppendLine(camion.MostrarCamion());
                }
               // sb.AppendLine(vehiculos.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// MostrarTotalFacturado: devolverá la ganancia total del lavadero (Double), dicho método tendrá
        /// una sobrecarga que reciba como parámetro la enumeración EVehiculos(con Auto, Camión y Moto 
        /// como enumerados) y retornará la ganancia del Lavadero por tipo de vehículo
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public double MostrarTotalFacturado(EVehiculo v)
        {
            double valor = 0;
            int contador = 0;
            foreach (Vehiculo item in this.vehiculos)
            {
                if (v == EVehiculo.Auto && (item is (Auto)))
                {
                    contador++;
                    valor = this.precioAuto * contador;
                }
                else if (v == EVehiculo.Camion && (item is (Camion)))
                {
                    contador++;
                    valor = this.precioCamion * contador;
                }
                else if (v == EVehiculo.Moto && (item is (Moto)))
                {
                    contador++;
                    valor = this.precioMoto * contador;

                }
            }
            return valor;
        }
        #endregion

        #region SOBRECARGA

        /// <summary>
        /// Sobrecarga == entre un lavadero y un vehículo, retornara TRUE,
        /// si el vehículo se encuentra en el lavadero
        /// </summary>
        /// <param name="lav"></param>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static bool operator == (Lavadero lav,Vehiculo vec)
        {
            bool estaONo = false;
            foreach (Vehiculo item in lav.Vehiculos)
            {
                if (vec == item)
                {
                    estaONo = true;
                    break;
                }
            }
            return estaONo;
        }

        public static bool operator !=(Lavadero lav, Vehiculo vec)
        {
            return !(lav == vec);
        }

        /// <summary>
        /// Sobrecarga del operador +, que agregara un vehículo siempre y cuando el vehículo no se 
        /// encuentre en el lavadero.Ej.miLavadero += unAuto;
        /// </summary>
        /// <param name="lav"></param>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static Lavadero operator + (Lavadero lav,Vehiculo vec)
        {
            if (!(lav == vec))
            {
                lav.Vehiculos.Add(vec);
            }
            return lav;
        }

        /// <summary>
        /// Sobrecarga del operador -, que quitara al vehiculo del lavadero, siempre y cuando este 
        /// dicho vehiculo. Ej. miLavadero -= unaMoto;
        /// </summary>
        /// <param name="lav"></param>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static Lavadero operator -(Lavadero lav,Vehiculo vec)
        {
            if (lav == vec)
            {
                lav.Vehiculos.Remove(vec);
            }
            return lav;
        }

        /// <summary>
        /// Generar un método estático (OrdenarVehiculosPorPatente : int) que reciba dos vehículos y 
        /// retorne un 0 (cero), si ambas patentes son iguales, si la primera patente es ‘mayor’ que la 
        /// segunda, retornará un 1 (uno) y si no, retornará un -1 (menos uno)
        /// </summary>
        /// <param name="vehiculo1"></param>
        /// <param name="vehiculo2"></param>
        /// <returns></returns>
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1,Vehiculo vehiculo2)
        {
            return String.Compare(vehiculo1.Patente,vehiculo2.Patente);
        }

        /// <summary>
        ///Generar un método de instancia (OrdenarVehiculosPorMarca : int) que reciba dos vehículos 
        ///retorne un 0 (cero), si ambas marcas son iguales, si la primera marca es ‘mayor’ que la 
        ///segunda, retornará un 1 (uno) y si no, retornará un -1 (menos uno).
        /// </summary>
        /// <param name="vehiculo1"></param>
        /// <param name="vehiculo2"></param>
        /// <returns></returns>
        public static int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            //return String.Compare(vehiculo1.Marca.ToString(), vehiculo2.Marca.ToString());
            return (vehiculo1.Marca.CompareTo(vehiculo2.Marca));//Es lo mismo de lo de arriba
        }
        #endregion
    }
}
