using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Template.Models;
using System;

namespace Template.Tests
{
  [TestClass]
  public class Template
  {
    [TestMethod]
    public void Template_SaysHelloWorld_String()
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