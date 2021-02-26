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
    // [TestMethod]
    // public void GetPastryPrice_ReturnsNumberFromCalculatedPrice_int()
    // {
    //   int expectedPrice = 15;
    //   Pastry pastryObject = new Pastry(5);
    //   int result = pastryObject.PastryPrice;
    //   Assert.AreEqual(expectedPrice, result);
    // }
      [TestMethod]
    public void ReturnPastryPrice_ReturnIntGivenNumberOfPastries_IntToInt()
    {
      int numInput = 5; // 5 Pastries
      int expectedOutput = 25; //10 dollars
      int actualOutput =  Pastry.ReturnPastryPrice(numInput);
      Assert.AreEqual(expectedOutput, actualOutput);
    }
  }
}