using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using guitar_shop.Models;

namespace guitar_shop.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Guitar> Guitars = Inventory.ToList();

    public void OnGet()
    {

    }
}
