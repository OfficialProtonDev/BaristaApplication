namespace BaristaApplication.Models
{
    public abstract class CoffeeBase
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int CoffeeShots { get; set; } = 2;

        public bool ContainsMilk { get; set; } = false;
        public bool ContainsWater { get; set; } = false;

        public List<CupType> CupTypes { get; set; }

        public List<ExtraIngredient> ExtraIngredients { get; set; } = new List<ExtraIngredient>();

        // Included for demonstration of polymorphism, in a real use case I would just use a string.
        public abstract string GetInstructions();
    }
}
