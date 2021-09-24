using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {

    public static void Main()
    {
      Bread breadOrder = new Bread(0, 0, 0);
      Pastry pastryOrder = new Pastry(0, 0, 0);
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
      Console.WriteLine("Buy two loaves of bread and get one free!");
      Console.WriteLine("Buy two pastries get one 1/2 off!");
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
      Console.WriteLine("What kind of bread would you like to order?");
      Console.WriteLine("1) Wheat - $5.00");
      Console.WriteLine("2) Sourdough - $6.00");
      Console.WriteLine("3) Our Famous Rye Bread - $7.00");
      Console.WriteLine("4) Back to menu");
      Console.WriteLine("");
      string breadSelect = Console.ReadLine();
      if (breadSelect == "4")
      {
        MainMenu(breadOrder, pastryOrder);
      }
      else if (breadSelect == "1" || breadSelect == "2" || breadSelect == "3")
      {
        Console.WriteLine("");
        Console.WriteLine("How many loaves?");
        string breadCountString = Console.ReadLine();
        int breadCount = int.Parse(breadCountString);
        if (breadCount % 3 == 2)
        {
          Console.WriteLine("");
          Console.WriteLine("Would you like another one? It's free! (Y to accept)");
          string response = Console.ReadLine();
          if (response.ToLower() == "y")
          {
            breadCount++;
            Console.WriteLine("");
            Console.WriteLine("Will do!");
          }
          else
          {
            Console.WriteLine("");
            Console.WriteLine("Alrighty then!");
          }
        }
        switch (breadSelect)
        {
          case "1":
            breadOrder.Wheat = breadCount;
            break;
          case "2":
            breadOrder.Sour = breadCount;
            break;
          case "3":
            breadOrder.Rye = breadCount;
            break;
        }
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Please make a selection.");
        BreadMenu(breadOrder, pastryOrder);
      }  
      MainMenu(breadOrder, pastryOrder);
    }

    public static void PastryMenu(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine("");
      Console.WriteLine("What kind of Pastry would you like to order?");
      Console.WriteLine("1) Crossiants - $2.00");
      Console.WriteLine("2) Strawberry Tarts - $3.00");
      Console.WriteLine("3) Extra-Large Cinnamon Rolls - $4.00");
      Console.WriteLine("4) Back to menu");
      Console.WriteLine("");
      string pastrySelect = Console.ReadLine();
      if (pastrySelect == "4")
      {
        MainMenu(breadOrder, pastryOrder);
      }
      else if (pastrySelect == "1" || pastrySelect == "2" || pastrySelect == "3")
      {
        Console.WriteLine("");
        Console.WriteLine("How many pastries would you like to order?");
        string pastryCountString = Console.ReadLine();
        int pastryCount = int.Parse(pastryCountString);
        if (pastryCount % 3 == 2)
        {
          Console.WriteLine("");
          Console.WriteLine("Would you like another one for 1/2 price? (Y to accept)");
          string response = Console.ReadLine();
          if (response.ToLower() == "y")
          {
            pastryCount++;
            Console.WriteLine("");
            Console.WriteLine("Will do!");
          }
          else
          {
            Console.WriteLine("");
            Console.WriteLine("Alrighty then!");
          }
        }
        switch (pastrySelect)
        {
          case "1":
            pastryOrder.Crossiant = pastryCount;
            break;
          case "2":
            pastryOrder.Tart = pastryCount;
            break;
          case "3":
            pastryOrder.Roll = pastryCount;
            break;
        }
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Please make a selection.");
        PastryMenu(breadOrder, pastryOrder);
      }
      MainMenu(breadOrder, pastryOrder);
    }

    public static void Checkout(Bread breadOrder, Pastry pastryOrder)
    {
      Console.WriteLine(breadOrder.Wheat);
      double wheatPrice = breadOrder.Cost(breadOrder.Wheat, 5);
      double sourPrice = breadOrder.Cost(breadOrder.Sour, 6);
      double ryePrice = breadOrder.Cost(breadOrder.Rye, 7);
      double crossiantPrice = pastryOrder.Cost(pastryOrder.Crossiant, 2);
      double tartPrice = pastryOrder.Cost(pastryOrder.Tart, 3);
      double rollPrice = pastryOrder.Cost(pastryOrder.Roll, 4);
      double totalPrice = wheatPrice + sourPrice + ryePrice + crossiantPrice + tartPrice + rollPrice;
      if (totalPrice > 0)
      {
        Console.WriteLine("");
        Console.WriteLine("Thank you! Your order is:");
        Console.WriteLine("");
        if (wheatPrice > 0)
        {
          Console.WriteLine($"Wheat bread loaf: {breadOrder.Wheat} for ${wheatPrice.ToString("0.00")}");
        }
        if (sourPrice > 0)
        {
          Console.WriteLine($"Sourdough bread loaf: {breadOrder.Sour} for ${sourPrice.ToString("0.00")}");
        }
        if (ryePrice > 0)
        {
          Console.WriteLine($"Rye bread loaf: {breadOrder.Rye} for ${ryePrice.ToString("0.00")}");
        }
        if (crossiantPrice > 0)
        {
          Console.WriteLine($"Crossiant: {pastryOrder.Crossiant} for ${crossiantPrice.ToString("0.00")}");
        }
        if (tartPrice > 0)
        {
          Console.WriteLine($"Strawberry tart: {pastryOrder.Tart} for ${tartPrice.ToString("0.00")}");
        }
        if (rollPrice > 0)
        {
          Console.WriteLine($"Cinnamon roll: {pastryOrder.Roll} for ${rollPrice.ToString("0.00")}");
        }
        Console.WriteLine("");
        Console.WriteLine($"For a total of ${totalPrice.ToString("0.00")}.");
        Console.WriteLine("");
        Console.WriteLine("Does this look correct? (Y to accept)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          Console.WriteLine("");
          Console.WriteLine("Thank you! Your order has been placed!");
          Bread newBreadOrder = new Bread(0, 0, 0);
          Pastry newPastryOrder = new Pastry(0, 0, 0);
          MainMenu(newBreadOrder, newPastryOrder);
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