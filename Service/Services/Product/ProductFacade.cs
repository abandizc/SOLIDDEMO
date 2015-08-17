using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Product
{
    public class ProductFacade
    {
        private readonly IProductService _productService;
        private readonly IProductStructure _productStructure;

        public ProductFacade(IProductService productService, IProductStructure productStructure)
        {
            _productService = productService;
            _productStructure = productStructure;
        }

        public void Add(Entites.Product.Product product)
        {
            _productService.Add(product);
        }

        public int CalculateTotal(Entites.Product.Product[] products)
        {
           return _productService.CalculateTax(products);
        }

        public bool UpdateAll(Entites.Product.Product[] products)
        {
           return _productService.UpdateAll(products);
        }

    }
}
