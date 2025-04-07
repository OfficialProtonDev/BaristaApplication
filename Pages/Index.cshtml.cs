using BaristaApplication.Models;
using BaristaApplication.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BaristaApplication.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string SelectedCoffeeName { get; set; }

        public List<CoffeeBase> CoffeeTypes { get; set; }

        public CoffeeBase SelectedCoffee { get; set; }

        public void OnGet()
        {
            CoffeeTypes = CoffeeFactory.GetAllCoffees();
        }

        public void OnPost()
        {
            CoffeeTypes = CoffeeFactory.GetAllCoffees();
            SelectedCoffee = CoffeeTypes.FirstOrDefault(c => c.Name == SelectedCoffeeName);
        }
    }
}
