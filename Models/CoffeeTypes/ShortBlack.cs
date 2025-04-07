namespace BaristaApplication.Models.CoffeeTypes
{
    public class ShortBlack : CoffeeBase
    {
        public ShortBlack()
        {
            Id = 1;
            Name = "ShortBlack";
            Description = "This is the base of all espresso beverages.";
            CupTypes = new List<CupType>
            {
                CupTypesData.Demitasse
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Place a demitasse cup under the group head and extract a double shot. Serve immediately!";
        }
    }
}
