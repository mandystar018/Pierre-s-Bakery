using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

[TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("Croissant", 2, 1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetKindOfPastry_ReturnKindOfPastry_String()
    {
      string pastry = "Croissant";
      Pastry newPastry = new Pastry("Croissant", 2, 1);
      string result = newPastry.Kind;
      Assert.AreEqual(pastry, result);
    }

    [TestMethod]
    public void GetPriceOfPastry_ReturnPriceOfPastry_Int()
    {
      int price = 2;
      Pastry newPastry = new Pastry("Croissant", 2, 1);
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPriceOfPastry_ReturnUpdatesPriceOfPastry_Int()
    {
      Pastry newPastry = new Pastry("Croissant", 2, 3);
      int updatedPrice = 5;
      newPastry.Price = updatedPrice;
      int result = newPastry.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetQuantityOfPastry_ReturnQuantityOfPastry_Int()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry("Croissant", 2, 1);
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SetQuantityOfPastry_ReturnUpdatedQuantityOfPastry_Int()
    {
      Pastry newPastry = new Pastry("Croissant", 2, 3);
      int updatedQuantity = 2;
      newPastry.Quantity = updatedQuantity;
      int result = newPastry.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void GetDiscountOfPastry_ReturnDiscountOfPastry_Int()
    {
      Pastry newPastry = new Pastry("Croissant", 6, 3);
      Assert.AreEqual( 5 , newPastry.GetDiscount(3));
    }
  }