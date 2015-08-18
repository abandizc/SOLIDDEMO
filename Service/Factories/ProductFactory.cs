using Entites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Factories
{
    public static class ProductFactory
    {
        public static Product GetProductBasedOnType(Product product)
        {
            if (product.ProductType == 2)
            {
                return GetElectricalProduct(product);
            }
            else
            {
                return GetGeneralProduct(product);
            }
        }

        public static ElectricalProduct GetElectricalProduct(Product product)
        {
            ElectricalProduct electricalProduct = new ElectricalProduct();
            electricalProduct.CompanyName = product.CompanyName;
            electricalProduct.ProductName = product.ProductName;
            electricalProduct.ID = product.ID;
            return electricalProduct;
        }

        public static GeneralProduct GetGeneralProduct(Product product)
        {
            GeneralProduct generalProduct = new GeneralProduct();
            generalProduct.CompanyName = product.CompanyName;
            generalProduct.ProductName = product.ProductName;
            generalProduct.ID = product.ID;
            return generalProduct;
        }
    }
}
