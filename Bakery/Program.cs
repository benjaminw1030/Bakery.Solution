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
      MainMenu(breadOrder, pastryOrder);
    }

    public static void MainMenu(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("");
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
        BreadMenu(breadOrder, pastryOrder);
      }
      else if (menuSelect == "2")
      {
        PastryMenu(breadOrder, pastryOrder);
      }
      else if (menuSelect == "3")
      {
        Checkout(breadOrder, pastryOrder);
      }
      else if (menuSelect == "4")
      {
        Quit(breadOrder, pastryOrder);
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Please enter a number from 1-4.");
        MainMenu(breadOrder, pastryOrder);
      }
    }

    public static void BreadMenu(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("");
      Console.WriteLine("How many loaves would you like to order?");
      string breadCountString = Console.ReadLine();
      int breadCount = int.Parse(breadCountString);
      breadOrder.Count = breadCount;
      if (breadOrder.Count % 3 == 2)
      {
        Console.WriteLine("");
        Console.WriteLine("Would you like another one? It's free! (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          breadOrder.Count++;
          Console.WriteLine("");
          Console.WriteLine("Will do!");
          MainMenu(breadOrder, pastryOrder);
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("Alrighty then!");
          MainMenu(breadOrder, pastryOrder);
        }
      }
      else
      {
        MainMenu(breadOrder, pastryOrder);
      }
    }

    public static void PastryMenu(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("");
      Console.WriteLine("How many pastries would you like to order?");
      string pastryCountString = Console.ReadLine();
      int pastryCount = int.Parse(pastryCountString);
      pastryOrder.Count = pastryCount;
      if (pastryOrder.Count % 3 == 2)
      {
        Console.WriteLine("");
        Console.WriteLine("Would you like another one for just $1? (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          pastryOrder.Count++;
          Console.WriteLine("");
          Console.WriteLine("Will do!");
          MainMenu(breadOrder, pastryOrder);
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("Alrighty then!");
          MainMenu(breadOrder, pastryOrder);
        }
      }
        else
      {
        MainMenu(breadOrder, pastryOrder);
      }
    }

    public static void Checkout(Bread breadOrder, Pastry pastryOrder)
    {
      int breadPrice = breadOrder.Cost();
      int pastryPrice = pastryOrder.Cost();
      int totalPrice = breadPrice + pastryPrice;
      if (totalPrice > 0)
      {
        Console.WriteLine("");
        Console.WriteLine("Thank you! Your order is:");
        Console.WriteLine("");
        Console.WriteLine($"{breadOrder.Count} loaves of bread for ${breadPrice}");
        Console.WriteLine($"{pastryOrder.Count} pastries for ${pastryPrice}");
        Console.WriteLine($"For a total of ${totalPrice}.");
        Console.WriteLine("");
        Console.WriteLine("Does this look correct? (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          Console.WriteLine("");
          Console.WriteLine("Thank you! Your order has been placed!");
          breadOrder.Count = 0;
          pastryOrder.Count = 0;
          MainMenu(breadOrder, pastryOrder);
        }
        else
        {
          Quit(breadOrder, pastryOrder);
        }
      }
      else
      {
      Console.WriteLine("");
      Console.WriteLine("You have not ordered anything yet.");
      MainMenu(breadOrder, pastryOrder);
      }
    }

    public static void Quit(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("");
      Console.WriteLine("Would you like to quit? (Y to accept)");
      string response = Console.ReadLine();
      if (response.ToLower() == "y")
      {
        Console.WriteLine("");
        Console.WriteLine("Thank you and have a nice day!");
      }
      else
      {
        MainMenu(breadOrder, pastryOrder);
      }
    }
  }
}