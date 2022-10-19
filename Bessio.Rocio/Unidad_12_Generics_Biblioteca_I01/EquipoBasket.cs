using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I01
{
    public class EquipoBasket : Equipo //Generar la clase EquipoBasquet que herede de Equipo.
    {
        #region SOBRECARGA DE CONSTRUCTOR PADRE 
        public EquipoBasket (string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {

        }
        #endregion
    }
}
