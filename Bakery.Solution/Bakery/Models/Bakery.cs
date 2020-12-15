using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public string Kind { get; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Bread(string kind, int price, int quantity)
    {
      Kind = kind;
      Price = price;
      Quantity = quantity;
    }

    public int GetDiscount(int Quantity)
    {
      int discount = 5;
      if (Quantity % 3 == 0)
      {
        Price -= discount;
      }
      return Price;
    }
  }

  public class Pastry
  {
    public string Kind { get; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Pastry(string kind, int price, int quantity)
    {
      Kind = kind;
      Price = price;
      Quantity = quantity;
    }

    public int GetDiscount(int Quantity)
    {
      int discount = 1;
      if (Quantity % 3 == 0)
      {
        Price -= discount ;
      }
      return Price;
    }
  }
}