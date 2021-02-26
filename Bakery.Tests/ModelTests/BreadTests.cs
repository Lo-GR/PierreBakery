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
      int expectedOutput =  Bread.ReturnBreadPrice(5); // 25 dollars
      Assert.AreEqual(numInput, expectedOutput);
    }
  }
}