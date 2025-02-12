using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Discount { get; set; }
        public string Blend { get; set; }
        public Coffee()
            :this(0, "Roasted beans")
        {
            
        }
        public Coffee(int discount, string blend)
        {
            if (Discount > 5)
            {
                throw new ArgumentOutOfRangeException("For meget discount, skal være mellem 1 og 5");
            }
            if (Discount < 0)
            {
                throw new ArgumentOutOfRangeException("For lidt discount, skal være højere end 0");
            }
            Discount = discount;
            Blend = blend;
        }
        public virtual int Price()
        {
            return 20 - Discount;
        }
        public abstract CoffeeStrength Strength();
        public enum CoffeeStrength
        {
            Strong,
            Medium,
            Weak
        }
    }
}
