using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;

using guitar_shop.Models;

namespace MyApp.Namespace
{
    public class StockModel : PageModel
    {

        public List<Guitar> Guitars = Inventory.ToList();

        public void OnGet()
        {
        }
    }
}
