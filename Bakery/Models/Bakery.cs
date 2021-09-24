using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Wheat { get; set; }
    public int Sour { get; set; }
    public int Rye { get; set; }

    public Bread(int wheat, int sour, int rye)
    {
      Sour = sour;
      Wheat = wheat;
      Rye = rye;
    }

    public double Cost(int bread, double price)
    {
      double cost = 0;
      for (int i = 1; i <= bread; i++)
      {
        if (i % 3 != 0)
        {
          cost += price;
        }
        else
        {
          cost += 0;
        }
      }
      return cost;
    }
  }

  public class Pastry
  {
    public int Crossiant { get; set; }
    public int Tart { get; set; }
    public int Roll { get; set; }

    public Pastry(int crossiant, int tart, int roll)
    {
      Crossiant = crossiant;
      Tart = tart;
      Roll = roll;
    }

    public double Cost(int pastry, double price)
    {
      double cost = 0;
      for (int i = 1; i <= pastry; i++)
      {
        if (i % 3 != 0)
        {
          cost += price;
        }
        else
        {
          cost += (price * .5);
        }
      }
      return cost;
    }
  }
}