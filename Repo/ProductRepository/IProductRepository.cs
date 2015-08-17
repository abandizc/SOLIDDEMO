using Entites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(int id);
        void Update(Product product);
        Product Read(int id);
        List<Product> ReadAll();
        bool UpdateAll(List<Entites.Product.Product> newProductList);
    }
}
