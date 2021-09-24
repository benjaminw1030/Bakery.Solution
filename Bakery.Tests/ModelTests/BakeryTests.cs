using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void Bread_CreatesBreadObject_Bread()
    {
      // Arrange
      string hello = "hello";
      // Act
      string helloWorld = TemplateClass.Template(hello);
      // Assert
      Assert.AreEqual("hello world", helloWorld);
    }
  }
}