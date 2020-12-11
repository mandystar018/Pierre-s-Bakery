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
      Bread newBread = new Bread("Baguette", 5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetKindOfBread_ReturnKindOfBread_String()
    {
      string bread = "Baguett";
      Bread newBread = new Bread("Baguette", 5);
      string result = newBread.Kind;
      Assert.AreEqual(bread, result);
    }
  }
}