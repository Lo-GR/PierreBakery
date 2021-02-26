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
      Assert.AreEqual(numInput, expectedOutput);
    }
  }
}