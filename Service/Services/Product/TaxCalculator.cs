using Entites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TaxCalculator : ITaxCalculator
    {
        public int GetTaxAmount(Product product)
        {
            if(product is ElectricalProduct)
            {
                return 100 * product.Price();
            }
            else
            {
                return 50 * product.Price();
            }

        }
    }
}
