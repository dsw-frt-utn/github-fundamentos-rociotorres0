using System;

namespace Problema1
{
    public partial class ProductHelper
    {
        // Método auxiliar para el formato de moneda
        private string FormatearPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}