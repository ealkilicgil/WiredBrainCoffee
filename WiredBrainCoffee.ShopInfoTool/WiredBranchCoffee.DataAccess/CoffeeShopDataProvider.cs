using System;
using System.Collections.Generic;
using System.Text;
using WiredBranchCoffee.DataAccess.Model;

namespace WiredBranchCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops() {
            yield return new CoffeeShop { Location="Frankfurt",BeansInStock=107};
            yield return new CoffeeShop { Location = "Freiburg", BeansInStock = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansInStock = 56 };
        }
    }
}
