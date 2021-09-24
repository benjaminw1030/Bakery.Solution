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
      int breadOrder = 2;
      Bread newBread = new Bread(breadOrder);
      Assert.AreEqual(2, newBread.Count);
    }
  }
}