using System;

namespace BreadSpace.Models
{
  public class Bread
  {
    public int BreadNumber {get; set;}
    public int BreadPrice {get; set;}
    private static int _basePrice = 5;
    public Bread(int breads)
    {
      BreadNumber = breads;
      BreadPrice = ApplyBreadDeals(breads, ReturnBreadPrice(breads));
    }
    public static int ReturnBreadPrice(int numBread)
    {
      return numBread * _basePrice;
    }
    public static int ApplyBreadDeals(int numBreads, int priceBreads)
    {
      //buy one get one deal
      int returnedPrice = priceBreads;
      int bOGOBreadAmount = numBreads/2;
      int bOGODiscount = _basePrice * bOGOBreadAmount;
      returnedPrice -= bOGODiscount;
      return returnedPrice;
    }
    public static int ReturnBaseBreadPrice()
    {
      return _basePrice;
    }
  }
}