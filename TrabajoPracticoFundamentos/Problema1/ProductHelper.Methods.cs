using System;

namespace Problema1
{
    // Debe ser public y partial
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            // Formato requerido: [code] description - price
            return $"[{code}] {description} - {FormatearPrecio(price)}";
        }
    }
}