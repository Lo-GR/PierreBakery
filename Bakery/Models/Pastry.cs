using System;
using System.Collections.Generic;

namespace PastrySpace.Models
{
  public class Pastry
  {
    public int PastryNumber {get; set;}
    public Pastry(int pastries)
    {
      PastryNumber = pastries;
    }
    public static int ReturnPastryPrice(int numPastries)
    {
      return numPastries * 2;
    }
  }
}