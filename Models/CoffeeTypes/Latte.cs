namespace BaristaApplication.Models.CoffeeTypes
{
    public class Latte : CoffeeBase
    {
        public Latte()
        {
            Id = 7;
            Name = "Latte";
            Description = "The texture of the milk in a latte can be slightly thicker than that of the flat white.";
            ContainsMilk = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.Glass,
                CupTypesData.LatteCup,
                CupTypesData.Bowl
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Extract a double shot in to the cup. Pour and allow the thicker, lightly textured milk to flow in to and mix \r\nwith the espresso. TIP: If using a BELL SHAPE JUG, to ensure a consistent pour of the thicker, frothy milk, \r\npour from the side of the jug. \r\nBowl Latte – milk should be the same as the standard latte but ensure you swirl the milk and keep it \r\nblended due to the size of the beverage.\r\n";
        }
    }
}
