using System;
using System.Text;
using Unidad_20_MetodosExtension_Biblioteca_I01;

namespace Unidad_20_MetodosExtension_Biblioteca_I01
{
    public static class Extensora
    {
        #region ATRIBUTOS

        #endregion

        #region METODOS DE LA CLASE
        /// <summary>
        /// Crear un método de extensión ObtenerPlacaCronicaTV que extienda DateTime, reciba un argumento de tipo Estaciones y devuelva un string. 
        /// El método debe retornar un texto con la cantidad de días que faltan para la estación indicada empezando a contar desde la fecha almacenada en
        /// la instancia de DateTime que llama al método.
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ObtenerPlacaCronica(this DateTime dateTime,Estaciones estaciones)
        {
            StringBuilder sb = new StringBuilder();
            DateTime dateTime1 = new DateTime().Date;
            DateTime diasRestantes = new DateTime();
            diasRestantes = dateTime - dateTime1;

            return sb.ToString();
        }
        
        #endregion


    }
}
