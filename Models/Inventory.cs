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
            new Guitar(name: "Gibson Les Paul", imageSrc: "https://cdn11.bigcommerce.com/s-hvzya2q3vy/images/stencil/1920w/products/49527/136044/bstgbssi01548265__76984.1694534550.jpg?c=1", location: "Preston", price: 799.99, available: true, description: "The Gibson Les Paul is a timeless classic known for its rich and warm tone. This brand new, never-used Les Paul is the perfect choice for any guitarist looking to rock the stage with style and substance."),
            new Guitar(name: "Fender Stratocaster", imageSrc: "https://cdn11.bigcommerce.com/s-hvzya2q3vy/images/stencil/1280x1280/products/49071/133848/bst2usfenams60thannobm__69240.1690905010.jpg?c=1&imbypass=on", location: "Liverpool", price: 599.99, available: false, description: "The Fender Stratocaster is a legendary guitar with a history of shaping modern music. This particular Stratocaster has some wear and tear, but it's still a reliable instrument with a unique character."),
            new Guitar(name: "Gibson Flying V", imageSrc: "https://andertons-productimages.imgix.net/327219-DSV19ANCH1_1%20-%20Copy.jpg?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Liverpool", price: 899.99, available: true, description: "Unleash your inner rockstar with the iconic Gibson Flying V. This guitar has seen some action and proudly wears its battle scars, making it a true rock 'n' roll companion."),
            new Guitar(name: "PRS SE Custom 22", imageSrc: "https://andertons-productimages.imgix.net/SECU22SHBG-PRS-SE-Custom-22-Semi-Hollow-Black-Gold-Burst-Body.jpg?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Liverpool", price: 699.99, available: true, description: "The PRS SE Custom 22 is a versatile semi-hollowbody guitar that delivers a smooth and expressive playing experience. This one is in great condition, ready to take your music to the next level."),
            new Guitar(name: "Epiphone Alex Lifeson Les Paul Excess", imageSrc: "https://andertons-productimages.imgix.net/EILPACQALRUBGH1-Epiphone-Alex-Lifeson-Les-Paul-Custom-Axcess-Ruby-Body.jpg?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Toronto", price: 749.99, available: true, description: "Designed in collaboration with Alex Lifeson of Rush, this Epiphone Les Paul offers exceptional playability and tone. It has been gently used and is in excellent condition."),
            new Guitar(name: "Jackson American Series Virtuoso", imageSrc: "https://andertons-productimages.imgix.net/2802401849-jackson-american-series-virtuoso-specific-ocean-hero.png?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Liverpool", price: 899.99, available: true, description: "The Jackson American Series Virtuoso is a precision-crafted instrument built for shredders and metalheads. This guitar is in top-notch condition, ready to melt faces with its blistering solos."),
            new Guitar(name: "Fender Vintage Telecaster", imageSrc: "https://andertons-productimages.imgix.net/541931-Fender%20American%20Vintage%20II%201951%20Telecaster%20Electric%20Guitar%20in%20Butterscotch%20Blonde.png?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Preston", price: 699.99, available: true, description: "The Fender Vintage Telecaster is a true classic with timeless tone. This Butterscotch Blonde beauty is in fantastic condition and exudes vintage charm."),
            new Guitar(name: "Ibanez Genesis Collection", imageSrc: "https://andertons-productimages.imgix.net/256684-1513864806562.png?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Liverpool", price: 799.99, available: true, description: "The Ibanez Genesis Collection pays homage to the golden age of rock. This guitar is in great shape, ready to deliver the high-performance sound Ibanez is known for."),
            new Guitar(name: "PRS Tremonti Signature", imageSrc: "https://andertons-productimages.imgix.net/445437-0318616%20%281%29.jpg?auto=compress&auto=format", location: "Liverpool", price: 849.99, available: true, description: "The PRS Tremonti Signature is a powerful and versatile instrument designed in collaboration with Mark Tremonti. It's in excellent condition and can handle everything from heavy riffs to melodic solos."),
            new Guitar(name: "Gretsch G7593T with Bigsby Bridge", imageSrc: "https://andertons-productimages.imgix.net/2401409805%2BJT21093931-JT21093931-(1).JPG?auto=compress&w=673&h=673&bg=ffffff&auto=format", location: "Liverpool", price: 749.99, available: false, description: "The Gretsch G7593T is a beautiful guitar with a Bigsby bridge for added expressiveness. This guitar is in pristine condition and offers a vintage-inspired sound that will inspire your creativity."),
        };
    }
  }
}