using Entites.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLID1.Factories
{
    public static class ProductIntializer
    {
        public static Product GetInstance(int type)
        {
            switch(type)
            {
                case 1: return new ElectricalProduct();
                default: return new GeneralProduct();
            }
        }
    }
}