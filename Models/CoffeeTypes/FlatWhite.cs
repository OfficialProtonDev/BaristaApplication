namespace BaristaApplication.Models.CoffeeTypes
{
    public class FlatWhite : CoffeeBase
    {
        public FlatWhite()
        {
            Id = 6;
            Name = "FlatWhite";
            Description = "Flat white drinkers are often the most fussy about the way their drink is prepared. Ensure the milk has \r\nvery little froth and is still textured enough to carry without spilling.";
            ContainsMilk = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.Tulip,
                CupTypesData.Cappuccino
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Place the cup under the head and extract the double shot. Add the mark of milk to the espresso by spoon.";
        }
    }
}
