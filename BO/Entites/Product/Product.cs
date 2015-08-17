using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entites
{
    public abstract class Product
    {
        public int id { get; set; }

        public string ProductName { get; set; }

        public int Total();

        public void Buy();

    }
}
