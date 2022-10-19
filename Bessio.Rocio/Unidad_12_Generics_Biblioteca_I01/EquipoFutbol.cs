using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_12_Generics_Biblioteca_I01
{
    public class EquipoFutbol : Equipo //Generar la clase EquipoFutbol que herede de Equipo.
    {
        #region SOBRECARGA DE CONSTRUCTOR PADRE
        public EquipoFutbol(string nombre,DateTime fechaCreacion) : base(nombre,fechaCreacion)
        {

        }
        #endregion
    }
}
