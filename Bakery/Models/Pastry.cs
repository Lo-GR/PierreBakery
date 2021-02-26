using System;
using System.Collections.Generic;

namespace PastrySpace.Models
{
  public class Pastry
  {
    private static int _basePrice = 5;
    public int PastryNumber {get; set;}
    public Pastry(int pastries)
    {
      PastryNumber = pastries;
    }
    public static int ReturnPastryPrice(int numPastries)
    {
      return numPastries * 2;
    }
    public static int ApplyPastryDeals(int numPastry, int pricePastries)
    {
      //buy 3 for a dollar off
      int returnedPrice = pricePastries;
      int threeFerDiscount = numPastry/3;
      returnedPrice -= threeFerDiscount;
      return returnedPrice;
    }
  }
}