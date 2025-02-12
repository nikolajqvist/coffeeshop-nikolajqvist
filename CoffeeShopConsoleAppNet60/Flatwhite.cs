using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Flatwhite : Coffee, IMilk
    {
        public Flatwhite()
        {
            
        }
        public Flatwhite(int discount, string blend):base(discount, blend)
        {
            
        }
        public override int Price()
        {
            return base.Price() + 100;
        }
        public int mlMilk()
        {
            throw new NotImplementedException();
        }

        public override CoffeeStrength Strength()
        {
            throw new NotImplementedException();
        }
    }
}
