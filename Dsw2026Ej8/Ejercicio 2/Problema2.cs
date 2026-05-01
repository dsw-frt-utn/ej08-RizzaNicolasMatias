using System;

namespace EJ08_RizzaNicolasMatias.Problema2
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, decimal unitPrice, int quantity)
        {
            decimal total = unitPrice * quantity;

            return $"Resumen de Venta:\n" +
                   $"Producto: [{productCode}] {productDescription}\n" +
                   $"Precio Unitario: {unitPrice:C}\n" +
                   $"Cantidad: {quantity}\n" +
                   $"Total: {total:C}";
        }
    }
}