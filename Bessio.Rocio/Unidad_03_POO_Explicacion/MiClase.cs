using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_03_POO_Explicacion
{
    class MiClase
    {

        //FORMA CORRECTA DE ESTRUCTURA DE CODIGO
        //1ro ATRIBUTOS
        //2do PROPIEDADES
        //3ro CONSTRUCTORES
        //4to METODOS
        //5to OPERADORES
        //--------------------------------

        //DEFINIR ATRIBUTOS:
        //                 SIEMPRE QUE INICIALICE UN ATRIBUTO ES POR MEDIO DE CONSTRUCTORES
        #region atributos NO ESTATICOS o de INSTANCIA
        //Puedo generar atributos y metodos
        //modificador de visibilidad - tipo de dato - nombre de atributo.
        public string cadena; //Es lo mismo poner String es un alias, string es una clase generica
        public int entero;  //Es lo mismo poner Int32
        #endregion

        #region atributos estaticos o de clase
        //TRIBUTOS ESTATICOS
        //modificador de visibilidad - static - tipo de dato -  nombre
        public static double doble;
        #endregion

        #region Metodo NO estatico o de INSTANCIA
        //METODO DE INSTANCIA O NO ESTATICO porq no tiene STATIC
        public void MetodoDeInstancia()
        {    //{} INDICE DE LO QUE MUESTRO
            string cadena = "aaaa";
            //1 FORMA DE MOSTRAR UN ATRIBUTO: (PERO NO LO VAMOS A USAR SIEMPRE, SOLO AL PRINCIPIO DE CURSADA)
            Console.WriteLine("VALOR CADENA: {0}\nVALOR ENTERO: {1}\nVALOR DOBLE: {2}", cadena, entero, doble);

            //2 FORAMA DE MOSTRAR UN ATRIBUTO this. representa un atributo de MiClase, this. NO SE USA CON ESTATICOS ej doble
            //this. = NO estatico.
            //Clase. = ESTATICO.
            Console.WriteLine("VALOR CADENA: {0}\nVALOR ENTERO: {1}\nVALOR DOBLE: {2}", this.cadena, this.entero, MiClase.doble);
        }
        #endregion

        #region Metodo ESTATICO o de CLASE
        //SEIMPRE QUE UN METODO SEA ESTATICO UNICAMENTE PODRE USAR LOS ATRIBUTOS ESTATICOS
        public static void MetodoDeClase()
        {
            //En este metodo NO puedo utilizar this.
            Console.WriteLine("\nVALOR DOBLE: {0}", MiClase.doble);
        }
        #endregion

        #region CONSTRUCTORES
        #region DE INSTANCIA
        //Metodo que INICIALIZA A LOS ATRIBUTOS, es un CONSTRUCTOR por DEFAULT.
        //modificador de visibilidad - NO lleva retorno y mismo nombre q la CLASE, puede llevar parametros
        //public MiClase()//Si pongo un nombre distinto al de clase, es obligatorio que retorne el constructor
        //{
        //    this.cadena = "valor inicial";
        //    this.entero = 8;
        //    //Puedo hacer MiClase.doble = 7; pero cada vez q inicializo le doy un valor una y otra vez


        //}

        //QUE EL CONSTRUCTOR PARAMETRIZADO INICIALIZADP SEA INDEPENDIENTE
        //NORMALMENTE SE USAN LOS ATRIBUTOS DE LA CLASE
        public MiClase(int entero, string cadena)
        {
            this.cadena = cadena;
            this.entero = entero;
        }
        #endregion

        #region CONSTRUCTOR ESTATICO
        //static - nombre de la clase donde estoy
        //*no pueden tener modificadores de visibilidad y tipo de retorno
        //Se genera una unica vez y es cuando se crea el priimer object
        static MiClase()
        {
            //SOLO PUEDO ACCEDER A LOS ATRIBUTOS ESTATICOS DE LA CLASE:
            MiClase.doble = 7;
        }
        #endregion
        #endregion  






    }
}
