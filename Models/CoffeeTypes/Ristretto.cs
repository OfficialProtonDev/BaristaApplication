using System.Xml.Linq;

namespace BaristaApplication.Models.CoffeeTypes
{
    public class Ristretto : CoffeeBase
    {
        public Ristretto()
        {
            Id = 2;
            Name = "Ristretto";
            Description = "The most concentrated of all espresso beverages, the ristretto is a ‘restricted’ short black.";
            CoffeeShots = 1;
            CupTypes = new List<CupType>
            {
                CupTypesData.Demitasse
            };
        }

        // Once again, this is an example of polymorphism, in a real use case I would just use a string.
        public override string GetInstructions()
        {
            return "Place a demitasse cup under the group head and extract a shot, restricting the pour, stopping the \r\nextraction at about 2/3 of the shot. Serve immediately!";
        }
    }
}
