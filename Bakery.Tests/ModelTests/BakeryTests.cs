using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ReturnsCount_Int()
    {
      Bread newBread = new Bread(1, 2, 3);
      Assert.AreEqual(1, newBread.Wheat);
      Assert.AreEqual(2, newBread.Sour);
      Assert.AreEqual(3, newBread.Rye);
    }

    [TestMethod]
    public void BreadSetter_AllowsChangeToCount_Int()
    {
      Bread newBread = new Bread(1, 2, 3);
      newBread.Wheat += 1;
      newBread.Sour += 1;
      newBread.Rye += 1;
      Assert.AreEqual(2, newBread.Wheat);
      Assert.AreEqual(3, newBread.Sour);
      Assert.AreEqual(4, newBread.Rye);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfBreadOrder_Int()
    {
      Bread order1 = new Bread(1, 0, 0);
      Bread order2 = new Bread(0, 3, 0);
      Bread order3 = new Bread(0, 0, 2);
      double wheatPrice = 5;
      double sourPrice = 6;
      double ryePrice = 7;
      Assert.AreEqual(5, order1.Cost(order1.Wheat, wheatPrice));
      Assert.AreEqual(12, order2.Cost(order2.Sour, sourPrice));
      Assert.AreEqual(14, order3.Cost(order3.Rye, ryePrice));
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryGetter_ReturnsCount_Int()
    {
      Pastry newPastry = new Pastry(1, 2, 3);
      Assert.AreEqual(1, newPastry.Crossiant);
      Assert.AreEqual(2, newPastry.Tart);
      Assert.AreEqual(3, newPastry.Roll);
    }

    [TestMethod]
    public void PastrySetter_AllowsChangeToCount_Int()
    {
      Pastry newPastry = new Pastry(1, 2, 3);
      newPastry.Crossiant -= 1;
      newPastry.Tart -= 1;
      newPastry.Roll -= 1;
      Assert.AreEqual(0, newPastry.Crossiant);
      Assert.AreEqual(1, newPastry.Tart);
      Assert.AreEqual(2, newPastry.Roll);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfPastryOrder_Int()
    {
      Pastry order1 = new Pastry(1, 0, 0);
      Pastry order2 = new Pastry(0, 3, 0);
      Pastry order3 = new Pastry(0, 0, 2);
      double crossiantPrice = 2;
      double tartPrice = 3;
      double rollPrice = 4;
      Assert.AreEqual(2, order1.Cost(order1.Crossiant, crossiantPrice));
      Assert.AreEqual(7.5, order2.Cost(order2.Tart, tartPrice));
      Assert.AreEqual(8, order3.Cost(order3.Roll, rollPrice));
    }
  }
}