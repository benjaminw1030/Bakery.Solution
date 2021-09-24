using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Bread breadOrder = new Bread(0);
      Pastry pastryOrder = new Pastry(0);
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------------");
      Console.WriteLine("");
      Console.WriteLine("Delicious baked goods for low, low prices!");
    }

    public static void MainMenu()
    {
      Console.WriteLine("We have the following specials this week:");
      Console.WriteLine("Bread loaves for $5 (Buy two get one free!)");
      Console.WriteLine("Pastries for $2 (3 for $5!)");
      Console.WriteLine("");
      Console.WriteLine("Please enter the number of your selection:");
      Console.WriteLine("1) Order Bread");
      Console.WriteLine("2) Order Pastries");
      Console.WriteLine("3) Checkout");
      Console.WriteLine("4) Quit");
      Console.WriteLine("");
      string menuSelect = Console.ReadLine();
      if (menuSelect == "1")
      {
        BreadMenu();
      }
    }

    public static void BreadMenu()
    {
      Console.WriteLine("How many loaves would you like to order?");
      string breadCount = Console.ReadLine();
      int breadCount = int.Parse(breadCount);
      breadOrder.Count += breadCount;
      if (breadOrder.Count % 3 == 1)
      {
        Console.WriteLine("Would you like another one? It's free! (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          breadOrder.Count++;
          Console.WriteLine("Will do!");
          MainMenu();
        }
        else
        {
          Console.WriteLine("Alrighty then!");
          MainMenu();
        }
      }
    }

    public static void Checkout()
    {

    }
  }
}