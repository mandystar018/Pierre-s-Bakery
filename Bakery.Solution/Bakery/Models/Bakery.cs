using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Kind { get; }
    public int Price { get;  }

    public Bread(string kind, int price)
    {
      Kind = kind;
      Price = price;
    }


  }
}