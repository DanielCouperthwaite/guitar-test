using System;
namespace guitar_shop.Models
{
  public class Guitar
  {
    public string Name { get; set; }
    public string ImageSrc { get; set; }
    public string Location { get; set; }
    public double Price { get; set; }
    public bool Available { get; set; }
    public string Description { get; set; }
    public Guitar(string name = "Not Found", string imageSrc = "/images/blank.png", string location = "Not Found", double price = 0.0, bool available = false, string description = "n/a")
    {
      Name = name;
      ImageSrc = imageSrc;
      Location = location;
      Price = price;
      Available = available;
      Description = description;
    }
  }

  
}