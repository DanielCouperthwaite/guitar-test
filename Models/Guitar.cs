using System;
namespace Guitar.Models
{
  public class Guitar
  {
    public string Name { get; set; }

    public string ImageSrc { get; set; }

    public string Location { get; set; }

    public double Price { get; set; }

    public bool Available { get; set; }

    public string Description { get; set; }

    public Guitar(string name = "Not Found", string imgsrc = "/images/blank.png", string location = "Not Found", double price = 0.0, bool available = false, string description = "n/a")
    {
      Name = name;
      ImageSrc = imgsrc;
      Location = location;
      Price = price;
      Available = available;
      Description = description;
    }
  }
}