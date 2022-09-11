using System;

using MiBiblioteca;

namespace Unidad_03_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //HACER STRING CON DATOS DEL TITULAR Y ACUMULARLO
            int opcion = 0;
            int opcionOperacion = 0;//Para que seleccione que tipo de operacion quiere


            Cuenta titular = new Cuenta(" ",0);
            
            float cantidad = 0;
            float plataAux = 0;
            string datosTitular = "";
            string razonTitular = "";

            do
            {
                Console.WriteLine("\n        BIENVENIDO AL BANCO NACION");
                Console.WriteLine("\n--------------------------------------------");

                /*//Le pido los datos PERSONALES al titular (Se podrian validar)
                Console.WriteLine("\nINGRESA EL NOMBRE DEL TITULAR: ");
                datosTitular += Console.ReadLine();

                Console.WriteLine("\nINGRESA EL APELLIDO DEL TITULAR: ");
                datosTitular += Console.ReadLine();
                */
                Console.WriteLine("\nINGRESE EL MONTO TOTAL DE LA CUENTA: ");
                while (!(float.TryParse(Console.ReadLine(), out cantidad)) || (cantidad<0))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE]: ");
                }

                titular.cantidad = cantidad;

                Console.WriteLine("\nLA RAZON DE LA OPERACION: ");
                razonTitular = Console.ReadLine();
                titular.titular = razonTitular;


                Console.WriteLine("\nINGRESE QUE OPERACION BANCARIA DESEA REALIZAR: \n1.ACREDITACION.\n2.EXTRACCION.\nOPCION: ");
                while (!(int.TryParse(Console.ReadLine(), out opcionOperacion)) || (opcionOperacion != 1 && opcionOperacion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }
                Console.Clear();
                switch(opcionOperacion)
                {
                    case 1:
                        Console.WriteLine("\nINGRESA CUANTO QUERES ACREDITAR EN LA CUENTA: ");
                        while (!(float.TryParse(Console.ReadLine(), out plataAux)) || (plataAux < 0))
                        {
                            Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE]: ");
                        }
                        titular.Ingresar(plataAux);
                        datosTitular = titular.Mostrar();

                        Console.Clear();
                        Console.WriteLine("    DATOS DE LA CUENTA: ");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine(datosTitular);
                    break;
                    case 2:
                        Console.WriteLine("\nINGRESA CUANTO QUERES DEBITAR EN LA CUENTA: ");
                        while (!(float.TryParse(Console.ReadLine(), out plataAux)) || (plataAux < 0))
                        {
                            Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE]: ");
                        }

                        titular.Retirar(plataAux);
                        datosTitular = titular.Mostrar();
                        Console.Clear();
                        Console.WriteLine("    DATOS DE LA CUENTA: ");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine(datosTitular);
                        break;
                }
                Console.WriteLine("\nPRESS ANY KEY TO CONTINUE!");
                Console.ReadKey();
                Console.Clear();
                //--------------------------------------------------------
                Console.WriteLine("\n¿DESEA SEGUIR OPERANDO?\n1.SI\n2.NO");
                while (!(int.TryParse(Console.ReadLine(), out opcion)) || (opcion != 1 && opcion != 2))
                {
                    Console.WriteLine("\n\n[VALOR INVALIDO, REINGRESE 1 (si) o 2 (no)]: ");
                }
                Console.Clear();
            } while (opcion !=2);
            
            Console.WriteLine("[APP ENDED!]");
        }
    }
}
