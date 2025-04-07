namespace BaristaApplication.Models.CoffeeTypes
{
    public class Moccaccino : CoffeeBase
    {
        public Moccaccino()
        {
            Id = 9;
            Name = "Moccaccino";
            Description = "A double shot of espresso with chocolate powder, combined with lightly textured milk.";
            ContainsMilk = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.LatteCup
            };
            ExtraIngredients = new List<ExtraIngredient>
            {
                ExtraIngredientsData.ChocolatePowder
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Add 1 tablespoon of chocolate powder to a cup, place the cup under the group head and make the double \r\nshot in to the chocolate powder. Mix well. Pour the textured milk in to the espresso/choc mix. TIP: If \r\nusing a BELL SHAPE JUG, to ensure a good volume of the heavily textured milk goes in the drink, pour from\r\nthe side of the jug. Sprinkle with plenty of chocolate powder.";
        }
    }
}
