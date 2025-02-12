using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado:Coffee, IMilk
    {
        public Cortado():base()
        {
            
        }
        public Cortado(int discount, string blend) : base(discount, blend)
        {
        }
        public int mlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return base.Price() + 5;
        }

        public override CoffeeStrength Strength()
        {
            return CoffeeStrength.Medium;
        }
    }
}
