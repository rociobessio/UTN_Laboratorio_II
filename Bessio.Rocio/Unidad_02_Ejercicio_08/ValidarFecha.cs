using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_02_Ejercicio_08
{
    class ValidarFecha
    {
        public static int CalcularDiasVividos(int dia, int mes, int anio)
        {
            int diasVividos = 0;
            DateTime fechaActual = DateTime.Now;
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);

            for (int i = fechaActual.Year; i <= fechaNacimiento.Year; i--)
            {
                if ((fechaActual.Year == fechaNacimiento.Year) && (fechaActual.Month == fechaNacimiento.Month) && (fechaActual.Day == fechaNacimiento.Day))
                {
                    break;
                }
                diasVividos++;
            }
            return diasVividos;
        }

    }
}
