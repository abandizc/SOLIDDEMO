using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
  
    public interface IProductService
    {
        void Add(Entites.Product.Product product);
        void Delete(int id);
        void Update(Entites.Product.Product product);
        Entites.Product.Product Read(int id);
        List<Entites.Product.Product> ReadAll();
        int CalculateTax(Entites.Product.Product[] products);
        bool UpdateAll(Entites.Product.Product[] products);
    }
}
