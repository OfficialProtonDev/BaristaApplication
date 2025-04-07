using BaristaApplication.Models;

namespace BaristaApplication.Operations
{
    public static class CoffeeFactory
    {
        public static List<CoffeeBase> GetAllCoffees()
        {
            return new List<CoffeeBase>
            {
                new Models.CoffeeTypes.ShortBlack(),
                new Models.CoffeeTypes.Ristretto(),
                new Models.CoffeeTypes.LongBlack(),
                new Models.CoffeeTypes.Americano(),
                new Models.CoffeeTypes.Macchiato(),
                new Models.CoffeeTypes.FlatWhite(),
                new Models.CoffeeTypes.Latte(),
                new Models.CoffeeTypes.Cappuccino(),
                new Models.CoffeeTypes.Moccaccino()
            };
        }
    }
}
