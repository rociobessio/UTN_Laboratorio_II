using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *                  ¿CONSULTASTE EL INDICE?
 *               -------------------------------
 *                 UNIDAD 07 - ENCAPSULAMIENTO 
 *                       EJERCICIO I02
    CONSIGNA:
 -------------
               - El descriptor de acceso get del indexador leerá la página pedida, siempre y cuando
                el subíndice se encuentre dentro de un rango correcto, sino retornará un string vacío.

               - En el set, si la página existe (existe ese índice) le asignará el texto. Si no 
                 existe (si el índice es superior al máximo existente), agregará una nueva página.

               - Crear un proyecto de consola y probar la clase en el método Main.
 */

namespace MiBiblioteca
{
    public class Libro
    {
        #region ATRIBUTOS
        private List<string> paginas;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// El DESCRIPTOR DE ACCESO get del indexador leera la pagina pedida,siempre y cuando el 
        /// subindice se encuentre dentro de un rango correcto, si no retorna un string vacio.
        /// En el set, si la pagina existe (existe ese indice) le asignara en el texto. Si no existe
        /// (si el indice es superior al maximo existente), agregara una nueva pagina.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {//Verifico que el subindice se encuentre en un rango correcto, si no retorna un string vacio
                if (index < 0 || index > this.paginas.Count)
                {
                    return "Pagina Invalida";
                }
                return paginas[index];
            }
            set
            {
                if (index>this.paginas.Count)//Si el indice de pagina existe le asigno texto
                {
                    this.paginas.Add(value);             
                }
                //Si no existe  (si el indice es superior al maximo existente), agregara una nueva pagina
                else if (index>=0)
                {//Con el Metodo Insert agrego una nueva pagina en el indice
                    this.paginas.Insert(index,value);
                }
            }
        }
        #endregion

        #region CONSTRUCTOR
        public Libro()
        {
            this.paginas = new List<string>();
        }

        #endregion

    }
}
