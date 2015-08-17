using Entites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repo.ProductRepository
{
    public class ProductRepository:IProductRepository
    {
        public static List<Product> productList;

        public ProductRepository()
        {
            productList = new List<Product>();
        }

        public void Add(Entites.Product.Product product)
        {
            productList.Add(product);
        }

        public void Delete(int id)
        {
            if(productList != null && productList.Count>0)
            {
                Product product = productList.Find(pList => pList.ID == id);
                productList.Remove(product);
            }
        }

        public void Update(Entites.Product.Product product)
        {
            if(product != null)
            {
                Delete(product.ID);
                Add(product);
            }
        }

        public Entites.Product.Product Read(int id)
        {
            if (productList != null && productList.Count > 0)
            {
                return productList.Find(pList => pList.ID == id);
            }
            else
            {
                return null;
            }
        }


        public List<Product> ReadAll()
        {
            return productList;
        }

        public bool UpdateAll(List<Entites.Product.Product> newProductList)
        {
            if (newProductList != null)
            {
                productList = newProductList;
                return true;
            }
            return false;
        }
    }
}
