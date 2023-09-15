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
            new Guitar(name: "Gibson Les Paul", imageSrc: "https://cdn11.bigcommerce.com/s-hvzya2q3vy/images/stencil/1920w/products/49527/136044/bstgbssi01548265__76984.1694534550.jpg?c=1", location: "Preston", price: 399.99, available: true, description: "Brand new! Never used!"),
            new Guitar(name: "Fender Stratocaster", imageSrc: "https://cdn11.bigcommerce.com/s-hvzya2q3vy/images/stencil/1280x1280/products/49071/133848/bst2usfenams60thannobm__69240.1690905010.jpg?c=1&imbypass=on", location: "Liverpool", price: 449.99, available: false, description: "Some wear and tear"),
        };
    }
  }
}