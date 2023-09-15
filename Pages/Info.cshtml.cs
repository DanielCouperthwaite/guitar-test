using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using guitar_shop.Models;

namespace MyApp.Namespace
{
    public class InfoModel : PageModel
    {

        public List<Guitar> Guitars = Inventory.ToList();


        public Guitar? CurrentGuitar { get; set; }

        
        public IActionResult OnGet(string name)
        {
            CurrentGuitar = Guitars.Find(guitar => guitar.Name.ToLower() == name.ToLower());

            if(CurrentGuitar == null)
            {
                return NotFound();
            }
            else 
            {
                return Page();
            }
        }
    }
}
