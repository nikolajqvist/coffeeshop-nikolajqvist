using CoffeeShopConsoleAppNet60;
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Coffee> coffees = new List<Coffee>()
        {
            new Latte(),
            new Cortado(),
            new Blackcoffee()
        };

        List<IMilk> milkCoffees = new List<IMilk>
        {
            new Latte(),
            new Cortado()
        };

        foreach (Coffee item in coffees)
        {
            if(item is IMilk)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine(item.Blend);
                Console.WriteLine(item.Discount);
                Console.WriteLine(item.Price());
                Console.WriteLine(item.Strength());
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(item.GetType().Name);
            Console.WriteLine(item.Blend);
            Console.WriteLine(item.Discount);
            Console.WriteLine(item.Price());
            Console.WriteLine(item.Strength());
        }

        Console.WriteLine();
        Console.WriteLine();

        Order o1 = new Order(0, "Torber", "Kirsten", 25, new List<Coffee>
        {
            new Latte(1, "Blend blend"),
            new Cortado(2, "Blend blend"),
            new Blackcoffee(3, "Blend blend"),
            new Flatwhite(5, "Blend my blend")
        });

        Console.WriteLine($"Totalpris i ordre: {o1.TotalOrderPrice()}");
        Console.WriteLine($"Totale kaffer i ordre: {o1.CoffeesInOrder()}");
        Console.WriteLine($"Total discount: {o1.DiscountInOrder()}");
    }
}