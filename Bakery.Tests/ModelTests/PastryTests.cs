using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PastrySpace.Models;

namespace PastrySpace.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryAmount_ReturnsNumberOfPastries_int()
    {
      int expectedNumber = 5;
      Pastry obj = new Pastry(expectedNumber);
      int result = obj.PastryNumber;
      Assert.AreEqual(expectedNumber, result);
    }
    [TestMethod]
    public void GetPastryPrice_ReturnsNumberFromCalculatedPrice_int()
    {
      int expectedPrice = 10;
      Pastry pastryObject = new Pastry(6);
      int result = pastryObject.PastryPrice;
      Assert.AreEqual(expectedPrice, result);
    }
      [TestMethod]
    public void ReturnPastryPrice_ReturnIntGivenNumberOfPastries_IntToInt()
    {
      int numInput = 5; // 5 Pastries
      int expectedOutput1 = 10; //10 dollars
      int actualOutput1 =  Pastry.ReturnPastryPrice(numInput);
      Assert.AreEqual(expectedOutput1, actualOutput1);
    }
    [TestMethod]
    public void ApplyPastryDeals_ReturnAdjustedPriceGivenNumberOfPastriesPrice_IntToInt()
    {
      int pastryQuantity = 6;
      int pastryPrice = 12;
      int expectedOutput2 = 10; //10 - 1, every third pastry drops price by 1 (3 for $5)
      int actualOutput2 = Pastry.ApplyPastryDeals(pastryQuantity, pastryPrice);
      Assert.AreEqual(expectedOutput2, actualOutput2);
      Console.WriteLine(expectedOutput2);
      Console.WriteLine(actualOutput2);
    }
    [TestMethod]
    public void ReturnBasePastryPrice_ReturnsBasePriceOfPastries_Int()
    {
      int expectedOutput3 = 2;
      Assert.AreEqual(expectedOutput3, Pastry.ReturnBasePastryPrice());
    }
  }
}