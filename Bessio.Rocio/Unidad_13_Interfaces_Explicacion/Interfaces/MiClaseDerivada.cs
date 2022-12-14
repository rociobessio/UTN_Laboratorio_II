using System;

namespace Interfaces
{
    public class MiClaseDerivada : MiClase, IMiOtraInterface
    {
        public string atributoDerivado;

        public MiClaseDerivada(string atributo, string atributoDerivado) 
            : base(atributo)
        {
            this.atributoDerivado = atributoDerivado;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.atributoDerivado;
        }

        public void OtroMetodo()
        {
            Console.WriteLine("...implementar...");
        }

        public override void MetodoSinRetornoNiParametros()
        {
            base.MetodoSinRetornoNiParametros();
        }
    }
}