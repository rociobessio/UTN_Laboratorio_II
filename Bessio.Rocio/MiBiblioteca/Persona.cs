using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *              ¿VOS CUANTAS PRIMAVERAS TENES?
 *            ----------------------------------
 *              UNIDAD 03 - CLASES - EJER. I02
 */


namespace MiBiblioteca
{
    public class Persona
    {

        #region ATRIBUTOS
        public string nombre;
        public DateTime fechaDeNacimiento;
        public string dni;
        #endregion

        #region CONSTRUCTOR

        public Persona(string nombre,DateTime fechaDeNacimiento,string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        #endregion

        #region METODOS

        #region SETTERS

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaDeNacimiento = fechaNacimiento;
        }

        public void SetDNI(string dni)
        {
            this.dni = dni;
        }
        #endregion

        #region GETTERS
        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetDNI()
        {
            return this.dni;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }
        #endregion

        private int CalcularEdad()
        {
            DateTime fechaPersona = this.GetFechaNacimiento();
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaPersona.Year;
            if (fechaActual < fechaPersona.AddYears(edad)) 
            {
                edad--;
            }
            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string nombrePersona = this.GetNombre();
            string dniPersona = this.GetDNI();
            DateTime fechaPersona = this.GetFechaNacimiento();
            int edadPersona = this.CalcularEdad();
            string esMayor = this.EsMayorDeEdad();

            sb.AppendLine($"\nNOMBRE PERSONA: {nombrePersona}\nDNI: {dniPersona}\nFECHA DE NACIMIENTO: {fechaPersona.ToShortDateString()}\nEDAD ACTUAL: {edadPersona}\nLA PERSONA {esMayor}");

            return sb.ToString();
        }
    
        public string EsMayorDeEdad()
        {
            int edad = this.CalcularEdad();
            string esMayor = "";

            if(edad>=18)
            {
                esMayor = "Es mayor de edad";
            }
            else
            {
                esMayor = "Es menor de edad";
            }

            return esMayor;
        }
        #endregion

    }
}
