using System;
/*
 *                                        RECIBO DE SUELDO 
 * CONSIGNA:
            Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años)
            y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

            Se pide calcular el importe a cobrar teniendo en cuenta que el total 
            (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
            hay que sumarle la cantidad de años trabajados multiplicados por $150,
            y al total de todas esas operaciones restarle el 13% en concepto de descuentos.

            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
            el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.

 * IMPORTANTE:
            Utilizar sentencias de iteración y selectivas.
                    
                                    -------------------------------
                                       /////    SI ANDA    \\\\\
                                    -------------------------------
 */
namespace Unidad_01_Metodos_Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            string nombreEmpleado;
            int antiguedad;
            float valorHora;
            int cantidadEmpleados = 0;

            int opcion = 0;

            //CALCULOS
            float totalImporte = 0;
            float valorFinal = 0;
            float valorDescuento = 0;
            string mostrarInformacion = "";

            while (opcion != 2)
            {
                Console.WriteLine("             MINI EMPRESITA CORP.");
                Console.WriteLine("------------------------------------------------");
                //Que por cada vuelta de empleado me reincie los valores
                hora = 0;
                antiguedad = 0;
                valorHora = 0;
                totalImporte = 0;
                valorFinal = 0;
                valorDescuento = 0;

                // Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años)
                //y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

                Console.WriteLine("INGRESA EL NOMBRE DEL EMPLEADO: ");
                nombreEmpleado = Console.ReadLine();

                Console.WriteLine("\nINGRESA EL VALOR POR HORA DEL EMPLEADO: ");
                while (!(float.TryParse(Console.ReadLine(), out valorHora)) || (valorHora < 1))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 1]: ");
                }

                Console.WriteLine("INGRESA EL VALOR DE ANTIGUEDAD DEL EMPLEADO: ");
                while (!(int.TryParse(Console.ReadLine(), out antiguedad)) || (antiguedad < 1))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 1]: ");
                }

                Console.WriteLine("INGRESA EL VALOR DE HORAS TRABAJADAS DEL EMPLEADO: ");
                while (!(int.TryParse(Console.ReadLine(), out hora)) || (hora < 1))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE VALOR MAYOR A 1]: ");
                }

                //CUENTAS:
                totalImporte = valorHora * hora; //TOTAL DE IMPORTE A COBRAR
                totalImporte = antiguedad * 150;

                //SE DEBE DE HACER UN DESCUENTO
                valorDescuento = totalImporte - (totalImporte * 13);
                valorFinal = totalImporte - valorDescuento;

                //UNA VEZ HECHA LA CUENTA Y PEDIDA LA INFORMACION SE DEBE DE MOSTRAR A TODOS LOS EMPLEADOS..how if not with vectores/arrays
                mostrarInformacion = mostrarInformacion + "\nNOMBRE EMPLEADO: " + nombreEmpleado + "\nANTIGUEDAD: " + antiguedad + "\nVALOR HORA: " + valorHora + "\nTOTAL A COBRAR: $" + valorFinal + "\nTOTAL NETO: $" + valorDescuento + "\n-----------------------------------------------------------------------";

                cantidadEmpleados++;

                //Al finalizar, preguntar al usuario si desea volver a operar. 
                Console.WriteLine("\n¿DESEA SEGUIR INGRESANDO EMPLEADOS?\n1.SI\n2.NO");
                while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }

                //LIMPIO LA CONSOLA POR CADA VUELTA
                Console.Clear();
            }
            //IMPRIMO TODA LA INFO DE LOS EMPLEADOS ACUMULADOS DENTRO DE UNA MISMA STRING
            Console.WriteLine(mostrarInformacion);
        }
    }
}
