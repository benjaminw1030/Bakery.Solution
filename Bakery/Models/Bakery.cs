using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Count { get; set; }

    public Bread(int count)
    {
      Count = count;
    }

    public int Cost()
    {
      int cost = 0;
      for (int i = 1; i <= this.Count; i++)
      {
        if (i % 3 != 0)
        {
          cost += 5;
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
    public int Count { get; set; }

    public Pastry(int count)
    {
      Count = count;
    }

    public int Cost()
    {
      int cost = 0;
      for (int i = 1; i <= this.Count; i++)
      {
        if (i % 3 != 0)
        {
          cost += 2;
        }
        else
        {
          cost += 1;
        }
      }
      return cost;
    }
  }
}