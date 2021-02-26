using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BreadSpace.Models;

namespace BreadSpace.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetBreadAmount_ReturnsNumberOfBreads_int()
    {
      int expectedNumber = 5;
      Bread breadObj = new Bread(expectedNumber);
      int result = breadObj.BreadNumber;
      Assert.AreEqual(expectedNumber, result);
    }
    [TestMethod]
    public void GetBreadPrice_ReturnsNumberFromCalculatedPrice_int()
    {
      int expectedPrice = 15;
      Bread breadObject = new Bread(5);
      int result = breadObject.BreadPrice;
      Assert.AreEqual(expectedPrice, result);
    }
    [TestMethod]
    public void ReturnBreadPrice_ReturnIntGivenNumberOfBreads_IntToInt()
    {
      int numInput = 5; // 5 Breads
      int expectedOutput1 = 25; //25 dollars
      int actualOutput1 =  Bread.ReturnBreadPrice(numInput);
      Assert.AreEqual(expectedOutput1, actualOutput1);
    }
    [TestMethod]
    public void ApplyBreadDeals_ReturnAdjustedPriceGivenNumberOfBreadsPrice_IntToInt()
    {
      int breadQuantity = 5;
      int breadPrice = 25;
      int expectedOutput2 = 15; //25 - 10 from BOGO
      int actualOutput2 = Bread.ApplyBreadDeals(breadQuantity, breadPrice);
      Assert.AreEqual(expectedOutput2, actualOutput2);
    }
    [TestMethod]
    public void ReturnBaseBreadPrice_ReturnsCurrentBreadBasePrice_Int()
    {
      int expectedOutput3 = 5;
      Assert.AreEqual(expectedOutput3, Bread.ReturnBaseBreadPrice());
    }
  }
}