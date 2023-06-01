using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public void OnGet()
        {
            pizzas = PizzaService.GetAll();
        }
        public List<Pizza> pizzas = new();
    }
}
