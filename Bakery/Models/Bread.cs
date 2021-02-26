using System;
using System.Collections.Generic;

namespace BreadSpace.Models
{
  public class Bread
  {
    public static int ReturnBreadPrice(int numBread)
    {
      return numBread * 5;
    }
    public static int ApplyBreadDeals(int numBreads, int priceBreads)
    {
      return 5;
    }
  }
}