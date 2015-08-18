using Entites.Product;
using Service.Factories;
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
            Product productType = ProductFactory.GetProductBasedOnType(product);
            if (productType is ElectricalProduct)
            {
                return 100 * product.Price();
            }
            else if(productType is GeneralProduct)
            {
                return 50 * product.Price();
            }
            else
            {
                return product.Price();
            }

        }
    }
}
