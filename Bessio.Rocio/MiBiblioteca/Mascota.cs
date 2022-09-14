using System;

namespace MiBiblioteca
{
    public class Mascota
    {

        #region Atributos
        public string nombre;
        public int edad;
        #endregion

        #region Constructor
        public Mascota(string n, int e)
        {
            this.nombre = n;
            this.edad = e;
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Mascota m,Mascota m2)
        {
            bool resp = false;

            if(m.nombre==m2.nombre & m.edad==m2.edad)
            resp = true;
            
            return resp;
        }

        public static bool operator !=(Mascota m, Mascota m2)
        {
            return !(m == m2);
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return "MASCOTA-> " + this.nombre + " " + this.edad + " años";
        }
        #endregion


    }
}
