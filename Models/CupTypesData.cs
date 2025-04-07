namespace BaristaApplication.Models
{
    public static class CupTypesData
    {
        public static readonly CupType Demitasse = new CupType { Id = 1, Name = "Demitasse Cup", Size = 70 };
        public static readonly CupType Tulip = new CupType { Id = 2, Name = "Tulip Cup", Size = 150 };
        public static readonly CupType Cappuccino = new CupType { Id = 3, Name = "Cappuccino Cup", Size = 190 };
        public static readonly CupType Glass = new CupType { Id = 4, Name = "Glass", Size = 220 };
        public static readonly CupType LatteCup = new CupType { Id = 4, Name = "Latte Cup", Size = 250 };
        public static readonly CupType Bowl = new CupType { Id = 5, Name = "Bowl", Size = 350 };
    }
}
