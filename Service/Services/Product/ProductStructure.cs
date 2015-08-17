using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Product
{
    public class ProductStructure:IProductStructure
    {
        private readonly IProductRepository _productRepository;

        public ProductStructure(IProductRepository productRespository)
        {
            _productRepository = productRespository;
        }
        public string GetProductDescription(int id)
        {
            Entites.Product.Product product = _productRepository.Read(id);

            return String.Format("Product ID is {0},Product name is {1},Product Company is {2}",product.ID,product.ProductName,product.CompanyName);
        }
    }
}
