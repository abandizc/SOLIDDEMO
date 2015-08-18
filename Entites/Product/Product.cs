using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Product
{
    public class Product
    {
        public int ID { get; set; }

        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public int ProductType { get; set; }

        public virtual int Price()
        {
            return 100;
        }

        public virtual string Buy()
        {
            return string.Format("Bought Base Class");
        }

    }
}
