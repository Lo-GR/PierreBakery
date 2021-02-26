using System;

namespace PastrySpace.Models
{
  public class Pastry
  {
    private static int _basePrice = 2;
    public int PastryNumber {get; set;}
    public int PastryPrice {get; set;}
    public Pastry(int pastries)
    {
      PastryNumber = pastries;
      PastryPrice = ApplyPastryDeals(pastries, ReturnPastryPrice(pastries));
    }
    public static int ReturnPastryPrice(int numPastries)
    {
      return numPastries * _basePrice;
    }
    public static int ApplyPastryDeals(int numPastry, int pricePastries)
    {
      //buy 3 for a dollar off
      int returnedPrice = pricePastries;
      int threeFerDiscount = numPastry/3;
      returnedPrice -= threeFerDiscount;
      return returnedPrice;
    }
    public static int ReturnBasePastryPrice()
    {
      return 0;
    }
  }
}