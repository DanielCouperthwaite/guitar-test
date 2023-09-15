using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http.Connections;

namespace guitar_shop.Models
{
  public static class Inventory
  {
    public static List<Guitar> ToList()
    {
        return new List<Guitar>
        {
            new Guitar(name: "Gibson", imageSrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/apple.png", location: "Preston", price: 399.99, available: true, description: "Brand new! Never used!"),
            new Guitar(name: "Fender", imageSrc: "https://content.codecademy.com/courses/asp-dot-net/food_icons/aubergine.png", location: "Liverpool", price: 449.99, available: false, description: "Some wear and tear"),
        };
    }
  }
}