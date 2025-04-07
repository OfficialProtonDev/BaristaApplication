namespace BaristaApplication.Models.CoffeeTypes
{
    public class Americano : CoffeeBase
    {
        public Americano()
        {
            Id = 4;
            Name = "Americano";
            Description = "Made in a larger cup (therefore more hot water). Like the Long Black, the extraction is poured over the \r\ntop of the water. Because the surface area is greater, it’s more difficult to retain a crema.";
            ContainsWater = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.Cappuccino
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Place the cup under the head and extract the double shot over the hot water. Note: The crema should \r\nform completely over the hot water and the cup is still not full. Serve with a small jug of hot water.";
        }
    }
}
