using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {

      Bread baguette = new Bread("Baguette", 5, 1);
      Bread specialBaguette = new Bread("Baguette", 15, 3);
      Pastry croissant = new Pastry("Croissant", 2, 1);
      Pastry specialCroissant = new Pastry("Croissant", 6, 3);

      Console.WriteLine("----------------------------------");
      Console.WriteLine("HELLO WELCOME TO PIERRE'S BAKERY!");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Do you want to see my menu?");
      string menu = Console.ReadLine();
      if (menu == "yes" || menu == "Yes")
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(baguette.Kind + " $" + baguette.Price);
        Console.WriteLine(croissant.Kind + " $" + croissant.Price);
      }

      Console.WriteLine("----------------------");
      Console.WriteLine("Would you like to see our specials?");
      string specials = Console.ReadLine();
      if (specials == "yes" || specials == "Yes")
      {
        Console.WriteLine("----------------------");
        Console.WriteLine("ANY kind of Bread Buy 2 and get 1 free!");
        Console.WriteLine("ANY kind of Pastry Buy 3 for $5");
        Console.WriteLine("----------------------");
      }
      else
      {
        Console.WriteLine("Well let's make an order!");
      }

      Console.WriteLine("Are you ready to Order?");
      string order = Console.ReadLine();
      if (order == "yes" || order == "Yes")
      {
        Console.WriteLine("----------------------");
        Console.WriteLine("LAZY MODE");
        Console.WriteLine("Please Enter:");
        Console.WriteLine("1 for single Bread");
        Console.WriteLine("2 for single Pastry");
        Console.WriteLine("3 for Bread special");
        Console.WriteLine("4 for Pastry special");
        Console.WriteLine("----------------------");
        string number = Console.ReadLine();
        if (number == "1")
        {
          Console.WriteLine("Your total price for " + baguette.Quantity + " " + baguette.Kind + " is $" + baguette.Price);
          Console.WriteLine("Thank you for your Purchase!");
        }
        else if (number == "2")
        {
          Console.WriteLine("Your total price for " + croissant.Quantity + " " + croissant.Kind + " is $" + croissant.Price);
        }
        else if (number == "3")
        {
          Console.WriteLine("Your total price for " + specialBaguette.Quantity + " " + specialBaguette.Kind + " is $" + specialBaguette.GetDiscount(3));
        }
        else if (number == "4")
        {
          Console.WriteLine("Your total price for " + specialCroissant.Quantity + " " + specialCroissant.Kind + " is $" + specialCroissant.GetDiscount(3));
        }
      }
      else
      {
        Console.WriteLine("Thank you for your Visit! Bye!");
      }

    }
  }
}