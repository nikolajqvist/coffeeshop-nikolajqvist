using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Blackcoffee:Coffee
    {
        public Blackcoffee():base()
        {
            
        }
        public Blackcoffee(int discount, string blend) : base(discount, blend)
        {
        }

        public override int Price()
        {
            return base.Price();
        }

        public override CoffeeStrength Strength()
        {
            return CoffeeStrength.Strong;
        }
    }
}
