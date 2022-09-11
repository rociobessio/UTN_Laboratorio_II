using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 *                                      LA ESTANTERIA
 *                                  ---------------------
 *                                       UNIDAD 04
 * CONSIGNA:
 *          1. Todos sus atributos son privados.
            2. Posee sólo un constructor de instancia.
            3. El método GetMarca, retornará el valor correspondiente al atributo marca.
            4. También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través de la conversión 
               explícita nombrada más adelante.
            5. El método de clase (estático) MostrarProducto es público y retornará una cadena detallando 
               los atributos de la clase.
          Posee las siguientes sobrecargas de operadores:
                explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo 
                codigoDeBarras del producto.
                I. == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, 
                   false caso contrario.
                II. == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada 
                    como argumento, false caso contrario.
 */

namespace Unidad_04_Biblioteca_LaEstanteria
{
    public class Producto
    {
        #region ATRIBUTOS
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region CONSTRUCTOR DE INSTANCIA
        public Producto(string marca, string codigo,float precio)
        {
            this.codigoDeBarra = codigo;
            this.precio = precio;
            this.marca = marca;
        }
        #endregion

        #region GETTERS
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }
        #endregion

        #region METODOS
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"LA MARCA DEL PRODUCTO ES: {p.marca}\nEL CODIGO DE BARRA ES: {(string)p}\nPRECIO: {p.precio}");

            return sb.ToString();
        }
        #endregion

        #region SOBRECARGA
        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        #region SOBRECARGA DE OPERADORES BOOLEANOS
        /*    public static bool operator ==(Producto p1, Producto p2)
            {
                return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
            }*/
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p,string marca)
        {
            return p.marca == marca;
        }

        public static bool operator != (Producto p, string marca)
        {
            return !(p == marca);
        }
        #endregion

        #endregion
    }
}
