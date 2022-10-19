using System;

namespace Interfaces.Ejemplo
{
    public interface IVendible
    {
        double Cantidad { get; set; }
        double Precio { get; set; }
        double Vender();
    }
}