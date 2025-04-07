namespace BaristaApplication.Models.CoffeeTypes
{
    public class Macchiato : CoffeeBase
    {
        public Macchiato()
        {
            Id = 5;
            Name = "Macchiato";
            Description = "A short black ‘marked’ with hot milk.";
            ContainsMilk = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.Demitasse
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Place the cup under the head and extract the double shot. Add the mark of milk to the espresso by spoon.";
        }
    }
}
