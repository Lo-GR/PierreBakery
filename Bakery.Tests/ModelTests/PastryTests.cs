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
  }
}