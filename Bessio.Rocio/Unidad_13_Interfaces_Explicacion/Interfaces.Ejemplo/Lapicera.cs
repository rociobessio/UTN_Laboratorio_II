using System;

namespace Interfaces.Ejemplo
{
    public class Lapicera : IVendible
    {
        public string trazo;

        public Lapicera(string trazo)
        {
            this.trazo = trazo;
        }

        public override string ToString()
        {
            return this.trazo;
        }

        #region IVendible

        public double Cantidad
        {
            get;
            set;
        }

        public double Precio
        {
            get;
            set;
        }

        public double Vender()
        {
            return (this.Precio * this.Cantidad) * 0.9;
        }

        #endregion

    }
}