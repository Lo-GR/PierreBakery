using System;
using System.Collections.Generic;

namespace BreadSpace.Models
{
  public class Bread
  {
    public static int BasePrice {get; set;}
    private static int _basePrice = 5;
    public static int ReturnBreadPrice(int numBread)
    {
      return numBread * 5;
    }
    public static int ApplyBreadDeals(int numBreads, int priceBreads)
    {
      int returnedPrice = priceBreads;
      int bOGOBreadAmount = numBreads/2;
      int bOGODiscount = _basePrice * bOGOBreadAmount;
      returnedPrice -= bOGODiscount;
      return returnedPrice;
    }
  }
}