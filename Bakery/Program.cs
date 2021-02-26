using System;
using BreadSpace.Models;
using PastrySpace.Models;
using System.Collections.Generic;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre Bakery!");
      Console.WriteLine("We currently sell BREAD, just the one kind, and PASTRIES, also just one kind.");
      Console.WriteLine($"The current price for Bread is {Bread.ReturnBaseBreadPrice()} dollars each and the current price of Pastry is {Pastry.ReturnBasePastryPrice()} dollars each.");
      AskBread();
      AskPastry();
    }
    public static void AskBread()
    {
      Console.WriteLine("How many Breads would you like? We currently have a buy one get one free sale.");
      int breadInput = int.Parse(Console.ReadLine());
      if (breadInput == 0)
      {
        Console.WriteLine("No problem!");
      }
      else if (breadInput < 0)
      {
        Console.WriteLine("Please enter a number from 0.");
        AskBread();
      }
      else
      {
        Bread breadOrder = new Bread(breadInput);
        Console.WriteLine($"Perfect! You added {breadInput} loaves of bread to your order.");
      }
    }
  }
}