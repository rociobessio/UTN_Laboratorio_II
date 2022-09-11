using System;

namespace Unidad_03_POO_Explicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            //USO DE LA BIBLIOTECA;Nombre>Clase>atributo/metodo.
            //si arriba de todo pongo using MiBiblioteca ya puedo dejar de usarlo en los ej de abajo
            MiBiblioteca.Class1.atributo = true;

            MiBiblioteca.Class1 objLib = new MiBiblioteca.Class1();
            objLib.otro_atributo = 4;

            //Asigno valores para inicializar un objeto
            double miValor = MiClase.doble;
            //Constructor por defecto, algo que inicialice los objetos.

            //-----------------------------------------------------------
            //ACCEDER A METODO ESTATICO
            MiClase.doble = 5.66; //Puedo asignar valores desde main

            MiClase.MetodoDeClase(); //Llamo al metodo

            //Los metodos de INSTANCIO-NO estaticos, NO PUEDO ACCEDERLOS

            //CREO UN Variable del tipo MiClase
            MiClase obj = new MiClase();//new: reserva memoria en el HEAP para alojar los valores del objeto
            //Puedo usar todos los atributos y/o metodos de la clase MiClase
            obj.cadena = "algo";
            obj.entero = 5;

            obj.MetodoDeInstancia();

            //Creo otro objeto y lo inicializo
            //EL CONSRUCTOR SE USA AL PRINCIPIO DE VIDA DE UN OBJETO
            MiClase obj2 = new MiClase(12, "chau");

            obj2.cadena = "DASDSDAS";

            //Hasta aca doble vale 5.66 y es ESTATICO por eso accedo por MiClase.
            MiClase.doble = 888;
            obj.MetodoDeInstancia();


        }
    }
}
