using Entites.Product;
using Repo;
using Service.Services;
using Service.Services.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRespository;
        private readonly ITaxCalculator _calculate;
        public ProductService(IProductRepository productRepository, ITaxCalculator calculater)
        {
            _calculate = calculater;
            _productRespository = productRepository;
        }

        public void Add(Product product)
        {
            _productRespository.Add(product);
        }

        public void Delete(int id)
        {
            _productRespository.Delete(id);
        }

        public void Update(Product product)
        {
            _productRespository.Update(product);
        }

        public Product Read(int id)
        {
            return _productRespository.Read(id);
        }

        public List<Product> ReadAll()
        {
            return _productRespository.ReadAll();
        }

        public int CalculateTax(Product[] products)
        {
            int totalprice = 0;
            if (products.Length != 0)
            {
                List<Product> productList = new List<Product>(products);

                foreach (var product in productList)
                {
                    totalprice += _calculate.GetTaxAmount(product);
                }
            }

            return totalprice;
        }


        public bool UpdateAll(Entites.Product.Product[] products)
        {
            int totalTax = 0;
            if(products.Length > 0)
            {
                List<Product> productList = new List<Product>(products);
                totalTax = CalculateTax(products);
                return _productRespository.UpdateAll(productList); 
            }
            return true;
        }

    }
}
