using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests : IDisposable
  {
    public void Dispose()
    {
      // Code inside this method is run between each test.
    }

    // Test methods go here
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
    // any necessary logic to prep for test; instantiating new classes, etc.
    // we can also use the arrange, act, assert organization in any test. 
    Assert.AreEqual(ExpectedResult, CodeToTest);
    }

    /* We can also use the CollectionAssert.AreEqual() method to 
    test and compare two collections (like arrays, lists, or 
    dictionaries). Anytime we use a list or dictionary, 
    we need to remember to include the using directive 
    using System.Collections.Generic;. */

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
    // any necessary logic to prep for test; instantiating new classes, etc.
    // we can also use the arrange, act, assert organization in any test. 
    CollectionAssert.AreEqual(ExpectedResult, CodeToTest);
    }
  }
}

/* Notice the instances of ProjectName and ClassName in 
the boilerplate code above. Like all other instances of 
ProjectName or ClassName in this lesson, these must be 
changed to match the name of your specific project.  */











