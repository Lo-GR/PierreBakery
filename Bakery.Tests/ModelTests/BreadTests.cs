using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BreadSpace.Models;

namespace BreadSpace.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void ReturnBreadPrice_ReturnIntGivenNumberOfBreads_IntToInt()
    {
      int numInput = 5; // 5 Breads
      int expectedOutput = 25; //25 dollars
      int actualOutput =  Bread.ReturnBreadPrice(numInput);
      Assert.AreEqual(expectedOutput, actualOutput);
    }
    [TestMethod]
    public void ApplyBreadDeals_ReturnAdjustedPriceGivenNumberOfBreadsPrice_IntToInt()
    {
      int breadQuantity = 5;
      int breadPrice = 25;
      int expectedOutput = 15; //25 - 10 from BOGO
      int actualOutput = Bread.ApplyBreadDeals(breadQuantity, breadPrice);
      Assert.AreEqual(expectedOutput, actualOutput);
    }
  }
}