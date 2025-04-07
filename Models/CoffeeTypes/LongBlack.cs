namespace BaristaApplication.Models.CoffeeTypes
{
    public class LongBlack : CoffeeBase
    {
        public LongBlack()
        {
            Id = 3;
            Name = "LongBlack";
            Description = "The extraction is poured on top of the water so the crema is not disturbed.";
            ContainsWater = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.Tulip
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Fill the cup just over half full with hot water from the espresso machine. Then, place the cup with water \r\nunder the group and extract a double shot over the hot water. If requested, serve the long black with a \r\nsmall jug of hot water.";
        }
    }
}
