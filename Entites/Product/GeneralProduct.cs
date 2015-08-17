using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Product
{
    public class GeneralProduct:Product
    {
        public override int Price()
        {
            return 3 * base.Price();
        }

        public override string Buy()
        {
            return base.Buy();
        }
    }
}
