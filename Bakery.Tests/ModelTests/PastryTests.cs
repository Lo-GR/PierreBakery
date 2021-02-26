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
  }
}