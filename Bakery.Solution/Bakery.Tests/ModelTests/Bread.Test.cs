using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("Baguette", 5, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetKindOfBread_ReturnKindOfBread_String()
    {
      string bread = "Baguette";
      Bread newBread = new Bread("Baguette", 5, 1);
      string result = newBread.Kind;
      Assert.AreEqual(bread, result);
    }

    [TestMethod]
    public void GetPriceOfBread_ReturnPriceOfBread_Int()
    {
      int price = 5;
      Bread newBread = new Bread("Baguette", 5, 1);
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPriceOfBread_ReturnUpdatesPriceOfBread_Int()
    {
      Bread newBread = new Bread("Baguette", 5, 1);
      int updatedPrice = 10;
      newBread.Price = updatedPrice;
      int result = newBread.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetQuantityOfBread_ReturnQuantityOfBread_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread("Baguette", 5, 1);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SetQuantityOfBread_ReturnUpdatedQuantityOfBread_Int()
    {
      Bread newBread = new Bread("Baguette", 5, 1);
      int updatedQuantity = 2;
      newBread.Quantity = updatedQuantity;
      int result = newBread.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void GetDiscountOfBread_ReturnDiscountOfBread_Int()
    {
      Bread newBread = new Bread("Baguette", 15, 3);
      int result = newBread.GetDiscount(3);
      Assert.AreEqual( 10 ,result);
    }
  }
}
