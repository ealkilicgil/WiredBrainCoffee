using System;
using System.Collections.Generic;
using System.Text;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStock = 107 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStock = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansInStock = 56 };
        }
    }
}
