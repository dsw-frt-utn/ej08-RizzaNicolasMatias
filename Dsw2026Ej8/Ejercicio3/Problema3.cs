using System;

namespace EJ08_RizzaNicolasMatias.Problema3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;

            copiaValor++;

            Product copiaProducto = product;

            copiaProducto.ModificarDescripcion("Nueva Descripción");
            return $"{originalValue}-{copiaValor}-{copiaProducto.Description}";
        }
    }
}