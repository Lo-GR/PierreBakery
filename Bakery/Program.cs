using System;
using BreadSpace.Models;
using PastrySpace.Models;

namespace Bakery
{
  public class Program
  {
    public static Bread breadOrder;
    public static Pastry pastryOrder;
    public static int pastryInput;
    public static int breadInput;
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre Bakery!");
      Console.WriteLine("We currently sell BREAD, just the one kind, and PASTRIES, also just one kind.");
      Console.WriteLine($"The current price for Bread is {Bread.ReturnBaseBreadPrice()} dollars each and the current price of Pastry is {Pastry.ReturnBasePastryPrice()} dollars each.");
      AskBread();
      AskPastry();
      Console.WriteLine("and with that, here are your order details:");
      FinalOrder();
      Console.WriteLine("Thank you for stopping by! Please press any key to exit.");
      Console.ReadLine();
    }
    public static void AskBread()
    {
      Console.WriteLine("How many Breads would you like? We currently have a buy one get one free sale.");
      breadInput = int.Parse(Console.ReadLine());
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
        breadOrder = new Bread(breadInput);
        Console.WriteLine($"Perfect! You added {breadInput} loaves of bread to your order.");
      }
    }
    public static void AskPastry()
    {
      Console.WriteLine("How many Pastries would you like? We're currently running a buy 3 for $5 deal.");
      pastryInput = int.Parse(Console.ReadLine());
      if (pastryInput == 0)
      {
        Console.WriteLine("No problem!");
      }
      else if (pastryInput < 0)
      {
        Console.WriteLine("Please enter a number from 0.");
        AskPastry();
      }
      else
      {
        pastryOrder = new Pastry(pastryInput);
        Console.WriteLine($"Perfect! You added {pastryInput} pastries to your order."); 
        
      }
    }
    public static void FinalOrder()
    {
      int totalCost = 0;
      if(breadInput > 0)
      {
        Console.WriteLine($"Bread Quantity: {breadOrder.BreadNumber}");
        Console.WriteLine($"Cost of Bread: ${breadOrder.BreadPrice}");
        totalCost += breadOrder.BreadPrice;
      }
      if(pastryInput > 0)
      {
        Console.WriteLine($"Pastry Quantity: {pastryOrder.PastryNumber}");
        Console.WriteLine($"Cost of Pastry: ${pastryOrder.PastryPrice}");
        totalCost += pastryOrder.PastryPrice;
      }
      if (pastryInput <= 0 && breadInput <= 0)
      {
        Console.WriteLine("It looks like you did not order anything this time. Please come again!");
      }
      else
      {
        Console.WriteLine($"Your total cost for this order is ${totalCost}");
      }
    }
  }
}