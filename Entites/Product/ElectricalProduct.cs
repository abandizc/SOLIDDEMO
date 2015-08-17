using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Product
{
    public class ElectricalProduct : Product
    {
        public override int Price()
        {
            return 2 * base.Price();
        }
    }
}
