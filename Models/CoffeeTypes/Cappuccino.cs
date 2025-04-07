namespace BaristaApplication.Models.CoffeeTypes
{
    public class Cappuccino : CoffeeBase
    {
        public Cappuccino()
        {
            Id = 8;
            Name = "Cappuccino";
            Description = "A double shot with a very thick, head of frothy milk.";
            ContainsMilk = true;
            CupTypes = new List<CupType>
            {
                CupTypesData.Cappuccino
            };
            ExtraIngredients = new List<ExtraIngredient>
            {
                ExtraIngredientsData.ChocolatePowder,
                ExtraIngredientsData.Cinnamon
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Carefully spoon all the heavily textured top milk in to the cup then pour the hot, lightly textured milk \r\nthrough the centre of the frothed milk OR hold back the heavily textured milk and pour approximately ½ a \r\ncup of lightly textured milk in to the double shot. Use the spoon to push the remaining, heavily textured \r\ntop milk in to the remainder of the cup. A dome of thicker foam will rise up above the rim of the cup. \r\nSprinkle with plenty of chocolate powder or a lighter sprinkle of cinnamon.";
        }
    }
}
