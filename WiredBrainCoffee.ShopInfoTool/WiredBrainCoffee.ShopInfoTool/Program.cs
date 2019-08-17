using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee");
            Console.WriteLine("Write help to list coffee shop commands,write quit the exit application ");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if (string.Equals("exit", line, StringComparison.OrdinalIgnoreCase))
                    break;
                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(">>>Available coffee shop commands:");
                    foreach (var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($">" + coffeeShop.Location);
                    }
                }
                else {
                    var foundCoffeeShops = coffeeShops.
                        Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    if (foundCoffeeShops.Count == 0)
                    {
                        Console.WriteLine($">Command '{line}' not found");
                    }
                    else if (foundCoffeeShops.Count == 1)
                    {
                        var coffeeShop = foundCoffeeShops.Single();
                        Console.WriteLine($"> Location :{ coffeeShop.Location}");
                        Console.WriteLine($"> Bean in Stock :{ coffeeShop.BeansInStock}");
                    }
                    else {
                        Console.WriteLine($"> Multiple matching coffee shop commands found:");
                        foreach (var coffeeType in foundCoffeeShops) {
                            Console.WriteLine($"> {coffeeType.Location}");
                        }
                    }
                }
            }

        }
    }
}
