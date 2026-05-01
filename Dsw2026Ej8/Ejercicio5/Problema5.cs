using System;

namespace EJ08_RizzaNicolasMatias.Problema5
{   
    public class Sale
    {
        public decimal Amount { get; set; } 
        public virtual decimal CalculateTotal()
        {
            return Amount;
        }
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount;
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount * 0.90m;
        }
    }

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}