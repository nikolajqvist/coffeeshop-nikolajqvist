using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        public int OrderId { get; set; }
        public string BaristaName { get; set; }
        public string CustomerName { get; set; }
        public int TableId { get; set; }
        public bool IsTakeAway { get; set; }
        public List<Coffee> _coffees { get; set; } = new List<Coffee>();

        public Order(int orderid, string baristaname, string customername, int tableid, List<Coffee> coffees)
        {
            OrderId = orderid;
            BaristaName = baristaname;
            CustomerName = customername;
            TableId = tableid;
            _coffees = coffees;
        }
        public Order(int orderid, string baristaname, string customername, bool istakeaway, List<Coffee> coffees)
        {
            OrderId = orderid;
            CustomerName = customername;
            BaristaName = baristaname;
            IsTakeAway = istakeaway;
            _coffees = coffees;
        }
        public int TotalOrderPrice()
        {
            int totalPrice = 0;
            foreach(Coffee coffe in _coffees)
            {
                totalPrice += coffe.Price();
            }
            return totalPrice;
        }

        public int CoffeesInOrder()
        {
            return _coffees.Count();
        }
        public int DiscountInOrder()
        {
            int totaldiscount = 0;
            foreach(Coffee coffe in _coffees)
            {
                totaldiscount += coffe.Discount;
            }
            return totaldiscount;
        }
    }
}
