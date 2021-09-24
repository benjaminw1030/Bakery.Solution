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
        BreadMenu();
      }
      else if (menuSelect == "2")
      {
        PastryMenu();
      }
      else if (menuSelect == "3")
      {
        Checkout();
      }
      else if (menuSelect == "4")
      {
        Quit();
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Please enter a number from 1-4.")
        MainMenu();
      }
    }

    public static void BreadMenu()
    {
      Console.WriteLine("");
      Console.WriteLine("How many loaves would you like to order?");
      string breadCount = Console.ReadLine();
      int breadCount = int.Parse(breadCount);
      breadOrder.Count = breadCount;
      if (breadOrder.Count % 3 == 1)
      {
        Console.WriteLine("");
        Console.WriteLine("Would you like another one? It's free! (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          breadOrder.Count++;
          Console.WriteLine("");
          Console.WriteLine("Will do!");
          MainMenu();
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("Alrighty then!");
          MainMenu();
        }
      }
    }

    public static void PastryMenu()
    {
      Console.WriteLine("");
      Console.WriteLine("How many pastries would you like to order?");
      string pastryCount = Console.ReadLine();
      int pastryCount = int.Parse(pastryCount);
      pastryOrder.Count = pastryCount;
      if (pastryOrder.Count % 3 == 1)
      {
        Console.WriteLine("");
        Console.WriteLine("Would you like another one for just $1? (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          pastryOrder.Count++;
          Console.WriteLine("");
          Console.WriteLine("Will do!");
          MainMenu();
        }
        else
        {
          Console.WriteLine("");
          Console.WriteLine("Alrighty then!");
          MainMenu();
        }
      }
    }

    public static void Checkout()
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
          MainMenu();
        }
        else
        {
          Quit();
        }
      }
      else
      {
      Console.WriteLine("");
      Console.WriteLine("You have not ordered anything yet.");
      MainMenu();
      }
    }

    Quit()
    {
      Console.WriteLine("");
      Console.WriteLine("Would you like to quit? (Y to accept)");
      string response = Console.ReadLine();
      if (response.ToLower() == "y")
      {
        Console.WriteLine("");
        Console.WriteLine("Thank you and have a nice day!")
      }
      else
      {
        MainMenu();
      }
    }
  }
}