using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(2, newBread.Count);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfBreadOrder_Int()
    {
      Bread order1 = new Bread(1);
      Bread order2 = new Bread(2);
      Bread order3 = new Bread(3);
      Bread order4 = new Bread(4);
      Assert.AreEqual(5, order1.Cost());
      Assert.AreEqual(10, order2.Cost());
      Assert.AreEqual(10, order3.Cost());
      Assert.AreEqual(15, order4.Cost());
    }
  }
}