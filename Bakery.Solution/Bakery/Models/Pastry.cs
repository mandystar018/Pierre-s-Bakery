  namespace Bakery.Models
{
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